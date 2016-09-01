# PathMenuXamarin
PathMenuXamarin is a custom menu button for Xamarin iOS. The original design for this control first appeared in the well-known iOS app, Path. 
The **PathMenuXamarin** is a close replication of Path's button, including the **animations**, the **sounds** and the **button's images** (*of course you can use your own images*).  

Clone for Xamarin.iOS : https://github.com/Tangdixi/DCPathButton

## Example

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

			NSObject[] itemArray = new NSObject[] { item1 , item2 , item3};

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

## License

The MIT License (MIT)

Copyright (c) 2016 Sunny Patel

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
