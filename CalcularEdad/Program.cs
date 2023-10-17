namespace CalcularEdad
{
    class Program
    {


        static bool EsFechaValida(DateTime fecha)
        {
            // Comprueba si la fecha está en un rango razonable, por ejemplo, entre 1900 y el año actual.
            int añoActual = DateTime.Now.Year;
            return fecha.Year >= 1900 && fecha.Year <= añoActual;
        }

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            if (fechaNacimiento > fechaActual)
            {
                throw new Exception("La fecha de nacimiento no puede estar en el futuro.");
            }

            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month ||
                (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa tu fecha de nacimiento (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                if (EsFechaValida(fechaNacimiento))
                {
                    int edad = CalcularEdad(fechaNacimiento);
                    Console.WriteLine($"Tienes {edad} años de edad.");
                }
                else
                {
                    Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
                }
            }
            else
            {
                Console.WriteLine("Formato de fecha no válido. Utiliza el formato yyyy-MM-dd.");
            }
        }
    }
}