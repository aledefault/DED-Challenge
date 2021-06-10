using System;

namespace DED.Domain
{
    public abstract class Device : IIdentity
    {
        public string SerialNumber { get; init; }
        public string Brand { get; init; }
        public string Model { get; init; }
        public Guid Id { get; init; }

        protected Device(Guid id, string serialNumber, string brand, string model)
        {
            Id = id;
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
        }

        public virtual bool IsValid()
        {
            if (SerialNumber == null || SerialNumber.Length != 18)
                return false;

            return true;
        }
    }
}
