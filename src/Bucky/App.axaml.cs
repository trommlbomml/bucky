using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Bucky.Features.Buckets;
using Bucky.Shell;
using Lamar;

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
                var container = CreateContainer(desktop);
                desktop.Exit += (_, __) => container.Dispose();
                
                container.GetInstance<IAppStart>()
                    .StartApplication();
            }

            base.OnFrameworkInitializationCompleted();
        }

        private static IContainer CreateContainer(IClassicDesktopStyleApplicationLifetime desktop) =>
            new Container(r =>
            {
                r.IncludeRegistry<Shell.Registry>();
                r.IncludeRegistry(new Instrumentation.Registry(desktop));
                r.IncludeRegistry<Features.Buckets.Registry>();
            });
    }
}