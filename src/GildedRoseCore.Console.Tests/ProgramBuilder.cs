using Program = ConsoleApplication.Program;
using Item = ConsoleApplication.Item;
using System.Collections.Generic;

namespace Tests
{

    public class ProgramBuilder : ITestProgramBuilder, ITestProgramBuilderWithNewItem
    {
        private readonly Program _programToBuild;
        private Item _itemToBuild;

        private ProgramBuilder()
        {
            _programToBuild = new Program();
        }

        public static ITestProgramBuilder CreateProgram()
        {
            return new ProgramBuilder();
        }

        public ITestProgramBuilderWithNewItem WithNewItem(string itemName)
        {
            if (_programToBuild.Items == null)
                _programToBuild.Items = new List<Item>();

            _itemToBuild = new Item { Name = itemName };
            _programToBuild.Items.Add(_itemToBuild);

            return this;
        }

        public ITestProgramBuilderWithNewItem ToSellIn(int numberOfDays)
        {
            _itemToBuild.SellIn = numberOfDays;
            return this;
        }

        public ITestProgramBuilderWithNewItem WithQuality(int quality)
        {
            _itemToBuild.Quality = quality;
            return this;
        }

        public Program Build()
        {
            return _programToBuild;
        }
    }

    public interface ITestProgramBuilder
    {
        ITestProgramBuilderWithNewItem WithNewItem(string itemName);
    }

    public interface ITestProgramBuilderWithNewItem
    {
        ITestProgramBuilderWithNewItem ToSellIn(int numberOfDays);
        ITestProgramBuilderWithNewItem WithQuality(int quality);
        Program Build();
    }
}