using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace App10
{
    [Activity(Label = "App10", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int counterClick = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Log.Debug(GetType().FullName, "OnCreate");
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            if (bundle != null)
            {
                counterClick = bundle.GetInt("click");

            }
            var clickButton = FindViewById<Button>(Resource.Id.ClickButton);
            var textView = FindViewById<TextView>(Resource.Id.Counter);
            textView.Text = Resources.GetText(Resource.String.Counter) + ": " + counterClick;
            clickButton.Click += delegate
            {
                counterClick++;
                textView.Text = Resources.GetText(Resource.String.Counter) + ": " + counterClick;
            };
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("click", counterClick);
            base.OnSaveInstanceState(outState);
            Log.Debug(GetType().FullName, "Saving instance state");
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(GetType().FullName, "onStart");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(GetType().FullName, "onStop");
        }

        protected override void OnDestroy()
        {
            Log.Debug(GetType().FullName, "OnDestroy");
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            Log.Debug(GetType().FullName, "OnPause");
            base.OnPause();
        }

        protected override void OnRestart()
        {
            Log.Debug(GetType().FullName, "OnRestart");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Log.Debug(GetType().FullName, "OnResume");
            base.OnResume();
        }
    }
}

