using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_Minado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j = 2;
            int p = 0;
            string[,] matriz = new string[9, 9] {
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
                { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", },
            };

            do
            {
                Console.WriteLine(" 1  2  3  4  5  6  7  8  9 ");
                Console.WriteLine("----------------------------");
                for (i = 1; i <= 9; i++)
                {
                    for (j = 1; j <= 9; j++)
                    {
                        if (matriz[i - 1, j - 1] != "[ ]")
                        {
                            Console.Write("{0}", matriz[i - 1, j - 1]);
                        }
                        else
                        {
                            Console.Write("[ ]");
                        }
                        matriz[0, 0] = ("[ ]");
                        matriz[0, 8] = ("[ ]");
                        matriz[3, 2] = ("[ ]");
                        matriz[3, 6] = ("[ ]");
                        matriz[5, 0] = ("[ ]");
                        matriz[6, 4] = ("[ ]");
                        matriz[4, 1] = ("[ ]");
                        matriz[7, 0] = ("[ ]");
                        matriz[8, 5] = ("[ ]");
                        matriz[6, 1] = ("[ ]");

                    }
                    Console.WriteLine("|{0}", i);
                }
                Console.WriteLine();

                Console.Write("Digite a Linha: ");
                i = int.Parse(Console.ReadLine());
                Console.Write("Digite a Coluna: ");
                j = int.Parse(Console.ReadLine());

                matriz[0, 8] = "[*]";
                matriz[3, 2] = "[*]";
                matriz[3, 6] = "[*]";
                matriz[5, 0] = "[*]";
                matriz[6, 4] = "[*]";
                matriz[4, 1] = "[*]";
                matriz[7, 0] = "[*]";
                matriz[8, 5] = "[*]";
                matriz[6, 1] = "[*]";

                if (matriz[i - 1, j - 1] == "[*]")
                {
                    Console.WriteLine("VOCÊ PERDEU!!!");
                }
                else
                {
                    Console.WriteLine("Você ganhou mais um ponto: |{0}");
                    Console.WriteLine();
                    matriz[i - 1, j - 1] = "[0]";
                    p++;
                }
            } while (matriz[i - 1, j - 1] != "[*]" && p != 74);



            if (matriz[i - 1, j - 1] == "[*]")
            {
                Console.WriteLine("[*]");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Parabéns você venceu");
                Console.ReadLine();
            }
        }
    }
}
