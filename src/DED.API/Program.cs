using DED.Messages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NServiceBus;

namespace DED.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(Host.CreateDefaultBuilder(args)).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(IHostBuilder builder) =>
                builder.UseNServiceBus(context =>
                {
                    var endpointConfiguration = new EndpointConfiguration("DED.API");

                    var transport = endpointConfiguration.UseTransport<RabbitMQTransport>();
                    transport.ConnectionString("host=rabbitmq");
                    transport.UseConventionalRoutingTopology();

                    var routing = transport.Routing();
                    routing.RouteToEndpoint(typeof(CreateDevice), "DED.DevicesBus");

                    endpointConfiguration.SendFailedMessagesTo("error");
                    endpointConfiguration.AuditProcessedMessagesTo("audit");

                    endpointConfiguration.UseSerialization<NewtonsoftSerializer>();
                    endpointConfiguration.EnableInstallers();
                    return endpointConfiguration;
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
