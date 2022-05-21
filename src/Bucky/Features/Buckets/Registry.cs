using Bucky.Instrumentation.Extensibility;
using Bucky.Shell;
using Lamar;

namespace Bucky.Features.Buckets
{
    public class Registry : ServiceRegistry
    {
        public Registry()
        {
            For<IFeatureLifeCycle>().Use<FeatureLifeCycle>().Singleton();
        }
    }
}