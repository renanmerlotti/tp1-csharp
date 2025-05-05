namespace questao1
{
    internal class Program
    {
        delegate decimal CalcularDesconto(decimal desconto);

        static decimal AplicarDesconto(decimal precoOriginal)
        {
            return precoOriginal * 0.9m;
        }

        static void Main(string[] args)
        {
            Console.Write("Informe o preço original do produto: ");
            decimal precoOriginal = decimal.Parse(Console.ReadLine());

            CalcularDesconto calcularDesconto = AplicarDesconto;

            decimal precoFinal = calcularDesconto(precoOriginal);

            Console.WriteLine("Preco com desconto: " + precoFinal);
        }
    }
}
