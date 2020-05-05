using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1.GUI
{
    class Rhomb : Figure
    {
        protected int horDiagLen;
        protected int vertDiagLen;
        protected Form1 form1;

        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen, Form1 form1) : base(centerX, centerY)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
            this.form1 = form1;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(this.centerX - horDiagLen/2,  this.centerY),
                new Point(this.centerX, this.centerY - vertDiagLen/2),
                new Point(this.centerX + this.horDiagLen/2,  this.centerY),
                new Point(this.centerX,  this.centerY + this.vertDiagLen/2),
            };
        }

        public override void DrawBlack()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(new Pen(form1.BackColor), GetCurrPoints());
        }
    }
}
