using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;
            int receivedAmount;
            int toPay;
            int returnAmount;
            int returnFivehundred;
            int returnHundred;
            int returnTwenty;
            int returnFive;
            int returnOne;


            /* While-loop som körs så länge ett fel upptäcks */
            while (true)
            {
                Console.Write("Ange totalsumma:     ");
                try
                {
                    sum = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    /* Felmeddelande */
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Summan är felaktig! Prova igen");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            if (sum < 1)
            {
                /* Felmeddelande */
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Summan är för litet! Köpet kunde inte genomföras.");
                Console.ResetColor();
                Console.WriteLine();

            }
            else
            {

                /* Ny While-loop, denna gången kollas det erhållna beloppet */
                while (true)
                {
                    Console.Write("Ange erhållet belopp:     ");
                    try
                    {
                        receivedAmount = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        /* Felmeddelande */
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Det erhållna beloppet är felaktigt! Prova igen");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
                if (receivedAmount < sum)
                {
                    /* Felmeddelande */
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Det erhållna beloppet är för litet! Köpet kunde inte genomföras.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    toPay = (int)sum;
                    double Rounding = Math.Round(sum, 0) - sum;

                    /* Antalet av varje valör räknas ut där den nästgående tar bort den förgående ur ekvationen */
                    returnAmount = receivedAmount - (int)sum;
                    returnFivehundred = returnAmount / 500;
                    returnHundred = (returnAmount - returnFivehundred * 500) / 100;
                    returnTwenty = (returnAmount - returnFivehundred * 500 - returnHundred * 100) / 20;
                    returnFive = (returnAmount - returnFivehundred * 500 - returnHundred * 100 - returnTwenty * 20) / 5;
                    returnOne = (returnAmount - returnFivehundred * 500 - returnHundred * 100 - returnTwenty * 20 - returnFive * 5) / 1;

                    /* Kvittot skrivs ut */
                    Console.WriteLine("KVITTO");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Totalt           :               {0, 10:c}", sum);
                    Console.WriteLine("Öresavrundning   :               {0, 10:c}", Rounding);
                    Console.WriteLine("Att betala       :               {0, 10:c0}", toPay);
                    Console.WriteLine("Kontant          :               {0, 10:c0}", receivedAmount);
                    Console.WriteLine("Tillbaka         :               {0, 10:c0}", returnAmount);
                    Console.WriteLine("-------------------------------------------");

                    /* Antalet valörer skrivs ut om dom överstiger 0 */
                    if (returnFivehundred > 0)
                    {
                        Console.WriteLine("500-lappar       : {0}", returnFivehundred);
                    }
                    if (returnHundred > 0)
                    {
                        Console.WriteLine("100-lappar       : {0}", returnHundred);
                    }
                    if (returnTwenty > 0)
                    {
                        Console.WriteLine("20-lappar        : {0}", returnTwenty);
                    }
                    if (returnFive > 0)
                    {
                        Console.WriteLine("5-kronor         : {0}", returnFive);
                    }
                    if (returnOne > 0)
                    {
                        Console.WriteLine("1-kronor         : {0}", returnOne);
                    }
                }

            }
        }





    }
}

