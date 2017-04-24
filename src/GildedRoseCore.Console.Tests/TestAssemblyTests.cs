using System;
using Xunit;
using System.Linq;

using System.Collections.Generic;
using Item = ConsoleApplication.Item;
using Program = ConsoleApplication.Program;

namespace Tests
{
    public class TestAssemblyTests
    {
        [Theory]
        [InlineData("+5 Dexterity Vest", 10, 20, 19)]
        public void TestAllItems(String itemName, int sellIn, int quality, int expectedQuality)
        {
            var app = getAppInstanceWithItem(new Item {Name = "", SellIn = 10, Quality = 20});

            app.UpdateQuality();

            var item = app.Items.FirstOrDefault();

            int expectedSellIn = sellIn > 0 ? sellIn - 1 : 0;

            Assert.NotNull(item);
            Assert.True(item.Quality.Equals(expectedQuality));
            Assert.True(item.SellIn.Equals(expectedSellIn));
        }

        private Program getAppInstanceWithItem(Item item){
            var app = new Program()
            {
                Items = new List<Item> { item }
            };

            return app;
        }
    }
}
