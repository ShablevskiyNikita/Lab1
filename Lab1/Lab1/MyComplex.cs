using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MyComplex : IMyNumber<MyComplex>
    {
        private double re;
        private double im;

        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public override string ToString()
        {
            return im > 0 
                ? re + "+" + " " + im + "i"
                : re * (-1) + "-" + im * (-1) + "i";
        }

        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(re + that.re, im + that.im);
        }

        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(re - that.re, im - that.im);
        }

        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(re * that.re - im * that.im, re * that.im + im * that.re);
        }

        public MyComplex Divide(MyComplex that)
        {
            if (that.re * that.re + that.im * that.im == 0)
            {
                throw new DivideByZeroException("You can't divide by zero");
            }
            return new MyComplex((re * that.re + im * that.im) / (that.re * that.re + that.im * that.im),
                (im * that.re - re * that.im) / (that.re * that.re + that.im * that.im));
        }
    }
}
