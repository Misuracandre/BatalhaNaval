namespace BatalhaNaval
{
    public class Tabuleiro
    {
        public char[,] tabuleiro;
        public char[] escolhacoluna = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't' };

        public Tabuleiro()
        {
            this.tabuleiro = new char[20, 20];
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    tabuleiro[l, c] = '-';
                }
            }

        }

        public void ImprimirTabuleiro()
        {

            Console.Write("  ");
            for (int i = 0; i < escolhacoluna.Length; i++)
            {
                Console.Write(" " + escolhacoluna[i]);
            }
            Console.WriteLine();


            for (int l = 0; l < 9; l++)
            {
                Console.Write((l + 1) + "  ");
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    Console.Write(tabuleiro[l, c] + " ");
                }
                Console.WriteLine();
            }

            for (int l = 9; l < tabuleiro.GetLength(0); l++)
            {
                Console.Write((l + 1) + " ");
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    Console.Write(tabuleiro[l, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}