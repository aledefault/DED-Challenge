using DED.Domain;
using NServiceBus;

namespace DED.Message
{
    public class CreateDevice : ICommand
    {
        public Device Device { get; set; }
    }
}
