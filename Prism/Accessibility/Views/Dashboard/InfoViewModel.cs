using System.Windows.Input;
using Accessibility.Views.Tabs;
using Prism.Navigation;
using Prism.Navigation.TabbedPages;
using Xamarin.Forms;

namespace Accessibility.Views.Dashboard
{
    class InfoViewModel
    {
        public InfoViewModel(INavigationService navigationService)
        {
            ButtonCommand1 = new Command(() =>
            {
                var path = nameof(MemberDashboard);
                navigationService.NavigateAsync(
                    $"/{nameof(TabRoot)}?selectedTab={path}",
                    new NavigationParameters());
            });


            ButtonCommand2 = new Command(() =>
            {
                navigationService.SelectTabAsync(nameof(MemberDashboard));
            });
        }

        public ICommand ButtonCommand1 { get; }
        public ICommand ButtonCommand2 { get; }

    }
}
