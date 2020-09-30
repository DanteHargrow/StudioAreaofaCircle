using System;
using System.Collections.Generic;
using System.Text;

namespace StudioAreaofaCircle
{
    class Circle
    {
        double radius;
        double areaOfCircle;
        double circumference;
        double diameter;
        int milesPerGal;
        double gallons;
        
       public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getAreaOfCirle()
        {
            this.areaOfCircle = Math.PI * this.radius * this.radius;
            return this.areaOfCircle;
        }
        public double getCircumference()
        {
            this.circumference = 2 * Math.PI * radius;
            return this.circumference;
        }
        public double getDiameter()
        {
            this.diameter = 2 * radius;
            return this.diameter;
        }
        public void setMPG(int MPG)
        {
            this.milesPerGal = MPG;
        }
        public int getMPG()
        {
            return this.milesPerGal;
        }
        public double getGallons()
        {
            this.gallons = this.circumference / this.milesPerGal;
            return this.gallons;
        }
    }
}
