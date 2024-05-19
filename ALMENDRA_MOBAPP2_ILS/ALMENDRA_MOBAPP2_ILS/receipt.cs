using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ALMENDRA_MOBAPP2_ILS
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class receipt : AppCompatActivity
    {
        TextView tv1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.XMLFile3);

            tv1 = FindViewById<TextView>(Resource.Id.textView3);

            string sname = Intent.GetStringExtra("sname");
            string smobile = Intent.GetStringExtra("smobile");
            string sloc = Intent.GetStringExtra("sloc");
            string sadd = Intent.GetStringExtra("sadd");

            string rname = Intent.GetStringExtra("rname");
            string rmobile = Intent.GetStringExtra("rmobile");
            string rloc = Intent.GetStringExtra("rloc");
            string radd = Intent.GetStringExtra("radd");

            string dprice = Intent.GetStringExtra("dprice");
            string wprice = Intent.GetStringExtra("wprice");
            string vprice = Intent.GetStringExtra("vprice");

            double total = double.Parse(dprice) + double.Parse(wprice) + double.Parse(vprice);
            double tax = total * 0.05;
            double subtotal = total + tax;
            tv1.Text = "Sender:" + "\n" + sname + "\n" + smobile + "\n" + sloc + "\n" + sadd + "\n"+"\n"+ "Receiver" + "\n" + rname + "\n" + rmobile + "\n" + rloc + "\n" + radd + "\n"+"\n"+
                "Subtotal:          " + subtotal + "\n" + "Charges:           " + total + "\n" + "Tax:                    " + tax + "\n" +
                "---------------------------------------------------------" + "\n" + "                       THANK YOU"; 
        }
    }
}