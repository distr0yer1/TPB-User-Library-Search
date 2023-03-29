
namespace TPB_User_Library_Search
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbnName = new System.Windows.Forms.RadioButton();
			this.rbnSize = new System.Windows.Forms.RadioButton();
			this.rbnUploaded = new System.Windows.Forms.RadioButton();
			this.rbnSeeder = new System.Windows.Forms.RadioButton();
			this.rbnLeecher = new System.Windows.Forms.RadioButton();
			this.rbnFiles = new System.Windows.Forms.RadioButton();
			this.cbxFlip = new System.Windows.Forms.CheckBox();
			this.cbxCateg = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnFilter = new System.Windows.Forms.Button();
			this.lbxContent = new System.Windows.Forms.ListBox();
			this.btnUsername = new System.Windows.Forms.Button();
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.lblItems = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(297, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search the contents of a User";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(76, 37);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(198, 20);
			this.txtUsername.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(61, 19);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(198, 20);
			this.txtSearch.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblItems);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnFilter);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxCateg);
			this.groupBox1.Controls.Add(this.cbxFlip);
			this.groupBox1.Controls.Add(this.rbnFiles);
			this.groupBox1.Controls.Add(this.rbnLeecher);
			this.groupBox1.Controls.Add(this.rbnSeeder);
			this.groupBox1.Controls.Add(this.rbnUploaded);
			this.groupBox1.Controls.Add(this.rbnSize);
			this.groupBox1.Controls.Add(this.rbnName);
			this.groupBox1.Location = new System.Drawing.Point(15, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(294, 208);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sort";
			// 
			// rbnName
			// 
			this.rbnName.AutoSize = true;
			this.rbnName.Location = new System.Drawing.Point(7, 47);
			this.rbnName.Name = "rbnName";
			this.rbnName.Size = new System.Drawing.Size(53, 17);
			this.rbnName.TabIndex = 0;
			this.rbnName.TabStop = true;
			this.rbnName.Text = "Name";
			this.rbnName.UseVisualStyleBackColor = true;
			// 
			// rbnSize
			// 
			this.rbnSize.AutoSize = true;
			this.rbnSize.Location = new System.Drawing.Point(7, 70);
			this.rbnSize.Name = "rbnSize";
			this.rbnSize.Size = new System.Drawing.Size(45, 17);
			this.rbnSize.TabIndex = 1;
			this.rbnSize.TabStop = true;
			this.rbnSize.Text = "Size";
			this.rbnSize.UseVisualStyleBackColor = true;
			// 
			// rbnUploaded
			// 
			this.rbnUploaded.AutoSize = true;
			this.rbnUploaded.Location = new System.Drawing.Point(7, 93);
			this.rbnUploaded.Name = "rbnUploaded";
			this.rbnUploaded.Size = new System.Drawing.Size(71, 17);
			this.rbnUploaded.TabIndex = 2;
			this.rbnUploaded.TabStop = true;
			this.rbnUploaded.Text = "Uploaded";
			this.rbnUploaded.UseVisualStyleBackColor = true;
			// 
			// rbnSeeder
			// 
			this.rbnSeeder.AutoSize = true;
			this.rbnSeeder.Location = new System.Drawing.Point(7, 116);
			this.rbnSeeder.Name = "rbnSeeder";
			this.rbnSeeder.Size = new System.Drawing.Size(64, 17);
			this.rbnSeeder.TabIndex = 3;
			this.rbnSeeder.TabStop = true;
			this.rbnSeeder.Text = "Seeders";
			this.rbnSeeder.UseVisualStyleBackColor = true;
			// 
			// rbnLeecher
			// 
			this.rbnLeecher.AutoSize = true;
			this.rbnLeecher.Location = new System.Drawing.Point(7, 139);
			this.rbnLeecher.Name = "rbnLeecher";
			this.rbnLeecher.Size = new System.Drawing.Size(69, 17);
			this.rbnLeecher.TabIndex = 4;
			this.rbnLeecher.TabStop = true;
			this.rbnLeecher.Text = "Leechers";
			this.rbnLeecher.UseVisualStyleBackColor = true;
			// 
			// rbnFiles
			// 
			this.rbnFiles.AutoSize = true;
			this.rbnFiles.Location = new System.Drawing.Point(7, 162);
			this.rbnFiles.Name = "rbnFiles";
			this.rbnFiles.Size = new System.Drawing.Size(46, 17);
			this.rbnFiles.TabIndex = 5;
			this.rbnFiles.TabStop = true;
			this.rbnFiles.Text = "Files";
			this.rbnFiles.UseVisualStyleBackColor = true;
			// 
			// cbxFlip
			// 
			this.cbxFlip.AutoSize = true;
			this.cbxFlip.Location = new System.Drawing.Point(7, 185);
			this.cbxFlip.Name = "cbxFlip";
			this.cbxFlip.Size = new System.Drawing.Size(83, 17);
			this.cbxFlip.TabIndex = 6;
			this.cbxFlip.Text = "High -> Low";
			this.cbxFlip.UseVisualStyleBackColor = true;
			// 
			// cbxCateg
			// 
			this.cbxCateg.FormattingEnabled = true;
			this.cbxCateg.Location = new System.Drawing.Point(140, 69);
			this.cbxCateg.Name = "cbxCateg";
			this.cbxCateg.Size = new System.Drawing.Size(148, 21);
			this.cbxCateg.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(138, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Category:";
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(141, 162);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(147, 40);
			this.btnFilter.TabIndex = 9;
			this.btnFilter.Text = "Apply Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// lbxContent
			// 
			this.lbxContent.FormattingEnabled = true;
			this.lbxContent.Location = new System.Drawing.Point(315, 5);
			this.lbxContent.Name = "lbxContent";
			this.lbxContent.Size = new System.Drawing.Size(350, 264);
			this.lbxContent.TabIndex = 7;
			this.lbxContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxContent_MouseDoubleClick);
			// 
			// btnUsername
			// 
			this.btnUsername.Location = new System.Drawing.Point(280, 36);
			this.btnUsername.Margin = new System.Windows.Forms.Padding(0);
			this.btnUsername.Name = "btnUsername";
			this.btnUsername.Size = new System.Drawing.Size(29, 22);
			this.btnUsername.TabIndex = 8;
			this.btnUsername.Text = "Go";
			this.btnUsername.UseVisualStyleBackColor = true;
			this.btnUsername.Click += new System.EventHandler(this.btnUsername_Click);
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(138, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Pages Loaded:";
			// 
			// lblItems
			// 
			this.lblItems.AutoSize = true;
			this.lblItems.Location = new System.Drawing.Point(223, 95);
			this.lblItems.Name = "lblItems";
			this.lblItems.Size = new System.Drawing.Size(13, 13);
			this.lblItems.TabIndex = 11;
			this.lblItems.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 280);
			this.Controls.Add(this.btnUsername);
			this.Controls.Add(this.lbxContent);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(689, 319);
			this.Name = "Form1";
			this.Text = "TPB Search";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxCateg;
		private System.Windows.Forms.CheckBox cbxFlip;
		private System.Windows.Forms.RadioButton rbnFiles;
		private System.Windows.Forms.RadioButton rbnLeecher;
		private System.Windows.Forms.RadioButton rbnSeeder;
		private System.Windows.Forms.RadioButton rbnUploaded;
		private System.Windows.Forms.RadioButton rbnSize;
		private System.Windows.Forms.RadioButton rbnName;
		private System.Windows.Forms.ListBox lbxContent;
		private System.Windows.Forms.Button btnUsername;
		private System.Windows.Forms.Timer tmrUpdate;
		private System.Windows.Forms.Label lblItems;
		private System.Windows.Forms.Label label5;
	}
}

