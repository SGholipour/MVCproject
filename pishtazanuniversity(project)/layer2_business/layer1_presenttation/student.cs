using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using layer2_business;
namespace layer1_presenttation
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        int idx;

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            businessclass bs = new businessclass();
            dataGridView1.DataSource = bs.getselectstudent(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text),textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text));
            dataGridView1.DataMember = "st";
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            businessclass bs = new businessclass();
            bs.getupdatestudent(textBox1.Text, textBox2.Text,
                Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(dataGridView1.Rows[idx].Cells[7].Value.ToString()));
            dataGridView1.DataSource = bs.getrefreshstudent();
            dataGridView1.DataMember = "st";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            businessclass bs = new businessclass();
            bs.getinsertstudent(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text),
                textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text));
            dataGridView1.DataSource = bs.getrefreshstudent();
            dataGridView1.DataMember = "st";

           login  mfrom = new login();
            mfrom.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
        businessclass bs = new businessclass();
            bs.getdeletestudent(Convert.ToInt32( dataGridView1.Rows[idx].Cells[7].Value.ToString()));
            dataGridView1.DataSource = bs.getrefreshstudent();
            dataGridView1.DataMember = "st";
        }

    

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void student_Load(object sender, EventArgs e)
        {
           splash ds = new splash();
            ds.ShowDialog();
        }  

        }
    }

