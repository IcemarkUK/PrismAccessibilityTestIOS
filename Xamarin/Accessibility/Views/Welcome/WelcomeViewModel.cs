
using System.Windows.Input;
using Accessibility.Views.Dashboard;
using Accessibility.Views.Login;
using Accessibility.Views.Tabs;
using Xamarin.Forms;

namespace Accessibility.Views.Welcome
{
    class WelcomeViewModel
    {
        public WelcomeViewModel(INavigation navigationService)
        {
           ButtonCommand1 = new Command(() => Application.Current.MainPage = new MemberLoginPage());
        }

        public ICommand ButtonCommand1 { get; }
    }
}
