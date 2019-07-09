using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Accessibility.Views.Tabs;
using Prism.Navigation;
using Prism.Navigation.TabbedPages;
using Xamarin.Forms;

namespace Accessibility.Views.Dashboard
{
    class MemberDashboardViewModel
    {
        public MemberDashboardViewModel(INavigationService navigationService)
        {
            ButtonCommand1 = new Command(() =>
            {
                var path = nameof(Info);
                navigationService.NavigateAsync(
                    $"/{nameof(TabRoot)}?selectedTab={path}",
                    new NavigationParameters());
            });

            ButtonCommand2 = new Command(() =>
            {
                navigationService.SelectTabAsync(nameof(Info));
            });
    
        }

        public ICommand ButtonCommand1 { get; }
        public ICommand ButtonCommand2 { get; }
    }
}
