namespace CalculoAreaPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nCalculadora de Área y Perímetro de Figuras Geométricas");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Salir");
                Console.Write("\nElija una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 4)
                {
                    break;
                }

                double area = 0;
                double perimetro = 0;

                switch (opcion)
                {
                    case 1: // Círculo
                        Console.Write("Ingrese el radio del círculo: ");
                        double radioCirculo = double.Parse(Console.ReadLine());
                        area = CalcularAreaCirculo(radioCirculo);
                        perimetro = CalcularPerimetroCirculo(radioCirculo);
                        break;

                    case 2: // Triángulo
                        Console.Write("Ingrese la base del triángulo: ");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        double alturaTriangulo = double.Parse(Console.ReadLine());
                        area = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                        perimetro = CalcularPerimetroTriangulo(baseTriangulo, alturaTriangulo);
                        break;

                    case 3: // Rectángulo
                        Console.Write("Ingrese la base del rectángulo: ");
                        double baseRectangulo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del rectángulo: ");
                        double alturaRectangulo = double.Parse(Console.ReadLine());
                        area = CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
                        perimetro = CalcularPerimetroRectangulo(baseRectangulo, alturaRectangulo);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }

                Console.WriteLine("Área: " + area);
                Console.WriteLine("Perímetro: " + perimetro);
            }
        }

        // Funciones para calcular el área y el perímetro de las figuras
        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        static double CalcularPerimetroCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }

        static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return 0.5 * baseTriangulo * altura;
        }

        static double CalcularPerimetroTriangulo(double baseTriangulo, double altura)
        {
            double hipotenusa = Math.Sqrt(baseTriangulo * baseTriangulo + altura * altura);
            return baseTriangulo + altura + hipotenusa;
        }

        static double CalcularAreaRectangulo(double baseRectangulo, double altura)
        {
            return baseRectangulo * altura;
        }

        static double CalcularPerimetroRectangulo(double baseRectangulo, double altura)
        {
            return 2 * (baseRectangulo + altura);
        }
    }
}