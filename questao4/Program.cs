namespace questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura atual: ");
            double temp = double.Parse(Console.ReadLine());

            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += () => Console.WriteLine("Alerta: Temperatura excedeu o limite!");

            sensor.ChecarTemperatura(temp);
        }
    }
}
