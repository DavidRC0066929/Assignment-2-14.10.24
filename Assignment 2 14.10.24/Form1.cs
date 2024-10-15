using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_14._10._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBox1.Text); // variable for length
                double width = double.Parse(textBox2.Text); // variable for width
                double height = double.Parse(textBox3.Text); // variable for height
                double volume = length * width * height; // does volume equation for rectangular cuboid
                double surfacearea = 2 * ((length * height) + (length * width) + (width * height)); // does surface area equation for rectangular cuboid
                label9.Text = volume.ToString("0.000") + " m^3"; // shows the volume in a label with correct units
                label10.Text = surfacearea.ToString("0.000") + " m^2"; // shows the surface area in a label with correct units
            }
            catch
            {
                MessageBox.Show("You input something in wrong"); // error message for falsely inputted text
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox6.Text); // variable for radius
                double pi = Math.PI; // variable for pi
                double volume = 4.0 / 3.0 * pi * (Math.Pow(radius, 3)); // does volume equation for a sphere
                double surfacearea = 4 * pi * (Math.Pow(radius, 2)); // does surface area equation for a sphere
                label12.Text = volume.ToString("0.000") + " m^3"; // shows the volume in a label with correct units
                label11.Text = surfacearea.ToString("0.000") + " m^2"; // shows the surface area in a label with correct units
            }
            catch
            {
                MessageBox.Show("You input something in wrong"); // error message for falsely inputted text
        }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(textBox9.Text); // variable for height
                double radius = double.Parse((textBox7.Text)); // variable for radius
                double pi = Math.PI; // variable for pi
                double volume = 1.0 / 3.0 * pi * (Math.Pow(radius, 2) * height); // does volume equation for a cone
                double surfacearea = (pi * radius) * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));// does surface area equation for a cone
                label22.Text = volume.ToString("0.000") + " m^3"; // shows the volume in a label with correct units
                label21.Text = surfacearea.ToString("0.000") + " m^2"; // shows the surface area in a label with correct units
            }
            catch
            {
                MessageBox.Show("You input something in wrong"); // error message for falsely inputted text
            }
        }
    }
}
