using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ChatApp_LLAMIDO;
using ChatApp_LLAMIDO.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace ChatApp_LLAMIDO.Droid
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        Drawable defaultTextBackgroundColor;
        public BorderlessEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            defaultTextBackgroundColor = Control.Background;
            MessagingCenter.Subscribe<object, bool>(this, "Hi", (sender, arg) =>
            {
                Console.WriteLine("Hi , I have received this");
                if (arg)
                {
                    //Control.SetBackgroundColor(Android.Graphics.Color.White);
                    //Control.LayerType.BorderColor = UIColor.Red.CGColor;

                    //var nativeEditText = (global::Android.Widget.EditText)Control;
                    //var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                    //shape.Paint.Color = Xamarin.Forms.Color.Black.ToAndroid();
                    //shape.Paint.SetStyle(Paint.Style.Stroke);
                    //nativeEditText.Background = shape;
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                    shape.Paint.Color = Xamarin.Forms.Color.Red.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    Control.Background = shape;

                }
                else
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                    shape.Paint.Color = Xamarin.Forms.Color.Black.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    Control.Background = shape;
                }
            });

                // Configure Entry properties
                if (e.NewElement != null)
                {

                }
        }
    }
}