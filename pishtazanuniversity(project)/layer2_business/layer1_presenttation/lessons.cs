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
    public partial class lessons : Form
    {
        public lessons()
        {
            InitializeComponent();
        }
        int idx;
        private void button1_Click(object sender, EventArgs e)
        {
            businessclass bs = new businessclass();
            dataGridView1.DataSource = bs.getselectlessons( Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text,textBox5.Text);
            dataGridView1.DataMember = "st";

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            businessclass bs = new businessclass();
            bs.getupdatelessons(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(dataGridView1.Rows[idx].Cells[5].Value.ToString()));
            dataGridView1.DataSource = bs.getrefreshlessons();
            dataGridView1.DataMember = "st";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            businessclass bs = new businessclass();
            bs.getinsertlessons(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text);
            dataGridView1.DataSource = bs.getrefreshlessons();
            dataGridView1.DataMember = "st";
            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "پیام ", MessageBoxButtons.OKCancel);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            businessclass bs = new businessclass();
            bs.getdeletelessons(Convert.ToInt32(dataGridView1.Rows[idx].Cells[5].Value.ToString()));
            dataGridView1.DataSource = bs.getrefreshlessons();
            dataGridView1.DataMember = "st";
        }

        private void lessons_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


    }

}
