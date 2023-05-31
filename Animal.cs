using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeometricExample
{
   public class Animal{
        public string name {get;set;}
        public int weight { get;set;}

        public void SetMe(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: "+name+", Weight: "+weight);
        }

    }
    public class Lion : Animal
    {
        public Lion(string name, int weight)
        {
            SetMe(name, weight);
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }
    }

    public class Tiger : Animal
    {
        public Tiger(string name, int weight)
        {
            SetMe(name, weight);
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion("lion",100);
            Tiger tiger1 = new Tiger("tiger", 200);
            lion1.Show();
            tiger1.Show();
        }
    }

}
