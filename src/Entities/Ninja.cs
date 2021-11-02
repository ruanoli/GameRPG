using System;


namespace NarutoRPG.src.Entities
{
    public abstract class Ninja
    {
        public Ninja(string name, int level, string village, string jutsu)
        {
            Name = name;
            Level = level;
            Village = village;
            Jutsu = jutsu;
        }

        public Ninja()
        {

        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Village { get; set; }
        public string Jutsu { get; set; }

        public override string ToString()
        {
            return ($"Ninja: {this.Name}\nLevel: {this.Level}\nVila: {this.Village}\n");
        }

        public virtual string Defense(int attack)
        {
            int level = this.Level;
            if (attack < 60)
            {
                return ($"{this.Name} da {this.Village} defendeu.");
            }
            else
            {
                return ($"{this.Name} sofreu dano!!");
            }
            
        }

        public virtual string Attack()
        {
            return ($"{this.Name} Atacou!!");

        }

        public virtual void Attack(int bonus) //Ataque especial com bônus.
        {
            if(bonus > 50)
            {
                 Console.WriteLine($"{this.Name} lançou um SUPER ataque!! **{bonus} pontos de bônus**");
            }
            else
            {
                Console.WriteLine($"{this.Name} atacou! Bônus de {bonus}");
            }
            
        }
        public void Duelo(int bonus)
        {
            if (bonus >= 100)
            {
                Console.WriteLine($"{this.Name} CARAAAAAAAAAAAACA!!! {bonus} de bônus 😮");
            }
            else
            {
                Console.WriteLine("O oponente vai atacar.");
            }
        }
    }
}
