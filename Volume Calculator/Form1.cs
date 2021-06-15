using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = this.textBox1.Text;
            Double radius = Double.Parse(text);
            Double pi = Math.PI;

            Double radiusCubed = Math.Pow(radius, 3);

            Double answer = radiusCubed * pi * 4/3;
            String answerText = answer.ToString();

            this.answerLabel = new Label();
            this.answerLabel.Text = answerText;

            this.tabPage1.Controls.Add(this.answerLabel);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tabPage1.Controls.Remove(this.answerLabel);
        }
    }
}
