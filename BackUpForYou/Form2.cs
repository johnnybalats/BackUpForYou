﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BackUpDb
{
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();
        }
        Form1 form1 = new Form1();
        private void SchedulecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emailnotcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Runbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
