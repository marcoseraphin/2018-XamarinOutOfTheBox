using Prism;
using Prism.Ioc;
using Prism.Unity;
using Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFAppTemplate.Services;
using XFAppTemplate.Services.Interfaces;
using XFAppTemplate.ViewModels;
using XFAppTemplate.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFAppTemplate
{
    public partial class App : PrismApplication
    {
		public App(IPlatformInitializer initializer = null) : base(initializer)
		{
		}

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("MasterDetailShellPage/NavigationPage/MainPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.Register<IPopupService, PopupService>();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MasterDetailShellPage, MasterDetailShellViewModel>();
			containerRegistry.RegisterForNavigation<MenuPage>();
			containerRegistry.RegisterForNavigation<BasePage>();
			containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
			containerRegistry.RegisterForNavigation<NonModalSubPage, NonModalSubViewModel>();
			containerRegistry.RegisterForNavigation<ModalSubPage, ModalSubViewModel>();
		}
	}
}