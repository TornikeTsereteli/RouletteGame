using MediatR;

namespace RouletteGame.Domain.Events;

public abstract class Message : IRequest<bool>
{
    protected Message()
    {
        MessageType = GetType().Name;
    }

    public string MessageType { get; protected set; }
}