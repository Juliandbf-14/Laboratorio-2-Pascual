namespace ValidadorPalindromo
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa una palabra o frase: ");
        string texto = Console.ReadLine();

        if (EsPalindromo(texto))
        {
            Console.WriteLine("Es un palíndromo.");
        }
        else
        {
            Console.WriteLine("No es un palíndromo.");
        }
    }

    static bool EsPalindromo(string texto)
    {
        // Eliminar espacios y convertir todo a minúsculas
        texto = texto.Replace(" ", "").ToLower();

        int longitud = texto.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (texto[i] != texto[longitud - i - 1])
            {   
                // No es un palíndromo
                return false;
            }
        }
        // Es un palíndromo
        return true; 
    }
}
}