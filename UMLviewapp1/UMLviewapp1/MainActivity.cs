using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace UMLviewapp1
{
	[Activity (Label = "UMLviewapp1", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			ImageView afbeelding = FindViewById<ImageView> (Resource.Id.afbeelding);
			Button start= FindViewById<Button> (Resource.Id.start);
			
			start.Click += delegate {
				StartActivity(typeof(activity_start_knop));
			};
		}
	}
}


