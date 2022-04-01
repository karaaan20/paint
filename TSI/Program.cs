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
            //Introduction to this application.

            Console.WriteLine("Hi, hope you're well! Would you like to use this paint calculator?");
            string ans = Console.ReadLine();
            ans.ToLower();
            if (ans == "yes")

                //The formula below will output the area of the wall

                Console.WriteLine("Please write the length of the wall:");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Please write the width of the wall");
            float width = float.Parse(Console.ReadLine());
            float area = length * width;
            Console.WriteLine("The area of your wall is:" + area + "m^2 ");

            //One 10l tub of paint will cover approx 120m^2 
            //Therefore, divide the area of the wall by 120m^2 to get the number of tubs needed. 

            float divide = area / 120;
            Console.WriteLine(divide);
            double i = Math.Ceiling(divide);
            Console.WriteLine("Exact number of paint tubs required={0}", divide);
            Console.WriteLine("However, the number of paint tubs required to purchase are = {0}", i);

            // Dependent upon the number of coats needed on the wall, the number of tubs may differ. 

            Console.WriteLine("Please state the number of coats needed on this particular wall:");
            int coats = int.Parse(Console.ReadLine());
            Console.WriteLine(coats * divide);
            double c = Math.Ceiling(coats * divide);
            Console.WriteLine("Hence, for " + coats + " number of coats, the number of paint tubs required would be " + c + "");

            double AAA = area;





            Console.WriteLine("Does this particular wall have an arc?");
            string ANS = Console.ReadLine();
            ANS.ToLower();
            if (ANS == "yes")
            { 

                Console.WriteLine("Please state the radius of the semi-circle:");
                double radius = double.Parse(Console.ReadLine());
                double Area = Math.PI * radius * radius * 0.5;
                Console.WriteLine("Area of semi-circle:" + Area);
                double AAAA = Area + AAA;
                double Divide = AAAA / 120;
                Console.WriteLine(Divide);
                double II = Math.Ceiling(Divide);
                Console.WriteLine("Exact number of paint tubs required for the semi-circle wall ={0})", Divide);
                Console.WriteLine("However, the number of paint tubs needed for your number of coats are ={0}", II*coats);

            }

            Console.WriteLine("Please state the estimated number of hours required to paint this wall");
            float WW = float.Parse(Console.ReadLine());
            float HH = WW / 8;
            if (HH <= 1)
            {
                Console.WriteLine("Complete the Paint Job today");
            }
            else if (HH <= 2)
            { Console.WriteLine("Complete the Paint Job over the course of two days"); }
            else if (HH <= 3)
            { Console.WriteLine("Complete the Paint Job over the course of three days"); }
            else if (HH > 3)
            { Console.WriteLine("This paint job requires atleast a week"); }

            bool validchoice;
            int priceofpaint;

            do
            {
                validchoice = false;

                string[] paintcolours = { "white", "black", "blue", "red", "grey", "yellow" };
                foreach (string s in paintcolours)
                { Console.WriteLine(s.ToUpper()); }

                Console.WriteLine("Please select a colour from the list");
                string userselection = Console.ReadLine();


                if (userselection.ToLower() == "white")
                {
                    validchoice = true;
                    priceofpaint = 10;
                    Console.WriteLine("The price of white paint is £10");
                    double TC = (priceofpaint * c);
                    Console.WriteLine("Given this particular colour type and the number of paint tubs required, the total cost of this would be £" + TC + "");
                }
                else if (userselection.ToLower() == "black")
                {
                    validchoice = true;
                    priceofpaint = 11;
                    Console.WriteLine("The price of black paint is £10.99");
                    double TC = (priceofpaint * c);
                    Console.WriteLine("Given this particular colour type and the number of paint tubs required, the total cost of this would be £" + TC + "");
                }
                else if (userselection.ToLower() == "blue")
                {
                    validchoice = true;
                    priceofpaint = 15;
                    Console.WriteLine("The price of blue paint is £15.99");
                    double TC = (priceofpaint * c);
                    Console.WriteLine("Given this particular colour type and the number of paint tubs required, the total cost of this would be £" + TC + "");
                }
                else if (userselection.ToLower() == "red")
                {
                    validchoice = true;

                    priceofpaint = 16;
                    Console.WriteLine("The price of red paint is £16");
                    double TC = (priceofpaint * c);
                    Console.WriteLine("Given this particular colour type and the number of paint tubs required, the total cost of this would be £" + TC + "");
                }
                else if (userselection.ToLower() == "grey")
                {
                    validchoice = true;
                    priceofpaint = 17;
                    Console.WriteLine("The price of grey paint is £17)");
                    double TC = (priceofpaint * c);
                    Console.WriteLine("Given this particular colour type and the number of paint tubs required, the total cost of this would be £" + TC + "");
                }
                else if (userselection.ToLower() == "yellow")
                {
                    validchoice = true;
                    priceofpaint = 18;
                    Console.WriteLine("The price of yellow paint is £18");
                    double TC = (priceofpaint * c);
                    Console.WriteLine("Given this particular colour type and the number of paint tubs required, the total cost of this would be £" + TC + "");
                }
                else
                {
                    Console.WriteLine("You did not make the correct choice, try again");
                    priceofpaint = 0;
                }
                int PP = priceofpaint;
            }
            while (validchoice == false);
        

                    Console.WriteLine("Please state whether the wall have any windows or doors?");
                    string Ans = Console.ReadLine();
                    Ans.ToLower();
                    if (Ans == "yes")

                        Console.WriteLine("Please state the length of the window/door");
                    double length1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please state the width of the window/door");
                    double width1 = double.Parse(Console.ReadLine());

                    double area1 = length1 * width1;
                    Console.WriteLine("The area of your window/door is " + area1 + " m^2");

                    double TA1 = area - area1;

                    Console.WriteLine("As a result, the area which needs to be painted is " + TA1 + "m^2");

                    double COST2 = TA1 / 120;
                    double I = Math.Ceiling(COST2);

                    Console.WriteLine("The total number of paint tubs needed to purchase would be " + I + "");
                    double CC = (I * priceofpaint);


                    Console.WriteLine("Hence, for your choice of colour and type of wall, the cost of this paint job would be £" + CC + "");        

                int day = 4;


                switch (day)
            { 
               
                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturday");
                        break;

                    case 7:
                        Console.WriteLine("Sunday");
                    break;
                        
                            double operation;
                            double first, second, result;

                            Console.WriteLine("Enter your first number: ");
                            first = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter your second number: ");
                            second = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Please select what operation you would like to use (+, -, *, /): ");
                            operation = (double)Console.Read();

                            switch (operation)
                            {
                                case '+':
                                    result = first + second;
                                    Console.WriteLine(first + second);
                                    break;

                                case '-':
                                    result = first - second;
                                    Console.WriteLine(first - second);
                                    break;

                                case '*':
                                    result = first * second;
                                    Console.WriteLine(first * second);
                                    break;

                                case '/':
                                    result = first / second;
                                    Console.WriteLine(first / second);
                                    break;

                            }
                        }
                }
            }
        }
    

