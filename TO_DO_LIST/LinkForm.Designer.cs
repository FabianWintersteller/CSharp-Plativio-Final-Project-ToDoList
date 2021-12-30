
namespace TO_DO_LIST {
	partial class LinkForm {
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
			this.components = new System.ComponentModel.Container();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.LinkTitle = new System.Windows.Forms.TextBox();
			this.Link = new System.Windows.Forms.TextBox();
			this.LinkCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.LinkCopy.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 28);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(51, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 28);
			this.label1.TabIndex = 4;
			this.label1.Text = "Link:";
			// 
			// LinkTitle
			// 
			this.LinkTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LinkTitle.Location = new System.Drawing.Point(141, 41);
			this.LinkTitle.Name = "LinkTitle";
			this.LinkTitle.Size = new System.Drawing.Size(396, 36);
			this.LinkTitle.TabIndex = 17;
			// 
			// Link
			// 
			this.Link.ContextMenuStrip = this.LinkCopy;
			this.Link.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Link.Location = new System.Drawing.Point(141, 113);
			this.Link.Name = "Link";
			this.Link.Size = new System.Drawing.Size(396, 36);
			this.Link.TabIndex = 18;
			// 
			// LinkCopy
			// 
			this.LinkCopy.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.LinkCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.LinkCopy.Name = "LinkCopy";
			this.LinkCopy.Size = new System.Drawing.Size(241, 69);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
			this.copyToolStripMenuItem.Text = "Copy..";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConfirmButton.Location = new System.Drawing.Point(141, 177);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(170, 42);
			this.ConfirmButton.TabIndex = 19;
			this.ConfirmButton.Text = "Confirm";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Location = new System.Drawing.Point(367, 177);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(170, 42);
			this.DeleteButton.TabIndex = 20;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// LinkForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 244);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.Link);
			this.Controls.Add(this.LinkTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "LinkForm";
			this.Text = "Link";
			this.Load += new System.EventHandler(this.LinkForm_Load);
			this.LinkCopy.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LinkTitle;
		private System.Windows.Forms.TextBox Link;
		private System.Windows.Forms.Button ConfirmButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.ContextMenuStrip LinkCopy;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		}
	}