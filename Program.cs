
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {

        //static void Greet() //Method Prototype
        //{
        //    {
        //        Console.WriteLine("Good Morning"); //Method Defination
        //    }
        //}

        //static void Greet(string name)
        //{
        //    Console.WriteLine("Good Morning " + name);
        //}

        //static float Average(int a, int b, int c)
        //{
        //    float sum = a + b + c;
        //    return sum / 3;
        //}

        //Method Overloading
        //static float Average(int a, int b)
        //{
        //    return (a + b) / 2;
        //}


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
            // int e = Math.Abs(-39); // => Gives Abdsolute Value of Integer
            // Console.WriteLine(e);

            // //Strings Methods
            // string hello = "Hello World this is arhan";
            // Console.WriteLine(hello.length); // => Gives Length of String
            // Console.WriteLine(hello.ToUpper()); // => Gives String in Upper Case
            // Console.WriteLine(hello.ToLower()); // => Gives String in Lower Case
            // Console.WriteLine(hello + " You are nice"); // => Concatenates the string
            // Console.WriteLine(string.Concat(hello," You are nice")); // => Another way to caoncatenate the string

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies");

            // string hello = "Hello World this is arhan";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(1));

            //Escape sequence Characters
            //string hello = "Hello World this is \"arhan\"";
            //Console.WriteLine(hello);
            //string hello1 = "Hello World\nthis is arhan";
            //Console.WriteLine(hello1);
            //string hello2 = "Hello World\t this is arhan";
            //Console.WriteLine(hello2);

            //Conditional Statements
            //If-Else If-Else
            //Console.WriteLine("Please enter your age");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;
            // if (age < 2)
            // {
            //     Console.WriteLine("You are just born");
            // }
            //else if (age < 10)
            // {
            //     Console.WriteLine("Please finish your high school");
            // }
            // else if (age < 18)
            // {
            //     Console.WriteLine("You are below 18 years");
            // }
            // else if (age < 75)
            // {
            //     Console.WriteLine("You can drive");
            // }
            // else{
            //     Console.WriteLine("You cannot drive");
            // }

            //Switch Case
            /*int age = 78; //Try changing age for the case given below to see the output
            switch (age)
            {
                case 18:
                    Console.WriteLine("Please wait for a year");
                    break;

                case 20:
                    Console.WriteLine("You are 20");
                    break;

                default:
                    Console.WriteLine("Enjoy!");
                    break;
            }*/

            //Loops
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //Better Alternative - Loops
            //While Loop
            //Program to write numbers from 1 to 5 using while loop
            //int i = 0
            //while(i < 5)
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}

            //do-while loop

            //int i = 0;
            //do{
            //    Console.WriteLine(i);
            //    i++;
            //}while(i < 5);

            //for loop
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(j);
            //}

            //Break and Continue
            //for (int j = 0; j < 5; j++)
            //{
            //    if (j == 0)
            //    {
            //    continue;   
            //    }
            //    Console.WriteLine(j);
            //    //break;
            //}
            /*
             Break - Leave this loop forever
             Continue - Leave this particular iteration of the loop
             */

            //Methods
            //Greet(); // => Method Call
            //Greet("Arhan"); // => Passing Argument

            //Console.WriteLine(Average(2,6,8));
            //float temp = Average(9,3,0);
            //Console.WriteLine(temp);
            //Console.WriteLine(Average(3,3,3));

            //Method Overloading
            //Console.WriteLine(Average(3,3));

            //Object Oriented Programming in C#
            Player tommy = new Player();
            Console.WriteLine(tommy.name);
            Console.WriteLine(tommy.health);
            tommy.SetHealth(57);
            Console.WriteLine(tommy.health);
            Console.WriteLine(tommy.GetHealth());
            //Console.WriteLine(tommy.h);

            Console.ReadLine(); // => used to hold console so that we will able to read the output

        }
    }
}
x
