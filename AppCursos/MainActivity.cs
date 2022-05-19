using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace AppCursos
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageView imgMod1, imgMod2, imgMod3, imgMod4;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Inicializacion();
            Eventos();
        }

        private void Eventos()
        {
            imgMod1.Click += ImgMod1_Click;
            imgMod2.Click += ImgMod2_Click;
            imgMod3.Click += ImgMod3_Click;
            imgMod4.Click += ImgMod4_Click;
        }

        private void ImgMod4_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityMod4));

            StartActivity(i);
        }

        private void ImgMod3_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityMod3));

            StartActivity(i);
        }

        private void ImgMod2_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityMod2));

            StartActivity(i);
        }

        private void ImgMod1_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityMod1));

            StartActivity(i);
        }

        private void Inicializacion()
        {
            imgMod1 = FindViewById<ImageView>(Resource.Id.imgConceptos);
            imgMod2 = FindViewById<ImageView>(Resource.Id.imgAcciones);
            imgMod3 = FindViewById<ImageView>(Resource.Id.imgtablas);
            imgMod4 = FindViewById<ImageView>(Resource.Id.imgAcc);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}