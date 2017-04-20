using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Locations;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Views;

namespace Beerspot
{
    [Activity(Label = "", Icon = "@drawable/icon",  Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

   

        //SupportActionBar.Title = "beerspot";

        //var mTitle = (TextView)toolbar.FindViewById(Resource.Id.toolbar_title);

        Button callMapButton = FindViewById<Button>(Resource.Id.callMapButton);

            callMapButton.Click += (sender, e) =>
            {
                var geoUri = Android.Net.Uri.Parse("geo:50.0614319,19.9374877");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.MenuButton, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {/*
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
                ToastLength.Short).Show();*/

            if (item.ItemId == Resource.Id.menu_button)
            {
                StartActivity(typeof(Activities.OptionsPage));
                return true;
            }
            else
                return base.OnOptionsItemSelected(item);
            

        }

    }


}