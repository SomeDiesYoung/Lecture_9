namespace Task_5;

internal partial class Program
{
    public class Axe : Weapon {
        public Axe(string name, int damage) : base(name, damage) { }

        public override string Name { get;set; }

        public override int Damage { get ; set; }
        //private int m_damage;
        //Random random = new Random();
        //public override int Damage { get => m_damage; set => m_damage = value > 0 ? random.Next(1, 35) : 1 ; }
        public override int GiveDamage()
        { return Damage; }
    }
}