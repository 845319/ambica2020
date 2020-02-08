using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Delegates01
{
    public partial class Form1 : Form
    {
        // Declaring a CalcFigure delegate type
        delegate double CalcFigure(double r);

        public Form1()
        {
            InitializeComponent();
        }

        // declaring static methods in a class
        // the circumference
        public static double Get_Length(double r)
        {
            double length;
            length = 2 * 3.1415 * r;
            return length;
        }

        // area of a circle
        public static double Get_Area(double r)
        {
            double area;
            area = 3.1415 * r * r;
            return area;
        }

        // the volume of a sphere
        public static double Get_Volume(double r)
        {
            double volume;
            volume = 3.1415 * r * r * r * 4.0 / 3.0;
            return volume;
        }
    }
}