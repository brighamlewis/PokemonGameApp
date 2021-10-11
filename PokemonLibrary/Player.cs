using PokemonGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Player : Trainer
    {
        public Starter PlayerStarter { get; set; }
        public Move ActiveMove { get; set; }

        public Player(string name, int hitChance, int block, int maxLife, int life, Starter playerStarter, Move activeMove) : base(name, hitChance, block, life, maxLife)
        {
            PlayerStarter = playerStarter;
            ActiveMove = activeMove;
            switch (PlayerStarter)
            {
                case Starter.Chimchar:
                    HitChance += 10;
                    Block -= 10;
                    
                    break;
                case Starter.Piplup:
                    HitChance += 5;
                    Block += 5;
                    MaxLife -= 5;
                    Life -= 5;
                    break;
                case Starter.Turtwig:
                    MaxLife += 5;
                    Life += 5;
                    Block += 10;
                    HitChance -= 5;
                    break;
            }
        }
        public override string ToString()
        {
            return string.Format($"{Name}\nRace: {PlayerStarter}\nLife: {Life} of {MaxLife}\nActive Move: {ActiveMove}\nHit Chance: {HitChance}%\nBlock Chance: {Block}%");
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(ActiveMove.MinDamage, ActiveMove.MaxDamage + 1);
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + ActiveMove.BonusHitChance;
        }
    }
}
