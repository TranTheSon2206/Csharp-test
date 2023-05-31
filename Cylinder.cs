using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeometricExample
{
    public class Cylinder
    {
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
         
        }

        public double radius { get; set; }
        public double height { get; set; }
        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Area { get; set; }
        public double Volume { get; set; }

        public void Process()
        {
            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + radius + ", Height: " + height+"\n");
            Console.WriteLine("Base: " + BaseArea.ToString("F2") + " | Lateral: " + LateralArea.ToString("F2") + " | Total: " + TotalArea.ToString("F2") + " | Volume: " + Volume.ToString("F2"));
        }


        public class Program
        {
            static void Main(string[] args)
            {
                
                Console.WriteLine("Enter the dimensions of the cylinder\n");
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());

                Cylinder c1 = new Cylinder(radius, height);
                c1.Process();
                c1.Result();


            }
        }

    }
}
