using System;
using System.Collections;
using System.Collections.Generic;

namespace ООП6
{
    class Program
    {
        abstract class CGraphicsObject
        {
            public static double x, a, b;
        }
        class Circle : CGraphicsObject
        {
            interface ICircle 
            {
                void Per();
            }
            class Circle1
            {
                public double P(double x) { return 2*Math.PI*x; }  
                ICircle сircle; 
                public Circle1(ICircle cir)
                {
                    сircle = cir;
                }
                public void Start()
                {
                    сircle.Per();
                }
            }
            class length: ICircle
            {
                public void Per()
                {

                    Console.WriteLine("Введите радиус окружности : ");
                    CGraphicsObject.x = Convert.ToInt32(Console.ReadLine());
                }
            }
            class Ellipse : CGraphicsObject
            {
                interface IEllipse
                {
                    void Per();
                }
                class Ellipse1
                {
                    public double P1(double a, double b) { return Math.PI * a*b; }
                    IEllipse ellipse;
                    public Ellipse1(IEllipse ell)
                    {
                        ellipse = ell; 
                    }
                    public void Start()
                    {
                        ellipse.Per();
                    }
                }
                class area : IEllipse
                {
                    public void Per()
                    {

                        Console.WriteLine("Введите длину большой полуоси: ");
                        CGraphicsObject.a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите длину малой полуоси: ");
                        CGraphicsObject.b = Convert.ToInt32(Console.ReadLine());
                    }
                }

                delegate double Operation(double x);
                delegate double Operation2(double a, double b);

                static void Main(string[] args)
                {
                    Circle1 per = new Circle1(new length());
                    per.Start();
                    Operation operation1 = per.P;
                    double result = Convert.ToInt32(operation1(CGraphicsObject.x));
                    Console.WriteLine("Длина окужности:");
                    Console.WriteLine(result);
                    Ellipse1 per1 = new Ellipse1(new area());
                    per1.Start();
                    Operation2 operation2 = per1.P1;
                    double result2 = operation2(CGraphicsObject.a, CGraphicsObject.b);
                    Console.WriteLine("Площядь элипса:");
                    Console.WriteLine(result2);
                    Console.Read();
                    ArrayList numbersList = new ArrayList() { CGraphicsObject.x, CGraphicsObject.a, CGraphicsObject.b};
                    object obj = 10;
                    numbersList.Add(obj);
                    numbersList.RemoveAt(3);
                    Console.WriteLine("Коллекция  радиуса и длин большого и малого элипса: ");
                    foreach (object o in numbersList)
                    {
                        Console.Write(o + " ");
                    }
                }
            }
        }
    }
}
