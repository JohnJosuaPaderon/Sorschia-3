using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Sorschia.Events;
using System;
using System.Linq;
using System.Windows;

namespace Sorschia
{
    public abstract class ViewModelBase : BindableBase
    {
        public ViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IRegionManager regionManager)
        {
            EventAggregator = eventAggregator;
            DialogService = dialogService;
            RegionManager = regionManager;
            ApplicationClosingEvent = eventAggregator.GetEvent<ApplicationClosingEvent>();

            LoadCommand = new DelegateCommand(Load);
            UnloadCommand = new DelegateCommand(Unload);
            NavigateCommand = new DelegateCommand<NavigationInfo>(Navigate);
        }

        protected IEventAggregator EventAggregator { get; }
        protected IDialogService DialogService { get; }
        protected IRegionManager RegionManager { get; }
        protected ApplicationClosingEvent ApplicationClosingEvent { get; }
        public DelegateCommand LoadCommand { get; }
        public DelegateCommand UnloadCommand { get; }
        public DelegateCommand<NavigationInfo> NavigateCommand { get; }

        protected void Invoke(Action callback)
        {
            Application.Current.Dispatcher.Invoke(callback);
        }

        protected virtual void Load()
        {
        }

        protected virtual void Unload()
        {
        }

        protected virtual void Navigate(NavigationInfo navigationInfo)
        {
            Navigate(navigationInfo.RegionName, navigationInfo.TargetViewName);
        }

        protected virtual void Navigate(string regionName, string targetViewName)
        {
            RegionManager.RequestNavigate(regionName, targetViewName, NavigateCallback);
        }

        protected virtual void NavigateCallback(NavigationResult result)
        {
            var activeView = result.Context.NavigationService.Region.ActiveViews.FirstOrDefault();
            if (activeView == null || Equals(activeView.GetType(), typeof(object)))
            {
                RegionManager.RequestNavigate(result.Context.NavigationService.Region.Name, NavigationConstants.NotFound, new NavigationParameters
                {
                    { NavigationConstants.NotFound_TargetViewName, result.Context.Uri.ToString() }
                });
            }
        }
    }
}
