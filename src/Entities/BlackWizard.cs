namespace POO.src.Entities
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;    
            this.HP = HP;
            this.MP = MP;                 
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia ";
        }

        public string Attack(int Bonus)
        { 
            if (Bonus >= 3)
            {
                return this.Name + " Lançou Magia de gelo super efetiva com bonus de +" + Bonus;
            }
            else if(Bonus >= 5)
            {
                return this.Name + " Lançou uma magia raio com força fraca com bonus de +" + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia fogo com força fraca com bonus de +" + Bonus;
            }
    }
}
}