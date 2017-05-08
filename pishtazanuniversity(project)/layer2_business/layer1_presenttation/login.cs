using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using layer2_business;
namespace layer1_presenttation
{
    public partial class login : Form
    {


        public login()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            businessclass b = new businessclass();
            var read = b.getlogin();
            read.Read();
            int count = 0;
            while (read.Read())
            {
                if (read["Tstdnum"].ToString() == textBox1.Text && read["Ttel"].ToString() == textBox2.Text)
                {

                    lessons mForm = new lessons();
                    mForm.Show();
                    count = 1;
                    break;

                }

            }
            if (count == 0)
            {

                MessageBox.Show("کد کاربری یا کلمه عبور اشتباه است ");

            }


        }

        private void login_Load(object sender, EventArgs e)
        {

        }

    }
}

