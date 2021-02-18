using System;
using Lab_1.IO;

namespace Lab_1.Menu
{
    public class HotDrink : Drink
    {
        ConsoleIO console = new ConsoleIO();
        private bool sugar;
        public HotDrink(string name) : base(name)
        {            
        }
        
        private void AskAboutSugar()
        {            
            console.AskAboutSugar();            
            if (console.ReadAnswer() == "yes")
            {
                AddSugar();
                Cost += 20;
            }
            else
                WithoutSugar();
        }

        private void AddSugar()
        {
            sugar = true;
        }

        private void WithoutSugar()
        {
            sugar = false;
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose a hot drink called '{Name}' {Capacity} capacity " + 
                              ((sugar) ? "with sugar.\n" :".\n") +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            base.AskClient();
            AskAboutSugar();
        }

        public override void GetHieratchy()
        {
            base.GetHieratchy();
            console.Write("-> HotDrinks");
        }
    }
}
