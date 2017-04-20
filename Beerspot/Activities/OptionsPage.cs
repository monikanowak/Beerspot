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



namespace Beerspot.Activities
{
    [Activity(Label = "", Theme = "@style/Theme.NoTitle")]
    public class OptionsPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.OptionsPage);
            // Create your application here
            Button mapaButton = FindViewById<Button>(Resource.Id.mapa_button);
            mapaButton.Click += GoToMap_Click;
        }

        private void GoToMap_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

    }
}