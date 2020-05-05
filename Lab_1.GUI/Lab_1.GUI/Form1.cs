using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(150, 150, 100, this);
            circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square(150, 150, 200, this);
            square.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rhomb rhomb = new Rhomb(150, 150, 100, 150, this);
            rhomb.MoveRight();
        }
    }
}
