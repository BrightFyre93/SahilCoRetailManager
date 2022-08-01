using Caliburn.Micro;
using SRMDesktopUI.EventModels;
using SRMDesktopUI.Library.API;
using SRMDesktopUI.Library.Models;

namespace SRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private readonly IEventAggregator _events;
        private readonly SalesViewModel _salesVM;
        private readonly ILoggedInUserModel _user;
        private readonly IApiHelper _apiHelper;

        public ShellViewModel(IEventAggregator events,
            SalesViewModel salesVM,
            ILoggedInUserModel user,
            IApiHelper apiHelper)
        {
            _events = events;
            _salesVM = salesVM;
            _user = user;

            _events.Subscribe(this);
            ActivateItem(IoC.Get<LoginViewModel>());
            _apiHelper = apiHelper;
        }

        public bool IsLoggedIn
        {
            get
            {
                bool output = false;

                if (!string.IsNullOrWhiteSpace(_user.Token))
                {
                    output = true;
                }

                return output;
            }
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
            NotifyOfPropertyChange(() => IsLoggedIn);
        }

        public void ExitApplication()
        {
            TryClose();
        }

        public void LogOut()
        {
            _user.ResetUserModel();
            _apiHelper.LogOffUser();
            ActivateItem(IoC.Get<LoginViewModel>());
            NotifyOfPropertyChange(() => IsLoggedIn);
        }
    }
}
