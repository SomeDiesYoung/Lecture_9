namespace Task_5;

internal partial class Program
{
    public class Character
    {
        public string Name { get; set; }
        public int Health = 100;

        public List<Weapon> Weapons { get; set; }

        public Character(string name, List<Weapon> Weapons)
        {
            this.Name = name;
            this.Weapons = Weapons;
        }
        public virtual void Hit(Weapon weapon, Character target)
        {
            int damage = weapon.GiveDamage();
            target.TakeDamage(damage);
        }
        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health > 0)
            {
                Console.WriteLine($"Warior {Name} your current HP is : {Health}");
            }
            else
            {
                Console.WriteLine("You Died.");
            }
        }
    }
}