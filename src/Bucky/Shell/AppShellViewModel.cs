using System.Collections.ObjectModel;
using Bucky.Instrumentation.Core;

namespace Bucky.Shell
{
    public class AppShellViewModel : ViewModel, IShellCommandRegistrator
    {
        private readonly ObservableCollection<IShellCommand> _shellCommands = new();

        public AppShellViewModel()
        {
            ShellCommands = new ReadOnlyObservableCollection<IShellCommand>(_shellCommands);
        }
        
        public ReadOnlyObservableCollection<IShellCommand> ShellCommands { get; }

        public void RegisterCommand(IShellCommand shellCommand)
        {
            _shellCommands.Add(shellCommand);
        }
    }
}