
namespace TO_DO_LIST {
	partial class MainForm {
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose( );
				}
			base.Dispose( disposing );
			}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent( ) {
			this.label1 = new System.Windows.Forms.Label();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.PriorityDropdown = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.CategoryDropdown = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SubTaskDropdown = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.LinkDropdown = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.DueTimePicker = new System.Windows.Forms.DateTimePicker();
			this.AmountBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.PostponedCheck = new System.Windows.Forms.CheckBox();
			this.MissedCheck = new System.Windows.Forms.CheckBox();
			this.CompletedCheck = new System.Windows.Forms.CheckBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.PlusButton = new System.Windows.Forms.Button();
			this.MinusButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// TitleBox
			// 
			this.TitleBox.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleBox.Location = new System.Drawing.Point(123, 29);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(1120, 50);
			this.TitleBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "Due Date:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 300);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 28);
			this.label4.TabIndex = 6;
			this.label4.Text = "Priority:";
			// 
			// PriorityDropdown
			// 
			this.PriorityDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PriorityDropdown.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriorityDropdown.FormattingEnabled = true;
			this.PriorityDropdown.Items.AddRange(new object[] {
            "",
            "High",
            "Average",
            "Low"});
			this.PriorityDropdown.Location = new System.Drawing.Point(227, 297);
			this.PriorityDropdown.Name = "PriorityDropdown";
			this.PriorityDropdown.Size = new System.Drawing.Size(396, 36);
			this.PriorityDropdown.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(30, 380);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 28);
			this.label5.TabIndex = 8;
			this.label5.Text = "Category:";
			// 
			// CategoryDropdown
			// 
			this.CategoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CategoryDropdown.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CategoryDropdown.FormattingEnabled = true;
			this.CategoryDropdown.Items.AddRange(new object[] {
            "",
            "Work",
            "Finance",
            "Private"});
			this.CategoryDropdown.Location = new System.Drawing.Point(227, 377);
			this.CategoryDropdown.Name = "CategoryDropdown";
			this.CategoryDropdown.Size = new System.Drawing.Size(396, 36);
			this.CategoryDropdown.TabIndex = 9;
			this.CategoryDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(30, 248);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 28);
			this.label6.TabIndex = 10;
			// 
			// SaveButton
			// 
			this.SaveButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.Location = new System.Drawing.Point(1073, 644);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(170, 42);
			this.SaveButton.TabIndex = 11;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Location = new System.Drawing.Point(871, 644);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(170, 42);
			this.DeleteButton.TabIndex = 12;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SubTaskDropdown);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.LinkDropdown);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(704, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(539, 208);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Optional";
			// 
			// SubTaskDropdown
			// 
			this.SubTaskDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SubTaskDropdown.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTaskDropdown.FormattingEnabled = true;
			this.SubTaskDropdown.Location = new System.Drawing.Point(157, 125);
			this.SubTaskDropdown.Name = "SubTaskDropdown";
			this.SubTaskDropdown.Size = new System.Drawing.Size(376, 36);
			this.SubTaskDropdown.TabIndex = 20;
			this.SubTaskDropdown.SelectedIndexChanged += new System.EventHandler(this.SubTaskDropdown_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(24, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 28);
			this.label9.TabIndex = 19;
			this.label9.Text = "Sub-Tasks:";
			// 
			// LinkDropdown
			// 
			this.LinkDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LinkDropdown.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LinkDropdown.FormattingEnabled = true;
			this.LinkDropdown.Items.AddRange(new object[] {
            "",
            "Add.."});
			this.LinkDropdown.Location = new System.Drawing.Point(157, 55);
			this.LinkDropdown.Name = "LinkDropdown";
			this.LinkDropdown.Size = new System.Drawing.Size(376, 36);
			this.LinkDropdown.TabIndex = 18;
			this.LinkDropdown.SelectedIndexChanged += new System.EventHandler(this.LinkDropdown_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(24, 58);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 28);
			this.label8.TabIndex = 17;
			this.label8.Text = "Link-List:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(30, 462);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 28);
			this.label7.TabIndex = 15;
			this.label7.Text = "Amount:";
			// 
			// DueTimePicker
			// 
			this.DueTimePicker.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DueTimePicker.Location = new System.Drawing.Point(227, 136);
			this.DueTimePicker.Name = "DueTimePicker";
			this.DueTimePicker.Size = new System.Drawing.Size(396, 36);
			this.DueTimePicker.TabIndex = 15;
			// 
			// AmountBox
			// 
			this.AmountBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AmountBox.Location = new System.Drawing.Point(227, 459);
			this.AmountBox.Name = "AmountBox";
			this.AmountBox.Size = new System.Drawing.Size(396, 36);
			this.AmountBox.TabIndex = 16;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.PostponedCheck);
			this.groupBox2.Controls.Add(this.MissedCheck);
			this.groupBox2.Controls.Add(this.CompletedCheck);
			this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(704, 377);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(539, 173);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Completion";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(393, 69);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 23);
			this.label12.TabIndex = 5;
			this.label12.Text = "postponed";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(223, 69);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "missed";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(32, 69);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(101, 23);
			this.label10.TabIndex = 3;
			this.label10.Text = "completed";
			// 
			// PostponedCheck
			// 
			this.PostponedCheck.AutoSize = true;
			this.PostponedCheck.Location = new System.Drawing.Point(432, 106);
			this.PostponedCheck.Name = "PostponedCheck";
			this.PostponedCheck.Size = new System.Drawing.Size(22, 21);
			this.PostponedCheck.TabIndex = 2;
			this.PostponedCheck.UseVisualStyleBackColor = true;
			this.PostponedCheck.CheckedChanged += new System.EventHandler(this.PostponedCheck_CheckedChanged);
			// 
			// MissedCheck
			// 
			this.MissedCheck.AutoSize = true;
			this.MissedCheck.Location = new System.Drawing.Point(248, 106);
			this.MissedCheck.Name = "MissedCheck";
			this.MissedCheck.Size = new System.Drawing.Size(22, 21);
			this.MissedCheck.TabIndex = 1;
			this.MissedCheck.UseVisualStyleBackColor = true;
			this.MissedCheck.CheckedChanged += new System.EventHandler(this.MissedCheck_CheckedChanged);
			// 
			// CompletedCheck
			// 
			this.CompletedCheck.AutoSize = true;
			this.CompletedCheck.Location = new System.Drawing.Point(70, 106);
			this.CompletedCheck.Name = "CompletedCheck";
			this.CompletedCheck.Size = new System.Drawing.Size(22, 21);
			this.CompletedCheck.TabIndex = 0;
			this.CompletedCheck.UseVisualStyleBackColor = true;
			this.CompletedCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.Honeydew;
			this.progressBar1.Location = new System.Drawing.Point(227, 219);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(396, 37);
			this.progressBar1.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 28);
			this.label3.TabIndex = 19;
			this.label3.Text = "Progress:";
			// 
			// PlusButton
			// 
			this.PlusButton.Location = new System.Drawing.Point(639, 221);
			this.PlusButton.Name = "PlusButton";
			this.PlusButton.Size = new System.Drawing.Size(30, 30);
			this.PlusButton.TabIndex = 21;
			this.PlusButton.Text = "+";
			this.PlusButton.UseVisualStyleBackColor = true;
			this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
			// 
			// MinusButton
			// 
			this.MinusButton.Location = new System.Drawing.Point(182, 221);
			this.MinusButton.Name = "MinusButton";
			this.MinusButton.Size = new System.Drawing.Size(30, 30);
			this.MinusButton.TabIndex = 22;
			this.MinusButton.Text = "-";
			this.MinusButton.UseVisualStyleBackColor = true;
			this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.MinusButton);
			this.Controls.Add(this.PlusButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.DueTimePicker);
			this.Controls.Add(this.AmountBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.CategoryDropdown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PriorityDropdown);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TitleBox);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TitleBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox PriorityDropdown;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox CategoryDropdown;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox SubTaskDropdown;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox LinkDropdown;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker DueTimePicker;
		private System.Windows.Forms.TextBox AmountBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox CompletedCheck;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox PostponedCheck;
		private System.Windows.Forms.CheckBox MissedCheck;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button PlusButton;
		private System.Windows.Forms.Button MinusButton;
		}
	}

