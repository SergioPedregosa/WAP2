using Xamarin.Forms;

namespace WAP2.Resources.CustomRenders
{
    public class BorderlessEntry : Entry
    {
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(BorderlessEntry), string.Empty);

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}
