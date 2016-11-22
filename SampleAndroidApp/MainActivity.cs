using Android.App;
using Android.Widget;
using Android.OS;

namespace SampleAndroidApp
{
    [Activity(Label = "SampleAndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var myButton = this.FindViewById<Button>(Resource.Id.myButton);
            myButton.Click += (s, e) =>
            {
                Toast.MakeText(this, "Hello World", ToastLength.Short);
            };
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

