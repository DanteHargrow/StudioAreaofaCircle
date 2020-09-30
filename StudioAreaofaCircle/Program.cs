using System;

namespace StudioAreaofaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle c1 = new Circle(radius);
            double area = c1.getAreaOfCirle();
            double circumference = c1.getCircumference();
            double diameter = c1.getDiameter();
            Console.WriteLine("Enter the miles per gallons for your car");
            c1.setMPG(int.Parse(Console.ReadLine()));
            Console.WriteLine(c1.getMPG());
            double gallons = c1.getGallons();

            Console.WriteLine($"\nArea of circle: {area}, diameter of circle: {diameter}, circumference of circle: {circumference}\n");
            Console.WriteLine($"You'll use {gallons} gallons to cover {circumference} miles");
        }
    }
}
