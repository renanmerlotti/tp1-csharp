namespace questao3
{
    internal class Program
    {
        static Func<double, double, double> calcularArea = (b, h) => b * h;
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base do retangulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do retangulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = calcularArea(baseRetangulo, altura);
            Console.WriteLine("Area do retangulo: " + area);
        }
    }
}
