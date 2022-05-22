using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Bucky.Shell;

namespace Bucky
{
    public partial class App : Application
    {
        public override void Initialize() 
            => AvaloniaXamlLoader.Load(this);

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var container = Bootstrapper.CreateContainer(desktop);
                desktop.Exit += (_, _) => container.Dispose();

                container.GetInstance<IAppStart>()
                    .StartApplication();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}