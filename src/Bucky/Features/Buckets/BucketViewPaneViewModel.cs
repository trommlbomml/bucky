using Bucky.Instrumentation.Core;
using Bucky.Instrumentation.Extensibility;
using Bucky.Shell;

namespace Bucky.Features.Buckets
{
    public class BucketViewPaneViewModel: ViewModel, IShellPane
    {
        public string Caption => "Test";
    }
}