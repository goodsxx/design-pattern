using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    //单例模式
    public sealed class Singleton
    {
        private static volatile Singleton? instance;
        private static object syncRoot = new();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance ??= new Singleton();
                    }
                }
                return instance;
            }
        }

        public void SomeMethod()
        {
            Console.WriteLine("Some method in singleton instance");
        }
    }
}
