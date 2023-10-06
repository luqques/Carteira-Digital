namespace Carteira
{
    public class Cliente
    {
        private string documento;
        private char tipoPessoa;
        public string Nome { get; set; }

        public string Documento
        {
            get { return documento; }
            set
            {
                documento = value;
                if (documento.Length == 14)
                {
                    tipoPessoa = 'J';
                }
                else if (documento.Length == 11)
                {
                    tipoPessoa = 'F';
                }
                else
                {
                    throw new ArgumentException("Documento inválido.");
                }
            }
        }    
        
        public Cliente()
        {
            Console.Write("Digite o número identificador do seu documento: ");
            Documento = Console.ReadLine();
        }
    }
}