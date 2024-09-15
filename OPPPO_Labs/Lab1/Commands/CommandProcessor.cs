namespace Lab1.Commands;

internal class CommandProcessor
{
    private readonly List<ICommand> _commands = new List<ICommand>();

    internal CommandBase CommandBase
    {
        get => default;
        set
        {
        }
    }

    public CommandProcessor AddCommand(ICommand command)
    {
        _commands.Add(command);
        return this;
    }

    public CommandProcessor ProcessCommands()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }

        _commands.Clear();
        return this;
    }
}
