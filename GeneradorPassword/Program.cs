using System.Text;

namespace GeneradorPassword
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.Write("Longitud de la contraseña: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            Console.Write("Incluir mayúsculas (S/N): ");
            bool incluirMayusculas = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Incluir minúsculas (S/N): ");
            bool incluirMinusculas = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Incluir números (S/N): ");
            bool incluirNumeros = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Incluir caracteres especiales (S/N): ");
            bool incluirCaracteresEspeciales = Console.ReadLine().Trim().ToUpper() == "S";

            string contrasena = GenerarContrasena(longitud, incluirMayusculas, incluirMinusculas, incluirNumeros, incluirCaracteresEspeciales);

            if (contrasena != null)
            {
                Console.WriteLine("Contraseña generada: " + contrasena);
            }
        }

        static string GenerarContrasena(int longitud, bool incluirMayusculas, bool incluirMinusculas, bool incluirNumeros, bool incluirCaracteresEspeciales)
        {
            const string caracteresMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string caracteresMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string numeros = "0123456789";
            const string caracteresEspeciales = "!@#$%^&*()_+[]{}|;:,.<>";

            string caracteresPermitidos = "";

            if (incluirMayusculas)
                caracteresPermitidos += caracteresMayusculas;
            if (incluirMinusculas)
                caracteresPermitidos += caracteresMinusculas;
            if (incluirNumeros)
                caracteresPermitidos += numeros;
            if (incluirCaracteresEspeciales)
                caracteresPermitidos += caracteresEspeciales;

            if (caracteresPermitidos.Length == 0)
            {
                Console.WriteLine("Debes seleccionar al menos un conjunto de caracteres.");
                return null;
            }

            StringBuilder contrasena = new StringBuilder();
            for (int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(caracteresPermitidos.Length);
                contrasena.Append(caracteresPermitidos[indiceCaracter]);
            }
            return contrasena.ToString();
        }
    }
}