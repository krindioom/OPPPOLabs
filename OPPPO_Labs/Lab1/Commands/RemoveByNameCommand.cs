namespace Lab1.Commands;

internal class RemoveByNameCommand : CommandBase
{
    private readonly string _name;

    public RemoveByNameCommand(HistoricalEventContext historicalEventContext, string name) : base(historicalEventContext)
    {
        _name = name;
    }

    public override void Execute()
    {
        _context.Remove(_name);
    }
}