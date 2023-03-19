using System;

namespace GeometricShapes
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("¿Qué figura desea calcular? (Círculo (C) / Rectángulo (R) )");
                string shapeType = Console.ReadLine().ToLower();
                string shapeName = "";

                Shape shape;
                try
                {
                    if (shapeType == "círculo" || shapeType == "c" || shapeType == "circulo")
                    {
                        double radius;
                        Console.WriteLine("Introduzca el radio:");
                        if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.WriteLine("Valor de radio inválido.");
                            continue;
                        }
                        shape = new Circle(radius);
                        shapeName = "Círculo";
                    }
                    else if (shapeType == "rectángulo" || shapeType == "r" || shapeType == "rectangulo")
                    {
                        double length, width;
                        Console.WriteLine("Introduzca el largo:");
                        if (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.WriteLine("Valor de largo inválido.");
                            continue;
                        }
                        Console.WriteLine("Introduzca el ancho:");
                        if (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
                        {
                            Console.WriteLine("Valor de ancho inválido.");
                            continue;
                        }
                        shape = new Rectangle(length, width);
                        shapeName = "Rectángulo";
                    }
                    else
                    {
                        Console.WriteLine("Tipo de figura inválido.");
                        continue;
                    }
                    double area = shape.CalculateArea();
                    Console.WriteLine($"El área del {shapeName} es: {area}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error de formato: por favor, asegúrese de ingresar un número válido.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    continue;
                }

                Console.WriteLine("Presione cualquier tecla para continuar o presione 's' para salir.");
                if (Console.ReadKey().KeyChar == 's') break;
            }

        }
    }
}

