namespace ValidadorNumerosPrimos
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Validador de Números Primos");
            Console.Write("Ingrese un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine(numero + " es un número primo.");
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo.");
            }
        }

        // Función para verificar si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false; // Los números negativos, 0 y 1 no son primos
            }

            if (numero <= 3)
            {
                return true; // 2 y 3 son primos
            }

            if (numero % 2 == 0 || numero % 3 == 0)
            {
                return false; // Los múltiplos de 2 o 3 no son primos
            }

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}