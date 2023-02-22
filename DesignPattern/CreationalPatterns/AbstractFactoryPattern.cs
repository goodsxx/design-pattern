using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    //抽象工厂模式

    // 抽象产品类：按钮
    public abstract class Button
    {
        public abstract void Paint();
    }

    // 具体产品类：Windows 按钮
    public class WindowsButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a Windows button.");
        }
    }

    // 具体产品类：MacOS 按钮
    public class MacOSButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a MacOS button.");
        }
    }

    // 抽象产品类：文本框
    public abstract class TextBox
    {
        public abstract void Paint();
    }

    // 具体产品类：Windows 文本框
    public class WindowsTextBox : TextBox
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a Windows text box.");
        }
    }

    // 具体产品类：MacOS 文本框
    public class MacOSTextBox : TextBox
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a MacOS text box.");
        }
    }

    // 抽象工厂类
    public abstract class GUIFactory
    {
        public abstract Button CreateButton();
        public abstract TextBox CreateTextBox();
    }

    // 具体工厂类：Windows 工厂
    public class WindowsFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }

        public override TextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    // 具体工厂类：MacOS 工厂
    public class MacOSFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new MacOSButton();
        }

        public override TextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }

    // 客户端代码
    public class Client
    {
        private GUIFactory factory;

        public Client(GUIFactory factory)
        {
            this.factory = factory;
        }

        public void Paint()
        {
            Button button = factory.CreateButton();
            button.Paint();

            TextBox textBox = factory.CreateTextBox();
            textBox.Paint();
        }
    }

}
