using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    // 定义原型类
    abstract class ElectronicProductPrototype
    {
        public string Model { get; set; }
        public abstract ElectronicProductPrototype Clone();
    }

    // 具体原型类1：手机
    class PhonePrototype : ElectronicProductPrototype
    {
        public PhonePrototype(string model)
        {
            Model = model;
        }

        public override ElectronicProductPrototype Clone()
        {
            Console.WriteLine($"Cloning phone model {Model}...");
            return (ElectronicProductPrototype)MemberwiseClone();
        }
    }

    // 具体原型类2：平板电脑
    class TabletPrototype : ElectronicProductPrototype
    {
        public TabletPrototype(string model)
        {
            Model = model;
        }

        public override ElectronicProductPrototype Clone()
        {
            Console.WriteLine($"Cloning tablet model {Model}...");
            return (ElectronicProductPrototype)MemberwiseClone();
        }
    }

}
