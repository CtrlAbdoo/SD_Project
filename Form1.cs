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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Home f1 = new Home();
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
                
          

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            forget_my_password f2 = new forget_my_password();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home f1 = new Home();
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
