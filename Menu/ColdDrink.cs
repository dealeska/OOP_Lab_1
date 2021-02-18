using System;
using Lab_1.IO;

namespace Lab_1.Menu
{
    public class ColdDrink : Drink
    {
        ConsoleIO console = new ConsoleIO();
        private bool ice;
        public ColdDrink(string name) : base(name)
        {
        }

        private void AskAboutIce()
        {            
            console.AskAboutIce();            
            if (console.ReadAnswer() == "yes")
                AddIce();
            else
                WithoutIce();
        }

        private void AddIce()
        {
            ice = true;
        }

        private void WithoutIce()
        {
            ice = false;
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose a cold drink called '{Name}' {Capacity} capacity " +
                              ((ice) ? "with ice.\n" : ".\n") +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            base.AskClient();
            AskAboutIce();
        }

        public override void GetHieratchy()
        {
            base.GetHieratchy();
            console.Write("-> ColdDrinks");
        }
    }
}
