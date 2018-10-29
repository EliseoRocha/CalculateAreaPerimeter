using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAreaPerimeter
{
    public partial class CalculateAreaAndPerimeter : Form
    {
        public CalculateAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(LengthTextBox.Text);
            double width = Convert.ToDouble(WidthTextBox.Text);
            double area = FindArea(length, width);
            double perimeter = FindPerimeter(length, width);
            AreaTextBox.Text = area.ToString();
            PerimeterTextBox.Text = perimeter.ToString();
        }

        private static double FindPerimeter(double length, double width)
        {
            return 2 * width + 2 * length;
        }

        private static double FindArea(double length, double width)
        {
            return width * length;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            AreaTextBox.Clear();
            PerimeterTextBox.Clear();
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            AreaTextBox.Clear();
            PerimeterTextBox.Clear();
        }
    }
}
