using System;

namespace Bucky.Shell
{
    public interface IAppStart
    {
        void StartApplication();
    }

    public class AppStart : IAppStart
    {
        private readonly Func<AppShellViewModel> _shellViewModelFactory;
        private readonly IViewService _viewService;

        public AppStart(Func<AppShellViewModel> shellViewModelFactory, IViewService viewService)
        {
            _shellViewModelFactory = shellViewModelFactory;
            _viewService = viewService;
        }

        public void StartApplication()
        {
            _viewService.ShowMainWindow(_shellViewModelFactory());
        }
    }
}