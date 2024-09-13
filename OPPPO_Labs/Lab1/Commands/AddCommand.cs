using Lab1.History;

namespace Lab1.Commands;

internal class AddCommand : CommandBase
{
    private readonly HistoricalEventBase _historicalEvent;

    public AddCommand(HistoricalEventContext historicalEventContext, HistoricalEventBase historicalEvent) : base(historicalEventContext)
    {
        _historicalEvent = historicalEvent;
    }

    public override void Execute()
    {
        _context.Add(_historicalEvent);
    }
}
