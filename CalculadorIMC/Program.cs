namespace CalculadorIMC
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa tu peso en kilogramos: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa tu altura en metros: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                if (peso > 0 && altura > 0)
                {
                    double imc = CalcularIMC(peso, altura);
                    string clasificacion = ClasificarIMC(imc);
                    Console.WriteLine($"Tu IMC es {imc:F2}, lo que se clasifica como: {clasificacion}");
                }
                else
                {
                    Console.WriteLine("El peso y la altura deben ser valores positivos.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error en los valores ingresados.");
            }
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string ClasificarIMC(double imc)
        {
            if (imc < 18.5)
                return "Bajo peso";
            if (imc < 24.9)
                return "Peso normal";
            else
                return "Sobrepeso";
        }
    }
}
