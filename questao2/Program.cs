namespace questao2
{
    internal class Program
    {
        static Action<string> exibirBoasVindas;
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um idioma (digite o número):");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");
            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                exibirBoasVindas = MensagemPortugues;
            } else if(opcao == 2)
            {
                exibirBoasVindas = MensagemIngles;
            } else if (opcao == 3)
            {
                exibirBoasVindas = MensagemEspanhol;
            }

            exibirBoasVindas("Usuario");
        }

        static void MensagemPortugues(string nome)
        {
            Console.WriteLine("Bem vindo, " + nome);
        }

        static void MensagemIngles(string nome)
        {
            Console.WriteLine("Welcome, " + nome);
        }

        static void MensagemEspanhol(string nome)
        {
            Console.WriteLine("Bienvenido, " + nome);
        }
    }
}
