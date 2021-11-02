using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarutoRPG.src.Entities
{
    /*
     
     */
    public class EvilNinja : Ninja
    {
        public EvilNinja(string name, int level, string village, string jutsu, string jutsuProhibited, int jutsuProhibitedLevel)
        {
            Name = name;
            Level = level;
            Village = village;
            Jutsu = jutsu;
            JutsuProhibited = jutsuProhibited;
            JutsuProhibitedLevel = jutsuProhibitedLevel;
        }

        public string JutsuProhibited { get; set; }
        public int JutsuProhibitedLevel { get; set; }
        public override string Attack()
        {
            return ($"{this.Name} Atacou com o jutsu {this.Jutsu}!!");

        }

        public override string Defense(int attack)
        {
            int level = this.Level;
            if (attack < 50)
            {
                return ($"{this.Name} da {this.Village} defendeu.");
            }
            else
            {
                return ($"{this.Name} sofreu dano!!");
            }
        }

        public override void Attack(int bonus) //Ataque especial com bônus.
        {
            int jutsuProhibitedLevel = this.JutsuProhibitedLevel;
  
            if (bonus > 50 && jutsuProhibitedLevel > 50)
            {
                Console.WriteLine($"{this.Name} lançou um SUPER HÍPER ULTRA MEGA ataque!! **{bonus} pontos de bônus**");
            }
            else if (bonus > 50)
            {
                Console.WriteLine($"{this.Name} lançou um SUPER ataque!! **{bonus} pontos de bônus**");
            }
            else
            {
                Console.WriteLine($"{this.Name} atacou! Bônus de {bonus}");
            }

        }
    }
}
