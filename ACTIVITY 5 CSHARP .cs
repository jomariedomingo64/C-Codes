using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n[ Mathematical Formula Menu ]");
            Console.WriteLine("A. Area");
            Console.WriteLine("P. Perimeter");
            Console.WriteLine("V. Volume");
            Console.WriteLine("X. eXit");

            Console.Write("Enter your choice: ");
            string mainChoice = Console.ReadLine().Trim().ToUpper();  // Fixed Input Handling

            switch (mainChoice)
            {
                case "A":
                    AreaMenu();
                    break;
                case "P":
                    PerimeterMenu();
                    break;
                case "V":
                    VolumeMenu();
                    break;
                case "X":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AreaMenu()
    {
        while (true)
        {
            Console.WriteLine("\n[ Area Menu ]");
            Console.WriteLine("C. Circle");
            Console.WriteLine("R. Rectangle");
            Console.WriteLine("S. Square");
            Console.WriteLine("T. Triangle");
            Console.WriteLine("X. eXit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine().Trim().ToUpper();  // Fixed Input Handling

            switch (choice)
            {
                case "C":
                    Console.WriteLine("Area of Circle");
                    break;
                case "R":
                    Console.WriteLine("Area of Rectangle");
                    break;
                case "S":
                    Console.WriteLine("Area of Square");
                    break;
                case "T":
                    Console.WriteLine("Area of Triangle");
                    break;
                case "X":
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void PerimeterMenu()
    {
        while (true)
        {
            Console.WriteLine("\n[ Perimeter Menu ]");
            Console.WriteLine("C. Circle");
            Console.WriteLine("R. Rectangle");
            Console.WriteLine("S. Square");
            Console.WriteLine("T. Triangle");
            Console.WriteLine("X. eXit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine().Trim().ToUpper();  // Fixed Input Handling

            switch (choice)
            {
                case "C":
                    Console.WriteLine("Perimeter of Circle");
                    break;
                case "R":
                    Console.WriteLine("Perimeter of Rectangle");
                    break;
                case "S":
                    Console.WriteLine("Perimeter of Square");
                    break;
                case "T":
                    Console.WriteLine("Perimeter of Triangle");
                    break;
                case "X":
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void VolumeMenu()
    {
        while (true)
        {
            Console.WriteLine("\n[ Volume Menu ]");
            Console.WriteLine("C. Cone");
            Console.WriteLine("S. Sphere");
            Console.WriteLine("U. cUbe");
            Console.WriteLine("Y. cYlinder");
            Console.WriteLine("X. eXit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine().Trim().ToUpper();  // Fixed Input Handling

            switch (choice)
            {
                case "C":
                    Console.WriteLine("Volume of Cone");
                    break;
                case "S":
                    Console.WriteLine("Volume of Sphere");
                    break;
                case "U":
                    Console.WriteLine("Volume of Cube");
                    break;
                case "Y":
                    Console.WriteLine("Volume of Cylinder");
                    break;
                case "X":
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}