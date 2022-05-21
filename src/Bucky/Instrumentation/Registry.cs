using Avalonia.Controls.ApplicationLifetimes;
using Bucky.Instrumentation.UserInterface;
using Bucky.Shell;
using Lamar;

namespace Bucky.Instrumentation
{
    public class Registry : ServiceRegistry
    {
        public Registry(IClassicDesktopStyleApplicationLifetime desktop)
        {
            For<IViewService>().Use(new ViewService(desktop)).Singleton();
        }
    }
}