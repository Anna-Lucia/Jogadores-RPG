namespace jogo.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;         
        }

        public Hero ()
        {
        }

        public string Name;
        public int Level;

        public string HeroType;

        public int Mp;

        public int Hp;


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Hp + " " + this.Mp;
        }

        public virtual string Attack()
        {
            return this.Name + " " + "Atacou com a sua espada";
        }
        
    }
}