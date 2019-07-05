
using System.Windows.Input;
using Accessibility.Views.Dashboard;
using Accessibility.Views.Login;
using Accessibility.Views.Tabs;
using Prism.Navigation;
using Xamarin.Forms;

namespace Accessibility.Views.Welcome
{
    class WelcomeViewModel
    {
        public WelcomeViewModel(INavigationService navigationService)
        {
            ButtonCommand1 = new Command(() => navigationService.NavigateAsync(nameof(MemberLogin), new NavigationParameters()));

            ButtonCommand2 = new Command(() =>
            {
                var path = nameof(MemberDashboard);
                navigationService.NavigateAsync(
                    $"/{nameof(TabRoot)}?selectedTab={path}",
                    new NavigationParameters());
            });

        }
        public ICommand ButtonCommand1 { get; }
        public ICommand ButtonCommand2 { get; }
    }
}
