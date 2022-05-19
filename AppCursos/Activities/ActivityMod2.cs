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
    [Activity(Label = "ActivityMod2")]
    public class ActivityMod2 : Activity
    {
        ListView ListB;
        TextView nombremodulo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Modulo2);

            Inicializacion();
            Eventos();

            nombremodulo.Text = "Acciones sobre una base de datos";
            ListB.Adapter = new AdapterMod2(this, Global.modulo2);

        }

        private void Eventos()
        {
            ListB.ItemClick += ListB_ItemClick;

        }

        private void Inicializacion()
        {
            ListB = FindViewById<ListView>(Resource.Id.listModulo2);
            nombremodulo = FindViewById<TextView>(Resource.Id.txtnombreidmodulo);
        }

        private void ListB_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Activities.ActivityDetalleVideo2));
            Global.idpuntero = e.Position;

            StartActivity(i);
        }
    }
}