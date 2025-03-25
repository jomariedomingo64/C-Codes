using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mathematical Formula Menu");
        Console.WriteLine("A. Area");
        Console.WriteLine("P. Perimeter");
        Console.WriteLine("V. Volume");
        Console.WriteLine("Select A, P, or V:");
        char menu = char.ToUpper(Console.ReadLine()[0]);

        double r, h;
        switch (menu)
        {
            case 'A':
                Console.WriteLine("Area Menu");
                Console.WriteLine("C. Circle");
                Console.WriteLine("R. Rectangle");
                Console.WriteLine("S. Square");
                Console.WriteLine("T. Triangle");
                Console.WriteLine("Select C, R, S, or T:");
                char areaMenu = char.ToUpper(Console.ReadLine()[0]);

                double area;
                switch (areaMenu)
                {
                    case 'C':
                        Console.WriteLine("Input radius");
                        r = double.Parse(Console.ReadLine());
                        area = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine($"Area of Circle: {area:F2}");
                        break;
                    case 'R':
                        Console.WriteLine("Input length");
                        double l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input width");
                        double w = double.Parse(Console.ReadLine());
                        area = l * w;
                        Console.WriteLine($"Area of Rectangle: {area:F2}");
                        break;
                    case 'S':
                        Console.WriteLine("Input side length");
                        double s = double.Parse(Console.ReadLine());
                        area = Math.Pow(s, 2);
                        Console.WriteLine($"Area of Square: {area:F2}");
                        break;
                    case 'T':
                        Console.WriteLine("Input base");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input height");
                        h = double.Parse(Console.ReadLine());
                        area = 0.5 * b * h;
                        Console.WriteLine($"Area of Triangle: {area:F2}");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                break;
            case 'P':
                Console.WriteLine("Perimeter Menu");
                Console.WriteLine("P. Parallelogram");
                Console.WriteLine("R. Rectangle");
                Console.WriteLine("S. Square");
                Console.WriteLine("T. Triangle");
                Console.WriteLine("Select P, R, S, or T:");
                char perimeterMenu = char.ToUpper(Console.ReadLine()[0]);

                double perimeter;
                switch (perimeterMenu)
                {
                    case 'P':
                        Console.WriteLine("Input base");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input height");
                        h = double.Parse(Console.ReadLine());
                        perimeter = 2 * b + 2 * h;
                        Console.WriteLine($"Perimeter of Parallelogram: {perimeter:F2}");
                        break;
                    case 'R':
                        Console.WriteLine("Input length");
                        double l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input width");
                        double w = double.Parse(Console.ReadLine());
                        perimeter = 2 * l + 2 * w;
                        Console.WriteLine($"Perimeter of Rectangle: {perimeter:F2}");
                        break;
                    case 'S':
                        Console.WriteLine("Input side length");
                        double side = double.Parse(Console.ReadLine());
                        perimeter = 4 * side;
                        Console.WriteLine($"Perimeter of Square: {perimeter:F2}");
                        break;
                    case 'T':
                        Console.WriteLine("Input side 1");
                        double s1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input side 2");
                        double s2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input side 3");
                        double s3 = double.Parse(Console.ReadLine());
                        perimeter = s1 + s2 + s3;
                        Console.WriteLine($"Perimeter of Triangle: {perimeter:F2}");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                break;
            case 'V':
                Console.WriteLine("Volume Menu");
                Console.WriteLine("C. Cone");
                Console.WriteLine("Y. cYlinder");
                Console.WriteLine("U. cUbe");
                Console.WriteLine("S. Sphere");
                Console.WriteLine("Select C, Y, U, or S:");
                char volumeMenu = char.ToUpper(Console.ReadLine()[0]);

                double volume;
                switch (volumeMenu)
                {
                    case 'C':
                        Console.WriteLine("Input radius");
                        r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input height");
                        h = double.Parse(Console.ReadLine());
                        volume = (double)1 / 3 * Math.PI * Math.Pow(r, 2) * h;
                        Console.WriteLine($"Volume of Cone: {volume:F2}");
                        break;
                    case 'Y':
                        Console.WriteLine("Input radius");
                        r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input height");
                        h = double.Parse(Console.ReadLine());
                        volume = Math.PI * Math.Pow(r, 2) * h;
                        Console.WriteLine($"Volume of Cylinder: {volume:F2}");
                        break;
                    case 'U':
                        Console.WriteLine("Input side length");
                        double side = double.Parse(Console.ReadLine());
                        volume = Math.Pow(side, 3);
                        Console.WriteLine($"Volume of Cube: {volume:F2}");
                        break;
                    case 'S':
                        Console.WriteLine("Input radius");
                        r = double.Parse(Console.ReadLine());
                        volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                        Console.WriteLine($"Volume of Sphere: {volume:F2}");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}
