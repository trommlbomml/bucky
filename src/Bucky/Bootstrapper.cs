using Avalonia.Controls.ApplicationLifetimes;
using Lamar;

namespace Bucky
{
    public static class Bootstrapper
    {
        public static IContainer CreateContainer(IClassicDesktopStyleApplicationLifetime desktop) =>
            new Container(r =>
            {
                r.IncludeRegistry<Shell.Registry>();
                r.IncludeRegistry(new Instrumentation.Registry(desktop));
                r.IncludeRegistry<Features.Buckets.Registry>();
            });
    }
}