using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinPlugins;
using XamarinPlugins.UWP;

[assembly: ExportRenderer(typeof(UWPCustomButton),typeof(UWPCustomButtonRenderer))]
namespace XamarinPlugins.UWP
{
    class UWPCustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if(e != null)
            {
                Control.Background = new LinearGradientBrush(
                    new GradientStopCollection
                    {
                        new GradientStop{Offset = 0, Color= Windows.UI.Colors.Magenta},
                        new GradientStop{Offset = 1, Color=Windows.UI.Colors.SaddleBrown},
                    },30);
                // Styling
            }
        }
    }
}
