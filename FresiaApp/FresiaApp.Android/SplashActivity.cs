﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FresiaApp.Droid
{
    [Activity(Label = "SplashActivity",
      MainLauncher = true,
      Theme = "@style/MainTheme.Splash",
      NoHistory = true,
      Icon = "@mipmap/icon")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();
            SetContentView(Resource.Layout.Splash);
            Task startupWork = new Task(() => { _ = SimulateStartupAsync(); });
            startupWork.Start();
        }

        private async Task SimulateStartupAsync()
        {
            await Task.Delay(millisecondsDelay: 4000);

            //Log.Debug(TAG, "Startup work is finished - starting MainActivity");

            StartActivity(intent: new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}