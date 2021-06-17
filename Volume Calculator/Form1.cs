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
            this.answerLabel.Location = new Point(286, 298);
            this.answerLabel.Font = new Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerLabel.Text = answerText;

            this.tabPage1.Controls.Add(this.answerLabel);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tabPage1.Controls.Remove(this.answerLabel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String edgeSizeText = this.textBox4.Text;
            Double edge = Double.Parse(edgeSizeText);

            Double answerDouble = Math.Pow(edge, 3);

            String answer = answerDouble.ToString();
            answerLabel2 = new Label();
            answerLabel2.Font = new Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            answerLabel2.Location = new Point(286, 298);
            answerLabel2.Text = answer;

            this.tabPage3.Controls.Add(answerLabel2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tabPage3.Controls.Remove(this.answerLabel2);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            String text = this.textBox8.Text;
            Double baseDouble = Double.Parse(text);
            String text2 = this.textBox7.Text;

            String text3 = this.textBox9.Text;

            Double prismHeight = Double.Parse(text3);

            Double triangleHeight = Double.Parse(text2);

            Double areaOfTriangle = triangleHeight * baseDouble * 1 / 2;

            Double volumeOfPrism = areaOfTriangle * prismHeight;

            String answer = volumeOfPrism.ToString();



            answerLabel3 = new Label();
            answerLabel3.Font = new Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            answerLabel3.Location = new Point(240, 372);
            answerLabel3.Text = answer;

            this.tabPage5.Controls.Add(answerLabel3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.tabPage5.Controls.Remove(answerLabel3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String text = this.textBox5.Text;
            String text2 = this.textBox6.Text;
            Double radius = Double.Parse(text);
            Double height = Double.Parse(text2);
            Double radiusSquared = Math.Pow(radius, 2);

            Double areaOfCircle = radiusSquared * Math.PI;

            Double volume = areaOfCircle * height;

            String answer = volume.ToString();
            answerLabel4 = new Label();
            answerLabel4.Text = answer;
            answerLabel4.Font = new Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            answerLabel4.Location = new Point(263, 298);
            this.tabPage4.Controls.Add(this.answerLabel4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.tabPage4.Controls.Remove(this.answerLabel4);
        }
    }
}
