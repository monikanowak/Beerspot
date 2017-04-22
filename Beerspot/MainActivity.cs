using Android.App;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace Beerspot
{
    [Activity(Label = "Beerspot", Icon = "@drawable/icon")]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private MapFragment _mapFragment;
        private GoogleMap _map;
        public void OnMapReady(GoogleMap googleMap)
        {
            _map = googleMap;

            if (_map != null)
            {
                //marker
                MarkerOptions markerOpt1 = new MarkerOptions();
                markerOpt1.SetPosition(new LatLng(49.826287, 20.490268));
                markerOpt1.SetTitle("Tu mieszkam :P");
                _map.AddMarker(markerOpt1);
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            _mapFragment = FragmentManager.FindFragmentByTag("map") as MapFragment;
            if (_mapFragment == null)
            {
                GoogleMapOptions mapOptions = new GoogleMapOptions()
                    .InvokeMapType(GoogleMap.MapTypeSatellite)
                    .InvokeZoomControlsEnabled(false)
                    .InvokeCompassEnabled(true);

                FragmentTransaction fragTx = FragmentManager.BeginTransaction();
                _mapFragment = MapFragment.NewInstance(mapOptions);
                fragTx.Add(Resource.Id.map, _mapFragment, "map");
                fragTx.Commit();
            }
            _mapFragment.GetMapAsync(this);
        }
    }
}