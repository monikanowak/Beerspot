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
    [Activity(Label = "WelcomePage", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.NoTitle")]
    public class WelcomePage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WelcomePage);
            // Create your application here
            Button goToMap = FindViewById<Button>(Resource.Id.goToMap);
            goToMap.Click += GoToMap_Click;
        }

        private void GoToMap_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}