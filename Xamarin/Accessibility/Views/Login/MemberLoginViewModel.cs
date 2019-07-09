using System.Windows.Input;
using Accessibility.Views.Dashboard;
using Accessibility.Views.Tabs;
using Xamarin.Forms;

namespace Accessibility.Views.Login
{
    class MemberLoginViewModel
    {
        public MemberLoginViewModel(INavigation navigationService)
        {
            ButtonCommand1 = new Command(() =>
            {
                Application.Current.MainPage = new TabRootPage();
            });
        }

        public ICommand ButtonCommand1 { get; }
    }
}
