
namespace TO_DO_LIST {
	partial class SubTasksForm {
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
			this.label2 = new System.Windows.Forms.Label();
			this.SubTitleBox = new System.Windows.Forms.TextBox();
			this.SubConfirmButton = new System.Windows.Forms.Button();
			this.SubTaskDeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 28);
			this.label2.TabIndex = 3;
			this.label2.Text = "Title:";
			// 
			// SubTitleBox
			// 
			this.SubTitleBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleBox.Location = new System.Drawing.Point(108, 68);
			this.SubTitleBox.Name = "SubTitleBox";
			this.SubTitleBox.Size = new System.Drawing.Size(396, 36);
			this.SubTitleBox.TabIndex = 17;
			// 
			// SubConfirmButton
			// 
			this.SubConfirmButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubConfirmButton.Location = new System.Drawing.Point(108, 140);
			this.SubConfirmButton.Name = "SubConfirmButton";
			this.SubConfirmButton.Size = new System.Drawing.Size(170, 42);
			this.SubConfirmButton.TabIndex = 18;
			this.SubConfirmButton.Text = "Confirm";
			this.SubConfirmButton.UseVisualStyleBackColor = true;
			this.SubConfirmButton.Click += new System.EventHandler(this.SubConfirmButton_Click);
			// 
			// SubTaskDeleteButton
			// 
			this.SubTaskDeleteButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTaskDeleteButton.Location = new System.Drawing.Point(334, 140);
			this.SubTaskDeleteButton.Name = "SubTaskDeleteButton";
			this.SubTaskDeleteButton.Size = new System.Drawing.Size(170, 42);
			this.SubTaskDeleteButton.TabIndex = 19;
			this.SubTaskDeleteButton.Text = "Delete";
			this.SubTaskDeleteButton.UseVisualStyleBackColor = true;
			this.SubTaskDeleteButton.Click += new System.EventHandler(this.SubTaskDeleteButton_Click);
			// 
			// SubTasksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 206);
			this.Controls.Add(this.SubTaskDeleteButton);
			this.Controls.Add(this.SubConfirmButton);
			this.Controls.Add(this.SubTitleBox);
			this.Controls.Add(this.label2);
			this.Name = "SubTasksForm";
			this.Text = "SubTasksForm";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SubTitleBox;
		private System.Windows.Forms.Button SubConfirmButton;
		private System.Windows.Forms.Button SubTaskDeleteButton;
		}
	}