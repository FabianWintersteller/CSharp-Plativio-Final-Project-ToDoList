
namespace TO_DO_LIST {
	partial class Overview {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose( );
				}
			base.Dispose( disposing );
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.listView1 = new System.Windows.Forms.ListView();
			this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConfigureButton = new System.Windows.Forms.Button();
			this.NewButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.amountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Task,
            this.Progress,
            this.DueDate,
            this.Category,
            this.Id,
            this.Status,
            this.Priority,
            this.Amount});
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 36);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(635, 415);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
			// 
			// Task
			// 
			this.Task.Text = "Task";
			// 
			// Progress
			// 
			this.Progress.Text = "Progress";
			// 
			// DueDate
			// 
			this.DueDate.Text = "Due Date";
			// 
			// Category
			// 
			this.Category.Text = "Category";
			// 
			// Id
			// 
			this.Id.Text = "Id";
			this.Id.Width = 0;
			// 
			// Status
			// 
			this.Status.DisplayIndex = 7;
			this.Status.Text = "Status";
			// 
			// Priority
			// 
			this.Priority.DisplayIndex = 5;
			this.Priority.Text = "Priority";
			// 
			// Amount
			// 
			this.Amount.DisplayIndex = 6;
			this.Amount.Text = "Amount";
			// 
			// ConfigureButton
			// 
			this.ConfigureButton.Location = new System.Drawing.Point(673, 382);
			this.ConfigureButton.Name = "ConfigureButton";
			this.ConfigureButton.Size = new System.Drawing.Size(95, 43);
			this.ConfigureButton.TabIndex = 1;
			this.ConfigureButton.Text = "Configure";
			this.ConfigureButton.UseVisualStyleBackColor = true;
			this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
			// 
			// NewButton
			// 
			this.NewButton.Location = new System.Drawing.Point(673, 314);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(95, 43);
			this.NewButton.TabIndex = 2;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(673, 245);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(95, 43);
			this.DeleteButton.TabIndex = 3;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Location = new System.Drawing.Point(0, 33);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.generalToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(800, 33);
			this.menuStrip2.TabIndex = 5;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// tasksToolStripMenuItem
			// 
			this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
			this.tasksToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
			this.tasksToolStripMenuItem.Text = "Tasks";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
			this.newToolStripMenuItem.Text = "New..";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// configureToolStripMenuItem
			// 
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
			this.configureToolStripMenuItem.Text = "Configure..";
			this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
			this.deleteToolStripMenuItem.Text = "Delete..";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem,
            this.progressToolStripMenuItem,
            this.dueDateToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.priorityToolStripMenuItem,
            this.amountToolStripMenuItem,
            this.statusToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// taskToolStripMenuItem
			// 
			this.taskToolStripMenuItem.Checked = true;
			this.taskToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
			this.taskToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.taskToolStripMenuItem.Text = "Task";
			this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
			// 
			// progressToolStripMenuItem
			// 
			this.progressToolStripMenuItem.Checked = true;
			this.progressToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.progressToolStripMenuItem.Name = "progressToolStripMenuItem";
			this.progressToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.progressToolStripMenuItem.Text = "Progress";
			this.progressToolStripMenuItem.Click += new System.EventHandler(this.progressToolStripMenuItem_Click);
			// 
			// dueDateToolStripMenuItem
			// 
			this.dueDateToolStripMenuItem.Checked = true;
			this.dueDateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.dueDateToolStripMenuItem.Name = "dueDateToolStripMenuItem";
			this.dueDateToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.dueDateToolStripMenuItem.Text = "Due Date";
			this.dueDateToolStripMenuItem.Click += new System.EventHandler(this.dueDateToolStripMenuItem_Click);
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.Checked = true;
			this.categoryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.categoryToolStripMenuItem.Text = "Category";
			this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
			// 
			// priorityToolStripMenuItem
			// 
			this.priorityToolStripMenuItem.Checked = true;
			this.priorityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
			this.priorityToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.priorityToolStripMenuItem.Text = "Priority";
			this.priorityToolStripMenuItem.Click += new System.EventHandler(this.priorityToolStripMenuItem_Click);
			// 
			// amountToolStripMenuItem
			// 
			this.amountToolStripMenuItem.Checked = true;
			this.amountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.amountToolStripMenuItem.Name = "amountToolStripMenuItem";
			this.amountToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.amountToolStripMenuItem.Text = "Amount";
			this.amountToolStripMenuItem.Click += new System.EventHandler(this.amountToolStripMenuItem_Click);
			// 
			// statusToolStripMenuItem
			// 
			this.statusToolStripMenuItem.Checked = true;
			this.statusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
			this.statusToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
			this.statusToolStripMenuItem.Text = "Status";
			this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
			// 
			// generalToolStripMenuItem
			// 
			this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
			this.generalToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
			this.generalToolStripMenuItem.Text = "General";
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
			this.printToolStripMenuItem.Text = "Print..";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
			this.closeToolStripMenuItem.Text = "Close..";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// Overview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.ConfigureButton);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Overview";
			this.Text = "Overview";
			this.Activated += new System.EventHandler(this.Overview_Activated);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Task;
		private System.Windows.Forms.ColumnHeader DueDate;
		private System.Windows.Forms.ColumnHeader Category;
		private System.Windows.Forms.Button ConfigureButton;
		private System.Windows.Forms.ColumnHeader Id;
		private System.Windows.Forms.ColumnHeader Status;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.ColumnHeader Progress;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dueDateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem amountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader Priority;
		private System.Windows.Forms.ColumnHeader Amount;
		}
	}