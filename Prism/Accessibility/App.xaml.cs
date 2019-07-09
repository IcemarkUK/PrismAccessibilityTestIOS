using System.Threading.Tasks;
using Accessibility.Views.Dashboard;
using Accessibility.Views.InitialLoad;
using Accessibility.Views.Login;
using Accessibility.Views.Tabs;
using Accessibility.Views.Welcome;
using Prism.Ioc;
using Prism.Unity;

namespace Accessibility
{
    public partial class App : PrismApplication
    {

        public App()
        {
            InitializeComponent();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TabRoot, TabRootViewModel>();
            containerRegistry.RegisterForNavigation<InitialLoad, InitialLoadViewModel>();
            containerRegistry.RegisterForNavigation<Welcome, WelcomeViewModel>();
            containerRegistry.RegisterForNavigation<MemberLogin, MemberLoginViewModel>();
            containerRegistry.RegisterForNavigation<MemberDashboard, MemberDashboardViewModel>();
            containerRegistry.RegisterForNavigation<Info, InfoViewModel>();
        }

        protected override async void OnInitialized()
        {
            await NavigateToInitialLoadingPageAsync();
        }

        private async Task NavigateToInitialLoadingPageAsync()
        {
            await NavigationService.NavigateAsync(nameof(InitialLoad));
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
