using System;
using Lab_1.IO;

namespace Lab_1.Menu
{
    public class Cake : Dessert
    {
        ConsoleIO console = new ConsoleIO();
        private bool extraFood;

        public Cake(string name) : base(name)
        {
        }

        private void AskAboutFoodAway()
        {
            ConsoleIO console = new ConsoleIO();
            console.AskAboutCake();            
            if (console.ReadAnswer() == "yes")           
                TakeOut();
            else
                TakeHere();
        }

        private void TakeOut()
        {
            extraFood = true;
        }

        private void TakeHere()
        {
            extraFood = false;
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose a cake dessert called '{Name}' " +
                              ((extraFood) ? "take away.\n" : "take here.\n") +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            base.AskClient();
            AskAboutFoodAway();
        }

        public override void GetHieratchy()
        {
            base.GetHieratchy();
            console.Write("-> Cakes");
        }
    }
}
