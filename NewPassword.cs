﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Design
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("New Password Reset Successfully");
                Home f1 = new Home();
                this.Hide();
                f1.Show();
            }
            else
                MessageBox.Show("it should be the same password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forget_my_password f1 = new forget_my_password();
            this.Hide();
            f1.Show();
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
