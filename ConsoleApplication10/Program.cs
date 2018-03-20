using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá estudante, eu sou Joelson, o programinha legal, e vou armazenar a sua nota e a de mais 4 coleguinhas, bora lá?");
            Console.WriteLine("Pra começar, eu preciso das notas né");
            Console.WriteLine("");

            int[,] x = new int[5, 4];

            for (int l = 0; l < 5; l++)
            {
                Console.WriteLine("Digite as 4 notas:");
                for (int c = 0; c < 4; c++)
                {

                    x[l, c] = int.Parse(Console.ReadLine());
                }
            }


            Console.Clear();

            for (int l = 0; l < 5; l++)
            {
                Console.WriteLine("");
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("| " + x[l, c] + " | ");

                }
            }

            Console.WriteLine("");
            Console.WriteLine("Agora vou trocar a ordem, tentem descobrir quais são a de quem");
            Console.WriteLine("");

            for (int l = 0; l < 5; l++)
            {
                Console.WriteLine("");


                for (int c = 0; c < 4; c++)
                {
                    if (c % 2 == 0)
                    {
                        int j = c + 1;
                        Console.Write("| " + x[l, j] + " | ");

                    }

                    else if (c % 2 != 0)
                    {
                        int t = c - 1;
                        Console.Write("| " + x[l, t] + " | ");

                    }

                    else
                    {
                        Console.WriteLine("o lokoooooooo, como tu chegou aqui???");

                    }


                }


            }


            Console.ReadKey();


        }
    }
}
