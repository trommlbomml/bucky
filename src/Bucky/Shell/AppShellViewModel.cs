using System.Collections.ObjectModel;
using Bucky.Instrumentation.Core;

namespace Bucky.Shell
{
    public class AppShellViewModel : ViewModel, IShellCommandHost, IShellPaneHost
    {
        private readonly ObservableCollection<IShellCommand> _shellCommands = new();
        private readonly ObservableCollection<IShellPane> _shellPanes = new();

        public AppShellViewModel()
        {
            ShellCommands = new ReadOnlyObservableCollection<IShellCommand>(_shellCommands);
            ShellPanes = new ReadOnlyObservableCollection<IShellPane>(_shellPanes);
        }
        
        public ReadOnlyObservableCollection<IShellCommand> ShellCommands { get; }
        
        public ReadOnlyObservableCollection<IShellPane> ShellPanes { get; }

        public void RegisterCommand(IShellCommand shellCommand) 
            => _shellCommands.Add(shellCommand);

        public void AddPane(IShellPane pane) 
            => _shellPanes.Add(pane);

        public void RemovePane(IShellPane pane) 
            => _shellPanes.Remove(pane);
    }
}