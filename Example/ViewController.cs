using System;

using UIKit;
using PathMenuXamarin;
using System.Diagnostics;
using Foundation;

namespace Example
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.LightGray;

			DCPathItemButton item1 = new DCPathItemButton(
				UIImage.FromFile("chooser-moment-icon-camera.png"),
				UIImage.FromFile("chooser-moment-icon-camera-highlighted.png"),
				UIImage.FromFile("chooser-moment-button.png"),
				UIImage.FromFile("chooser-moment-button-highlighted.png")
			);

			DCPathItemButton item2 = new DCPathItemButton(
				UIImage.FromFile("chooser-moment-icon-music.png"),
				UIImage.FromFile("chooser-moment-icon-music-highlighted.png"),
				UIImage.FromFile("chooser-moment-button.png"),
				UIImage.FromFile("chooser-moment-button-highlighted.png")
			);

			DCPathItemButton item3 = new DCPathItemButton(
				UIImage.FromFile("chooser-moment-icon-place.png"),
				UIImage.FromFile("chooser-moment-icon-place-highlighted.png"),
				UIImage.FromFile("chooser-moment-button.png"),
				UIImage.FromFile("chooser-moment-button-highlighted.png")
			);

			DCPathItemButton item4 = new DCPathItemButton(
				UIImage.FromFile("chooser-moment-icon-sleep.png"),
				UIImage.FromFile("chooser-moment-icon-sleep-highlighted.png"),
				UIImage.FromFile("chooser-moment-button.png"),
				UIImage.FromFile("chooser-moment-button-highlighted.png")
			);

			DCPathItemButton item5 = new DCPathItemButton(
				UIImage.FromFile("chooser-moment-icon-thought.png"),
				UIImage.FromFile("chooser-moment-icon-thought-highlighted.png"),
				UIImage.FromFile("chooser-moment-button.png"),
				UIImage.FromFile("chooser-moment-button-highlighted.png")
			);

			NSObject[] itemArray = new NSObject[] { item1 , item2 , item3 , item4 , item5 };

			DCPathButton btnPath = new DCPathButton(UIImage.FromFile("chooser-button-tab.png"), UIImage.FromFile("chooser-button-tab-highlighted.png"));
			btnPath.Frame = new CoreGraphics.CGRect(UIScreen.MainScreen.Bounds.Width/2-25, 300, 50, 50);
			btnPath.AllowSounds = true;
			btnPath.BloomSoundPath = "Sounds/bloom.caf";
			btnPath.FoldSoundPath = "Sounds/fold.caf";
			btnPath.ItemSoundPath = "Sounds/selected.caf";
			btnPath.AllowCenterButtonRotation = true;
			btnPath.Delegate = new BtnDelegate();

			btnPath.BottomViewColor = UIColor.Gray;

			btnPath.BloomDirection = kDCPathButtonBloomDirection.TopRight;
			btnPath.DcButtonCenter = new CoreGraphics.CGPoint(10 + btnPath.Frame.Size.Width / 2, this.View.Frame.Size.Height - btnPath.Frame.Size.Height / 2 - 10);
			btnPath.BottomViewColor = UIColor.Black;

			btnPath.AddPathItems(itemArray);
			View.Add(btnPath);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class BtnDelegate : DCPathButtonDelegate
	{
		public override void PathButton(DCPathButton dcPathButton, nuint itemButtonIndex)
		{
			Debug.WriteLine("Selected Button Index : " + itemButtonIndex);
		}
	}
}

