using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
        }
    }

    struct Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public static Complex ToComplex(double x)
        {

        }
        public static Complex operator+(Complex z1, Complex z2)
        {
            return new Complex() { Re = z1.Re + z2.Re, Im = z1.Im + z2.Im };
        }

        public static Complex operator-(Complex z1, Complex z2)
        {
            return new Complex() { Re = z1.Re - z2.Re, Im = z1.Im - z2.Im };
        }

        public static Complex operator*(Complex z1, Complex z2)
        {
            return new Complex() { Re = z1.Re * z2.Re - z1.Im * z2.Im, Im = z1.Re * z2.Im + z2.Re * z1.Im};
        }

        public static Complex operator/(Complex z1, Complex z2)
        {
            if(z2.Re == 0 && z2.Im == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return new Complex()
                {
                    Re = (z1.Re * z2.Re + z1.Im * z2.Im) / (z2.Re * z2.Re + z2.Im * z2.Im),
                    Im = (z2.Re * z1.Im - z1.Re * z2.Im) / (z2.Re * z2.Re + z2.Im * z2.Im),
                };
            }
        }

        public static bool operator==(Complex z1, Complex z2)
        {
            if (z1.Re == z2.Re && z1.Im == z2.Im)
                return true;
            else
                return false;
        }

        public static bool operator!=(Complex z1, Complex z2)
        {
            if (z1.Re != z2.Re || z1.Im != z2.Im)
                return true;
            else
                return false;
        }

        public bool Equals(Complex z)
        {
            if (this.Re == z.Re && this.Im == z.Im)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{this.Re}+i{this.Im}";
        }
    }

    class Frac
    {
        public double Num { get; set; }
        public double Den { get; set; }

        public static Complex operator +(Complex x, Complex z2)
        {
            return new Complex() { Re = z1.Re + z2.Re, Im = z1.Im + z2.Im };
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex() { Re = z1.Re - z2.Re, Im = z1.Im - z2.Im };
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex() { Re = z1.Re * z2.Re - z1.Im * z2.Im, Im = z1.Re * z2.Im + z2.Re * z1.Im };
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            if (z2.Re == 0 && z2.Im == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return new Complex()
                {
                    Re = (z1.Re * z2.Re + z1.Im * z2.Im) / (z2.Re * z2.Re + z2.Im * z2.Im),
                    Im = (z2.Re * z1.Im - z1.Re * z2.Im) / (z2.Re * z2.Re + z2.Im * z2.Im),
                };
            }
        }

        public static bool operator ==(Complex z1, Complex z2)
        {
            if (z1.Re == z2.Re && z1.Im == z2.Im)
                return true;
            else
                return false;
        }

        public static bool operator !=(Complex z1, Complex z2)
        {
            if (z1.Re != z2.Re || z1.Im != z2.Im)
                return true;
            else
                return false;
        }

        public bool Equals(Complex z)
        {
            if (this.Re == z.Re && this.Im == z.Im)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{this.Re}+i{this.Im}";
        }
    }
}
