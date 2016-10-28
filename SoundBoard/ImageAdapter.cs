using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace SoundBoard
{
    class ImageAdapter : BaseAdapter
    {
        // references to our images
        private readonly int[] thumbIds = {
                                          Resource.Drawable.ted,
                                          Resource.Drawable.dougal,
                                          Resource.Drawable.jack,
                                          Resource.Drawable.miss_doyle,
                                          Resource.Drawable.bishop_brennan

                                      };

        private readonly Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }
        public override int Count
        {
            get
            {
                return thumbIds.Length; 
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {
                // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.LayoutParameters = new AbsListView.LayoutParams(250, 250);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                imageView = (ImageView)convertView;
            }
            imageView.SetImageResource(thumbIds[position]);
            return imageView;
        }
    }
}