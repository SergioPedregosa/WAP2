using Microsoft.Identity.Client;
using WAP2.Helpers;
using WAP2.Views;
using WAP2.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WAP2
{
    public partial class App : Application
    {
        public static IPublicClientApplication AuthenticationClient { get; private set; }
        public static IPublicClientApplication AuthenticationClientRegister { get; private set; }
        public static object UIParent { get; set; } = null;
        public App()
        {
            InitializeComponent();

            //Sharpnado Tabs
            //Sharpnado.Tabs.Initializer.Initialize(false, false);
            //Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            AuthenticationClient = PublicClientApplicationBuilder
                .Create(Constants.ClientId)
                .WithIosKeychainSecurityGroup(Constants.IosKeychainSecurityGroups)
                .WithB2CAuthority(Constants.AuthoritySignIn)
                .WithRedirectUri($"msal{Constants.ClientId}://auth")
                .Build();

            AuthenticationClientRegister = PublicClientApplicationBuilder
                .Create(Constants.ClientId)
                .WithIosKeychainSecurityGroup(Constants.IosKeychainSecurityGroups)
                .WithB2CAuthority(Constants.AuthorityRegister)
                .WithRedirectUri($"msal{Constants.ClientId}://auth")
                .Build();

            /*AuthenticationClient = PublicClientApplicationBuilder
                .Create(Constants.ClientId)
                .WithRedirectUri(Constants.RedirectUri)
                .WithAuthority(AadAuthorityAudience.AzureAdMyOrg)
                .WithTenantId(Constants.TenantId)
                .WithIosKeychainSecurityGroup(Constants.IosKeychainSecurityGroups)
                .Build();*/

            MainPage = new NavigationPage(new MainPage());
            
        }

        protected override void OnStart()
        {
            OnResume();
        }

        protected override void OnSleep()
        {
            TheTheme.SetTheme();
            RequestedThemeChanged -= App_RequestedThemeChanged;
        }

        protected override void OnResume()
        {
            TheTheme.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }
        private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                TheTheme.SetTheme();
            });
        }
    }
}
