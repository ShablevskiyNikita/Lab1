using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab1
{
    class MyFrac: IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        private BigInteger nom;
        private BigInteger denom;

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if(denom == 0)
            {
                throw new DivideByZeroException("You can't divide by zero!");
            }

            BigInteger nsd = BigInteger.GreatestCommonDivisor(nom, denom);
            this.nom = nom / nsd;
            this.denom = denom / nsd;

            // convert to the normal format
            if((this.denom < 0 && this.nom > 0) || (this.nom < 0 && this.denom < 0))
            {
                this.nom *= -1;
                this.denom *= -1;
            }

        }

        public MyFrac(int nom, int denom)
        {
            if (denom == 0)
            {
                throw new DivideByZeroException("You can't divide by zero!");
            }

            BigInteger nsd = BigInteger.GreatestCommonDivisor(nom, denom);
            this.nom = nom / nsd;
            this.denom = denom / nsd;

            // convert to the normal format
            if ((this.denom < 0 && this.nom > 0) || (this.nom < 0 && this.denom < 0))
            {
                this.nom *= -1;
                this.denom *= -1;
            }

        }

        public override string ToString()
        {
            return nom + "/" + denom;
        }

        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(nom * that.denom + that.nom * denom, denom * that.denom);
        }

        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(nom * that.denom - that.nom * denom, denom * that.denom);
        }

        public MyFrac Divide(MyFrac that)
        {
            return new MyFrac(nom * that.denom, denom * that.nom);
        }

        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(nom * that.nom , denom * that.denom);
        }

        public int CompareTo(MyFrac that)
        {
            return ((double)nom / (double)denom)
                .CompareTo((double)that.nom / (double)that.denom);
        }
    }
}
