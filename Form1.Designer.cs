namespace toDoList
{
	partial class ToDoList
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
			this.label1 = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.Description = new System.Windows.Forms.Label();
			this.Title = new System.Windows.Forms.Label();
			this.NewButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.ToDoListView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1065, 86);
			this.label1.TabIndex = 0;
			this.label1.Text = "To Do List";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleTextBox.Location = new System.Drawing.Point(12, 138);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(1065, 26);
			this.TitleTextBox.TabIndex = 1;
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionTextBox.Location = new System.Drawing.Point(12, 187);
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(1065, 26);
			this.DescriptionTextBox.TabIndex = 2;
			this.DescriptionTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Description
			// 
			this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description.Location = new System.Drawing.Point(9, 161);
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(1065, 23);
			this.Description.TabIndex = 3;
			this.Description.Text = "Description :";
			// 
			// Title
			// 
			this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(12, 112);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(1065, 23);
			this.Title.TabIndex = 4;
			this.Title.Text = "Title :";
			this.Title.Click += new System.EventHandler(this.label3_Click);
			// 
			// NewButton
			// 
			this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewButton.Location = new System.Drawing.Point(12, 218);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(250, 31);
			this.NewButton.TabIndex = 5;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditButton.Location = new System.Drawing.Point(288, 218);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(250, 31);
			this.EditButton.TabIndex = 6;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Location = new System.Drawing.Point(557, 218);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(250, 31);
			this.DeleteButton.TabIndex = 7;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.Location = new System.Drawing.Point(827, 218);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(250, 31);
			this.SaveButton.TabIndex = 8;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ToDoListView
			// 
			this.ToDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ToDoListView.BackgroundColor = System.Drawing.Color.White;
			this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ToDoListView.Location = new System.Drawing.Point(12, 259);
			this.ToDoListView.Name = "ToDoListView";
			this.ToDoListView.Size = new System.Drawing.Size(1062, 374);
			this.ToDoListView.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(441, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "M2m Early Release";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ToDoList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1089, 646);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ToDoListView);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.Description);
			this.Controls.Add(this.DescriptionTextBox);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.label1);
			this.Name = "ToDoList";
			this.Text = "To Do List";
			this.Load += new System.EventHandler(this.ToDoList_Load);
			((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.TextBox DescriptionTextBox;
		private System.Windows.Forms.Label Description;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.DataGridView ToDoListView;
		private System.Windows.Forms.Label label2;
	}
}

