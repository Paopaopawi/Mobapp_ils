using Android.App;
using Android.Content;
using Android.Hardware.Lights;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using static Android.Renderscripts.Sampler;

namespace ALMENDRA_MOBAPP2_ILS
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class n : AppCompatActivity
    {
        EditText et1, et2, et3, et4, et5, et6;
        Button bt1, bt2;
        Spinner spinner1, spinner2, spinner3, spinner4;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.XMLFile1);

            et1 = FindViewById<EditText>(Resource.Id.editText1);
            et2 = FindViewById<EditText>(Resource.Id.editText2);
            et3 = FindViewById<EditText>(Resource.Id.editText3);
            et4 = FindViewById<EditText>(Resource.Id.editText4);
            et5 = FindViewById<EditText>(Resource.Id.editText5);
            et6 = FindViewById<EditText>(Resource.Id.editText6);

            bt1 = FindViewById<Button>(Resource.Id.button1);
            bt2 = FindViewById<Button>(Resource.Id.button2);

            spinner1 = FindViewById<Spinner>(Resource.Id.spinner1);
            spinner2 = FindViewById<Spinner>(Resource.Id.spinner2);
            spinner3 = FindViewById<Spinner>(Resource.Id.spinner3);
            spinner4 = FindViewById<Spinner>(Resource.Id.spinner4);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.spinner1_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            var adapter2 = ArrayAdapter.CreateFromResource(this, Resource.Array.spinner2_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            var adapter3 = ArrayAdapter.CreateFromResource(this, Resource.Array.spinner3_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter3.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = adapter;
            spinner2.Adapter = adapter;
            spinner3.Adapter = adapter2;
            spinner4.Adapter = adapter3;


            bt2.Click += pay;

            
        }
private void pay(object sender, EventArgs e)
{
           
            var weight = spinner3.SelectedItem.ToString();
            var value = spinner4.SelectedItem.ToString();
            var sendername = et1.Text;
            var sendermobile = et2.Text;
            var senderloc = spinner1.SelectedItem.ToString();
            var senderadd = et3.Text;

            var receivername = et4.Text;
            var receivermobile = et5.Text;
            var receiverloc = spinner2.SelectedItem.ToString();
            var receiveradd = et6.Text;

            double price = 0;
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region I - Ilocos Region")
            {
                price = 60;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region II - Cagayan Valley")
            {
                price =70;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region III - Central Luzon")
            {
                price = 105;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 180;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 240;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region V - Bicol Region")
            {
                price =240;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 80;
            }
            if (senderloc == "Region I - Ilocos Region" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 140;
            }






            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region I - Ilocos Region")
            {
                price = 70;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region II - Cagayan Valley")
            {
                price = 60;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region III - Central Luzon")
            {
                price = 105;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 180;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 240;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region V - Bicol Region")
            {
                price = 240;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 80;
            }
            if (senderloc == "Region II - Cagayan Valley" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 140;
            }




            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region I - Ilocos Region")
            {
                price = 80;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region II - Cagayan Valley")
            {
                price = 80;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region III - Central Luzon")
            {
                price = 60;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 120;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 225;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region V - Bicol Region")
            {
                price = 225;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 110;
            }
            if (senderloc == "Region III - Central Luzon" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 90;
            }






            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region I - Ilocos Region")
            {
                price = 180;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region II - Cagayan Valley")
            {
                price = 180;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region III - Central Luzon")
            {
                price = 120;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 60;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 190;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region V - Bicol Region")
            {
                price = 190;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 160;
            }
            if (senderloc == "Region IV-A - CALABARZON" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 80;
            }





            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region I - Ilocos Region")
            {
                price =240;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region II - Cagayan Valley")
            {
                price = 240;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region III - Central Luzon")
            {
                price = 225;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 160;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 60;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region V - Bicol Region")
            {
                price = 100;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 250;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 110;
            }





            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region I - Ilocos Region")
            {
                price = 240;
            }
            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region II - Cagayan Valley")
            {
                price =245;
            }
            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region III - Central Luzon")
            {
                price = 225;
            }
            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 160;
            }
            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 100;
            }
            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region V - Bicol Region")
            {
                price = 60;
            }
            if (senderloc == "Region V - Bicol Region" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 250;
            }
            if (senderloc == "Region IV-B - MIMAROPA" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 120;
            }




            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region I - Ilocos Region")
            {
                price = 80;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region II - Cagayan Valley")
            {
                price =80;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region III - Central Luzon")
            {
                price = 110;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 190;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 250;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region V - Bicol Region")
            {
                price = 250;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 60;
            }
            if (senderloc == "Region CAR - Cordillera Administrative Region" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 150;
            }


            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region I - Ilocos Region")
            {
                price = 140;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region II - Cagayan Valley")
            {
                price = 140;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region III - Central Luzon")
            {
                price = 90;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region IV-A - CALABARZON")
            {
                price = 80;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region IV-B - MIMAROPA")
            {
                price = 225;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region V - Bicol Region")
            {
                price = 225;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region CAR - Cordillera Administrative Region")
            {
                price = 150;
            }
            if (senderloc == "Region NCR - National Capital Region" && receiverloc == "Region NCR - National Capital Region")
            {
                price = 60;
            }



            double wprice = 0;
            if (weight == "1kg-5kg")
            {
                wprice = 15;
            }
            if (weight == "6kg-15kg")
            {
                wprice = 30;
            }
            if (weight == "16kg-30kg")
            {
                wprice = 50;
            }
            if (weight == "31kg-50kg")
            {
                wprice = 100;
            }
            double vprice = 0;
            if (value == "0-300")
            {
                vprice = 30;
            }
            if (value == "301-700")
            {
                vprice = 50;
            }
            if (value == "701-1000")
            {
                vprice = 80;
            }
            if (value == "1001-5000")
            {
                vprice = 120;
            }

            double total = price + wprice+vprice;
            double tax = total * 0.05;
            double totals = total + tax;
            var totalz = totals.ToString();
            if (et1.Text == "" || et2.Text == "" || et3.Text == "" ||
                et4.Text == "" || et5.Text == "" || et6.Text == "")
            {

                Toast.MakeText(this,"Complete info", ToastLength.Short).Show();
            }
            else
            {
                Intent intent = new Intent(this, typeof(payment));
                intent.PutExtra("sname", sendername);
                intent.PutExtra("smobile", sendermobile);
                intent.PutExtra("sloc", senderloc);
                intent.PutExtra("sadd", senderadd);

                intent.PutExtra("rname", receivername);
                intent.PutExtra("rmobile", receivermobile);
                intent.PutExtra("rloc", receiverloc);
                intent.PutExtra("radd", receiveradd);

                intent.PutExtra("dprice", price.ToString());
                intent.PutExtra("wprice", wprice.ToString());
                intent.PutExtra("vprice", vprice.ToString());

                intent.PutExtra("total", totalz);
                this.StartActivity(intent);
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}