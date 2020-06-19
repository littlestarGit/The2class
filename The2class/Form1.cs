using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The2class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.label1.Left += 10;
            this.Text = DateTime.Now.ToString();
            this.label1.BackColor = Color.FromArgb(
                rnd.Next(DateTime.Now.Millisecond%255),
                rnd.Next(DateTime.Now.Millisecond % 255), 
                rnd.Next(DateTime.Now.Millisecond % 255));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.label1.Left += 10;
            this.Text = DateTime.Now.ToString();
            this.label1.BackColor = Color.FromArgb(
                rnd.Next(255),
                rnd.Next(255),
                rnd.Next(255));
        }
    }
}
