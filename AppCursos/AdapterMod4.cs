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

    class AdapterMod4 : BaseAdapter
    {
        Activity context;
        List<Modulos> listaMod4;

        public AdapterMod4(Activity context, List<Modulos> listaMod4)
        {
            this.context = context;
            this.listaMod4 = listaMod4;
        }

        public override int Count => listaMod4.Count;

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
            var item4 = listaMod4[position];
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.PlantillaModulo, parent, false);
                view.FindViewById<TextView>(Resource.Id.txtvideo).Text = item4.Nombre_video;


            }
            return view;
        }
    }
}