namespace jogo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int Mp, int Hp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            
        }

        public override string Attack()
        {
            return this.Name + "Lançou um golpe";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " " + "Lançou golpe forte com bônus de " + Bonus;
            }else{
                return this.Name + " " + "Lançou golpe fraca com bônus de " + Bonus;
            }
        }

    }
}