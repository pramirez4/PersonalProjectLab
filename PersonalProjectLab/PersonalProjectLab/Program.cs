using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool convert = true
                ;
            // Creat loop 
            while (convert)
            {
                // prompt user for tire size old first then new
                string  input;
                int oldTire = 0;
                int newTire = 0;
                int shownSpeed = 0;

                Console.WriteLine("What is the diameter of the original tires?");
                input = Console.ReadLine();
                oldTire = int.Parse(input);

                Console.WriteLine("What is the diameter of the new tires?");
                input = Console.ReadLine();
                newTire = int.Parse(input);
                //add a nested loop to convert another speed with the same tires

                bool sameTire = true;

                while (sameTire)
                {
                 Console.WriteLine("What speed would you like to convert?");
                       input = Console.ReadLine();
                       shownSpeed = int.Parse(input);

                        // call tireclass

                        TireClass real = new TireClass();

                        decimal actualSpeed = real.tireConverion(oldTire, newTire, shownSpeed);

                        Console.WriteLine("Your actual speed is:" + Math.Round(actualSpeed));

                    Console.WriteLine("Would you like to convert another speed? 1 for yes 2 for no");

                    string anotherSpeed = Console.ReadLine();
                    
                    if (anotherSpeed =="2")
                    {
                        sameTire = false;

                    }
                }
               

                //prompt user for speedometer speed
                //print tire sizes and then posted speed and new speed and if it is faster or not
               
                Console.WriteLine("Would you like to convert an other tire size? 1 for yes or 2 for quit");
                string anotherTire = Console.ReadLine();

                if (anotherTire == "2")
                {
                    //No new tires so end the program
                    convert = false;

                }
            }
            Console.WriteLine("Thanks for converting your tire speed with my program!");
        }
    }
}