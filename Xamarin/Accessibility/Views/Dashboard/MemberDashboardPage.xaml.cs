using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Accessibility.Views.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemberDashboardPage : ContentPage
    {
        public MemberDashboardPage()
        {
            InitializeComponent();

            BindingContext = new MemberDashboardViewModel(this);
        }
    }
}