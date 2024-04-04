using Xamarin.Essentials;

namespace WAP2.Helpers
{
    public class Settings
    {
        // 0 = Light, 1 = Dark
        const int theme = 0;
        public static int Theme
        {
            get => Preferences.Get(nameof(Theme), theme);
            set => Preferences.Set(nameof(Theme), value);
        }
    }
}
