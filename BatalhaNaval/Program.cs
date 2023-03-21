using BatalhaNaval;

int portaAvioes1 = 0;
int portaAvioes2 = 0;
int destroyer1 = 0;
int destroyer2 = 0;
int submarino1 = 0;
int submarino2 = 0;

Tabuleiro tab = new Tabuleiro();

tab.ImprimirTabuleiro();

Jogador jogador1 = new Jogador("Jogador 1");

Jogador jogador2 = new Jogador("Jogador 2");

AtirarJogador1();


void AtirarJogador1()
{
    if (portaAvioes2 + destroyer2 + submarino2 == 9)
    {
        Console.Clear();
        tab.ImprimirTabuleiro();
        Console.WriteLine("Parabéns Jogador 1, você venceu!!!\n\nFim do jogo...");
        System.Environment.Exit(0);
    }
    else
    {
        Console.Clear();
        tab.ImprimirTabuleiro();
        jogador1.Atirar();
        if (jogador1.TiroLinha == 16 && jogador1.TiroColuna == 'f')
        {
            if (tab.tabuleiro[15, 5] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                portaAvioes2++;
                tab.tabuleiro[15, 5] = 'X';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 16 && jogador1.TiroColuna == 'g')
        {
            if (tab.tabuleiro[16, 6] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                portaAvioes2++;
                tab.tabuleiro[15, 6] = 'X';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 16 && jogador1.TiroColuna == 'h')
        {
            if (tab.tabuleiro[15, 7] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                portaAvioes2++;
                tab.tabuleiro[15, 7] = 'X';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 16 && jogador1.TiroColuna == 'i')
        {
            if (tab.tabuleiro[15, 8] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                portaAvioes2++;
                tab.tabuleiro[15, 8] = 'X';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 8 && jogador1.TiroColuna == 'j')
        {
            if (tab.tabuleiro[7, 9] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                destroyer2++;
                tab.tabuleiro[7, 9] = 'X';
                Console.WriteLine($"\nVocê acertou um Destroyer!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 9 && jogador1.TiroColuna == 'j')
        {
            if (tab.tabuleiro[8, 9] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                destroyer2++;
                tab.tabuleiro[8, 9] = 'X';
                Console.WriteLine($"\nVocê acertou um Destroyer!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 10 && jogador1.TiroColuna == 'j')
        {
            if (tab.tabuleiro[9, 9] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                destroyer2++;
                tab.tabuleiro[9, 9] = 'X';
                Console.WriteLine($"\nVocê acertou um Destroyer!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 2 && jogador1.TiroColuna == 'p')
        {
            if (tab.tabuleiro[1, 15] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                submarino2++;
                tab.tabuleiro[1, 15] = 'X';
                Console.WriteLine($"\nVocê acertou um Submarino!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        if (jogador1.TiroLinha == 3 && jogador1.TiroColuna == 'p')
        {
            if (tab.tabuleiro[2, 15] == 'X')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador2();
            }
            else
            {
                destroyer2++;
                tab.tabuleiro[2, 15] = 'X';
                Console.WriteLine($"\nVocê acertou um Submarino!!!");
                Console.ReadLine();
                AtirarJogador1();
            }
        }
        else
        {
            Console.WriteLine($"\nVocê acertou a água!!!");
            Console.ReadLine();
            Console.Clear();
            tab.ImprimirTabuleiro();
            AtirarJogador2();
        }
    }
}

void AtirarJogador2()
{
    if (portaAvioes1 + destroyer1 + submarino1 == 9)
    {
        Console.Clear();
        tab.ImprimirTabuleiro();
        Console.WriteLine($"Parabéns Jogador 2, você venceu!!!\n\nFim do jogo...");
        System.Environment.Exit(0);
    }
    else
    {
        Console.Clear();
        tab.ImprimirTabuleiro();
        jogador2.Atirar();
        if (jogador2.TiroLinha == 3 && jogador2.TiroColuna == 'c')
        {
            if (tab.tabuleiro[2, 2] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                portaAvioes1++;
                tab.tabuleiro[2, 2] = 'O';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 4 && jogador2.TiroColuna == 'c')
        {
            if (tab.tabuleiro[3, 2] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                portaAvioes1++;
                tab.tabuleiro[3, 2] = 'O';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 5 && jogador2.TiroColuna == 'c')
        {
            if (tab.tabuleiro[4, 2] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                portaAvioes1++;
                tab.tabuleiro[4, 2] = 'O';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 6 && jogador2.TiroColuna == 'c')
        {
            if (tab.tabuleiro[5, 2] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                portaAvioes1++;
                tab.tabuleiro[5, 2] = 'O';
                Console.WriteLine($"\nVocê acertou um Porta-Aviões!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 8 && jogador2.TiroColuna == 'f')
        {
            if (tab.tabuleiro[7, 5] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                destroyer1++;
                tab.tabuleiro[7, 5] = 'O';
                Console.WriteLine($"\nVocê acertou um Destroyer!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 9 && jogador2.TiroColuna == 'f')
        {
            if (tab.tabuleiro[8, 5] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                destroyer1++;
                tab.tabuleiro[8, 5] = 'O';
                Console.WriteLine($"\nVocê acertou um Destroyer!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 10 && jogador2.TiroColuna == 'f')
        {
            if (tab.tabuleiro[9, 5] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                destroyer1++;
                tab.tabuleiro[9, 5] = 'O';
                Console.WriteLine($"\nVocê acertou um Destroyer!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 19 && jogador2.TiroColuna == 'q')
        {
            if (tab.tabuleiro[18, 16] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                submarino1++;
                tab.tabuleiro[18, 16] = 'O';
                Console.WriteLine($"\nVocê acertou um Submarino!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        if (jogador2.TiroLinha == 19 && jogador2.TiroColuna == 'r')
        {
            if (tab.tabuleiro[18, 17] == 'O')
            {
                Console.WriteLine("\nVocê já escolheu essa posição");
                Console.ReadLine();
                AtirarJogador1();
            }
            else
            {
                destroyer1++;
                tab.tabuleiro[18, 17] = 'O';
                Console.WriteLine($"\nVocê acertou um Submarino!!!");
                Console.ReadLine();
                AtirarJogador2();
            }
        }
        else
        {
            Console.WriteLine($"\nVocê acertou a água!!!");
            Console.ReadLine();
            Console.Clear();
            tab.ImprimirTabuleiro();
            AtirarJogador1();
        }
    }
}