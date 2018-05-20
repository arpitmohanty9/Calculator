using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
         char operation = new char();
        double input = new double();
      

        public Form1()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            if (display_output.Text == "0")
                display_output.Clear();

            Button btn = (Button)sender;
            // display_output.Text += btn.Text;
            display_output.Text += btn.Text;
            

        }


        private void operator_click(object sender, EventArgs e)
        {
          
            Button btn = (Button)sender;
            // display_output.Text += btn.Text;
            display_output.Text += btn.Text;


        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void hash_Click(object sender, EventArgs e)
        {
            //no need
        }

        private void History_Click(object sender, EventArgs e)
        {
            // No need
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            display_output.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
