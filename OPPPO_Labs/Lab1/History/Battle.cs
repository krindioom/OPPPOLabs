using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.History;

internal class Battle : HistoricalEventBase
{
    public string BattlePlace { get; private set; } = null!;

    public Battle(string battlePlace, DateOnly date, string eventName)
        :base(date, eventName)
    {
        BattlePlace = battlePlace;
    }
}
