using Android.Content;
using WAP2.Droid.Resources.CustomRenders;
using WAP2.Resources.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace WAP2.Droid.Resources.CustomRenders
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public BorderlessEntryRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
            }

            if (e.NewElement != null)
            {

            }
        }
    }
}