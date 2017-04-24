using System;
using Xunit;

using System.Collections.Generic;
using Item = ConsoleApplication.Item;
using Program = ConsoleApplication.Program;

namespace Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth() 
        {
            Assert.True(true);
        }

        //Example test case
        [Fact]
        public void TestAllItems(){

            var app = new Program()
            {
                Items = new List<Item>
                        {
                            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                            new Item
                                {
                                    Name = "Backstage passes to a TAFKAL80ETC concert",
                                    SellIn = 15,
                                    Quality = 20
                                },
                            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                        }

            };

            app.UpdateQuality();

            Assert.True(true);
        }
    }
}
