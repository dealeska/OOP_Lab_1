using System;

namespace Lab_1.IO
{
    public class ConsoleIO
    {
        public void AskAboutCake()
        {
            Console.WriteLine("Food to out? (yes/no)");
        }

        public void AskAboutDessert()
        {
            Console.WriteLine("1 - early, 2 - late");
        }

        public void AskAboutGloves()
        {
            Console.WriteLine("Gloves? (yes/no)");
        }

        public void AskAboutTaste()
        {
            Console.WriteLine("1 - chokolate, 2 - vanilla, 3 - strawberry");
        }

        public void AskAboutIce()
        {
            Console.WriteLine("Ice? (yes/no)");
        }

        public void AskAboutSugar()
        {
            Console.WriteLine("Sugar? (yes/no)");
        }

        public void AskAboutCapasity()
        {
            Console.WriteLine("1 - small, 2 - middle, 3 - large.");
        }

        public string ReadAnswer()
        {
            return Console.ReadLine();
        }

        public void ChooseNothing()
        {
            Console.WriteLine("You choose nothing. Ok)");
        }

        public void Write(string hierarchy)
        {
            Console.Write(hierarchy);
        }
    }
}
