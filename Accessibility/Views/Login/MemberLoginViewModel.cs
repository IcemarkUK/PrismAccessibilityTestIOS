using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Accessibility.Views.Dashboard;
using Accessibility.Views.Tabs;
using Prism.Navigation;
using Xamarin.Forms;

namespace Accessibility.Views.Login
{
    class MemberLoginViewModel
    {
        public MemberLoginViewModel(INavigationService navigationService)
        {
            //
            // broken, causes lockup on iOS Accessibility
            //
            ButtonCommand1 = new Command(() =>
            { 
                var path = nameof(MemberDashboard);
                navigationService.NavigateAsync(
                    $"/{nameof(TabRoot)}?selectedTab={path}",
                    new NavigationParameters());
            });

            // initial workaround 
            ButtonCommand2 = new Command(() =>
            {
                navigationService.NavigateAsync(nameof(TabRoot));
            });

            ButtonCommand3 = new Command(() =>
            {
                navigationService.NavigateAsync($"root:///{nameof(TabRoot)}");
            });
        }

        public ICommand ButtonCommand1 { get; }

        public ICommand ButtonCommand2 { get; }

        public ICommand ButtonCommand3 { get; }
    }
}
