using System.Net;
using DED.DevicesBus.Services;
using DED.Domain;
using Microsoft.Extensions.Hosting;
using NServiceBus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using StackExchange.Redis;

namespace DED.DevicesBus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host
                .CreateDefaultBuilder(args)
                .ConfigureServices(collection =>
                {
                    collection.AddMediatR(typeof(Program));
                    collection.AddSingleton<MongoDbService>();
                })
                .UseNServiceBus(context =>
                {
                    var endpointConfiguration = new EndpointConfiguration("DED.DevicesBus");
                    var transport = endpointConfiguration.UseTransport<RabbitMQTransport>();
                    transport.ConnectionString("host=rabbitmq");
                    transport.UseConventionalRoutingTopology();

                    endpointConfiguration.SendFailedMessagesTo("error");
                    endpointConfiguration.AuditProcessedMessagesTo("audit");
                    endpointConfiguration.Conventions().DefiningCommandsAs(type => type.Namespace == "DED.API.Messages");

                    endpointConfiguration.UseSerialization<NewtonsoftSerializer>();
                    endpointConfiguration.EnableInstallers();
                    return endpointConfiguration;
                });
    }
}
