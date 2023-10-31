using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace NotepadApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        string jsonFilePath;
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
            jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "notes.json");
            LoadNotesFromJson();
        }

        private void InitializeDataTable()
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Note", typeof(string));
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Note"].Visible = false;
        }

        private void SaveNotesToJson()
        {
            string json = JsonConvert.SerializeObject(table);
            File.WriteAllText(jsonFilePath, json);
        }

        private void LoadNotesFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                DataTable loadedTable = JsonConvert.DeserializeObject<DataTable>(json);

                
                DataTable newTable = new DataTable();
                newTable.Columns.Add("Title", typeof(string));
                newTable.Columns.Add("Note", typeof(string));

                
                foreach (DataRow row in loadedTable.Rows)
                {
                    newTable.Rows.Add(row["Title"], row["Note"]);
                }

                
                dataGridView1.DataSource = newTable;
                table = newTable; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void notesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            noteText.Clear();
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(titleText.Text) && !string.IsNullOrWhiteSpace(noteText.Text))
            {
                table.Rows.Add(titleText.Text, noteText.Text);
                newNote.PerformClick();
                SaveNotesToJson();
            }
            else
            {
                MessageBox.Show("Both title and note cannot be empty. Please enter valid content.");
            }

        }

        private void readNoteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell.RowIndex < table.Rows.Count)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                titleText.Text = table.Rows[index].ItemArray[0].ToString();
                noteText.Text = table.Rows[index].ItemArray[1].ToString();
            }
            else
            {
                MessageBox.Show("No notes available or invalid selection.");
            }
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell.RowIndex < table.Rows.Count)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows.RemoveAt(index);
                SaveNotesToJson();
            }
            else
            {
                MessageBox.Show("No notes available or invalid selection.");
            }
        }
    }
}
