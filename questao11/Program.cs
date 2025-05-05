namespace questao11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Func<string, string, string> concatenar = (n, s) => n + " " + s;
            Func<string, string> maiusculas = s => s.ToUpper();
            Func<string, string> removerEspacos = s => s.Replace(" ", "");

            string resultado = removerEspacos(maiusculas(concatenar("Renan", "Merlotti")));

            Console.WriteLine(resultado);
        }
    }
}
