using System;

namespace Bloc1Activitat9
{
    public class Program
    {
        public static void Main()
        {
            const string MsgMenu = """
                Escull una opció:
                    [1] - Mostrar pokedex
                    [0] - Sortir

                -> 
                """;
            const string MsgOptioNotInMenu = """
                Aquesta opció no es troba en el menu.
                Siusplau, escull una de les opcions que si que hi pots trobar.

                """;
            const string PokedexTitle = "Pokemons de la pokedex atrapats:";
            const string PokemonInfo = "[{0}] - {1}";//0 = position of the pokemon : 1 = name of the pokemon
            const string MsgPokemonToFree = """

                Quin pokemon vols alliberar?
                Introdueix el seu número:

                -> 
                """;
            const string MsgSpaceEmpty = "Aquest espai no conte cap pokemon.";
            const string MsgPokemonFreed = "El pokemon {0} s'ha alliberat";
            const string MsgPokemonNotFound = "No s'ha trobat el pokemon amb número {0}";
            const string MsgPressToContinue = "Prem qualsevol tecla per continuar...";
            const string EmptySpace = "Empty"; //to update the spaces of where the pokemons are freed by the user
            const string MsgExit = "Sortint de la pokedex...";

            string[] pokedex = { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Meowth", "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra" };
            int menuOption = 1;

            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(MsgMenu);
                } while (false == Int32.TryParse(Console.ReadLine(), out menuOption));
                switch (menuOption)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(PokedexTitle);
                            for (int i = 0; i < pokedex.GetLength(0); i++)
                            {
                                Console.WriteLine(PokemonInfo, i, pokedex[i]);
                            }
                            Console.Write(MsgPokemonToFree);
                        } while (false == Int32.TryParse(Console.ReadLine(), out menuOption));

                        if (menuOption < pokedex.GetLength(0))
                        {
                            if (pokedex[menuOption] == "Empty")
                            {
                                Console.WriteLine(MsgSpaceEmpty);
                            }
                            else
                            {
                                Console.WriteLine(MsgPokemonFreed, pokedex[menuOption]);
                                pokedex[menuOption] = EmptySpace;
                            }
                        }
                        else
                        {
                            Console.WriteLine(MsgPokemonNotFound, menuOption);
                        }

                        break;
                    case 0:
                        Console.WriteLine(MsgExit);
                        break;
                    default:
                        Console.WriteLine(MsgOptioNotInMenu);
                        break;
                }
                Console.WriteLine(MsgPressToContinue);
                Console.ReadKey();
            } while (menuOption != 0);
        }
    }
}