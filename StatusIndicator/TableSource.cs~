using System;
using UIKit;

namespace StatusIndicator
{
	public class TableSource : UITableViewSource
	{
		public Message[] tableItems;
		string cellIdentifier = "tabelCellMessage";

		public TableSource (Message[] data)
		{
			tableItems = data;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);

			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = tableItems[indexPath.Row].Name;
			//cell.DetailTextLabel.Text = tableItems[indexPath.Row].Name;
			return cell;
		}

		public Message GetItem(int id) {
			return tableItems[id];
		}
	}
}

