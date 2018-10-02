using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 .Text != "" )
            {
                errorProvider1.Clear();
                label1.Text = textBox1.Text;

            }
            else
            {
                errorProvider1.SetError(textBox1, "Please Enter a Text!");
            }
            if (maskedTextBox1.Text != "(   )    -") 
            {
                
                label2.Text = maskedTextBox1 .Text;

            }
            if (radioButton1 .Checked )
            {
                label3.Text = radioButton1.Text;
            }
            else if (radioButton2 .Checked )
                {
                label3.Text = radioButton2.Text;
            
            }
            else if (radioButton3 .Checked )
            {
                label3.Text = radioButton3.Text;
            }
               else
            {

            }
            if (checkBox1 .Checked  && checkBox2 .Checked ) 
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                label4.Text = "Please select just one";
                label5.Text = "";
               
            }
            else if (checkBox1.Checked)
                {
                    label4.Text = checkBox1.Text;
                    label5.Text = "";

                }
                
               

            else if (checkBox2.Checked)
                {
                    label5.Text = checkBox2.Text;
                    label4.Text = "";
                }
            if (checkBox1 .Checked == false && label4 .Text == checkBox1 .Text )
               
            {
                label4.Text = "";
             
            }
            if (checkBox2.Checked == false && label5.Text == checkBox2.Text)

            {
                
                label5.Text = "";
            }
            label6.Text = monthCalendar1.SelectionStart.Date.ToShortDateString  () ;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
           


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
