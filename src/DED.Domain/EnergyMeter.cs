using System;

namespace DED.Domain
{
    public class EnergyMeter : Device
    {
        public EnergyMeter(Guid id, string serialNumber, string brand, string model) : base(id, serialNumber, brand, model)
        {
        }
    }
}
