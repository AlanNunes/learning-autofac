using Mediator.Interfaces;

namespace Mediator.Models
{
    public class Mediator2 : IMediator<Command, string>
    {
        public string Handle(Command command)
        {
            return "Result Mediator2";
        }
    }
}
