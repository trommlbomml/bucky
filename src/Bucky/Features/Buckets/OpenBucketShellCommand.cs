using System.Windows.Input;
using Bucky.Instrumentation.Core;
using Bucky.Shell;

namespace Bucky.Features.Buckets
{
    public class OpenBucketShellCommand : ViewModel, IShellCommand
    {
        public OpenBucketShellCommand()
        {
            Command = new RelayCommand(OnOpenBucketCommand);
            Caption = "Open Bucket";
        }

        public ICommand Command { get; }
        public string Caption { get; }
        
        private void OnOpenBucketCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}