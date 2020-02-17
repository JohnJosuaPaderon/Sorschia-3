using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace Sorschia
{
    public abstract class NavigationViewModelBase : ViewModelBase, INavigationAware
    {
        public NavigationViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IRegionManager regionManager) : base(eventAggregator, dialogService, regionManager)
        {
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
