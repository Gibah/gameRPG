namespace POO.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;    
            this.HP = HP;
            this.MP = MP;           
        }

        public override string Attack()
        {
            return this.Name + " Ataque com shurikens ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return this.Name + " Ataque com duas espadas +" + Bonus ;    
            }
            else 
            {
                return this.Name + " Ataque com uma espada +" + Bonus ;
            }
             
        }
    }
}