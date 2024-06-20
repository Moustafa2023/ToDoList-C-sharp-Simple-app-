using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoList
{
	public partial class ToDoList : Form
	{
		public ToDoList()
		{
			InitializeComponent();
			// Add KeyDown event handlers
			TitleTextBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
			DescriptionTextBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
		}

		DataTable toDoList = new DataTable();
		bool isEditing = false;

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void ToDoList_Load(object sender, EventArgs e)
		{
			// Create our columns
			toDoList.Columns.Add("Title");
			toDoList.Columns.Add("Description");
			// Feed the viewer the data
			ToDoListView.DataSource = toDoList;
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			TitleTextBox.Text = "";
			DescriptionTextBox.Text = "";
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			isEditing = true;
			TitleTextBox.Text = toDoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
			DescriptionTextBox.Text = toDoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				toDoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error :{ex.ToString()}");
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			SaveNote();
		}

		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true; // To prevent the beep sound on Enter key press
				SaveNote();
			}
		}

		private void SaveNote()
		{
			if (isEditing)
			{
				toDoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
				toDoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescriptionTextBox.Text;
			}
			else
			{
				toDoList.Rows.Add(TitleTextBox.Text, DescriptionTextBox.Text);
			}

			// Clear the screen
			TitleTextBox.Text = "";
			DescriptionTextBox.Text = "";
			isEditing = false;
		}
	}
}
