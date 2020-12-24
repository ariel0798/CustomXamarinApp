using CustomXamarin.ViewModels;
using CustomXamarin.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace CustomXamarin
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer)
            : base(platformInitializer)
        {
            InitializeComponent();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ServicePage, MainViewModel>(NavigationConstants.ServicePage);
            containerRegistry.RegisterForNavigation<EffectPage>(NavigationConstants.EffectPage);
            containerRegistry.RegisterForNavigation<CustomRenderPage>(NavigationConstants.CustomRenderPage);
            containerRegistry.RegisterForNavigation<HomePage>(NavigationConstants.HomePage);
        }

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync(NavigationConstants.HomePage);
        }
    }
}
