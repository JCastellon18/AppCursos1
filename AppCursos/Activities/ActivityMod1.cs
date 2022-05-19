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
    [Activity(Label = "ActivityMod1")]
    public class ActivityMod1 : Activity
    {
        ListView ListB;
        TextView nombremodulo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Modulo1);

            Inicializacion();
            Eventos();

            nombremodulo.Text = "Lista de Conceptos basicos de BD";
            ListB.Adapter = new AdapterMod1(this, Global.modulo1);

        }

        private void Eventos()
        {
            ListB.ItemClick += ListB_ItemClick;

        }

        private void Inicializacion()
        {
            ListB = FindViewById<ListView>(Resource.Id.listModulo1);
            nombremodulo = FindViewById<TextView>(Resource.Id.txtnombreidmodulo);
        }

        private void ListB_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Activities.ActivityDetalleVideo));
            Global.idpuntero = e.Position;

            StartActivity(i);
        }
    }
}