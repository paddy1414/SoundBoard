using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace SoundBoard
{
    [Activity(Label = "SoundBoard", MainLauncher = true, Icon = "@drawable/soundIcon")]
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
                if (args.Position.ToString().Equals("0"))
                {
                    soundByte = MediaPlayer.Create(this, Resource.Raw.ted);
                    soundByte.Start();
                }

                if (args.Position.ToString().Equals("1"))
                {
                    soundByte = MediaPlayer.Create(this, Resource.Raw.father_dougal);
                    soundByte.Start();
                }

                if (args.Position.ToString().Equals("2"))
                {
                    soundByte = MediaPlayer.Create(this, Resource.Raw.father_jack);
                    soundByte.Start();
                }

                if (args.Position.ToString().Equals("3"))
                {
                    soundByte = MediaPlayer.Create(this, Resource.Raw.mrs_doyle);
                    soundByte.Start();
                }

                if (args.Position.ToString().Equals("4"))
                {
                    soundByte = MediaPlayer.Create(this, Resource.Raw.bishop_brennan);
                    soundByte.Start();
                }


            };


            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

