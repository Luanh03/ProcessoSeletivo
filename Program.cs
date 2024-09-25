using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ProcessoSeletivo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Questão 1");
            Console.WriteLine("Entre com o número para que seja informado se o número pertence a sequência: ");
            int number = int.Parse(Console.ReadLine());

            int a = 0, b = 1;
            bool belongs = false;

            if (number == a || number == b)
            {
                belongs = true;
            }
            else
            {
                while (b <= number)
                {
                    int next = a + b;
                    a = b;
                    b = next;

                    if (b == number)
                    {
                        belongs = true;
                        break;
                    }
                }
            }

            if (belongs)
            {
                Console.WriteLine("O número " + number + " faz parte da sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número " + number + " não faz parte da sequência de Fibonacci.");
            }
            Console.WriteLine("-----------------------------");


            Console.WriteLine("-----------------------------");
            //2
            Console.WriteLine("QUESTÂO 2");
            Console.WriteLine("Digite uma frase: ");
            string text = Console.ReadLine();

            int counter = ContadorDeLetrasA(text);

            if(counter > 0)
            {
                Console.WriteLine("A string contém a vogal 'a' (maiúscula ou minúscula) e ela aparece " + counter + " vezes.");
            }
            else
            {
                Console.WriteLine("Esta string não contém a vogal 'a' (maiúscula ou minúscula).");
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("-----------------------------");
            //3
            int indice = 12, soma = 0, k = 1;
            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }
            Console.WriteLine("O valor da variável soma é: " + soma);
            Console.WriteLine("-----------------------------");


            Console.WriteLine("-----------------------------");
            //4
            Console.WriteLine("Questão 4");

            //A
            Console.WriteLine("Qual o próximo número da sequência A) 1, 3, 5, 7, "); 
            int[] x = { 1, 3, 5, 7};

            int nextX = x[x.Length - 1] + 2;
            Console.WriteLine("O próximo elemento é: " + nextX);

            //B
            Console.WriteLine("Qual o próximo número da sequência B) 2, 4, 8, 16, 32, 64 ");
            int[] y = { 2, 4, 8, 16, 32, 64 };

            int nextY = y[y.Length - 1] * 2;
            Console.WriteLine("O próximo elemento é: " + nextY);

            //C
            Console.WriteLine("Qual o próximo número da sequência C) 0, 1, 4, 9, 16, 25, 36 ");
            int[] c = { 0, 1, 4, 9, 16, 25, 36 };

            int nextC = (c.Length) * (c.Length);
            Console.WriteLine("O próximo elemento é: " + nextC);

            //D
            Console.WriteLine("Qual o próximo número da sequência D) 4, 16, 36, 64 ");
            int[] d = { 4, 16, 36, 64 };

            int nextD = 10 * 10;
            Console.WriteLine("O próximo elemento é: " + nextD);

            //E
            Console.WriteLine("Qual o próximo número da sequência E) 1, 1, 2, 3, 5, 8 ");
            int[] e = { 1, 1, 2, 3, 5, 8, };

            int nextE = e[e.Length - 1] + e[e.Length - 2];
            Console.WriteLine("O próximo elemento é: " + nextE);

            //F
            Console.WriteLine("Qual o próximo número da sequência F) 2,10, 12, 16, 17, 18, 19 ");
            int[] f = { 2, 10, 12, 16, 17, 18, 19 };

            int nextF = f[f.Length - 1] + 1;
            Console.WriteLine("O próximo elemento é: " + nextF);
            Console.WriteLine("-----------------------------");


            Console.WriteLine("-----------------------------");
            //5
            Console.WriteLine("QUESTÃO 5");
            Console.WriteLine("A ideia para solução seria deixar uma das luzes acessas por um determinado tempo, depois apagar e ligar outra. Depois conferir qual está ligada e qual está apagada e quente, consequentemente a fria não foi ligada. Ilustração abaixo: ");



            bool[] lamps = { false, false, false }; 
            Random random = new Random();

            int lampIndex = random.Next(0, 3); 
            lamps[lampIndex] = true;

            Console.WriteLine("Lâmpada " + lampIndex + 1 + " está acesa.");

            Console.WriteLine("Ligando o interruptor 1 (Interruptor1) por 10 minutos");
            System.Threading.Thread.Sleep(1000); 

            Console.WriteLine("Desligando o interruptor 1 e ligando o interruptor 2 (Interruptor2)");

            Console.WriteLine("Indo até a sala das lâmpadas");

            for (int i = 0; i < lamps.Length; i++)
            {
                if (lamps[i])
                {
                    Console.WriteLine("Lâmpada " + i + 1 + " está acesa (Interruptor2).");
                }
                else
                {
                    Console.WriteLine("Lâmpada " + i + 1 + " está apagada (Interruptor1 ou Interruptor3).");
                }
            }

            Console.WriteLine("Identificação completa:");
            Console.WriteLine("Interruptor1 controla a lâmpada apagada e quente.");
            Console.WriteLine("Interruptor2 controla a lâmpada acesa.");
            Console.WriteLine("Interruptor3 controla a lâmpada apagada e fria.");
        }


        static int ContadorDeLetrasA(string str)
        {
            int contador = 0;

            foreach (char letter in str)
            {
                if (letter == 'a' || letter == 'A')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}


