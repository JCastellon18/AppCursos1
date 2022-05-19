using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCursos
{
    [Activity(Label = "ActivityMod3")]
    public class ActivityMod3 : Activity
    {
        ListView ListB;
        TextView nombremodulo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Modulo3);

            Inicializacion();
            Eventos();

            nombremodulo.Text = "Manejos de tablas dinamicas";
            ListB.Adapter = new AdapterMod3(this, Global.modulo3);

        }

        private void Eventos()
        {
            ListB.ItemClick += ListB_ItemClick;

        }

        private void Inicializacion()
        {
            ListB = FindViewById<ListView>(Resource.Id.listModulo3);
            nombremodulo = FindViewById<TextView>(Resource.Id.txtnombreidmodulo);
        }

        private void ListB_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Activities.ActivityDetalleVideo3));
            Global.idpuntero = e.Position;

            StartActivity(i);
        }
    }
}