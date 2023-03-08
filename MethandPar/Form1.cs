using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethandPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int length = 0;
        int width = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            length = int.Parse(txtLength.Text);
            width = int.Parse(txtWidth.Text);

            // Calculate the perimeter of the rectangle
            int perimeter = 2 * (length + width);

            // Display the perimeter in the label
            lblPerimeter.Text = "Perimeter: " + perimeter.ToString();


            double area = length * width;
            lblArea.Text = "The area of the rectangle is " + area.ToString();

        }
        public int CalculatePerimeter(int width, int length)
        {
            return (width + length) + 2;

        }
        public int CalculateArea(int width, int length)
        {
            return (width + length) + 2;

        }
    }
}
