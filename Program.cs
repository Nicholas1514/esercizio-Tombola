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
            //dichiarazione numeri casuali
            Random r = new Random();
            int estratti;

            Thread.Sleep(2000);

            int[,] cartella1 = new int[3, 9];
            int[,] cartella2 = new int[3, 9];
            Thread.Sleep(2000);
            Console.WriteLine("\n" + "CARTELLA 1" + "\n");
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
            Thread.Sleep(2000);
            // stampa cartella 1
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Console.Write(cartella1[i, j] + " ");
                }
                Console.WriteLine("\n" + "________________________" + "\n");
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
            Thread.Sleep(2000);
            //stampa cartella 2
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella2[i, j] + " ");
                }
                Console.WriteLine("\n" + "_______________________" + "\n");
            }
            Console.WriteLine("\n");
            //generatore di numeri
            while (true)
            {
                int n = r.Next(1, 91);
                int numusciti = 0;
                Thread.Sleep(2000);
                Console.WriteLine("\n" + "Il numero estratto è: " + n);
                numusciti++;

               
                //controllo cartella 1
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (n == cartella1[i, j])
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                }

                //controllo cartella 2
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (n == cartella2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                }
                //generazione tabellone
                int[,] tabellone = new int[9, 10];
                int contatore = 1;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tabellone[i, j] = contatore++;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("TABELLONE");
                //stampa tabellone

                for (int i = 0; i < 9; i++)
                {


                    for (int j = 0; j < 10; j++)
                    {
                        //condizione per fare illuminare il numero
                        if (n == tabellone[i, j])
                        {
                            //il numero si illumina di blu 
                            Console.ForegroundColor = ConsoleColor.DarkBlue;



                        }

                        Console.Write(tabellone[i, j] + " ");
                        Console.ResetColor();




                    }
                    Console.WriteLine();

                }
                //controllo tombola
                int numcartella1 = 0;
                int numcartella2 = 0;
                //cartella1
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        numcartella1 = numcartella1 + cartella1[i, j];
                    }
                }
                //cartella2
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        numcartella2 = numcartella2 + cartella2[i, j];
                    }
                }
                //condizioni tombola
                if (numcartella1 == 0)
                {
                    Console.WriteLine("TOMBOLA");
                    Console.WriteLine("Ha vinto la cartella 1");
                }
                if (numcartella2 == 0)
                {
                    Console.WriteLine("TOMBOLA");
                    Console.WriteLine("Ha vinto la cartella 2");
                }

            }



















        }





















    }
    }

