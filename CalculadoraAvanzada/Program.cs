namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            // • Crea una calculadora que realice operaciones avanzadas como suma, resta, multiplicación, división, potenciación y raíz cuadrada.
            // • Implementa un menú de selección de operaciones para el usuario.
            // • Utiliza funciones separadas para cada operación.

            bool respuesta = true;

            while (respuesta == true)
            {
                Console.WriteLine("Opciones de la calculadora Avanzada:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potenciación");
                Console.WriteLine("6. Sacar Raíz Cuadrada");
                Console.WriteLine("0. Salir");
                Console.WriteLine("\nEscoge una opción:");

                string opcion = Console.ReadLine();
                

                if (opcion == "1")
                {
                    Console.WriteLine("Ingresa el primer número");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el segundo número");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = Suma(a, b);
                    Console.WriteLine($"El resultado de la suma de {a} + {b} es igual a: {resultado}");

                    Console.WriteLine("\nQuieres volver al menú principal? (Si/No)");
                    string salir = Console.ReadLine();

                    if (salir == "No")
                        respuesta = false;
                }

                if (opcion == "2")
                {
                    Console.WriteLine("Ingresa el primer número");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el segundo número");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = Resta(a, b);
                    Console.WriteLine($"El resultado de la resta de {a} + {b} es igual a: {resultado}");

                    Console.WriteLine("\nQuieres volver al menú principal? (Si/No)");
                    string salir = Console.ReadLine();

                    if (salir == "No")
                        respuesta = false;
                }

                if (opcion == "3")
                {
                    Console.WriteLine("Ingresa el primer número");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el segundo número");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = Multiplicacion(a, b);
                    Console.WriteLine($"El resultado de la multiplicación de {a} + {b} es igual a: {resultado}");

                    Console.WriteLine("\nQuieres volver al menú principal? (Si/No)");
                    string salir = Console.ReadLine();

                    if (salir == "No")
                        respuesta = false;
                }

                if (opcion == "4")
                {
                    Console.WriteLine("Ingresa el primer número");
                    float a = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el segundo número");
                    float b = float.Parse(Console.ReadLine());

                    float resultado = Division(a, b);
                    Console.WriteLine($"El resultado de la división de {a} + {b} es igual a: {resultado}");

                    Console.WriteLine("\nQuieres volver al menú principal? (Si/No)");
                    string salir = Console.ReadLine();

                    if (salir == "No")
                        respuesta = false;
                }

                if (opcion == "5")
                {
                    Console.WriteLine("Ingresa un número");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Ingresa el número para elevar el numero de {a} a la potencia ingresada");
                    double b = double.Parse(Console.ReadLine());

                    double resultado = Potenciacion(a, b);
                    Console.WriteLine($"El número {a} elevado a la potencia de {b} es igual a: {resultado}");

                    Console.WriteLine("\nQuieres volver al menú principal? (Si/No)");
                    string salir = Console.ReadLine();

                    if (salir == "No")
                        respuesta = false;
                }

                if (opcion == "6")
                {
                    Console.WriteLine("Ingresa un número");
                    int a = int.Parse(Console.ReadLine());

                    double resultado = RaizCuadrada(a);
                    Console.WriteLine($"La raíz cuadrada del número {a} es: {resultado}");

                    Console.WriteLine("\nQuieres volver al menú principal? (Si/No)");
                    string salir = Console.ReadLine();

                    if (salir == "No")
                        respuesta = false;
                }

                if(opcion == "0")
                    respuesta = false;
            }
        }

        //Operaciones
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static float Division(float a, float b)
        {
            return a * b;
        }

        static double Potenciacion(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double RaizCuadrada(int a)
        {
            return Math.Sqrt(a);
        }
    }
}