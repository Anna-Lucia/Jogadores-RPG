namespace jogo.src.Entities
{
    public class Knight: Hero
    {
        public Knight(string Name, int Level, string HeroType, int Mp, int Hp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            
        }
    }
}