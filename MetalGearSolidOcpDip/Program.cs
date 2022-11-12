namespace MetalGearSolidOcpDip
{
    public class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(2000, "londrina");
            CalculaPreco calcula = new CalculaPreco(new TabelaPrecoPadrao(), new Transportadora());

            double resultado = calcula.Calcula(compra);

            Console.WriteLine("O preço da compra é :" + resultado);
            Console.ReadKey();

        }
    }
}