using System;

namespace ААВААА
{
    public interface IArOperation
    {
        double Del();
        double Otr();
        double Prz();
        double Sum();
    }   

        public interface ISqrSqrt
    {
        double Sqr();
        double Sqrt();
    }

    class A : IArOperation
    {
        double My_x, My_y;

        public double x
        {
            set { My_x = value; }
            get { return My_x; }
        }

        public double y
        {
            set { My_y = value; }
            get { return My_y; }
        }

        public A() { }
        public A(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Sum()
        {
            return x + y;
        }

        public virtual double Otr()
        {
            return x - y;
        }

        public virtual double Prz()
        {
            return x * y;
        }

        public virtual double Del()
        {
            return x / y;
        }

        public virtual void rewrite()
        {
            Console.WriteLine($"Переменная x = {x} \nПеременная y = {y}");
        }
    }

    class Aa : A
    {
        public double z;

        public Aa(double z, double x, double y)
            : base(x, y)
        {
            this.z = z;
        }

        public override double Sum()
        {
            return base.x + base.y + z;
        }

        public override void rewrite()
        {
            base.rewrite();
            Console.WriteLine($"Переменная z = {z}"); 
        }
    }

    class Ab : A
    {
        public Ab(double x, double y)
            : base(x, y) { }
        public double Sqr()
        {
            return base.x * base.x;
        }

        public double Sqrt()
        {
            return Math.Sqrt(base.x);
        }
    }

    class Program
    {
        static void Main()
        {
            A a1 = new A(15, 5);
            Console.WriteLine("A \n ");
            a1.rewrite();
            Console.WriteLine("{0} + {1} = {2}", a1.x, a1.y, a1.Sum());
            Console.WriteLine("{0} - {1} = {2}", a1.x, a1.y, a1.Otr());
            Console.WriteLine("{0} * {1} = {2}", a1.x, a1.y, a1.Prz());
            Console.WriteLine("{0} / {1} = {2}", a1.x, a1.y, a1.Del());

            Aa aa1 = new Aa(7, 14, 21);
            Console.WriteLine("\nAA1 \n ");
            aa1.rewrite();
            Console.WriteLine("{0} + {1} + {2} = {3}", aa1.x, aa1.y, aa1.z, aa1.Sum());
            Console.WriteLine("{0} / {1} = {2}", aa1.x, aa1.y, aa1.Del());

            Ab ab1 = new Ab(25, 5);
            Console.WriteLine("\nAB1 \n ");
            ab1.rewrite();
            Console.WriteLine("{0} + {1} = {2}", ab1.x, ab1.y, ab1.Sum());
            Console.WriteLine("{0} - {1} = {2}", ab1.x, ab1.y, ab1.Otr());
            Console.WriteLine("{0} * {1} = {2}", ab1.x, ab1.y, ab1.Prz());
            Console.WriteLine("{0} / {1} = {2} \n", ab1.x, ab1.y, ab1.Del()); 
            Console.WriteLine(" х = {0} \n х в квадрате = {1}", ab1.x,  ab1.Sqr());
            Console.WriteLine(" х = {0} \n квадратный корень из х = {1}", ab1.x, ab1.Sqrt());

            Console.ReadLine();
        }
    }
}