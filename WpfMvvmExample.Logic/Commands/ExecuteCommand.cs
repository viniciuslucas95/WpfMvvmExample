namespace WpfMvvmExample.Logic.Commands;

public class ExecuteCommand : BaseCommand
{
    private readonly Action _action;
    private readonly bool _canExecute;

    public ExecuteCommand(Action action, bool canExecute = true)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public override bool CanExecute(object? parameter)
    {
        return _canExecute;
    }

    public override void Execute(object? parameter)
    {
        _action();
    }
}
