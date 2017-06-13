using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Assignment_JoelleFronzaglio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Assignment section 1 - take the radius of a circle and display the circumference and area
            Console.WriteLine("Enter the radius of a circle");
            int radius = Convert.ToInt32(Console.ReadLine());
      
            double circumference;
            double area;   
            area = 3.14 * Math.Pow(radius, 2);
            circumference = 2 * 3.14 * radius;
            Console.WriteLine("Your circle has a radius of {0}, a circumference of {1}, and an area of {2}\n", radius, circumference, area);
            Console.ReadLine();

            //Assignment section 2 - take the inputs of base & height & return area of a triangle
            Console.WriteLine("Enter the base of a triangle");
            float tribase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of a triangle");
            float height = Convert.ToInt32(Console.ReadLine());

            float triarea = (tribase * height) / 2;
            Console.WriteLine("Your triangle has an area of {0}\n", triarea);

            //Assignment section 3: Write a method to prompt the user for a number then display check if the number is Even or Odd
            Console.WriteLine("Please enter any number:");
            int evenorodd = Convert.ToInt32(Console.ReadLine());

            if (evenorodd % 2 == 0)
            {
                Console.WriteLine("The number is even\n");
            }
            else
            {
                Console.WriteLine("The number is odd\n");
            }

            //Assignment Secion 4: prompt the user for an Integer then display the same value  with one decimal place. eg user enter "15 " result is: "You entered 15, the new value is 15.0".
            Console.WriteLine("Please enter an integer: ");
            string myinteger = Console.ReadLine();
            Console.WriteLine(myinteger + ".0\n");

            // Write a method to prompt the user for a letter of the alphabet and display it's numerical value. 
            Console.WriteLine("Please enter any letter of the alphabet");
            char myletter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII: " + (int) myletter + "\n");

            //Write a method to prompt the user for a double then display the value as a whole number. eg user enter "15 .8" result is:  "You entered 15.8, the new value is 16".eg user enter "15 .4" result is:  "You entered 15.4, the new value is 15".
            Console.WriteLine("Please enter any number exact to the tenth decimal place:");
            decimal mydecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("You entered {0}, your new value is {1}\n", mydecimal, Math.Round(mydecimal));

            //Write a program that displays your name and address on the screen as if it were a letter.
                      
            
            string topbottom = "+-----------------------------------------------------+\n";
            string stamps = "|                                                 ### |\n";
            string name = "|                           Joelle Fronzaglio         |\n";
            string addr1 = "|                           909 Hope Place            |\n";
            string addr2 = "|                           Columbia, MO 65203        |\n";
            string buffer = "|                                                     |\n";

            Console.WriteLine(topbottom + stamps + stamps + stamps + buffer + buffer + name + addr1 + addr2 + buffer + topbottom);
            

            Console.ReadLine();
        }
    }
}