using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.APP.Interfaces;
using Library.APP.Lists;
using Library.DTO;
namespace Library.APP
{
	public partial class LibraryMain : Form
	{
		public LibraryMain()
		{
			InitializeComponent();

			SetTagsForLists();
		}

		private void SetTagsForLists() {
			ltsCategoryList.Tag = typeof(Category);
			ltsBookList.Tag = typeof(Book);
			ltsAuthorList.Tag = typeof(Author);
			ltsMemberList.Tag = typeof(Member);
			ltsOrderList.Tag = typeof(Order);
			ltsPositionList.Tag = typeof(Position);
			ltsEmployeeList.Tag = typeof(Employee);
		}

		private void btnToolStripAdd_Click(object sender, EventArgs e)
		{
			if (this.ActiveMdiChild != null)
				using (AuthorInsert authorInsert = new AuthorInsert())
				{
					authorInsert.Show();
					authorInsert.MdiParent = this;
				}
		}

		private void ShowLists(object sender, EventArgs e) {
			var item = sender as ToolStripMenuItem;
			var type = (Type)item.Tag;

			var form = new BaseListForm();
			form.BuildForm(type);
			form.MdiParent = this;
			form.Show();
		}

		private void LibraryMain_Load(object sender, EventArgs e)
		{
			IsMdiContainer = true;
		}
	}
}
