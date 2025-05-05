using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Register = new Form3();
            Register.TopLevel = false;
            Register.FormBorderStyle = FormBorderStyle.None;
            Register.Dock = DockStyle.Fill;

            panel2.Controls.Clear(); // Clear the panel before adding a new form
            panel2.Controls.Add(Register);
            Register.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 LogIn = new Form2();
            LogIn.TopLevel = false;
            LogIn.FormBorderStyle = FormBorderStyle.None;
            LogIn.Dock = DockStyle.Fill;

            panel2.Controls.Clear(); // Clear the panel before adding a new form
            panel2.Controls.Add(LogIn);
            LogIn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 calculator = new Form1();
            //calculator.Show();
            Form1 calculator = new Form1();
            calculator.TopLevel = false;
            calculator.FormBorderStyle = FormBorderStyle.None;
            calculator.Dock = DockStyle.Fill;


            panel2.Controls.Clear(); // Clear the panel before adding a new form
            panel2.Controls.Add(calculator);
            calculator.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;

        }

        private void repositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();  
        }
    }
}
