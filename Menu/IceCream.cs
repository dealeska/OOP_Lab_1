using System;
using Lab_1.Types;
using Lab_1.IO;

namespace Lab_1.Menu
{ 
    public class IceCream : Dessert
    {
        ConsoleIO console = new ConsoleIO();
        private TTaste taste;

        public IceCream(string name) : base(name)
        {
        }

        private void ChooseTaste()
        {
            console.AskAboutTaste();
            switch (Convert.ToInt32(console.ReadAnswer()))
            {
                case 1:
                    taste = TTaste.chokolate;
                    Cost = 200;
                    break;
                case 2:
                    taste = TTaste.vanilla;
                    Cost = 200;
                    break;
                case 3:
                    taste = TTaste.strawberry;
                    Cost = 200;
                    break;
                default:
                    console.ChooseNothing();
                    taste = TTaste.vanilla;
                    Cost = 200;
                    break;
            }
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose an ice-cream dessert called '{Name}' " +
                              $"with {taste} taste.\n" +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            base.AskClient();
            ChooseTaste();
        }

        public override void GetHieratchy()
        {
            base.GetHieratchy();
            console.Write("-> IceCream");
        }
    }
}
