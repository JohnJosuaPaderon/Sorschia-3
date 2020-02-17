using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;

namespace Sorschia
{
    public abstract class DialogViewModelBase : ViewModelBase, IDialogAware
    {
        public DialogViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IRegionManager regionManager) : base(eventAggregator, dialogService, regionManager)
        {
            CloseCommand = new DelegateCommand(Close);
        }

        public DelegateCommand CloseCommand { get; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _dialogBusy;
        public bool DialogBusy
        {
            get { return _dialogBusy; }
            set { SetProperty(ref _dialogBusy, value); }
        }

        public event Action<IDialogResult> RequestClose;

        protected virtual void OnRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }

        public virtual bool CanCloseDialog()
        {
            return !DialogBusy;
        }

        public virtual void OnDialogClosed()
        {

        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
        }

        protected virtual void Close()
        {
            OnRequestClose(new DialogResult());
        }

        protected virtual void Close(ButtonResult buttonResult, Action<IDialogResult> configure)
        {
            var result = new DialogResult(buttonResult);
            configure(result);
            OnRequestClose(result);
        }
    }
}
