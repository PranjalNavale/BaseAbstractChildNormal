using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseChild
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Circle cr = new Circle();
            cr.calculatearea();
            cr.calculateperimeter();
            cr.calclateVolume();
            Area arcr = new Circle();
            arcr.calculatearea();
            arcr.calculateperimeter();
            arcr.calclateVolume();

        }

        public abstract class Area
        {

            public abstract void calculatearea();
           
            public void calclateVolume()
            {
                Console.WriteLine("abstract class volume");
            }
            public void calculateperimeter()
            {
                Console.WriteLine("abstract class perimeter");
            }
        }

        public class Circle : Area
        {

            public override void calculatearea()
            {

                Console.WriteLine("child class area");
            }

            public new void calculateperimeter()
            {
                Console.WriteLine("child class perimeter");
            }
        }
    }
}
