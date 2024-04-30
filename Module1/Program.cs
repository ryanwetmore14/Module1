using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Transactions;

namespace Module1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var AreaOfTriangle = (10 * 20);
            var AreaOfRectangle = (20 * 30);
            var AreaOfCircle = (Math.PI * 2);
            var AreaOfSquare = (10 * 10);


            Console.WriteLine("Hello, World! We are finding the area and radius of different shapes!");


            //Determining the area of a circle


            Console.WriteLine("Enter Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine("Area of circle is : " + area);

            //Determining the area of a triangle

            Console.WriteLine("Enter the base of your triangle");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ener the height of your triangle");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            double areaOfTriangle = (.5 * triangleBase * triangleHeight);
            Console.WriteLine("AreaOfTriangle: " + areaOfTriangle);

            //Deteremining the area of a rectangle 

            Console.WriteLine("Enter length of rectangle:");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle:");
            double Width = Convert.ToDouble(Console.ReadLine());
            double areaOfRectangle = Length * Width;
            Console.WriteLine("Area of rectangle is:" + areaOfRectangle);

            //Determining the area of a sqaure

            Console.WriteLine("Enter the side of your sqaure");
            double side = Convert.ToDouble(Console.ReadLine());
            double areaOfSquare = (side * side);
            Console.WriteLine("Area of sqaure is:" + areaOfSquare);

            //Bonus Exercise

            Console.WriteLine("Choose a shape!");
            string shapeRectangle = Console.ReadLine();

            Console.WriteLine($"Rectangle is a great choice! the area of a rectangle is {AreaOfRectangle}");

            Console.WriteLine("Choose another shape!");
            string shapeCircle = Console.ReadLine();   

            Console.WriteLine($"Circle is also a great choice! the area of a circle is {AreaOfCircle}");

            Console.WriteLine("Go ahead and choose another shape!");
            string shapeTriangle = Console.ReadLine();

            Console.WriteLine($"Triangles are a cool shape! the area of a triangle is {AreaOfTriangle}");

        }
        public static double AreaOfRectangle(int length, int width)
        {
            return length * width;

        }

        public static double AreaOfTriangle(int triangleBase, int triangleHeight)
        {

            return .5 * triangleBase * triangleHeight;   
        }

        public static double AreaOfSqaure(int side)
        {
            return side * side;

        }

        public static double AreaOfCircle(int rad)
        {
            return Math.PI * rad * rad;

        }
    }
}
