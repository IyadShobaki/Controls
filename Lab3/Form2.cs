﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1 .ShowDialog () == DialogResult.OK )
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}