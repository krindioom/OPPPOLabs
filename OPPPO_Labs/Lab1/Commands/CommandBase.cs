namespace Lab1.Commands;

internal abstract class CommandBase : ICommand
{
    protected readonly HistoricalEventContext _context;

    public CommandBase(HistoricalEventContext historicalEventContext)
    {
        _context = historicalEventContext;
    }

    public abstract void Execute();
}
