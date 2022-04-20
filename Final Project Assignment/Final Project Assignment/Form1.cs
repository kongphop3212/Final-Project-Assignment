using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Data;

namespace Final_Project_Assignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Title Name";
            dataGridView1.Columns[2].Name = "Name";
            dataGridView1.Columns[3].Name = "Surname";
            dataGridView1.Columns[4].Name = "Date";
            dataGridView1.Columns[5].Name = "Time";
            dataGridView1.Columns[6].Name = "In and Out";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void addRow(string id,string titlename, string name, string surname, string date, string time, string inout)
        {
            String[] row = {id, titlename, name, surname, date, time, inout};
            dataGridView1.Rows.Add(row);
        }
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            addRow(textId.Text, comboBoxTitleName.Text, textName.Text, textSurname.Text, dateTimeDate.Text, dateTimeTime.Text, comboBoxInandOut.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erorr :" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}