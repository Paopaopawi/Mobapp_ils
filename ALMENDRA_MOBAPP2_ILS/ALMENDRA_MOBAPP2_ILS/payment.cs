using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace ALMENDRA_MOBAPP2_ILS
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class payment : AppCompatActivity
    {
        TextView tv1;
        CheckBox cb1;
        EditText et1;
        Button bt1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.XMLFile2);
            

                
            tv1 = FindViewById<TextView>(Resource.Id.textView2);
            cb1 = FindViewById<CheckBox>(Resource.Id.checkBox1);
            et1 = FindViewById<EditText>(Resource.Id.editText1);
            bt1 = FindViewById<Button>(Resource.Id.button1);

            string total = Intent.GetStringExtra("total");
            string dprice = Intent.GetStringExtra("dprice");
            string wprice = Intent.GetStringExtra("wprice");
            string vprice = Intent.GetStringExtra("vprice");
            tv1.Text = "Total: "+total + "\n" +"Delivery fee: "+"\n" +"Distance - "+dprice+"\n"+"Weight - "+wprice+"\n"+"Item Value: "+vprice;

            cb1.CheckedChange += delegate (object sender, CompoundButton.CheckedChangeEventArgs e)
            {
                if (e.IsChecked == true)
                {
                    bt1.Enabled = true;
                }
                else
                {
                    bt1.Enabled = false;
                }
            };


           
            bt1.Click += bclick;
        }
        private void bclick (object sender, EventArgs e)
        {
            string total = Intent.GetStringExtra("total");
            double tot = double.Parse(total);
            var con = int.Parse(et1.Text);
            if (con < tot)
            {
                Toast.MakeText(this, "Insufficient payment", ToastLength.Short).Show();
            }
            else
            {
                string sendername = Intent.GetStringExtra("sname");
                string sendermobile = Intent.GetStringExtra("smobile");
                string senderloc = Intent.GetStringExtra("sloc");
                string senderadd = Intent.GetStringExtra("sadd");

                string receivername = Intent.GetStringExtra("rname");
                string receivermobile = Intent.GetStringExtra("rmobile");
                string receiverloc = Intent.GetStringExtra("rloc");
                string receiveradd = Intent.GetStringExtra("radd");

                string dprice = Intent.GetStringExtra("dprice");
                string wprice = Intent.GetStringExtra("wprice");
                string vprice = Intent.GetStringExtra("vprice");
                Intent intent = new Intent(this, typeof(receipt));
                

                intent.PutExtra("sname", sendername);
                intent.PutExtra("smobile", sendermobile);
                intent.PutExtra("sloc", senderloc);
                intent.PutExtra("sadd", senderadd);

                intent.PutExtra("rname", receivername);
                intent.PutExtra("rmobile", receivermobile);
                intent.PutExtra("rloc", receiverloc);
                intent.PutExtra("radd", receiveradd);

                intent.PutExtra("dprice", dprice);
                intent.PutExtra("wprice", wprice);
                intent.PutExtra("vprice", vprice);
                this.StartActivity(intent);
            }
        }
    }
}