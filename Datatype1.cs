using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AreaOfSquare
    {
        private double side;


        public void Acceptdetails()
        {
            Console.WriteLine("Enter the side:");
            side = Convert.ToDouble(Console.ReadLine());

        }
        public double GetArea()
        {
            return side * side;
        }
        public void Display()
        {
            Console.WriteLine(side);
            Console.WriteLine(GetArea());
        }
    

    public static void Main(String[] args)
        {
            AreaOfSquare area = new AreaOfSquare();
            area.Acceptdetails();
            area.Display();
            Console.ReadLine();
        }
    }
}

    









