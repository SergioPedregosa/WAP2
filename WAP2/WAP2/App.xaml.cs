using WAP2.Helpers;
using WAP2.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WAP2
{
    public partial class App : Application
    {
        public static object UIParent { get; set; } = null;
        public App()
        {
            InitializeComponent();
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
