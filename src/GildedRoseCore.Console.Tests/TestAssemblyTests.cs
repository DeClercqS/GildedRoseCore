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
        [InlineData("Aged Brie", 2, 0, 1)]
        [InlineData("Elixir of the Mongoose", 5, 7, 6)]
        [InlineData("Sulfuras, Hand of Ragnaros", 0, 80, 80)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 15, 20, 21)]
        [InlineData("Conjured Mana Cake", 3, 6, 5)]

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
