using System;

namespace sorttriangle
{
    class Tryangle: IComparable 
    {

        private double a;
        private double b;
        private double c;
  
        public Tryangle(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;

        }

        public Tryangle(double a)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ShowTryangle()
        {

           Console.WriteLine("Строна треугольника" +a +"\t" + b + "\t" + c + "\tплощадь = " + GetSquare());

        }



        public int CompareTo(object obj)
        {
            Tryangle it = (Tryangle)obj;
            if (this.GetSquare() == it.GetSquare()) return 0;
            else if (this.GetSquare() > it.GetSquare()) return 1;
            else return -1;
        }


        public double GetSquare()
        {
            if (TryangleChek(a, b, c))
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));


            }
            else return -1; 



        }

        private static bool TryangleChek(double a, double b, double c) 
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c || a + c > b || b + c > a)
                {
                    return true;
                }
                else return false;
            }
            else return false; 
        }



    }
}
