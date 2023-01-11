using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tombola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IL GIOCO DELLA TOMBOLA" + "\n");


            Generacartelle();
            Thread.Sleep(2000);
           
            Generatorenumeri();
            Thread.Sleep(2000);
            Generatoretabellone();
            Thread.Sleep(2000);
            
        }


        static void Generacartelle()
        {
            Random r = new Random();
            int x = r.Next();
            int[,] cartella1 = new int[3, 9];
            int[,] cartella2 = new int[3, 9];
            Console.WriteLine("CARTELLA 1" + "\n");
            //cartella 1
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cartella1[0, 0] = r.Next(1, 9);
                    cartella1[1, 0] = r.Next(1, 9);
                    cartella1[2, 0] = 0;

                    cartella1[0, 1] = r.Next(10, 19);
                    cartella1[1, 1] = 0;
                    cartella1[2, 1] = r.Next(10, 19);

                    cartella1[0, 2] = 0;
                    cartella1[1, 2] = r.Next(20, 29);
                    cartella1[2, 2] = 0;

                    cartella1[0, 3] = 0;
                    cartella1[1, 3] = r.Next(30, 39);
                    cartella1[2, 3] = r.Next(30, 39);


                    cartella1[0, 4] = r.Next(40, 49);
                    cartella1[1, 4] = 0;
                    cartella1[2, 4] = 0;

                    cartella1[0, 5] = 0;
                    cartella1[1, 5] = 0;
                    cartella1[2, 5] = r.Next(50, 59);


                    cartella1[0, 6] = r.Next(60, 69);
                    cartella1[1, 6] = r.Next(60, 69);
                    cartella1[2, 6] = 0;


                    cartella1[0, 7] = 0;
                    cartella1[1, 7] = r.Next(70, 79);
                    cartella1[2, 7] = r.Next(70, 79);

                    cartella1[0, 8] = r.Next(80, 90);
                    cartella1[1, 8] = 0;
                    cartella1[2, 8] = r.Next(80, 90);

                    


                }

            }
            // stampa cartella 1
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella1[i, j] + " ");
                }
                Console.WriteLine("\n" + "________________________");
            }
            Console.WriteLine("\n");
            Console.WriteLine("CARTELLA 2" + "\n");
            //cartella 2
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cartella2[0, 0] = r.Next(1, 9);
                    cartella2[1, 0] = r.Next(1, 9);
                    cartella2[2, 0] = 0;

                    cartella2[0, 1] = r.Next(10, 19);
                    cartella2[1, 1] = 0;
                    cartella2[2, 1] = r.Next(10, 19);

                    cartella2[0, 2] = 0;
                    cartella2[1, 2] = r.Next(20, 29);
                    cartella2[2, 2] = 0;

                    cartella2[0, 3] = 0;
                    cartella2[1, 3] = r.Next(30, 39);
                    cartella2[2, 3] = r.Next(30, 39);


                    cartella2[0, 4] = r.Next(40, 49);
                    cartella2[1, 4] = 0;
                    cartella2[2, 4] = 0;

                    cartella2[0, 5] = 0;
                    cartella2[1, 5] = 0;
                    cartella2[2, 5] = r.Next(50, 59);


                    cartella2[0, 6] = r.Next(60, 69);
                    cartella2[1, 6] = r.Next(60, 69);
                    cartella2[2, 6] = 0;


                    cartella2[0, 7] = 0;
                    cartella2[1, 7] = r.Next(70, 79);
                    cartella2[2, 7] = r.Next(70, 79);

                    cartella2[0, 8] = r.Next(80, 90);
                    cartella2[1, 8] = 0;
                    cartella2[2, 8] = r.Next(80, 90);

               


                }

            }
            //stampa cartella 2
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella2[i, j] + " ");
                }
                Console.WriteLine("\n" + "_______________________");
            }
            Console.WriteLine("\n");

      


        }

        static int Generatorenumeri()
        {

            Random r = new Random();

            int n = r.Next(1, 90);

            Console.WriteLine("Il numero estratto è: " + n);

            Console.WriteLine("\n");
            return n;
        } 

         static void Generatoretabellone(ref int n)
        {
            //generazione tabellone
            int[,] tabellone = new int[9, 10]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {11,12,13,14,15,16,17,18,19,20},
                {21,22,23,24,25,26,27,28,29,30 },
                {31,32,33,34,35,36,37,38,39,40 },
                {41,42,43,44,45,46,47,48,49,50 },
                {51,52,53,54,55,56,57,58,59,60},
                {61,62,63,64,65,66,67,68,69,70 },
                {71,72,73,74,75,76,77,78,79,80 },
                {81,82,83,84,85,86,87,88,89,90 },
            };

            Console.WriteLine("TABELLONE");





            //stampa tabellone

            for (int i = 0; i < 9; i++)
            {


                for (int j = 0; j < 10; j++)
                {

                    Console.Write(tabellone[i, j] + " ");

                }
                Console.WriteLine();

            }


            //controllo dei numeri sul tabellone (aggiornamento)
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (n == tabellone[i, j])
                    {

                        Console.SetCursorPosition(0, 26);
                        Console.BackgroundColor = ConsoleColor.Red;


                    }

                }

             

            }
            //controllo cartella 1
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    
                }
            }

            //controllo cartella 2
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                }
            }
        }












    }
    }

