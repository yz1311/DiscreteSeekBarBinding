using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Org.Adw.Library.Widgets.Discreteseekbar;

namespace DiscreteSeekBarDemo
{
	[Activity (Label = "DiscreteSeekBarDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.Main);
			DiscreteSeekBar discreteSeekBar1 =  FindViewById<DiscreteSeekBar>(Resource.Id.discrete1);
			discreteSeekBar1.SetNumericTransformer(new SeekBarNumericTransformer());
		}
	}

	public class SeekBarNumericTransformer:DiscreteSeekBar.NumericTransformer
	{
		public override int Transform(int value) {
			return value * 100;
		}
	}
}


