
namespace exAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*Bem vindo(a) ao jogo da Avininhação*");
            Console.WriteLine("*************************************");

            Console.WriteLine("Escolha o nivel de dificuldade: ");
            Console.WriteLine("(1)Fácil   (2)Médio   (3)Difícil");
            Console.Write("Escolha: ");
            int nDificuldade = int.Parse(Console.ReadLine());

            Random nAleatorio = new Random();
            int nSecreto = nAleatorio.Next(1, 21);
            int nTentativas = 0;
            int pontuacao = 1000;

            if(nDificuldade == 1)
            {
                nTentativas = 15;
            }
            else if(nDificuldade == 2)
            {
                nTentativas = 10;
            }
            else
            {
                nTentativas = 5;
            }

            for (int i = 0; i < nTentativas; i++)
            {
                Console.WriteLine("\nTentativa " + (i+1) + " de " + nTentativas);
                Console.WriteLine("---------------------------------");
                Console.Write("Qual o seu " + (i+1) + "° chute: ");
                int chute = int.Parse(Console.ReadLine());
                int formula = (chute - nSecreto) / 2;
                if (chute > nSecreto)
                {
                    Console.WriteLine("\nSeu chute foi maior que o número secreto");                    
                    if (formula < 0)
                    {
                        formula = formula * -1;                        
                    }
                    pontuacao = pontuacao - formula;
                    Console.WriteLine("Você está agora com " + pontuacao + " pontos!");
                }else if(chute < nSecreto)
                {
                    Console.WriteLine("\nSeu chute foi menor que o número secreto");
                    if (formula < 0)
                    {
                        formula = formula * -1;                        
                    }
                    pontuacao = pontuacao - formula;
                    Console.WriteLine("Você está agora com " + pontuacao + " pontos!");
                }
                else
                {
                    Console.WriteLine("Parabéns, com " + pontuacao + " pontos, você acertou!");
                    break;
                }
            }
        }
    }
}