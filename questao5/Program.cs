namespace questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DownloadManager manager = new DownloadManager();
            manager.DownloadCompleted += () => Console.WriteLine("Download concluído!");

            Console.WriteLine("Iniciando download...");
            manager.StartDownload();
        }
    }
}
