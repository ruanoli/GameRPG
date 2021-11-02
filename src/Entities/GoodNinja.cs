using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarutoRPG.src.Entities
{
    class GoodNinja : Ninja
    {
        public GoodNinja(string name, int level, string village, string jutsu)
        {
            Name = name;
            Level = level;
            Village = village;
            Jutsu = jutsu;
        }

        public override string Attack()
        {
            int levelNinja = this.Level;
            if (levelNinja > 500)
            {
                return ($"{this.Name} da {this.Village} deu um SUPER ataque com o jutsu {this.Jutsu}!!");
            }
            else
            {
                return ($"{this.Name} da {this.Village} atacou com o jutsu {this.Jutsu}!!");
            }
        }

        public override string Defense(int attack)
        {
            int level = this.Level;
            if (attack < 70)
            {
                return ($"{this.Name} da {this.Village} defendeu.");
            }
            else
            {
                return ($"{this.Name} sofreu dano!!");
            }
        }
    }
}
