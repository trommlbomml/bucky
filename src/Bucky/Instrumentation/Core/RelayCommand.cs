using System;
using System.Windows.Input;

namespace Bucky.Instrumentation.Core;

public class RelayCommand : ViewModel, ICommand
{
    private readonly Action _action;
    private bool _isEnabled;

    public RelayCommand(Action action)
    {
        _action = action;
    }

    public bool CanExecute(object? parameter) 
        => IsEnabled;

    public bool IsEnabled
    {
        get => _isEnabled;
        set => SetValue(ref _isEnabled, value, _ => CanExecuteChanged?.Invoke(this, EventArgs.Empty));
    }

    public void Execute(object? parameter) 
        => _action();

    public event EventHandler? CanExecuteChanged;
}