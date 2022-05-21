using Avalonia.Controls.ApplicationLifetimes;
using Lamar;

namespace Bucky.Shell
{
    public class Registry : ServiceRegistry
    {
        public Registry()
        {
            For<IAppStart>().Use<AppStart>().Singleton();

            Use<AppShellViewModel>().Singleton()
                .For<AppShellViewModel>()
                .For<IShellCommandRegistrator>();
        }
    }
}