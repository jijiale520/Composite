using System;

namespace Composite.Properties
{
    public class Button : Component
    {
        public Button(string _name) : base(_name)
        {
            base.name = _name;
        }

        public override void Display()
        {
            Console.WriteLine("按钮控件 控件名："+base.GetName());
        }
    }
}