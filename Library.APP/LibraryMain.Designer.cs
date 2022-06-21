
namespace Library.APP
{
	partial class LibraryMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsCategoryList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsBookList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsAuthorList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsMemberList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsOrderList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsPositionList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ltsEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.btnToolStripAdd = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.authorToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.employeesToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // categoryToolStripMenuItem
      // 
      this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsCategoryList,
            this.addToolStripMenuItem});
      this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
      this.categoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.categoryToolStripMenuItem.Text = "Categories";
      // 
      // ltsCategoryList
      // 
      this.ltsCategoryList.Name = "ltsCategoryList";
      this.ltsCategoryList.Size = new System.Drawing.Size(180, 22);
      this.ltsCategoryList.Tag = "";
      this.ltsCategoryList.Text = "List";
      this.ltsCategoryList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem.Text = "Add";
      // 
      // booksToolStripMenuItem
      // 
      this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsBookList,
            this.addToolStripMenuItem1});
      this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
      this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.booksToolStripMenuItem.Text = "Books";
      // 
      // ltsBookList
      // 
      this.ltsBookList.Name = "ltsBookList";
      this.ltsBookList.Size = new System.Drawing.Size(180, 22);
      this.ltsBookList.Tag = "";
      this.ltsBookList.Text = "List";
      this.ltsBookList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem1
      // 
      this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
      this.addToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem1.Text = "Add";
      // 
      // authorToolStripMenuItem
      // 
      this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsAuthorList,
            this.addToolStripMenuItem3});
      this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
      this.authorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.authorToolStripMenuItem.Text = "Authors";
      // 
      // ltsAuthorList
      // 
      this.ltsAuthorList.Name = "ltsAuthorList";
      this.ltsAuthorList.Size = new System.Drawing.Size(180, 22);
      this.ltsAuthorList.Tag = "";
      this.ltsAuthorList.Text = "List";
      this.ltsAuthorList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem3
      // 
      this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
      this.addToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem3.Text = "Add";
      // 
      // membersToolStripMenuItem
      // 
      this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsMemberList,
            this.addToolStripMenuItem2});
      this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
      this.membersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.membersToolStripMenuItem.Text = "Members";
      // 
      // ltsMemberList
      // 
      this.ltsMemberList.Name = "ltsMemberList";
      this.ltsMemberList.Size = new System.Drawing.Size(180, 22);
      this.ltsMemberList.Tag = "";
      this.ltsMemberList.Text = "List";
      this.ltsMemberList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem2
      // 
      this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
      this.addToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem2.Text = "Add";
      // 
      // ordersToolStripMenuItem
      // 
      this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsOrderList,
            this.addToolStripMenuItem4});
      this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
      this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.ordersToolStripMenuItem.Text = "Orders";
      // 
      // ltsOrderList
      // 
      this.ltsOrderList.Name = "ltsOrderList";
      this.ltsOrderList.Size = new System.Drawing.Size(180, 22);
      this.ltsOrderList.Tag = "";
      this.ltsOrderList.Text = "List";
      this.ltsOrderList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem4
      // 
      this.addToolStripMenuItem4.Name = "addToolStripMenuItem4";
      this.addToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem4.Text = "Add";
      // 
      // positionToolStripMenuItem
      // 
      this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsPositionList,
            this.addToolStripMenuItem6});
      this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
      this.positionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.positionToolStripMenuItem.Text = "Positions";
      // 
      // ltsPositionList
      // 
      this.ltsPositionList.Name = "ltsPositionList";
      this.ltsPositionList.Size = new System.Drawing.Size(180, 22);
      this.ltsPositionList.Tag = "";
      this.ltsPositionList.Text = "List";
      this.ltsPositionList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem6
      // 
      this.addToolStripMenuItem6.Name = "addToolStripMenuItem6";
      this.addToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem6.Text = "Add";
      // 
      // employeesToolStripMenuItem
      // 
      this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsEmployeeList,
            this.addToolStripMenuItem7});
      this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
      this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
      this.employeesToolStripMenuItem.Text = "Employees";
      // 
      // ltsEmployeeList
      // 
      this.ltsEmployeeList.Name = "ltsEmployeeList";
      this.ltsEmployeeList.Size = new System.Drawing.Size(180, 22);
      this.ltsEmployeeList.Tag = "";
      this.ltsEmployeeList.Text = "List";
      this.ltsEmployeeList.Click += new System.EventHandler(this.ShowLists);
      // 
      // addToolStripMenuItem7
      // 
      this.addToolStripMenuItem7.Name = "addToolStripMenuItem7";
      this.addToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem7.Text = "Add";
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolStripAdd,
            this.toolStripButton1,
            this.toolStripButton2});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1054, 27);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // btnToolStripAdd
      // 
      this.btnToolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnToolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnToolStripAdd.Image")));
      this.btnToolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnToolStripAdd.Name = "btnToolStripAdd";
      this.btnToolStripAdd.Size = new System.Drawing.Size(24, 24);
      this.btnToolStripAdd.Text = "toolStripButton1";
      this.btnToolStripAdd.Click += new System.EventHandler(this.btnToolStripAdd_Click);
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0);
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
      this.toolStripButton1.Size = new System.Drawing.Size(59, 27);
      this.toolStripButton1.Text = "toolStripButton1";
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Margin = new System.Windows.Forms.Padding(1, 1, 5, 2);
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
      this.toolStripButton2.Size = new System.Drawing.Size(31, 24);
      this.toolStripButton2.Text = "toolStripButton2";
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 572);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // directorySearcher1
      // 
      this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
      this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
      this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
      // 
      // LibraryMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1054, 594);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "LibraryMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.LibraryMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ltsCategoryList;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ltsBookList;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnToolStripAdd;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ltsAuthorList;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ltsMemberList;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ltsOrderList;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ltsPositionList;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem6;
    private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ltsEmployeeList;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem7;
  }
}

