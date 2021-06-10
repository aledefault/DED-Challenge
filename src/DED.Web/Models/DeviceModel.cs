using System;

namespace DED.Web.Models
{
    public class DeviceModel
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
    }
}
