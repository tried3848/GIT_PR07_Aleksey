using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleksey_PR07_GIT
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidUser(textBox1.Text,textBox2.Text))
            {
                MessageBox.Show("Hello");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private bool IsValidUser(string login, string password)
        {
            return login == "admin" && password == "admin";
        }
    }
}
