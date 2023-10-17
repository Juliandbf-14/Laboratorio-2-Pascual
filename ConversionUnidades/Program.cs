namespace ConversionUnidades
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nSeleccione la categoría de conversión:");
                Console.WriteLine("1. Longitud");
                Console.WriteLine("2. Peso");
                Console.WriteLine("3. Volumen");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 4)
                {
                    break;
                }

                double resultado = 0;

                switch (opcion)
                {
                    case 1: // Longitud
                        resultado = ConvertirLongitud();
                        Console.WriteLine("El resultado es: " + resultado + " metros");
                        break;

                    case 2: // Peso
                        resultado = ConvertirPeso();
                        Console.WriteLine("El resultado es: " + resultado + " kilogramos");
                        break;

                    case 3: // Volumen
                        resultado = ConvertirVolumen();
                        Console.WriteLine("El resultado es: " + resultado + " litros");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
        }

        static double ConvertirLongitud()
        {
            Console.Write("Introduzca la longitud en pies: ");
            double longitudEnPies = double.Parse(Console.ReadLine());
            return longitudEnPies * 0.3048; // Convertir de pies a metros
        }

        static double ConvertirPeso()
        {
            Console.Write("Introduzca el peso en libras: ");
            double pesoEnLibras = double.Parse(Console.ReadLine());
            return pesoEnLibras * 0.453592; // Convertir de libras a kilogramos
        }

        static double ConvertirVolumen()
        {
            Console.Write("Introduzca el volumen en galones: ");
            double volumenEnGalones = double.Parse(Console.ReadLine());
            return volumenEnGalones * 3.78541; // Convertir de galones a litros
        }
    }

}