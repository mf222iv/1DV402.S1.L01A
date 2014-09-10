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

            Console.Write("Ange totalsumma:     ");
            sum = double.Parse(Console.ReadLine());
            Console.Write("Ange erhållet belopp:     ");
            receivedAmount = int.Parse(Console.ReadLine());
            toPay = (int) sum;
            double Rounding = Math.Round(sum, 0) - sum;
            returnAmount = receivedAmount - (int)sum;
            returnFivehundred = returnAmount / 500;
            returnHundred = (returnAmount - returnFivehundred * 500) / 100;
            returnTwenty = (returnAmount - returnFivehundred * 500 - returnHundred * 100) / 20;
            returnFive = (returnAmount - returnFivehundred * 500 - returnHundred * 100 - returnTwenty * 20) / 5;
            returnOne = (returnAmount - returnFivehundred * 500 - returnHundred * 100 - returnTwenty * 20 - returnFive * 5) / 1;


            Console.WriteLine("KVITTO");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Totalt           :               {0, 10:c}", sum);
            Console.WriteLine("Öresavrundning   :               {0, 10:c}", Rounding);
            Console.WriteLine("Att betala       :               {0, 10:c}", toPay);
            Console.WriteLine("Kontant          :               {0, 10:c}", receivedAmount);
            Console.WriteLine("Tillbaka         :               {0, 10:c}", returnAmount);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("500-lappar       : {0}", returnFivehundred);
            Console.WriteLine("100-lappar       : {0}", returnHundred);
            Console.WriteLine("20-lappar        : {0}", returnTwenty);
            Console.WriteLine("5-kronor         : {0}", returnFive);
            Console.WriteLine("1-kronor         : {0}", returnOne);

        }
    }
}
