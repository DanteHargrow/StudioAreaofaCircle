using System;

namespace StudioAreaofaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius;
            double areaOfCirle;
            double circumference;
            double diameter;
            radius = double.Parse(Console.ReadLine());
            areaOfCirle = Math.PI*radius*radius;
            diameter = 2 * radius;
            circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Area of circle: {areaOfCirle}, diameter of circle: {diameter}, circumference of circle: {circumference}");
        }
    }
}
