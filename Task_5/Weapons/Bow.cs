namespace Task_5;

internal partial class Program
{
    public class Bow : Weapon {
        public Bow(string name, int damage) : base(name, damage) { }

        public override string Name { get;set; }
        public override int Damage { get; set; }
        public override int GiveDamage()
        { return Damage; }
    }
}