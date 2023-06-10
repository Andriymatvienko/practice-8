using System.ComponentModel.DataAnnotations;
using System;
namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        
        
        struct Discipline
        {
            public string Subject;
            public string Name;
            public int Hours;
        }
        
        
        public Form1()
        {
            InitializeComponent();

           
        }
        Discipline[] worker = new Discipline[20];
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount= 3;
            dataGridView1.Columns[0].HeaderText= "Name";
            dataGridView1.Columns[1].HeaderText= "Subject";
            dataGridView1.Columns[2].HeaderText = "Hours";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SubjectTextBox.Text == "" || NameTextBox.Text == "" ||
                HoursTextBox.Text == "")
            {
                MessageBox.Show("ÕÂ ‚Ò≥ ‰‡ÌÌ≥ Ó·‡Ì≥,œŒÃ»À ¿!!");
            }
            else
            {
                
                worker[i].Subject = SubjectTextBox.Text;
                worker[i].Name = NameTextBox.Text;
                worker[i].Hours=int.Parse(HoursTextBox.Text);
                dataGridView1.Rows.Add(worker[i].Name, worker[i].Subject, worker[i].Hours.ToString());
                i++;

            }
            ClearInputFields();
            
        }
        private void ClearInputFields()
        {
            SubjectTextBox.Text = "";
            NameTextBox.Text = "";
            HoursTextBox.Text = "";
        }

        private void Á‡Í˚Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}