using System.ComponentModel;
using System.Windows.Input;

namespace Bucky.Shell
{
    public interface IShellCommand : INotifyPropertyChanged
    {
        ICommand Command { get; }
        
        string Caption { get; }
    }
    
    public interface IShellCommandHost
    {
        void RegisterCommand(IShellCommand shellCommand);
    }
}