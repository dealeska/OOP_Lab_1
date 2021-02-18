
namespace Lab_1.Menu
{
    public abstract class MenuItem
    {
        public string Name { get; set; }

        private float cost;
        protected float Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value > 0)
                    cost = value;
                else cost = 0;
            }
        }

        public MenuItem(string name)
        {
            this.Name = name;                    
        }

        public abstract void WriteDescription();
        public abstract void AskClient();
        public abstract void GetHieratchy();
    }
}
