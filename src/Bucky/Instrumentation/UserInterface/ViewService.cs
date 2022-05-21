using Avalonia.Controls.ApplicationLifetimes;
using Bucky.Instrumentation.Core;
using Bucky.Shell;

namespace Bucky.Instrumentation.UserInterface
{
    public class ViewService : IViewService
    {
        private readonly IClassicDesktopStyleApplicationLifetime _lifeCycle;

        public ViewService(IClassicDesktopStyleApplicationLifetime lifeCycle) 
            => _lifeCycle = lifeCycle;

        public void ShowMainWindow(ViewModel context)
        {
            _lifeCycle.MainWindow = new MainWindow
            {
                DataContext = context
            };
        }
    }
}