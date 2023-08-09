using System;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityStu = 1;
            int[] Scoremidterm, Scorefinal, Scoresum;
            string[] Namestudent;

            Console.Write("How many students ? : ");
            quantityStu = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            Namestudent = new string[quantityStu];
            Scoremidterm = new int[quantityStu];
            Scorefinal = new int[quantityStu];
            Scoresum = new int[quantityStu];


            Console.WriteLine("\n:: Student Information ::");

            for (int Yayee = 0; Yayee < quantityStu; Yayee++)
            {
                Console.Write($"\nPlease key student({Yayee + 1} of {quantityStu}) name : ");
                Namestudent[Yayee] = Console.ReadLine();

                Console.Write($"Please key {Namestudent[Yayee]}'s middle score : ");
                Scoremidterm[Yayee] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {Namestudent[Yayee]}'s final score : ");
                Scorefinal[Yayee] = Convert.ToInt32(Console.ReadLine());

                Scoresum[Yayee] = Scoremidterm[Yayee] + Scorefinal[Yayee];
            }

            Console.WriteLine("\n:: List of students and grades ::");
            int Yayee_ = 0;

            while (Yayee_< quantityStu)
            {
                float gradesScore = 0.0f;

                #region 

                if (Scoresum[Yayee_] <= 49) gradesScore = 0f;
                else if (Scoresum[Yayee_] <= 54) gradesScore = 1f;
                else if (Scoresum[Yayee_] <= 59) gradesScore = 1.5f;
                else if (Scoresum[Yayee_] <= 64) gradesScore = 2f;
                else if (Scoresum[Yayee_] <= 69) gradesScore = 2.5f;
                else if (Scoresum[Yayee_] <= 74) gradesScore = 3f;
                else if (Scoresum[Yayee_] <= 79) gradesScore = 3.5f;
                else if (Scoresum[Yayee_] >= 80) gradesScore = 4f;

                #endregion

                Console.WriteLine($"{Yayee_ + 1}. {Namestudent[Yayee_]} have a" +
                                $" total {Scoresum[Yayee_]} score or {gradesScore} grades.");
                Yayee_++;
            } 

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}