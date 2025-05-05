namespace questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Action<string> logDelegate = logger.LogToConsole;

            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            logDelegate("Mensagem de teste do sistema");
        }
    }
}
