using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        string textFile = "readfile.txt";
        Image[] images = new Image[4];
        int randomNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void captionMarvelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void superHeroBackStoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void multyverseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backStoryToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter(@"output.txt"))
                writer.WriteLine(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(textFile);
            using(StreamReader file = new StreamReader(textFile))
                foreach(string line in lines)
                {
                    MessageBox.Show(line);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            images[0] = Image.FromFile("c:/Users/Owner/Source/repos/Final Project/bin/Captain America.JFIF");
            images[1] = Image.FromFile("c:/Users/Owner/Source/repos/Final Project/bin/IronMan3.0.JPG");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 4;
            Random random = new Random();
            randomNum = random.Next(1,30);
            textBox2.Text = randomNum.ToString();

        }
    }
}