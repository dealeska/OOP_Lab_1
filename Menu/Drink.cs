using System;
using Lab_1.IO;
using Lab_1.Types;

namespace Lab_1.Menu
{

    public class Drink : MenuItem
    {
        ConsoleIO console = new ConsoleIO();
        public TCapacity Capacity { get; set; }

        public Drink(string name) : base(name)
        { 
         
        }

        private void ChooseCapacity()
        {            
            console.AskAboutCapasity();
            switch (Convert.ToInt32(console.ReadAnswer()))
            {
                case 1:
                    Capacity = TCapacity.small;
                    Cost = 200;
                    break;
                case 2:
                    Capacity = TCapacity.middle;
                    Cost = 400;
                    break;
                case 3:
                    Capacity = TCapacity.large;
                    Cost = 600;
                    break;
                default:
                    console.ChooseNothing();
                    Capacity = TCapacity.large;
                    Cost = 600;
                    break;
            }
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose a drink called '{Name}' {Capacity} capacity.\n" +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            ChooseCapacity();
        }

        public override void GetHieratchy()
        {
            console.Write("Menu -> Drinks ");             
        }
    }
}
