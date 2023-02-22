using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    //建造者模式
    #region 优化前
    // 产品类，包含多个部件
    public class Computer
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public string GetParts()
        {
            return string.Join(", ", parts);
        }
    }

    // 抽象建造者，定义创建各个部件的抽象方法
    public abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();

        public abstract void BuildCpu();
        public abstract void BuildMotherboard();
        public abstract void BuildMemory();
        public abstract void BuildHardDrive();

        public Computer GetComputer()
        {
            return computer;
        }
    }

    // 具体建造者，实现创建各个部件的方法
    public class DesktopBuilder : ComputerBuilder
    {
        public override void BuildCpu()
        {
            computer.AddPart("Desktop CPU");
        }

        public override void BuildMotherboard()
        {
            computer.AddPart("Desktop Motherboard");
        }

        public override void BuildMemory()
        {
            computer.AddPart("Desktop Memory");
        }

        public override void BuildHardDrive()
        {
            computer.AddPart("Desktop Hard Drive");
        }
    }

    public class LaptopBuilder : ComputerBuilder
    {
        public override void BuildCpu()
        {
            computer.AddPart("Laptop CPU");
        }

        public override void BuildMotherboard()
        {
            computer.AddPart("Laptop Motherboard");
        }

        public override void BuildMemory()
        {
            computer.AddPart("Laptop Memory");
        }

        public override void BuildHardDrive()
        {
            computer.AddPart("Laptop Hard Drive");
        }
    }

    // 指挥者，控制创建电脑的流程
    public class ComputerDirector
    {
        private ComputerBuilder computerBuilder;

        public ComputerDirector(ComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }

        public void ConstructComputer()
        {
            computerBuilder.BuildCpu();
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildMemory();
            computerBuilder.BuildHardDrive();
        }
    }
    #endregion

    #region 优化后
    // 产品类
    class Computer2
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public string GetParts()
        {
            return string.Join(", ", parts);
        }
    }

    // 抽象建造者类
    abstract class ComputerBuilder2
    {
        protected Computer2 computer = new Computer2();

        public abstract ComputerBuilder2 BuildCpu(string cpu);
        public abstract ComputerBuilder2 BuildMotherboard(string motherboard);
        public abstract ComputerBuilder2 BuildMemory(string memory);
        public abstract ComputerBuilder2 BuildHardDisk(string hardDisk);

        public Computer2 GetComputer()
        {
            return computer;
        }
    }

    // 具体建造者类
    class LaptopBuilder2 : ComputerBuilder2
    {
        public override ComputerBuilder2 BuildCpu(string cpu)
        {
            computer.AddPart(cpu);
            return this;
        }

        public override ComputerBuilder2 BuildMotherboard(string motherboard)
        {
            computer.AddPart(motherboard);
            return this;
        }

        public override ComputerBuilder2 BuildMemory(string memory)
        {
            computer.AddPart(memory);
            return this;
        }

        public override ComputerBuilder2 BuildHardDisk(string hardDisk)
        {
            computer.AddPart(hardDisk);
            return this;
        }
    }

    // 指挥者类
    class ComputerDirector2
    {
        public void Construct(ComputerBuilder2 builder, string cpu, string motherboard, string memory, string hardDisk)
        {
            builder.BuildCpu(cpu)
                .BuildMotherboard(motherboard)
                .BuildMemory(memory)
                .BuildHardDisk(hardDisk);
        }
    }
    #endregion
}
