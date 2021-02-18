using System;
using Lab_1.Types;
using Lab_1.IO;

namespace Lab_1.Menu
{    
    public class Dessert : MenuItem
    {
        ConsoleIO console = new ConsoleIO();
        private TDelivery delivery;
        public Dessert(string name) : base(name)
        { }

        private void ChooseDeliveryTime()
        {
            console.AskAboutDessert();
            switch (Convert.ToInt32(console.ReadAnswer()))
            {
                case 1:
                    delivery = TDelivery.beginning;
                    Cost = 300;
                    break;
                case 2:
                    delivery = TDelivery.end;
                    Cost = 200;
                    break;                
                default:
                    console.ChooseNothing();
                    delivery = TDelivery.end;
                    Cost = 200;
                    break;
            }
        }

        public override void WriteDescription()
        {
            Console.WriteLine($"You choose a dessert called '{Name}' with serving at the {delivery}.\n" +
                              $"That'll be {Cost} money, please.");
        }

        public override void AskClient()
        {
            ChooseDeliveryTime();
        }

        public override void GetHieratchy()
        {            
            console.Write("Menu -> Desserts ");
        }
    }
}
