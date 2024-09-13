using Lab1;
using Lab1.Commands;
using Lab1.History;

var context = new HistoricalEventContext();
var processor = new CommandProcessor();

processor
    .AddCommand(new AddCommand(context, new HistoricalContract(new(1783, 09, 03), "Версальский договор").AddGovernments("США", "Британия")))
    .AddCommand(new AddCommand(context, new Battle("Москва", new(1941, 09, 30), "Битва за москву")))
    .AddCommand(new PrintCommand(context))
    
    .AddCommand(new RemoveByDateCommand(context, new(1941, 09, 30)))
    .ProcessCommands()
    .AddCommand(new PrintCommand(context))
    .ProcessCommands();