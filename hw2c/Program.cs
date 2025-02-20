using System;

class Program
{
    static void Main(string
    {
        bool exitProgram = false;

        while (!exitProgram)
        {

            Console.WriteLine("**************");
            Console.WriteLine("* Menu:");
            Console.WriteLine("* 1 - New Game");
            Console.WriteLine("* 2 - Load Game");
            Console.WriteLine("* 3 - Options");
            Console.WriteLine("* 4 - Quit");
            Console.WriteLine("**************");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)

            {
                case "1":
                    NewGame();
                    break;
                case "2":
                    LoadGame();
                    break;
                case "3":
                    Options();
                    break;
                case "4":
                    exitProgram = Quit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();


        }
    }
    static void LoadGame()
    {
        Console.WriteLine("Loading game...");
    }
    static void Options()
    {
        Console.WriteLine("Opening options...");

    }
    static bool Quit()
    {
        Console.WriteLine("Quitting the game...");
        return true;
    }
}

