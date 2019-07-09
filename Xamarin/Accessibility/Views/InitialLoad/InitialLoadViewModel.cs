
using System.Windows.Input;
using Accessibility.Views.Welcome;
using Xamarin.Forms;

namespace Accessibility.Views.InitialLoad
{
    class InitialLoadViewModel
    {
        public InitialLoadViewModel(INavigation navigationService)
        {
            ButtonCommand1 = new Command(() => Application.Current.MainPage=new WelcomePage());
        }

        public ICommand ButtonCommand1 { get; }
    }
}
