using System.Windows.Input;
using Accessibility.Views.Tabs;
using Xamarin.Forms;

namespace Accessibility.Views.Dashboard
{
    class InfoViewModel
    {
        public InfoViewModel(Page page)
        {
            ButtonCommand1 = new Command(() =>
            {
                var masterPage = Application.Current.MainPage as TabbedPage;
                masterPage.CurrentPage = masterPage.Children[0];
            });
        }

        public ICommand ButtonCommand1 { get; }

    }
}
