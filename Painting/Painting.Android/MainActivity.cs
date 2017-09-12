using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using static Android.Views.View;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace Painting.Droid
{
	[Activity (Label = "Painting.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
    {
        XData data = new XData();

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Drawing);

            data.Color = Color.Black;
            data.Width = 5;
            FindViewById<DrawView>(Resource.Id.drawFiheld).data = data;

            int[] idColors = new int[] { Resource.Id.btnBlack, Resource.Id.btnBlue, Resource.Id.btnRed };

            foreach (int i in idColors)
            {
                Button tBut = FindViewById<Button>(i);
                tBut.Click += GetColor;
            }
            FindViewById<EditText>(Resource.Id.tWidth).TextChanged += GetWidth;
        }

        public void GetWidth(object sender, EventArgs e)
        {
            data.Width = Int32.Parse((sender as EditText).Text);
        }

        public void GetColor(object sender, EventArgs e)
        {
            var buttonBackground = (sender as Button).Background;
            if (buttonBackground is ColorDrawable)
            {
                data.Color = (buttonBackground as ColorDrawable).Color;
                //You now have a background color.
            }
        }
    }
}


