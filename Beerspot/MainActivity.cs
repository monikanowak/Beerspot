using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Locations;

namespace Beerspot
{
    [Activity(Label = "Beerspot", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button callMapButton = FindViewById<Button>(Resource.Id.callMapButton);

            callMapButton.Click += (sender, e) =>
            {
                var geoUri = Android.Net.Uri.Parse("geo:50.0614319,19.9374877");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };
        }
    }
}