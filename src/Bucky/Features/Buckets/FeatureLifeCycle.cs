using Bucky.Shell;

namespace Bucky.Features.Buckets
{
    public class FeatureLifeCycle : IFeatureLifeCycle
    {
        private readonly IShellCommandHost _commandHost;

        public FeatureLifeCycle(IShellCommandHost commandHost)
        {
            _commandHost = commandHost;
        }
        
        public void Startup()
        {
            _commandHost.RegisterCommand(new OpenBucketShellCommand());
        }
    }
}