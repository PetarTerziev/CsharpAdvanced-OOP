using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MuseElf museElf = new MuseElf("Pesho", 100);
            SoulMaster soulMaster = new SoulMaster("Boiko Borisov", 100);
            BladeKnight bladeKnight = new BladeKnight("Gosho", 150);

            Wizard wizard = new Wizard("Svetlon Nakov", 1500);
            Knight knight = new Knight("Viktor", 1000);

            Console.WriteLine(museElf);
            Console.WriteLine(soulMaster);
            Console.WriteLine(bladeKnight);

            Console.WriteLine(wizard);
            Console.WriteLine(knight);

        }
    }
}
