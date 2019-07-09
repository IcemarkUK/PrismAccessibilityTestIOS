using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Accessibility.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemberLoginPage : ContentPage
    {
        public MemberLoginPage()
        {
            InitializeComponent();

            BindingContext = new MemberLoginViewModel(Navigation);
        }
    }
}