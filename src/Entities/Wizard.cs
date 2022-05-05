namespace jogo.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType, int Mp, int Hp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public override string Attack()
        {
            return this.Name + "Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " " + "Lançou Magia forte com bônus de " + Bonus;
            }else{
                return this.Name + " " + "Lançou Magia fraca com bônus de " + Bonus;
            }
        }
    }
}