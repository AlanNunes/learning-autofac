using Mediator.Interfaces;

namespace Mediator.Models
{
    public class Mediator : IMediator<Command, Response>
    {
        public Response Handle(Command command)
        {
            return new Response(true);
        }
    }
}
