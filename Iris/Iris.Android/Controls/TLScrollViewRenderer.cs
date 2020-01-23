using Pedidos.Controls;
using Xamarin.Forms.Platform.Android;

namespace Pedidos.Droid.Controls
{
    public class TLScrollViewRenderer : ScrollViewRenderer
    {
        public TLScrollViewRenderer(Android.Content.Context context) : base(context)
        {

        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as TLScrollView;
            element?.Render();
        }

    }
}