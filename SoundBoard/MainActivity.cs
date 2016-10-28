using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace SoundBoard
{
    [Activity(Label = "SoundBoard", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            var gridview = FindViewById<GridView>(Resource.Id.gridview);
            gridview.Adapter = new ImageAdapter(this);
            gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
             Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();

               MediaPlayer soundByte;
                soundByte = MediaPlayer.Create(this, Resource.Raw.ted);
                soundByte.Start();
            };


            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

