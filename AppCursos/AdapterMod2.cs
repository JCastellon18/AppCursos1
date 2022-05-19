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

    class AdapterMod2 : BaseAdapter
    {
        Activity context;
        List<Modulos> listaMod2;

        public AdapterMod2(Activity context, List<Modulos> listaMod2)
        {
            this.context = context;
            this.listaMod2 = listaMod2;
        }

        public override int Count => listaMod2.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = listaMod2[position];
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.PlantillaModulo, parent, false);
                view.FindViewById<TextView>(Resource.Id.txtvideo).Text = item.Nombre_video;


            }
            return view;
        }
    }
}