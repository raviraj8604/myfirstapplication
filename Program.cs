using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This In My First App");
            int G;

            // Pass variable G to the method
            // using out keyword
            Sum(out G);

            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);
            Console.ReadLine();
        }



        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }



        static void SetValue(ref string str1)
        {

            // Check parameter value
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }

            // Assign the new value
            // of the parameter
            str1 = "GeeksforGeeks";
        }
    }
    class Program1
    {
        //public void Main()
        //{
        //    Console.WriteLine("This In My First App");
        //    Console.ReadLine();
        //}



    }
}
