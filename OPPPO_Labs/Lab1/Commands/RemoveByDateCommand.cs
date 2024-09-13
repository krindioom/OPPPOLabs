namespace Lab1.Commands;

internal class RemoveByDateCommand: CommandBase
{
    private readonly DateOnly _date;

    public RemoveByDateCommand(HistoricalEventContext historicalEventContext, DateOnly date) : base(historicalEventContext)
    {
        _date = date;
    }

    public override void Execute()
    {
        _context.Remove(_date);
    }
}
