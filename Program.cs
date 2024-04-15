using System;

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

            //Typecasting
            int a = 58;
            float b = 56.36F; //By default floating point number is double.To make it float you have to write the suffix 'f'.
            double c = 963.256D; //Not compulsory to have the suffix 'F' and also you can write suffix 'D'
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine(); // => used to hold console so that we will able to read the output

        }
    }
}
