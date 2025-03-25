using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\nMathematical Formula Menu");
            Console.WriteLine("A. Area");
            Console.WriteLine("P. Perimeter");
            Console.WriteLine("V. Volume");
            Console.WriteLine("X. eXit");
            Console.Write("Select A, P, V, or X: ");
            char menu = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (menu)
            {
                case 'A':
                    AreaMenu();
                    break;
                case 'P':
                    PerimeterMenu();
                    break;
                case 'V':
                    VolumeMenu();
                    break;
                case 'X':
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    public static void AreaMenu()
    {
        bool inAreaMenu = true;
        
        while (inAreaMenu)
        {
            Console.WriteLine("\nArea Menu");
            Console.WriteLine("C. Circle");
            Console.WriteLine("R. Rectangle");
            Console.WriteLine("S. Square");
            Console.WriteLine("T. Triangle");
            Console.WriteLine("X. eXit");
            Console.Write("Select C, R, S, T, or X: ");
            char areaMenu = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (areaMenu)
            {
                case 'C':
                    Console.Write("Input radius: ");
                    double r = double.Parse(Console.ReadLine());
                    double area = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"Area of Circle: {area:F2}");
                    break;
                case 'R':
                    Console.Write("Input length: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Input width: ");
                    double w = double.Parse(Console.ReadLine());
                    area = l * w;
                    Console.WriteLine($"Area of Rectangle: {area:F2}");
                    break;
                case 'S':
                    Console.Write("Input side length: ");
                    double s = double.Parse(Console.ReadLine());
                    area = Math.Pow(s, 2);
                    Console.WriteLine($"Area of Square: {area:F2}");
                    break;
                case 'T':
                    Console.Write("Input base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Input height: ");
                    double h = double.Parse(Console.ReadLine());
                    area = 0.5 * b * h;
                    Console.WriteLine($"Area of Triangle: {area:F2}");
                    break;
                case 'X':
                    inAreaMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    public static void PerimeterMenu()
    {
        bool inPerimeterMenu = true;
        
        while (inPerimeterMenu)
        {
            Console.WriteLine("\nPerimeter Menu");
            Console.WriteLine("C. Circle");
            Console.WriteLine("R. Rectangle");
            Console.WriteLine("S. Square");
            Console.WriteLine("T. Triangle");
            Console.WriteLine("X. eXit");
            Console.Write("Select C, R, S, T, or X: ");
            char perimeterMenu = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double perimeter;
            switch (perimeterMenu)
            {
                case 'C':
                    Console.Write("Input radius: ");
                    double r = double.Parse(Console.ReadLine());
                    perimeter = 2 * Math.PI * r;
                    Console.WriteLine($"Perimeter of Circle: {perimeter:F2}");
                    break;
                case 'R':
                    Console.Write("Input length: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Input width: ");
                    double w = double.Parse(Console.ReadLine());
                    perimeter = 2 * (l + w);
                    Console.WriteLine($"Perimeter of Rectangle: {perimeter:F2}");
                    break;
                case 'S':
                    Console.Write("Input side length: ");
                    double side = double.Parse(Console.ReadLine());
                    perimeter = 4 * side;
                    Console.WriteLine($"Perimeter of Square: {perimeter:F2}");
                    break;
                case 'T':
                    Console.Write("Input side 1: ");
                    double s1 = double.Parse(Console.ReadLine());
                    Console.Write("Input side 2: ");
                    double s2 = double.Parse(Console.ReadLine());
                    Console.Write("Input side 3: ");
                    double s3 = double.Parse(Console.ReadLine());
                    perimeter = s1 + s2 + s3;
                    Console.WriteLine($"Perimeter of Triangle: {perimeter:F2}");
                    break;
                case 'X':
                    inPerimeterMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    public static void VolumeMenu()
    {
        bool inVolumeMenu = true;
        
        while (inVolumeMenu)
        {
            Console.WriteLine("\nVolume Menu");
            Console.WriteLine("C. Cone");
            Console.WriteLine("S. Sphere");
            Console.WriteLine("U. cUbe");
            Console.WriteLine("Y. cYlinder");
            Console.WriteLine("X. eXit");
            Console.Write("Select C, S, U, Y, or X: ");
            char volumeMenu = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double volume;
            switch (volumeMenu)
            {
                case 'C':
                    Console.Write("Input radius: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.Write("Input height: ");
                    double h = double.Parse(Console.ReadLine());
                    volume = (double)1 / 3 * Math.PI * Math.Pow(r, 2) * h;
                    Console.WriteLine($"Volume of Cone: {volume:F2}");
                    break;
                case 'Y':
                    Console.Write("Input radius: ");
                    r = double.Parse(Console.ReadLine());
                    Console.Write("Input height: ");
                    h = double.Parse(Console.ReadLine());
                    volume = Math.PI * Math.Pow(r, 2) * h;
                    Console.WriteLine($"Volume of Cylinder: {volume:F2}");
                    break;
                case 'U':
                    Console.Write("Input side length: ");
                    double side = double.Parse(Console.ReadLine());
                    volume = Math.Pow(side, 3);
                    Console.WriteLine($"Volume of Cube: {volume:F2}");
                    break;
                case 'S':
                    Console.Write("Input radius: ");
                    r = double.Parse(Console.ReadLine());
                    volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                    Console.WriteLine($"Volume of Sphere: {volume:F2}");
                    break;
                case 'X':
                    inVolumeMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
    }
}
