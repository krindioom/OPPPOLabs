using Lab1.History;

namespace Lab1;

internal class HistoricalEventContext
{
    public List<HistoricalEventBase> historicalEvents = new List<HistoricalEventBase>();

    public void Add(HistoricalEventBase historicalEventBase)
    {
        historicalEvents.Add(historicalEventBase);
    }

    public void Remove(string name)
    {
        var sellections = historicalEvents
            .Where(x => x.EventName.Contains(name));

        if (!sellections.Any())
        {
            return;
        }

        historicalEvents
        .ForEach(x => historicalEvents.Remove(x));
    }

    public void Remove(DateOnly date)
    {
        var sellections = historicalEvents
            .Where(x => x.EventDate == date);

        if (!sellections.Any())
        {
            return;
        }

        historicalEvents
        .ForEach(x => historicalEvents.Remove(x));
    }

    public IEnumerable<HistoricalEventBase> GetHistoricalEvents(string name)
    {
        return historicalEvents.Where(x => x.EventName.Contains(name));
    }
    
    public IEnumerable<HistoricalEventBase> GetHistoricalEvents(DateOnly date)
    {
        return historicalEvents.Where(x => x.EventDate == date);
    }
}
