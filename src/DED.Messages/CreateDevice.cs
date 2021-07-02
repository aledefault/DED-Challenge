using DED.Domain;
using NServiceBus;

namespace DED.Messages
{
    public class CreateDevice : ICommand
    {
        public Device Device { get; set; }
    }
}
