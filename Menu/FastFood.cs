using System;
using Lab_1.IO;

namespace Lab_1.Menu
{
    public class FastFood : MenuItem
    {
        ConsoleIO console = new ConsoleIO();
        private bool gloves;
        public FastFood(string name) : base(name)
        { }

        private void AskAboutGloves()
        {
            Cost = 400;
            console.AskAboutGloves();
            if (console.ReadAnswer() == "yes")
            {
                PutGloves();
                Cost += 40;
            }
            else
                WithoutGloves();
        }

        private void PutGloves()
        {
            gloves = true;
        }

        private void WithoutGloves()
        {
            gloves = false;
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose a fastfood called '{Name}' " +
                              ((gloves) ? "eating with gloves\n" : ".\n") +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            AskAboutGloves();
        }

        public override void GetHieratchy()
        {
            console.Write("Menu -> FastFood ");
        }
    }
}
