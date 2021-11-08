using System;
using System.Collections.Generic;

namespace Composite.Properties
{
    public class Container : Component
    {
        private List<Component> controlList;
        public Container(string _name) : base(_name)
        {
            base.name = _name;
            controlList = new List<Component>();
        }

        public void AddControl(Component _control)
        {
            controlList.Add(_control);
        }

        public void RemoveControl(Component _control)
        {
            controlList.Remove(_control);
        }

        public override void Display()
        {
            foreach (var item in controlList)
            {
                item.Display();
            }
        }
    }
}