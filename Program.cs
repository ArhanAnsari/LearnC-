using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
     class Program
    {
        static void Main(string[] args)
        {
            //Comments

            // This is important for debugging. Do not remove

            // This is Single Line Comment

            /*
             * Multi
             * Lint
             * Comment
             */

            /*
             Another Way 
            To write Multi
            Line Comment
             */

            //Variables
            //int arhan = 34; //Integer Variable

            /*Data Types in C#:
             Integer - int arhan; --> 4 bytes
             Long - long arhan; --> 8 bytes
             Floating point number - float that; --> 4 bytes
             Double - double arhan; --> 8 bytes
             Character - char a = 'A --> 2 bytes
             Boolean - bool isGreat = true; --> 1 bit //Value can be true or false
             String - string imp = "Arhan --> 2 bytes per character
             */
            //Taking input from user

            //string imp = Console.ReadLine();
            //Console.WriteLine(imp);

            //Printing to Console Functions - Write() and WriteLine()

            /*Console.WriteLine("Hello World");
            Console.WriteLine("Hello Arhan");
            Console.Write("Written using write() function");
            Console.WriteLine("I love C# and the number is " + arhan);*/

            //Examples of Datatypes

            //int a = 58;
            //float b = 56.36F; //By default floating point number is double.To make it float you have to write the suffix 'f'.
            //double c = 963.256D; //Not compulsory to have the suffix 'F' and also you can write suffix 'D'
            //bool isGreat = true;
            //char d = 'r';

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(d);

            //Typecasting

            /*
             There are two types of casting:

             1. Implicit Casting (Automatic Casting)
                char -> int -> long -> float -> double
             2. Explicit Casting (Manual Casting)
                double -> float -> long -> int -> char
             */
            //int x = (int) 3.5; // Manual casting
            //double x1 = (double)3.5;
            //Console.WriteLine(x1);

            //int x = 3;
            //double y = x;
            //int z = 'y';
            //float z1 = 'y';

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z); // Give ASCII value
            //Console.WriteLine(z1); // Give ASCII value

            //Typecasting using methods

            //These methods are:

            /*
             Convert.ToString()
             Convert.ToDouble()
             Convert.ToBoolean()
             Convert.ToInt32() --> Int
             Convert.ToInt64() --> Long
             */

            //float var = Convert.ToInt64(3.55);
            //string ax = "Random String";

            //Taking user input

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey, hello "+ name);

            //Console.WriteLine("Enter the number of candies you want:");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies");
            //Console.WriteLine("Now you have " + 
            //    (Convert.ToInt32(can) + 4));

            //Operators

            /*
             There are 4 types of operators
            1. Arithmetic Operators
            2. Assignment Operators
            3. Logical Operators
            4. Comparison Operators
            */

            // 1. Arithmetic Operators

            // int a = 4;
            // int b = 2;
            // Console.WriteLine("The value of a + b is: " + (a + b));
            // Console.WriteLine("The value of a - b is: " + (a - b));
            // Console.WriteLine("The value of a * b is: " + (a * b));
            // Console.WriteLine("The value of a / b is: " + (a / b));

            // 2. Assignment Operator

            //int a = 4;
            //int b = a;
            //Console.WriteLine(b);
            //b += 4;
            //Console.WriteLine(b);
            //b -= 4;
            //Console.WriteLine(b);
            //b *= 4;
            //Console.WriteLine(b);
            //b /= 4;
            //Console.WriteLine(b);

            // 3. Logical Operators
            //Console.WriteLine(true && false); // ---> False
            //Console.WriteLine(false && false); // ---> False
            //Console.WriteLine(true && true); // ---> True   

            //Console.WriteLine(true || false); // ---> False
            //Console.WriteLine(false || false); // ---> False
            //Console.WriteLine(true || true); // ---> True

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            // 4. Comparison Operators

            //Console.WriteLine(324 < 555);
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(324 == 555);
            //Console.WriteLine(5 == 5);

            //Math Class in C#
            // int a = Math.Max(34, 345); // => Gives Maximum Value
            // Console.WriteLine(a);
            // int b = Math.Min(34, 345); // => Gives Minimum Value
            // Console.WriteLine(b);
            // double d = Math.Sqrt(36); // => Gives Square Root of 36
            // Console.WriteLine(d);
            // int e = Math.Abs(-39); // => Gives Abdolute Value of Integer
            // Console.WriteLine(e);

             // //Strings Methods
             // string hello = "Hello World this is arhan";
             // Console.WriteLine(hello.length); // => Gives Length of String
             // Console.WriteLine(hello.ToUpper()); // => Gives String in Upper Case
             // Console.WriteLine(hello.ToLower()); // => Gives String in Lower Case
             // Console.WriteLine(hello + " You are nice"); // => Concatenates the string
             // Console.WriteLine(string.Concat(hello," You are nice")); // => Another way to caoncatenate the string
             
             string name = Console.ReadLine();
             string candies = Console.ReadLine();
             Console.WriteLine($"Your name is {name}. You will get {candies} candies");


            Console.ReadLine(); // => used to hold console so that we will able to read the output

        }
    }
}
