using Microsoft.WindowsAzure.MobileServices;
using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using MaratonaXamarin.Shared;

namespace MaratonaXamarin.iOSApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            CurrentPlatform.Init();

            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			this.btnCarregar.TouchUpInside += (sender, e) =>
			{
				var api = new UserApi();

				var users = await api.ListAsync(new Shared.Developer
				{
					Id = Guid.NewGuid().ToString(),
					Name = "Angelo",
					Email = "angelo@angelo.com",
					State = "SP",
					City = "Carapicuiba"
				});

				lvwItems.Source
			};
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

	public class TableViewSource : UITableViewSource
	{
		private List<string> _repositories;

		public TableViewSource(List<string> repositories)
		{
			_repositories = repositories;
		}

		public override nint RowsInSection(UITableView tableview, nint section) => _repositories.Count;

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("TableViewCell");
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, "TableViewCell");

			cell.TextLabel.Text = _repositories[indexPath.Row];
			return cell;
		}
	}
}