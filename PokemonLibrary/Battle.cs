using PokemonGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Battle
    {
        public static void Attack(Trainer attacker, Trainer defender)
        {
            int diceroll = new Random().Next(1, 101);
            System.Threading.Thread.Sleep(40);
            if (diceroll <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }

        public static void Combat(Player player, EnemyPokemon enemyPokemon)
        {
            //Could use turnary operator to determine initiative
            Attack(player, enemyPokemon);
            if (enemyPokemon.Life > 0)
            {
                Attack(enemyPokemon, player);
            }
        }
    }
}
