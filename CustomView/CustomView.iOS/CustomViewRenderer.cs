using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using CustomView.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomView.CustomView), typeof(CustomViewRenderer))]

namespace CustomView.iOS
{
    class CustomViewRenderer : ViewRenderer
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var context = UIGraphics.GetCurrentContext();
            var formsView = Element as CustomView;
            if (formsView != null & formsView.IsDrawBackground)
            {
                context.SaveState();
                context.SetFillColor(UIColor.Red.CGColor);
                context.AddRect(rect);
                context.DrawPath(CGPathDrawingMode.FillStroke);
                context.RestoreState();
            }
        }

        public new void Init()
        {

        }
    }
}