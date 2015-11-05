
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

namespace UMLviewapp1
{
	[Activity (Label = "activity_start_knop")]			
	public class activity_start_knop : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.layout_start);
			// Create your application here

			ImageView afbeelding_UML = FindViewById<ImageView> (Resource.Id.afbeelding_UML);
			EditText aantekeningen = FindViewById<EditText> (Resource.Id.aantekeningen);
			RatingBar ratingbar = FindViewById<RatingBar> (Resource.Id.ratingBar);
			Button open = FindViewById<Button> (Resource.Id.open);
			Button download = FindViewById<Button> (Resource.Id.download);
			Button upload = FindViewById<Button> (Resource.Id.upload);

				
		}
	}
}

