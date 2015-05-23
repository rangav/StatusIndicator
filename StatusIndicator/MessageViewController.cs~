using System;

using UIKit;
using RestSharp;

namespace StatusIndicator
{
	public partial class MessageViewController : UIViewController
	{
		public MessageViewController (IntPtr handle) : base (handle)
		{
		}

		ActivityHelper progress = new ActivityHelper();

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			Message[] messages = new Message[] {
				new Message{Name="Apple"},
				new Message{Name="Google"},	
				new Message{Name="Localmint"},	
				new Message{Name="Airbnb"},	
				new Message{Name="Skype"},	
				new Message{Name="Slack"},	
			};

			// some rest api goes here...
			var client = new RestClient ("http://www.google.com");
			var request = new RestRequest ("/");


			progress.ShowProgressView (tableViewMessages);
			tableViewMessages.SeparatorColor = UIColor.Clear;

			client.ExecuteAsync (request, response => {
				Console.WriteLine(response.Content);

				// the data normally comes from api call here 
				// do work on UI thread
          		InvokeOnMainThread(delegate {
					tableViewMessages.Source = new TableSource (messages);
					tableViewMessages.ReloadData ();

					// standard seperator color = rdba(199,199,204,255)
					tableViewMessages.SeparatorColor = UIColor.FromRGBA(199,199,204,255);
					progress.HideProgressView();
				});					
			});

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
			// add any view did load example
		}
	}
}

