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
        [Fact]
        public void TestNormalDegrade(){

            var app = new Program()
            {
                Items = new List<Item>
                        {
                            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                        }

            };

            app.UpdateQuality();

            var item = app.Items.FirstOrDefault();

            Assert.NotNull(item);
            Assert.True(item.Quality.Equals(19));
            Assert.True(item.SellIn.Equals(9));
        }
    }
}
