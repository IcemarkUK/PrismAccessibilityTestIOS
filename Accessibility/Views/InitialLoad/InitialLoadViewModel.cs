using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Accessibility.Views.Dashboard;
using Accessibility.Views.Tabs;
using Prism.Navigation;
using Xamarin.Forms;

namespace Accessibility.Views.InitialLoad
{
    class InitialLoadViewModel
    {
        public InitialLoadViewModel(INavigationService navigationService)
        {
            ButtonCommand1 = new Command(() => navigationService.NavigateAsync(nameof(Welcome), new NavigationParameters()));

            ButtonCommand2 = new Command(() =>
            {
                var path = nameof(Info);
                navigationService.NavigateAsync(
                    $"/{nameof(TabRoot)}?selectedTab={path}",
                    new NavigationParameters());
            });
        }

        public ICommand ButtonCommand1 { get; }
        public ICommand ButtonCommand2 { get; }

    }
}
