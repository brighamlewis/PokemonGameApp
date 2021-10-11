using PokemonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Starter starterPokemon = Starter.Piplup;
            string trainerName;
            string rivalName;
            int winCount = 0;

            Console.Title = "Pokemon B";

            Console.WriteLine("Oak: Hello there! Welcome to the world of Pokemon! My name is Oak! People call me the Pokemon Professor! This world is inhabited by creatures called Pokemon! For some people, Pokemon are pets. Others use them for fights. Myself...I study Pokemon as a profession. First, what is your name ?");
            trainerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oak : Right! So your name is " + trainerName + " This is my grandson. He's been your rival since you were a baby. ...Erm, what is his name again?");
            rivalName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oak: That's right! I remember now! His name is " + rivalName + "! " + trainerName + "! Your very own Pokemon legend is about to unfold! A world of dreams and adventures with Pokemon awaits! Let's go!");
            System.Threading.Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("You wake up in your room and look out the window. The sun is high in the sky for it being this early... !!!!!! You look at your alarm clock, YOU ARE LATE! Today is the trainer ceremony where you receive your first pokemon and pokedex! You better get ready and get going so you can make it in time!");
            System.Threading.Thread.Sleep(10000);
            Console.Clear();

            bool bedroomMenu = true;
            Console.WriteLine("You get out of bed and get dressed for the big day.");
            do
            {

                Console.WriteLine($"Now to get to the lab. \n1) Go to the lab\n2) Nintendo Switch\n3) Check PC\n4) Get back in bed \n5) Watch tv\n");
                ConsoleKey bedroomChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (bedroomChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        bedroomMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("You think about playing some unite, but you decide against it as you are late already.");
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine($"You boot up the PC. You browse PokeTwitter but decide to get going instead.");
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("You don't have time for that! As tempting as it is you will just have to settle for a nap later.");
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("It's just the news, theres something about a comet hitting down in a nearby town but you don't get more info than that.");
                        break;


                    default:
                        Console.WriteLine($"{bedroomChoice} was not a valid option. Please choose again.");
                        break;
                }
            } while (bedroomMenu);

            Console.Clear();

            Console.WriteLine("You step out of your home into the rest of twinlead town, You rush to the lab passing " + rivalName + "'s house. You navigate your way around your small village and arrive at the lab, " + rivalName + " stands waiting for you.\n" + rivalName + ": What took you so long? We are already late, don't ruin this for me. Lets go inside.");
            System.Threading.Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine($"As you walk in the proffessor greets you.\nOak:" + trainerName + " and " + rivalName + " its about time you two showed up. Are you two ready to start your journey's to become pokemon masters? Lets get down to business, First things first this is your pokedex. I invented the thing, although there were some early prototypes many years ago. It logs information about pokemon you have seen and caught. Thats why you are here your goal is to complete these pokedexes in order to help me further this research. Here is one for each of you.\nPokedex Received!");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Next to the most important part choosing your very first pokemon! Are you both ready to pick your starting pokemon?");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine(trainerName + ": Of course professor I was born for this.\n" + rivalName + ": Yes let's get this over with so I can show the world my skills");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Oak: Haha! Perfect! Lets get on to it then. There will be three options choose carefully. I'll flip a coin to choose who will choose first. *Flips Coin* Ah " + trainerName + " seems you have won go ahead and choose!");
            System.Threading.Thread.Sleep(10000);
            Console.Clear();



            bool starterMenu = true;
            do
            {

                Console.WriteLine("You see three pokeballs in front of you. They all contain starter pokemon.\n1) Piplup the Penguin Pokemon\n2) Chimchar the Fire Monkey Pokemon\n3) Turtwig the Tiny Leaf Pokemon");
                ConsoleKey starterChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (starterChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine();
                        starterPokemon = Starter.Piplup;
                        Console.WriteLine("\nOak: What a perfect pokemon for you! Looks as if he already likes you!");

                        starterMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        starterPokemon = Starter.Chimchar;
                        Console.WriteLine("\nOak: What a perfect pokemon for you! Looks as if he already likes you!");

                        starterMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        starterPokemon = Starter.Turtwig;
                        Console.WriteLine("\nOak: What a perfect pokemon for you! Looks as if he already likes you!");
                        starterMenu = false;
                        break;

                    default:
                        Console.WriteLine($"{starterChoice} was not a valid option. Please choose again.");
                        break;
                }

            } while (starterMenu);

            

            Move tackle = new Move("Tackle", 0, 1, 4);

            Player player = new Player(trainerName, 60, 10, 50, 50, starterPokemon, tackle);

            bool exit = false;

            do
            {
                Console.WriteLine("As you leave to continue your journey you see:\n");
                Console.WriteLine(Route.GetRoute() + "\n\n");

                EnemyPokemon rattata = new EnemyPokemon("Rattata", 20, 2, 12, 12, 1, 3, "A forest Pokemon, Rattata. It likes cheese, nuts, fruits, and berries. It also comes out into open fields to steal foods from travelers.");

                EnemyPokemon caterpie = new EnemyPokemon("Caterpie", 40, 10, 8, 8, 1, 4, "Caterpie, the Worm Pokémon. Caterpie uses the suction cups on its feet to climb trees and feed on its favorite leaves.");

                EnemyPokemon pidgey = new EnemyPokemon("Pidgey", 50, 5, 6, 6, 1, 2, "Pidgey, the Tiny Bird Pokémon. Pidgey usually doesn't like to battle, but it won't hesitate to attack if provoked.");

                EnemyPokemon metapod = new EnemyPokemon("Metapod", 30, 30, 3, 3, 1, 2, "A steel-hard shell protects its tender body. It quietly endures hardships while awaiting evolution.");

                EnemyPokemon poochyena = new EnemyPokemon("Poochyena", 35, 10, 6, 6, 1, 5, "Poochyena, the Bite Pokémon. Poochyena is the pre-evolved form of Mightyena. Its biting strength is superior to other Pokémon, and has the endurance to chase opponents down until completely exhausted.");

                EnemyPokemon butterfree = new EnemyPokemon("Butterfree", 40, 20, 10, 10, 1, 6, "Butterfree has a superior ability to search for delicious honey from flowers. It can even search out, extract, and carry honey from flowers that are blooming over six miles from its nest.");

                EnemyPokemon[] wildPokemon =
                {
                    rattata, rattata, rattata, caterpie, pidgey, caterpie, caterpie, metapod, metapod, rattata, rattata, pidgey, poochyena, butterfree
                };

                //Random rand = new Random();
                //int index = rand.Next(monsters.Length);
                //Monster monster = monsters[index];
                System.Threading.Thread.Sleep(1000);
                EnemyPokemon enemyPokemon = wildPokemon[(new Random()).Next(wildPokemon.Length)];
                Console.WriteLine("In the tall grass you see a(n) " + enemyPokemon.Name + "!\n");

                bool reload = false;

                do
                {
                    Console.Title = $"{player.Name} Life: {player.Life} Battles Won: {winCount}";
                    Console.WriteLine("Choose your action:\n" +
                        "A)ttack\n" +
                        "F)lee\n" +
                        "V)iew Stats\n" +
                        "W)ild Pokemon Stats");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Battle.Combat(player, enemyPokemon);
                            if (enemyPokemon.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                //Monster death action for us get new room
                                Console.WriteLine($"The {enemyPokemon.Name} fainted!");
                                Console.ResetColor();
                                Console.WriteLine("You move on to the next area.");
                                reload = true;
                                System.Threading.Thread.Sleep(2000);
                                winCount++;
                            }
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine("Run away....");
                            Console.WriteLine($"The {enemyPokemon.Name} attacks you as you turn to flee!");
                            Battle.Attack(enemyPokemon, player);
                            reload = true;
                            break;
                        case ConsoleKey.V:
                            Console.WriteLine(player + "\n");
                            break;
                        case ConsoleKey.W:
                            Console.WriteLine(enemyPokemon + "\n");
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("You run back home, the professors mission was too much for you.");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("You have chosen an invalid option.");
                            break;
                    }

                    if (player.Life < 1)
                    {
                        Console.WriteLine($"Your {starterPokemon} faints! You panic and white out as you hurriedly take your pokemon to a pokecenter. {enemyPokemon.Name} was too strong!");
                        exit = true;
                    }

                } while (!reload && !exit);


            } while (!exit);

            Console.WriteLine("GAME OVER!");

        }
    }
}

