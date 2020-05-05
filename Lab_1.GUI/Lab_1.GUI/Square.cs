using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1.GUI
{
    class Square : Figure
    {
        protected int sideLength;
        protected Form1 form1;

        public Square(int centerX, int centerY, int sideLength, Form1 form1) : base(centerX, centerY)
        {
            this.sideLength = sideLength;
            this.form1 = form1;
        }

        public override void DrawBlack()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawRectangle(Pens.Black, this.centerX - this.sideLength/2, this.centerY - this.sideLength / 2, this.sideLength, this.sideLength);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawRectangle(new Pen(form1.BackColor), this.centerX - this.sideLength / 2, this.centerY - this.sideLength / 2, this.sideLength, this.sideLength);
        }
    }
}
