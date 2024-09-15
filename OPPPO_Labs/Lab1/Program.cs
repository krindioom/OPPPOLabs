using Lab1;
using Lab1.Commands;
using Lab1.History;

var context = new HistoricalEventContext();
var processor = new CommandProcessor();

// Добавление исторических событий
processor
    .AddCommand(new AddCommand(context, new HistoricalContract(new(1783, 09, 03), "Версальский договор").AddGovernments("США", "Британия")))
    .AddCommand(new AddCommand(context, new Battle("Битва под Сталинградом", new(1942, 08, 23), "Ключевое сражение Второй мировой войны")))
    .AddCommand(new AddCommand(context, new HistoricalContract(new(1812, 12, 24), "Тильзитский мир").AddGovernments("Россия", "Франция")))
    .AddCommand(new AddCommand(context, new Battle("Битва при Ватерлоо", new(1815, 06, 18), "Заключительное сражение Наполеоновских войн")))
    .AddCommand(new AddCommand(context, new HistoricalContract(new(1918, 11, 11), "Компьенское перемирие").AddGovernments("Антанта", "Германия")))
    .AddCommand(new AddCommand(context, new Battle("Битва за Москву", new(1941, 10, 02), "Операция по защите Москвы от немецкой армии")))
    .AddCommand(new PrintCommand(context))

    // Удаляем событие
    .AddCommand(new RemoveByDateCommand(context, new(1942, 08, 23))) // Удаляем битву под Сталинградом
    .ProcessCommands()

    .AddCommand(new PrintCommand(context)) // Печать после удаления события
    .ProcessCommands()

    // Добавление еще нескольких событий
    .AddCommand(new AddCommand(context, new HistoricalContract(new(1867, 07, 01), "Соглашение о покупке Аляски").AddGovernments("США", "Россия")))
    .AddCommand(new AddCommand(context, new Battle("Битва при Геттисберге", new(1863, 07, 01), "Крупнейшее сражение Гражданской войны в США")))
    .AddCommand(new AddCommand(context, new HistoricalContract(new(1989, 11, 09), "Падение Берлинской стены").AddGovernments("ГДР", "ФРГ")))
    .AddCommand(new PrintCommand(context))
    .ProcessCommands();
