using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Commands;

internal class PrintCommand : CommandBase
{
    public PrintCommand(HistoricalEventContext historicalEventContext) : base(historicalEventContext)
    {
    }

    public override void Execute()
    {
        var events = _context.GetHistoricalEvents();
        foreach (var item in events)
        {
            Console.WriteLine(item.GetDetails());
        }
    }
}
