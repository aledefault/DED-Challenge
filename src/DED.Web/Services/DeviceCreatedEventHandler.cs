using DED.Domain;
using System;

namespace DED.Web.Services
{
    public class DeviceCreatedEventService
    {
        public event EventHandler<DeviceCreatedEventArgs> DeviceCreatedRecieved;

        public void Publish(Device device) => OnDeviceCreated(device);

        protected virtual void OnDeviceCreated(Device device) => 
            DeviceCreatedRecieved?.Invoke(this, new DeviceCreatedEventArgs { Device = device });
    }

    public class DeviceCreatedEventArgs : EventArgs
    {
        public Device Device { get; set; }
    }
}
