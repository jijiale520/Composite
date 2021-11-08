namespace Composite.Properties
{
    public abstract class Component
    {
        protected string name;

        public Component(string _name)
        {
            this.name = _name;
        }

        public string GetName()
        {
            return this.name;
        }

        public abstract void Display();
    }
}