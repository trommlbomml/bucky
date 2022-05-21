using Bucky.Instrumentation.Core;
using Bucky.Shell;

namespace Bucky.Features.Buckets
{
    public class BucketViewPaneViewModel: ViewModel, IShellPane
    {
        public string Caption => "Test";
    }
}