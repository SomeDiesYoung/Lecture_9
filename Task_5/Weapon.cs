namespace Task_5;

internal partial class Program
{
    public abstract class Weapon
    {
        public abstract string Name { get; set; }
        public abstract int Damage { get;set; }
        protected Weapon(string name,int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }

        public abstract int GiveDamage();
    }
}