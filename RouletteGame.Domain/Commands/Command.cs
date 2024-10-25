using RouletteGame.Domain.Events;

namespace RouletteGame.Domain.Commands;

public abstract class Command : Message
{
    protected Command()
    {
        TimeStamp = DateTime.Now;
    }

    public DateTime TimeStamp { get; protected set; }
}