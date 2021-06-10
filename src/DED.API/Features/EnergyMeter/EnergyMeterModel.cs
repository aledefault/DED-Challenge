using System.ComponentModel.DataAnnotations;

namespace DED.API.Features.EnergyMeter
{
    public class EnergyMeterModel
    {
        [Required]
        [StringLength(18, MinimumLength = 18)]
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}