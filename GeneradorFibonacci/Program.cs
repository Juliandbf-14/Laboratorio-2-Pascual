namespace GeneradorFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de Secuencia Fibonacci");
            Console.Write("Ingrese la cantidad de términos a generar: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Secuencia Fibonacci generada:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(GenerarFibonacciIterativo(i) + " ");
            }
        }

        // Función iterativa para generar la secuencia Fibonacci
        static int GenerarFibonacciIterativo(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0;
            int b = 1;
            int resultado = 0;

            for (int i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }

            return resultado;
        }
    }

}