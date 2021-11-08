using Composite.Properties;

namespace Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Container comp = new Container("总文件夹");
            comp.AddControl(new Button("提交"));
            comp.AddControl(new Panel("main"));
            Container comp2 = new Container("二级文件夹");
            comp2.AddControl(new Button("取消"));
            comp.AddControl(comp2);
            comp.Display();
        }
    }
}