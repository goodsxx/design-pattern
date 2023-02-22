using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    //工厂模式
    public abstract class Product
    {
        public abstract void Use();
    }
    public class ConcreteProductA : Product
    {
        public override void Use()
        {
            Console.WriteLine("Using ConcreteProductA");
        }
    }

    public class ConcreteProductB : Product
    {
        public override void Use()
        {
            Console.WriteLine("Using ConcreteProductB");
        }
    }

    public abstract class Factory
    {
        public abstract Product CreateProduct();
    }
    public class ConcreteFactoryA : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteFactoryB : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }

}
