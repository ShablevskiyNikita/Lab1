using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1.GUI
{
    class Circle : Figure
    {
        protected int radius;
        protected Form1 form1;

        public Circle(int centerX, int centerY, int radius, Form1 form1) : base(centerX, centerY)
        {
            this.radius = radius;
            this.form1 = form1;
        }

        public override void DrawBlack()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, this.centerX - this.radius, this.centerY - this.radius, this.radius * 2, this.radius * 2);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawEllipse(new Pen(form1.BackColor), this.centerX - this.radius, this.centerY - this.radius, this.radius * 2, this.radius * 2);
        }
    }
}
