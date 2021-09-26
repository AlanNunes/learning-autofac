namespace Mediator.Interfaces
{
    public interface IMediator<TCommand, TResponde>
    {
        public TResponde Handle(TCommand command);
    }
}
