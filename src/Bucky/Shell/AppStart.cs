using System;
using System.Collections.Generic;
using Bucky.Instrumentation.Extensibility;

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
        private readonly IEnumerable<IFeatureLifeCycle> _features;

        public AppStart(
            Func<AppShellViewModel> shellViewModelFactory, 
            IViewService viewService,
            IEnumerable<IFeatureLifeCycle> features)
        {
            _shellViewModelFactory = shellViewModelFactory;
            _viewService = viewService;
            _features = features;
        }

        public void StartApplication()
        {
            foreach (var feature in _features)
            {
                feature.Startup();
            }
            _viewService.ShowMainWindow(_shellViewModelFactory());
        }
    }
}