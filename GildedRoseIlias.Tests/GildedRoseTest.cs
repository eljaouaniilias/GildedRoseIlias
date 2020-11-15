using System.Collections.Generic;
using GildedRoseIlias.ConsoleApp;
using GildedRoseIlias.ConsoleApp.Exceptions;
using GildedRoseIlias.Library;
using NUnit.Framework;

namespace GildedRoseIlias.Tests
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Given_GenericItem_When_NextDay_Then_QualityDropsWithOneAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(19, Items[0].Quality);
        }

        [Test]
        public void Given_GenericItemAndSellInIsZero_When_NextDay_Then_QualityDropsWithTwoAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20}
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(18, Items[0].Quality);
        }

        [Test]
        public void Given_GenericItemAndQualityIsZero_When_NextDay_Then_QualityDropsWithZeroAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0}
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void Given_AgedBrie_When_NextDay_Then_QualityRisesWithOneAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 10}
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(11, Items[0].Quality);
        }

        [Test]
        public void Given_AgedBrieAndSellInIsZero_When_NextDay_Then_QualityRisesWithTwoAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 0, Quality = 10}
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(12, Items[0].Quality);
        }

        [Test]
        public void Given_AgedBrieAndQualityIs50_When_NextDay_Then_QualityRisesWithZeroAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 0, Quality = 50}
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(50, Items[0].Quality);
        }

        [Test]
        public void Given_LegendaryItem_When_NextDay_Then_QualityRisesWithZeroAndSellInDropsWithZero()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(80, Items[0].Quality);
        }

        [Test]
        public void Given_BackstagePassesItem_When_NextDay_Then_QualityRisesWithOneAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 15,
                            Quality = 20
                        },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(14, Items[0].SellIn);
            Assert.AreEqual(21, Items[0].Quality);
        }

        [Test]
        public void Given_BackstagePassesItemAndSellInIsTen_When_NextDay_Then_QualityRisesWithTwoAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 11,
                            Quality = 20
                        },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(10, Items[0].SellIn);
            Assert.AreEqual(22, Items[0].Quality);
        }

        [Test]
        public void Given_BackstagePassesItemAndSellInIsFive_When_NextDay_Then_QualityRisesWithThreeAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 6,
                            Quality = 20
                        },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(5, Items[0].SellIn);
            Assert.AreEqual(23, Items[0].Quality);
        }

        [Test]
        public void Given_BackstagePassesItemAndSellInIsZero_When_NextDay_Then_QualityEqualsZeroAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 0,
                            Quality = 20
                        },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void Given_ConjuredItem_When_NextDay_Then_QualityDropsWithTwoAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                        {
                            Name = "Conjured Mana Cake",
                            SellIn = 10,
                            Quality = 20
                        },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(18, Items[0].Quality);
        }

        [Test]
        public void Given_ConjuredItemAndSellInIsZero_When_NextDay_Then_QualityDropsWithFourAndSellInDropsWithOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                        {
                            Name = "Conjured Mana Cake",
                            SellIn = 0,
                            Quality = 20
                        },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(16, Items[0].Quality);
        }

        [Test]
        public void Given_UnknownItem_When_NextDay_Then_ShouldThrowException()
        {
            Assert.Throws<UnknownItemTypeException>(new TestDelegate(TestUnknownItem));
        }

        private void TestUnknownItem()
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Unknown new item",
                    SellIn = 0,
                    Quality = 20
                },
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
        }
    }
}
