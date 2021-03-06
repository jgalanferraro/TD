﻿using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Threading;

using TD.Service;

namespace TD.ViewModel
{
    public abstract class ViewModel : ViewModelBase
    {
        static ViewModel()
        {
            DispatcherHelper.Initialize();
        }

        private readonly INavigationService2 _navigationService;

        protected ViewModel(INavigationService2 navigationService)
        {
            _navigationService = navigationService;
        }

        public string ActivePage { get { return _navigationService.CurrentPageKey; } }

        protected void NavigateTo(string page)
        {
            NavigateTo(page, null);
        }

        protected void NavigateTo(string page, object state)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() => _navigationService.NavigateTo(page, state));
        }

        protected void RaisePropertyChangedOnUI(string propertyName)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() => RaisePropertyChanged(propertyName));
        }

        protected void RaisePropertiesChanged(params string[] properties)
        {
            foreach (string p in properties)
            {
                RaisePropertyChangedOnUI(p);
            }
        }
    }
}
