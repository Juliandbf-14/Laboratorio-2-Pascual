namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.WriteLine("5. Fahrenheit a Kelvin");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            Console.Write("Selecciona una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0.0;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa la temperatura en Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    resultado = CelsiusToFahrenheit(celsius);
                    // F2 se utiliza para dar formato al valor en el strin interpolado como un número de punto fijo con dos decimales.
                    Console.WriteLine($"Resultado: {resultado:F2} Fahrenheit");
                    break;

                case 2:
                    Console.Write("Ingresa la temperatura en Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    resultado = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine($"Resultado: {resultado:F2} Celsius");
                    break;

                case 3:
                    Console.Write("Ingresa la temperatura en Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    resultado = CelsiusToKelvin(celsius);
                    Console.WriteLine($"Resultado: {resultado:F2} Kelvin");
                    break;

                case 4:
                    Console.Write("Ingresa la temperatura en Kelvin: ");
                    double kelvin = Convert.ToDouble(Console.ReadLine());
                    resultado = KelvinToCelsius(kelvin);
                    Console.WriteLine($"Resultado: {resultado:F2} Celsius");
                    break;

                case 5:
                    Console.Write("Ingresa la temperatura en Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    resultado = FahrenheitToKelvin(fahrenheit);
                    Console.WriteLine($"Resultado: {resultado:F2} Kelvin");
                    break;

                case 6:
                    Console.Write("Ingresa la temperatura en Kelvin: ");
                    kelvin = Convert.ToDouble(Console.ReadLine());
                    resultado = KelvinToFahrenheit(kelvin);
                    Console.WriteLine($"Resultado: {resultado:F2} Fahrenheit");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        static double FahrenheitToKelvin(double fahrenheit)
        {
            double celsius = FahrenheitToCelsius(fahrenheit);
            return CelsiusToKelvin(celsius);
        }

        static double KelvinToFahrenheit(double kelvin)
        {
            double celsius = KelvinToCelsius(kelvin);
            return CelsiusToFahrenheit(celsius);
        }
    }
}