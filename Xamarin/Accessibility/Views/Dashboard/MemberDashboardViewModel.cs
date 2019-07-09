using System.Windows.Input;
using Xamarin.Forms;

namespace Accessibility.Views.Dashboard
{
    class MemberDashboardViewModel
    {
        public MemberDashboardViewModel(Page page)
        {
            ButtonCommand1 = new Command(() =>
            {
                var masterPage = Application.Current.MainPage as TabbedPage;
                masterPage.CurrentPage = masterPage.Children[1];
            });
        }

        public ICommand ButtonCommand1 { get; }
    }
}
