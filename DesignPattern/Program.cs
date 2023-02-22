using DesignPattern.CreationalPatterns;


#region 单例模式
Console.WriteLine("--单例模式-----------------");
Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;

if (instance1 == instance2)
{
    Console.WriteLine("Singleton works!");
}

instance1.SomeMethod();
#endregion

#region 工厂模式
Console.WriteLine("--工厂模式-----------------");
// 使用 ConcreteFactoryA 来创建 ConcreteProductA
Factory factoryA = new ConcreteFactoryA();
Product productA = factoryA.CreateProduct();
productA.Use();

// 使用 ConcreteFactoryB 来创建 ConcreteProductB
Factory factoryB = new ConcreteFactoryB();
Product productB = factoryB.CreateProduct();
productB.Use();
#endregion

#region 抽象工厂模式
Console.WriteLine("--抽象工厂模式-----------------");
// 使用 Windows 工厂创建控件
GUIFactory windowsFactory = new WindowsFactory();
Client windowsClient = new Client(windowsFactory);
windowsClient.Paint();

// 使用 MacOS 工厂创建控件
GUIFactory macosFactory = new MacOSFactory();
Client macosClient = new Client(macosFactory);
macosClient.Paint();
#endregion

#region 建造者模式
Console.WriteLine("--建造者模式-----------------");
// 创建一个具体的建造者，例如 DesktopBuilder 或 LaptopBuilder
ComputerBuilder desktopBuilder = new DesktopBuilder();

// 创建指挥者并将具体的建造者传递给它
ComputerDirector computerDirector = new ComputerDirector(desktopBuilder);

// 控制创建电脑的流程
computerDirector.ConstructComputer();

// 从具体的建造者中获取创建的电脑产品
Computer computer = desktopBuilder.GetComputer();

// 输出电脑的各个部件
Console.WriteLine("Computer parts: " + computer.GetParts());

Console.WriteLine("优化版本");

// 创建一个具体的建造者，例如 DesktopBuilder2 或 LaptopBuilder2
ComputerBuilder2 laptopBuilder2 = new LaptopBuilder2();

// 创建指挥者并将具体的建造者传递给它
ComputerDirector2 computerDirector2 = new ComputerDirector2();
computerDirector2.Construct(laptopBuilder2, "Laptop CPU", "Laptop Motherboard", "Laptop Memory", "Laptop Memory");

// 从具体的建造者中获取创建的电脑产品
Computer2 computer2 = laptopBuilder2.GetComputer();

// 输出电脑的各个部件
Console.WriteLine("Computer parts: " + computer2.GetParts());
#endregion

#region 原型模式
Console.WriteLine("--原型模式-----------------");
// 创建手机原型
var phonePrototype = new PhonePrototype("iPhone X");

// 克隆手机原型
var clonedPhone1 = phonePrototype.Clone();
Console.WriteLine($"Cloned phone model: {clonedPhone1.Model}");

var clonedPhone2 = phonePrototype.Clone();
Console.WriteLine($"Cloned phone model: {clonedPhone2.Model}");

// 创建平板电脑原型
var tabletPrototype = new TabletPrototype("iPad Pro");

// 克隆平板电脑原型
var clonedTablet1 = tabletPrototype.Clone();
Console.WriteLine($"Cloned tablet model: {clonedTablet1.Model}");

var clonedTablet2 = tabletPrototype.Clone();
Console.WriteLine($"Cloned tablet model: {clonedTablet2.Model}");
#endregion

Console.ReadLine();
