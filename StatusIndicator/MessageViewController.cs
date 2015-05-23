using System;

using UIKit;

namespace StatusIndicator
{
	public partial class MessageViewController : UIViewController
	{
		public MessageViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
			// add any view did load example
		}
	}
}

