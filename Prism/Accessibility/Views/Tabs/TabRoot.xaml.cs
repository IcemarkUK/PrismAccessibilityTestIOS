using Accessibility.Views.Dashboard;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Accessibility.Views.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabRoot : TabbedPage
    {
        public TabRoot()
        {
            InitializeComponent();
        }
    }
}