
using Prism.Mvvm;
using Prism.Navigation;

namespace Accessibility.Views.Tabs
{
    class TabRootViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public TabRootViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

    }


}
