


using sorttriangle;
using SortTriangle;
using System;

class Programm
{

    static void Main(string[] args)
    {

        Class1 Class1 = new Class1();
        Class1.AddTryangle(new Tryangle(3,2.4, 1));
        Class1.AddTryangle(new Tryangle(8, 2.4, 6));
        Class1.AddTryangle(new Tryangle(3, 1.9, 1));
        Class1.AddTryangle(new Tryangle(2, 5, 1));
        Class1.AddTryangle(new Tryangle(2, 5, 1));
        Class1.Sort();
        Class1.Show();
        Console.ReadLine();


    }

}






















//using SortTriangle;
//using System;



//class Program
//{
//   static void Main(string[] args)
//    {

//        double a, b, c;
        


//        Console.WriteLine("сколько площадей треугольников заполнять в массив?");
       
//           int  d = int.Parse(Console.ReadLine());
//        for (int i = 0; i < d; i++)
//        {
//            Console.WriteLine("введи значение сторон треугольника");
//            a = double.Parse(Console.ReadLine());
//            b = double.Parse(Console.ReadLine());
//            c = double.Parse(Console.ReadLine());
            
//            if (a + b > c && a + c > b && b + c > a)
//            {
//              double [] TriArr = new double[d];

//                Tryangle Tri = new Tryangle(a,b,c);
//                TriArr[i] = Tri.ShowTryangle();
//                Tri.ShowTryangle();


//            }
//            else Console.WriteLine("треугольник не существует");

            
//        }
        
       





//    }

//}