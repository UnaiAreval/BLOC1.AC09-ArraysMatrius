using System;

namespace Bloc1Activitat9
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string TroopsTitle = """

                ====TROPES====
                """;
            const string LandTitle = """
                
                ====TERRENY===
                """;
            const string ResourcesTitle = """

                ===RECURSOS===
                """;
            const string LineJump = "\n";
            string[] MapIcons = { "🛡️", "⚔️", "🗼", "🕳️", "🌿", "💎", "➖" };

            string[] troops = new string[10];
            string[,] land = new string[5, 5];
            string[][] resources =
            {
                new string[4],
                new string[2],
                new string[3]
            };

            for (int i = 0; i < troops.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    troops[i] = MapIcons[0];
                }
                else
                {
                    troops[i] = MapIcons[1];
                }
            }

            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        land[i, j] = MapIcons[2];
                    }
                    else if (i % 2 == 1 && j % 2 == 1)
                    {
                        land[i, j] = MapIcons[3];
                    }
                    else
                    {
                        land[i, j] = MapIcons[4];
                    }
                }
            }

            for (int i = 0; i < resources.GetLength(0); i++)
            {
                for (int j = 0; j < resources[i].GetLength(0); j++)
                {
                    if ((i + j) % 2 == 1)
                    {
                        resources[i][j] = MapIcons[5];
                    }
                    else
                    {
                        resources[i][j] = MapIcons[6];
                    }
                }
            }

            Console.WriteLine(TroopsTitle);
            foreach (string troop in troops)
            {
                Console.Write(troop);
            }

            Console.WriteLine(LandTitle);
            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    Console.Write(land[i, j]);
                }
                Console.Write(LineJump);
            }

            Console.WriteLine(ResourcesTitle);
            for (int i = 0; i < resources.GetLength(0); i++)
            {
                foreach (string resourc in resources[i])
                {
                    Console.Write(resourc);
                }
                Console.Write(LineJump);
            }
        }
    }
}