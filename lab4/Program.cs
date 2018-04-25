using System;

namespace lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!\n");

            // using while loop instead of jump statements (Start:, goto Start;, etc.)

            bool keepitmovin = true;

            while (keepitmovin)
            {
                Console.Write("Enter an integer: ");
                string userinput = Console.ReadLine();
                int num;
                bool isvalidnumber = int.TryParse(userinput, out num);

                if (isvalidnumber)
                {
                    Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                    Console.WriteLine("======\t\t======\t\t=======");
                    for (int i = 1; i <= num; i++)
                    {
                        Console.WriteLine(i + "\t\t" + (i * i) + "\t\t" + (i * i * i));

                    }

                }
                else
                {
                    Console.WriteLine($"\n{userinput} is not a valid integer (whole number), try again.\n");
                    continue;
                }

                bool goagain = true;
                while (goagain)
                {
                    Console.Write("\nContinue? (y/n):  ");
                    string goresponse = Console.ReadLine();
                    goresponse = goresponse.ToLower();


                    if (goresponse == "y")
                    {
                        Console.WriteLine("");
                        goagain = false;

                    }
                    else if (goresponse == "n")
                    {
                        Console.WriteLine("\nBye!");
                        goagain = false;
                        keepitmovin = false;
                    }
                    else
                    {
                        Console.WriteLine("\nYou did not enter y or n, please enter y to continue or n to quit.");
                        continue;
                    }

                }
            }
        }
    }
}
