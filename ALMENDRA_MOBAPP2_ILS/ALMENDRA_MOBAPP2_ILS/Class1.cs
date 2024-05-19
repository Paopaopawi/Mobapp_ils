using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace ALMENDRA_MOBAPP2_ILS
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class Class1 : AppCompatActivity
    {
        ImageButton bt1, bt2, bt3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.XMLFile4);
            bt1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            bt2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            bt3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            bt1.Click += bclick;
            bt2.Click += aclick;
            bt3.Click += aclick;
        }
        private void bclick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(n));
            this.StartActivity(intent);
        }
        private void aclick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Sorry not available right now :(", ToastLength.Long).Show();
        }
    }
}