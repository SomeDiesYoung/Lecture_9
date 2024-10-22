using System.Threading.Channels;

namespace Task_5;

internal partial class Program
{
    static void Main()
    {
        List<Weapon> weapons = new List<Weapon>();

        Sword sword = new Sword("excalibur", 5);
        weapons.Add(sword);
        Bow bow = new Bow("Nodens' Arc", 3);
        weapons.Add(bow);
        Axe axe = new Axe("Fyr'alath", 9);
        weapons.Add(axe);

        Character pablo = new Character("Pablito", sword);
        Character miguel = new Character("Miguel", weapons);





        Console.ReadLine();
    }
}