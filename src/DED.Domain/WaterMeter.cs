using System;

namespace DED.Domain
{
    public class WaterMeter : Device
    {
        public WaterMeter(Guid id, string serialNumber, string brand, string model) : base(id, serialNumber, brand, model)
        {
        }
    }
}
