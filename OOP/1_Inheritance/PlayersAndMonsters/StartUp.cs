namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BladeKnight turkan = new BladeKnight("Turkan", 20);
            DarkKnight wayne = new DarkKnight("Wayne", 30);
            Knight bruce = new Knight("Bruce", 28);


            SoulMaster harry = new SoulMaster("Harry", 8);
            Wizard gandalf = new Wizard("Gandalf", 30);
            DarkWizard tyler1 = new DarkWizard("Tyler1 the Dark Magician", 40);

            
            MuseElf solar = new MuseElf("Solar", 3);
            Elf legolas = new Elf("Legolas", 29);

            


            
            System.Console.WriteLine(turkan);
            System.Console.WriteLine(wayne);
            System.Console.WriteLine(bruce);

            System.Console.WriteLine(harry);
            System.Console.WriteLine(tyler1);
            System.Console.WriteLine(gandalf);

            System.Console.WriteLine(solar);
            System.Console.WriteLine(legolas);

            DarkKnight arthas = new("Arthas", 30);

            System.Console.WriteLine(arthas);

            



        }
    }
}