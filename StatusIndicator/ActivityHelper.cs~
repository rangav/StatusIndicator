using System;
using UIKit;
using CoreGraphics;

namespace StatusIndicator
{
	public class ActivityHelper
	{
		public ActivityHelper ()
		{
		}

		//ref: https://coderwall.com/p/su1t1a/ios-customized-activity-indicator-with-swift
		// https://github.com/Isuru-Nanayakkara/IJProgressView
		// http://stackoverflow.com/questions/27466428/find-middle-of-x-axis-to-place-label-swift-xcode-6

		UIView containerView = new UIView ();
		UIView progressView = new UIView ();
		UILabel activityLabel;
		UIActivityIndicatorView activityIndicator = new UIActivityIndicatorView ();


		public void ShowProgressView (UIView view)
		{
			containerView.Frame = view.Frame;
			containerView.Center = view.Center;
			containerView.BackgroundColor = UIColor.FromRGB (255, 255, 255);

			activityLabel = new UILabel ();
			activityLabel.Text = "Loading..";
			activityLabel.TextColor = UIColor.LightGray;
			activityLabel.Font = UIFont.SystemFontOfSize (20);

			containerView.AddSubview (activityLabel);
			activityLabel.Frame = new CGRect(0, -90, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
			activityLabel.TextAlignment = UITextAlignment.Center;

			//activityIndicator.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.WhiteLarge;
			activityIndicator.Color = UIColor.FromRGB(20,20,20);
			activityIndicator.Transform = CGAffineTransform.MakeScale (1.1f, 1.1f);
			activityIndicator.Center = new CGPoint(containerView.Center.X,containerView.Center.Y-50);

			containerView.AddSubview (activityIndicator);
			view.AddSubview (containerView);

			activityIndicator.StartAnimating ();
		}

		/// <summary>
		/// This is for activity indicator with a background frame 
		/// </summary>
		/// <param name="view">View.</param>
		public void ShowProgressViewBackground (UIView view)
		{
			containerView.Frame = view.Frame;
			containerView.Center = view.Center;
			containerView.BackgroundColor = UIColor.FromRGB (34, 255, 255);

			progressView.Frame = new CGRect (0, 0, 80, 80);
			progressView.Center = view.Center;
			progressView.BackgroundColor = UIColor.FromRGB (255, 255, 255);
			progressView.ClipsToBounds = true;
			progressView.Layer.CornerRadius = 10;

			activityIndicator.Frame = new CGRect (0, 0, 40, 40);
			activityIndicator.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.Gray;
			activityIndicator.Center = new CGPoint (progressView.Bounds.Width / 2, progressView.Bounds.Height / 2);

			progressView.AddSubview (activityIndicator);
			containerView.AddSubview (progressView);
			view.AddSubview (containerView);

			activityIndicator.StartAnimating ();
		}

		public void HideProgressView ()
		{
			activityIndicator.StopAnimating ();
			containerView.RemoveFromSuperview ();
		}
	}
}

