using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Notes : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public Notes()
        {
            InitializeComponent();
        }
        private void Notes_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            noteHistory.DataSource = notes;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[noteHistory.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[noteHistory.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[noteHistory.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Not a valid note" + ex.Message); }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[noteHistory.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[noteHistory.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void noteHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[noteHistory.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[noteHistory.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }
    }
}
