﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

namespace AppCursos.Activities
{
    [Activity(Label = "ActivityDetalleVideo2")]
    public class ActivityDetalleVideo2 : Activity
    {
        TextView txturlvideo, txturlyoutube, txtnombrevideo, txtnbasedatos;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DetalleVideo);

            Inicializacion();
            Eventos();

            var item = Global.modulo2[Global.idpuntero];
            txtnombrevideo.Text = item.Nombre_video;
            txturlyoutube.Text = item.URL_YT1;
            txtnbasedatos.Text = item.Nombre_archi;
            txturlvideo.Text = item.URL_BD1;            
            
        }
        private void Eventos()
        {
            txturlyoutube.Click += Txturlyoutube_Click;
            txturlvideo.Click += Txturlvideo_Click;
            txturlvideo.Clickable = true;
            txturlyoutube.Clickable = true;
        }
        private void Txturlvideo_Click(object sender, EventArgs e)
        {
            if (txturlvideo.Text.Contains("http"))
            {
                Intent i = new Intent(Intent.ActionView);
                i.SetData(Android.Net.Uri.Parse(txturlvideo.Text));

                StartActivity(i);
            }else
            {
                txturlvideo.SetTextColor(Android.Graphics.Color.Black);
            }

        }
        private void Txturlyoutube_Click(object sender, EventArgs e)
        {
            if (txturlyoutube.Text.Contains("http"))
            {
                Intent i = new Intent(Intent.ActionView);
                i.SetData(Android.Net.Uri.Parse(txturlyoutube.Text));

                StartActivity(i);
            }
            else
            {
                txturlyoutube.SetTextColor(Android.Graphics.Color.Black);
            }
        }

        private void Inicializacion()
        {
            txturlvideo = FindViewById<TextView>(Resource.Id.txturlvideo);
            txturlyoutube = FindViewById<TextView>(Resource.Id.txturlyt);
            txtnombrevideo = FindViewById<TextView>(Resource.Id.txtnombredetalle);
            txtnbasedatos = FindViewById<TextView>(Resource.Id.txtbd);
            
        }
    }
}