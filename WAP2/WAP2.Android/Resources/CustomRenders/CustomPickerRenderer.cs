using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using WAP2.Droid.Resources.CustomRenders;
using WAP2.Resources.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace WAP2.Droid.Resources.CustomRenders
{
    public class CustomPickerRenderer : PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
        }
        CustomPicker element;

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            element = (CustomPicker)this.Element;

            if (Control != null && this.Element != null && !string.IsNullOrEmpty(element.Image))
                Control.Background = AddPickerStyles(element.Image);

        }

        public LayerDrawable AddPickerStyles(string imagePath)
        {
            ShapeDrawable border = new ShapeDrawable();
            border.Paint.Color = Android.Graphics.Color.Transparent;
            //border.SetPadding(10, 10, 10, 10);
            //border.Paint.SetStyle(Paint.Style.Stroke);

            Drawable[] layers = { border, GetDrawable(imagePath) };
            LayerDrawable layerDrawable = new LayerDrawable(layers);
            layerDrawable.SetLayerInset(0, 0, 0, 0, 0);

            return layerDrawable;
        }

        private BitmapDrawable GetDrawable(string imagePath)
        {
            //int resID = Resources.GetIdentifier(imagePath, "drawable", this.Context.PackageName);
            var drawable = Resources.GetDrawable(imagePath);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, 25, 25, true));
            result.Gravity = Android.Views.GravityFlags.Right;

            return result;
        }
    }
}