using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Accessibility.Views.InitialLoad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialLoadPage : ContentPage
    {
        public InitialLoadPage()
        {
            InitializeComponent();

            BindingContext = new InitialLoadViewModel(Navigation);
            
        }
    }
}