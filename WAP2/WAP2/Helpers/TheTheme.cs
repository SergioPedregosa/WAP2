using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WAP2.Helpers
{
    public class TheTheme
    {
        public static void SetTheme()
        {
            switch (Settings.Theme)
            {
                //Light
                case 0:
                    App.Current.UserAppTheme = OSAppTheme.Light;
                    break;
                //Dark
                case 1:
                    App.Current.UserAppTheme = OSAppTheme.Dark;
                    break;
            }
        }
    }
}
