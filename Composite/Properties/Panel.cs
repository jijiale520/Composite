using System;

namespace Composite.Properties
{
    public class Panel : Component
    {
        public Panel(string _name) : base(_name)
        {
            base.name = _name;
        }

        public override void Display()
        {
            Console.WriteLine("面板控件，控件名："+base.GetName());
        }
    }
}