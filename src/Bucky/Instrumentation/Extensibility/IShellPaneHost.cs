using System.ComponentModel;

namespace Bucky.Instrumentation.Extensibility
{
    public interface IShellPane : INotifyPropertyChanged
    {
        string Caption { get; }
    }
    
    public interface IShellPaneHost
    {
        void AddPane(IShellPane pane);

        void RemovePane(IShellPane pane);
    }
}