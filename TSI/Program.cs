using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The formula below will output the area of the wall
            Console.WriteLine("Please write the length of the wall:");
            float length= float.Parse(Console.ReadLine());
            Console.WriteLine("Please write the width of the wall");
            float width= float.Parse(Console.ReadLine());

            float area = length * width;
            Console.WriteLine("The area of your wall is:"+area+"m^2 ");
            //one 10l tub of paint will cover approx 120m^2 
            //Therefore, divide the area of the wall by 120m^2 to get the number of tubs needed. 
            float divide = area / 120;
            Console.WriteLine(divide);
            double i = Math.Ceiling(divide);
            Console.WriteLine("Exact number of paint tubs required={0}", divide);
            Console.WriteLine("However, the number of paint tubs required to purchase are = {0}", i);

            // Dependent upon the number of coats needed on the wall, the number of tubs may differ. 
            Console.WriteLine("Please state the number of coats needed on this particular wall:");
            int coats= int.Parse(Console.ReadLine());
            Console.WriteLine(coats * divide);
            double c = Math.Ceiling(coats * divide);
            Console.WriteLine("Hence, for " + coats + " number of coats, the number of paint tubs required would be " + c + "");

            // To find the cost of this job would be the number of paint tubs multipied by the cost of one tub of paint
            int cost = 10;
            Console.WriteLine(cost * c);
            Console.WriteLine("the cost of this paint job is " + cost * c + "");
               



            

            
            
           
            
           










        }
    }
}
