namespace Carteira
{
    class Saldo
    {
        private static double valorSaldo;
        private static double ValorSaldo
        {
            get { return valorSaldo; }
            set
            {
                valorSaldo = value;
            }
        }

        internal static void MostrarSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de R${ValorSaldo}");
        }
    }
}