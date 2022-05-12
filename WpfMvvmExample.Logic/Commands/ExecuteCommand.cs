namespace WpfMvvmExample.Logic.Commands;

public class ExecuteCommand : CommandBase
{
    private readonly Action _action;
    private readonly Func<bool>? _canExecute;

    public ExecuteCommand(Action action, Func<bool>? canExecute = null)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public override bool CanExecute(object? parameter)
    {
        if (_canExecute is null) return true;
        if (!_canExecute()) return false;

        return base.CanExecute(parameter);
    }

    public override void Execute(object? parameter)
    {
        _action();
    }
}
