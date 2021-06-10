using System;
using System.Text.RegularExpressions;

namespace DED.Domain
{
    public class Gateway : Device
    {
        private static readonly Regex _ipRx = new(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b", RegexOptions.Compiled);

        public string Ip { get; init; }
        public int Port { get; init; }

        public Gateway(Guid id, string serialNumber, string ip, int port, string brand, string model) : base(id, serialNumber, brand, model)
        {
            Ip = ip;
            Port = port;
        }

        public override bool IsValid()
        {
            if (!base.IsValid())
                return false;

            if (Ip == null || !_ipRx.IsMatch(Ip))
                return false;

            if (Port< 0 || Port > 65535)
                return false;

            return true;
        }
    }
}
