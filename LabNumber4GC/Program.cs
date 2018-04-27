using System;


namespace LabNumber4GC
{
    class Program
    {
        static void Main(string[] args)
        {

            bool UserContinue = true;
            Console.WriteLine("Learn your squares and cubes!\n");
            while (UserContinue == true)

            {
                Console.WriteLine("Enter an integer: ");

                double UserInput = (Double.Parse(Console.ReadLine()));

                double Square = 0;
                double Cube = 0;

                for (double i = 1; i <= UserInput; i++)
                {

                    Square = Math.Pow(i, 2);
                    Cube = Math.Pow(i, 3);

                    Console.WriteLine("\tNumber: " + i + "\tSquared: " + Square + "\tCubed: " + Cube);
                 
                }

                Console.WriteLine("Do you want to continue? y/n");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "no" || choice.ToLower() == "n")
                {
                    UserContinue = false;
                }
            }
        }
    }
}
