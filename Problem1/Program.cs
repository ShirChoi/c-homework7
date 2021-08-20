using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            Rectangle rect1 = new Rectangle(ReadDouble("Rect1 side1"), ReadDouble("Rect1 side2"));

            System.Console.WriteLine($"Rect1 perimeter: {rect1.Perimeter}");
            System.Console.WriteLine($"Rect1 area: {rect1.Area}");

            Rectangle rect2 = new Rectangle(ReadDouble("Rect2 side1"), ReadDouble("Rect2 side2"));

            System.Console.WriteLine($"Rect2 perimeter: {rect2.Perimeter}");
            System.Console.WriteLine($"Rect2 area: {rect2.Area}");
        }

        static double ReadDouble(string varName) {
            System.Console.Write(varName + ": ");
            return double.Parse(Console.ReadLine());
        }
    }

    class Rectangle {
        private double _side1, _side2;
        public double Area {
            get {
                return AreaCalculator();
            }
        }

        public double Perimeter {
            get {
                return PerimeterCalculator();
            }
        }

        public Rectangle(double side1, double side2) {
            _side1 = side1;
            _side2 = side2;
        }   

        private double AreaCalculator() {
            return _side1 * _side2;
        }

        private double PerimeterCalculator() {
            return 2 * (_side1 + _side2);
        }
    }
}
