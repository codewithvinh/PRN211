namespace Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvProject = new DataGridView();
			grbCurrentProject = new GroupBox();
			button1 = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			btnRefresh = new Button();
			lbStartDate = new Label();
			lbType = new Label();
			cbxType = new ComboBox();
			dtpStartDate = new DateTimePicker();
			rtxtDescription = new RichTextBox();
			lbDescription = new Label();
			txtName = new TextBox();
			lbName = new Label();
			txtID = new TextBox();
			lbID = new Label();
			((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
			grbCurrentProject.SuspendLayout();
			SuspendLayout();
			// 
			// dgvProject
			// 
			dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProject.Location = new Point(12, 35);
			dgvProject.Name = "dgvProject";
			dgvProject.RowHeadersWidth = 45;
			dgvProject.RowTemplate.Height = 27;
			dgvProject.Size = new Size(591, 403);
			dgvProject.TabIndex = 0;
			dgvProject.CellClick += dgvProject_CellClick;
			// 
			// grbCurrentProject
			// 
			grbCurrentProject.Controls.Add(button1);
			grbCurrentProject.Controls.Add(btnEdit);
			grbCurrentProject.Controls.Add(btnAdd);
			grbCurrentProject.Controls.Add(btnRefresh);
			grbCurrentProject.Controls.Add(lbStartDate);
			grbCurrentProject.Controls.Add(lbType);
			grbCurrentProject.Controls.Add(cbxType);
			grbCurrentProject.Controls.Add(dtpStartDate);
			grbCurrentProject.Controls.Add(rtxtDescription);
			grbCurrentProject.Controls.Add(lbDescription);
			grbCurrentProject.Controls.Add(txtName);
			grbCurrentProject.Controls.Add(lbName);
			grbCurrentProject.Controls.Add(txtID);
			grbCurrentProject.Controls.Add(lbID);
			grbCurrentProject.Location = new Point(619, 12);
			grbCurrentProject.Name = "grbCurrentProject";
			grbCurrentProject.Size = new Size(378, 440);
			grbCurrentProject.TabIndex = 1;
			grbCurrentProject.TabStop = false;
			grbCurrentProject.Text = "Curent Project";
			// 
			// button1
			// 
			button1.FlatAppearance.BorderColor = Color.Silver;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(287, 393);
			button1.Name = "button1";
			button1.Size = new Size(83, 25);
			button1.TabIndex = 13;
			button1.Text = "Edit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += btnEdit_Click;
			// 
			// btnEdit
			// 
			btnEdit.FlatAppearance.BorderColor = Color.Silver;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.Location = new Point(198, 393);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(83, 25);
			btnEdit.TabIndex = 13;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnAdd
			// 
			btnAdd.FlatAppearance.BorderColor = Color.Silver;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Location = new Point(104, 393);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(83, 25);
			btnAdd.TabIndex = 13;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.FlatAppearance.BorderColor = Color.Silver;
			btnRefresh.FlatStyle = FlatStyle.Flat;
			btnRefresh.Location = new Point(6, 393);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(83, 25);
			btnRefresh.TabIndex = 13;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// lbStartDate
			// 
			lbStartDate.AutoSize = true;
			lbStartDate.Location = new Point(24, 273);
			lbStartDate.Name = "lbStartDate";
			lbStartDate.Size = new Size(62, 17);
			lbStartDate.TabIndex = 12;
			lbStartDate.Text = "StartDate";
			// 
			// lbType
			// 
			lbType.AutoSize = true;
			lbType.Location = new Point(24, 323);
			lbType.Name = "lbType";
			lbType.Size = new Size(35, 17);
			lbType.TabIndex = 11;
			lbType.Text = "Type";
			// 
			// cbxType
			// 
			cbxType.FormattingEnabled = true;
			cbxType.Location = new Point(104, 320);
			cbxType.Name = "cbxType";
			cbxType.Size = new Size(177, 25);
			cbxType.TabIndex = 10;
			// 
			// dtpStartDate
			// 
			dtpStartDate.Location = new Point(104, 267);
			dtpStartDate.Name = "dtpStartDate";
			dtpStartDate.Size = new Size(221, 25);
			dtpStartDate.TabIndex = 9;
			// 
			// rtxtDescription
			// 
			rtxtDescription.Location = new Point(104, 135);
			rtxtDescription.Name = "rtxtDescription";
			rtxtDescription.Size = new Size(221, 106);
			rtxtDescription.TabIndex = 8;
			rtxtDescription.Text = "";
			// 
			// lbDescription
			// 
			lbDescription.AutoSize = true;
			lbDescription.Location = new Point(24, 135);
			lbDescription.Name = "lbDescription";
			lbDescription.Size = new Size(74, 17);
			lbDescription.TabIndex = 4;
			lbDescription.Text = "Description";
			// 
			// txtName
			// 
			txtName.Location = new Point(104, 82);
			txtName.Name = "txtName";
			txtName.Size = new Size(193, 25);
			txtName.TabIndex = 3;
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(24, 82);
			lbName.Name = "lbName";
			lbName.Size = new Size(43, 17);
			lbName.TabIndex = 2;
			lbName.Text = "Name";
			// 
			// txtID
			// 
			txtID.Location = new Point(104, 32);
			txtID.Name = "txtID";
			txtID.ReadOnly = true;
			txtID.Size = new Size(146, 25);
			txtID.TabIndex = 1;
			// 
			// lbID
			// 
			lbID.AutoSize = true;
			lbID.Location = new Point(24, 35);
			lbID.Name = "lbID";
			lbID.Size = new Size(20, 17);
			lbID.TabIndex = 0;
			lbID.Text = "ID";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1013, 487);
			Controls.Add(grbCurrentProject);
			Controls.Add(dgvProject);
			Name = "Form1";
			Text = "Projects";
			((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
			grbCurrentProject.ResumeLayout(false);
			grbCurrentProject.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvProject;
		private GroupBox grbCurrentProject;
		private TextBox textBox3;
		private Label label4;
		private TextBox textBox2;
		private Label lbDescription;
		private TextBox txtName;
		private Label lbName;
		private TextBox txtID;
		private Label lbID;
		private Label lbType;
		private ComboBox cbxType;
		private DateTimePicker dtpStartDate;
		private RichTextBox rtxtDescription;
		private Label lbStartDate;
		private Button btnEdit;
		private Button btnAdd;
		private Button btnRefresh;
		private Button button1;
	}
}