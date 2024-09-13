using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.History;

internal abstract class HistoricalEventBase
{
    public DateOnly EventDate {  get; protected set; }

    public string EventName { get; protected set; } = null!;

    public HistoricalEventBase(DateOnly date, string eventname)
    {
        EventDate = date;
        EventName = eventname;
    }
}
