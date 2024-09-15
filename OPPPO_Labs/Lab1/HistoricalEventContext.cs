using Lab1.History;

namespace Lab1;

internal class HistoricalEventContext
{
    private List<HistoricalEventBase> _historicalEvents = new List<HistoricalEventBase>();

    internal HistoricalEventBase HistoricalEventBase
    {
        get => default;
        set
        {
        }
    }

    public void Add(HistoricalEventBase historicalEventBase)
    {
        _historicalEvents.Add(historicalEventBase);
    }

    public void Remove(string name)
    {
        var sellections = _historicalEvents
            .Where(x => x.EventName.Contains(name));

        if (!sellections.Any())
        {
            return;
        }

        _historicalEvents
        .ForEach(x => _historicalEvents.Remove(x));
    }

    public void Remove(DateOnly date)
    {
        var sellections = _historicalEvents
            .Where(x => x.EventDate == date)
            .ToList();

        foreach (var historicalEvent in sellections)
        {
            _historicalEvents.Remove(historicalEvent);
        }
    }


    public IEnumerable<HistoricalEventBase> GetHistoricalEvents(string name)
    {
        return _historicalEvents.Where(x => x.EventName.Contains(name));
    }
    
    public IEnumerable<HistoricalEventBase> GetHistoricalEvents(DateOnly date)
    {
        return _historicalEvents.Where(x => x.EventDate == date);
    }

    public IEnumerable<HistoricalEventBase> GetHistoricalEvents()
    {
        return _historicalEvents;
    }
}
