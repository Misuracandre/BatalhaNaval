namespace BatalhaNaval
{
    internal class Jogador
    {
        public string Nome { get; private set; }

        public int TiroLinha { get; set; }

        public char TiroColuna { get; set; }

        public Jogador(string nome)
        {
            this.Nome = nome;
        }

        public void Atirar()
        {
            try
            {
                Console.WriteLine(Nome + " escolha uma linha...");
                TiroLinha = int.Parse(Console.ReadLine());

                Console.WriteLine($"\n{Nome} escolha uma coluna...");
                TiroColuna = char.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine($"\nVocê digitou uma posição inválida!!!");
                Console.WriteLine();
                Atirar();
            }
        }
    }
}

