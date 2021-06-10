using System;
using System.ComponentModel.DataAnnotations;

namespace DED.Web.Models
{
    public class DeviceModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 18)]
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        [Required]
        [RegularExpression(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b")]
        public string Ip { get; set; }
        
        [Range(0, 65535)]
        public int Port { get; set; }
    }
}
