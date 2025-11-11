using System;

namespace Bloc1Activitat9
{
    public class Program
    {
        public static void Main()
        {
            //Exercici 5 en proces
            const string Shop = """
                === ÍTEMS DISPONIBLES A LA TENDA ===
                {0}
                """;
            const string ShopData = "\tNom\tNivell mínim\tPoder\tPes (kg)\tCost (€)\tRaresa";
            const string ItemData = "\t{0}\t{1}\t{2}\t{3} kg\t{4} €\t{5}";
            const string OrdinariItem = "Ordinari";
            string[] Objects = { "Espasa", "Escut", "Poció", "Arc" };
            string[] RareItemStatus = { "Comú", "Rar", "Llegendari" };
            const int MaxMinLevel = 11;
            const int MinMinLevel = 1;
            const int MaxPower = 501;
            const int MinPower = 100;
            double[] Weight = { 4.7, 8.2, 0.6, 2.9 };
            double[] Price = { 134.50, 82.30, 15.99, 198.00 };

            Random random = new Random();
            string rare;
            int rareItem; //1 -> true ; 0 -> false
            int rareItemState; //used with the array RareItemStatus to asign a rare cuality to the item
            int level;
            int power;

            Console.WriteLine(Shop, ShopData);
            for (int i = 0; i < Objects.GetLength(0); i++)
            {
                level = random.Next(MinMinLevel, MaxMinLevel);
                power = random.Next(MinPower, MaxPower);
                rareItem = random.Next(0, 2);

                if (rareItem == 1)
                {
                    rareItemState = random.Next(0, RareItemStatus.GetLength(0));
                    rare = RareItemStatus[rareItemState];
                }
                else
                {
                    rare = OrdinariItem;
                }

                Console.WriteLine(ItemData, Objects[i], level, power, Weight[i], Price[i], rare);
            }
        }
    }
}