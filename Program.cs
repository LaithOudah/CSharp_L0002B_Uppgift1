/*
 * Author: Laith Oudah
 * Kurs: L0002B
 * LTU: LAIOUD-1
 * UPPGIFT: Inlämningsuppgift 1
 */

using System;

namespace L0002B_Uppgift1

{
    public class Vaxel
    {
        // Enkel och vacker main som tar in en funktion
        static void Main(string[] args)
        {
            CalcVäxel();
        }

        /*
        * Deklarerar de olika valörerna och sätter en getter till de.
        * Använder mig utav get då det är en åtkomst metod/ indexer som retunerar
        * genskapsvärdet eller indexeringselementet
        */

        private int FiveHundredBills { get; }
        private int HundredBills { get; }
        private int FiftyBills { get; }
        private int TwentyBill { get; }
        private int TenCoin { get; }
        private int FiveCoin { get; }
        private int OneCoin { get; }


        // Gör en ny variabel som heter växel.
        // Växel beräknar skillnaden mellan priset och betalningen.
        /*
         * Funktion som beräknar växel
         * Gör en ny variabel som heter växel.
         * Växel beräknar skillnaden mellan priset och betalningen.
         * Returnerar i vilka valörer man får växeln i
         */
        private static void CalcVäxel()
        {
            /*
             * Tar in värdet pris
             * Sparar i var price
            * Konverterar till int från String
             */
            Console.WriteLine("Ange pris: ");
            var price = Convert.ToInt32(Console.ReadLine());

            /*
             * Tar in värdet betalt
             * Sparar i var betalt
             * Konverterar till int från String
             */
            Console.WriteLine("Betalt: ");
            var betalt = Convert.ToInt32(Console.ReadLine());


            var växel = betalt - price;

            // En instance av min funktion som heter Vaxel och tar in det beräknade värdet av växel
            var vaxel = new Vaxel(växel);

            // En if sats som tittar på ifall man har betalat för lite
            if (växel >= 0)
            {
                /*
                 * If-satsen innehåller flera ifsatser som tittar på vöxeln ifall den överstiger 0
                 * Ifall den gör det skriver de ut det annars ingeting.
                 * Ifall detta inte fanns hade de med 0 värde även skrivits ut.
                 */

                if (vaxel.FiveHundredBills > 0)
                {
                    Console.WriteLine($"{vaxel.FiveHundredBills} Femhundralappar");
                }

                if (vaxel.HundredBills > 0)
                {
                    Console.WriteLine($"{vaxel.HundredBills} st Hundralappar");
                }

                if (vaxel.FiftyBills > 0)
                {
                    Console.WriteLine($"{vaxel.FiftyBills} st Femtiolappar");
                }

                if (vaxel.TwentyBill > 0)
                {
                    Console.WriteLine($"{vaxel.TwentyBill} st Tjugiolappar");
                }

                if (vaxel.TenCoin > 0)
                {
                    Console.WriteLine($"{vaxel.TenCoin} st Tiokronor ");
                }

                if (vaxel.FiveCoin > 0)
                {
                    Console.WriteLine($"{vaxel.FiveCoin} st Femkronor");
                }

                if (vaxel.OneCoin > 0)
                {
                    Console.WriteLine($"{vaxel.OneCoin} st Enkroner");
                }

                Console.WriteLine("\nTotalt tillbaka: " + växel + " kr\n");

                Console.Write("\nTotal belopp: " + price + "kr" + "\n");
                Console.Write("Betalt: " + betalt + "kr\n\n");
            }
            else
            {
                Console.WriteLine("\nFör lite betalt. \n");
            }
        }

        /*
         * Funktion tittar på de olika värderna. 
         * Tar in en argument int som kallas för pris
         * Därefter testas det argumentet ifall det är delbart med
         * de olika valörerna och sparar sedan värdet i price
         */
        private Vaxel(int price)
        {
            FiveHundredBills = (price / 500);
            price %= 500;

            HundredBills = (price / 100);
            price %= 100;

            FiftyBills = (price / 50);
            price %= 50;

            TwentyBill = (price / 20);
            price %= 20;

            TenCoin = (price / 10);
            price %= 10;

            FiveCoin = (price / 5);
            price %= 5;

            OneCoin = (price / 1);
            price %= 1;
        } // Private Vaxel
    } // Public Class Vaxel
} // L0002B_Uppgift1