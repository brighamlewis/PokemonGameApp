using PokemonGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class EnemyPokemon : Trainer
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public EnemyPokemon(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description) : base(name, hitChance, block, life, maxLife)
        {
            MaxDamage = MaxDamage;
            Description = description;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\n{(Life == MaxLife ? $"The {Name} is in perfect condition." : Life <= MaxLife * .25 ? $"The {Name} begins to slow and looks in rough shape" : $"The {Name} is beginning to show wounds but is still in good condition.")}");
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
