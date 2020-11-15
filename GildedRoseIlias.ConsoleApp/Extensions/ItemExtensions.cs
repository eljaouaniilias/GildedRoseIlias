using GildedRoseIlias.ConsoleApp.Exceptions;
using GildedRoseIlias.Library;

namespace GildedRoseIlias.ConsoleApp.Extensions
{
    public static class ItemExtensions
    {
        private static int _minQuality = 0;
        private static int _maxQuality = 50;

        public static void UpdateSelf(this Item item)
        {
            switch (item.Name)
            {
                case "+5 Dexterity Vest":
                case "Elixir of the Mongoose":
                    ProcessGenericItem(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    ProcessLegendaryItem(item);
                    break;
                case "Aged Brie":
                    ProcessAgedBrie(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    ProcessBackstagePasses(item);
                    break;
                case "Conjured Mana Cake":
                    ProcessGenericItem(item, true);
                    break;
                default:
                    throw new UnknownItemTypeException(item.Name);
            }
        }

        private static void ProcessGenericItem(Item item, bool conjured = false)
        {
            item.SellIn--;

            var qualityIncrement = -1;

            if (conjured)
            {
                qualityIncrement *= 2;
            }

            if (item.SellIn < 0)
            {
                qualityIncrement *= 2;
            }

            UpdateQuality(item, qualityIncrement);
        }

        private static void ProcessAgedBrie(Item item)
        {
            item.SellIn--;

            var qualityIncrement = 1;

            if (item.SellIn < 0)
            {
                qualityIncrement *= 2;
            }

            UpdateQuality(item, qualityIncrement);
        }

        private static void ProcessLegendaryItem(Item item)
        {
            // do nothing
        }

        private static void ProcessBackstagePasses(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            var qualityIncrement = 1;

            if (item.SellIn <= 5)
            {
                qualityIncrement = 3;
            }
            else if (item.SellIn <= 10)
            {
                qualityIncrement = 2;
            }

            UpdateQuality(item, qualityIncrement);
        }


        private static void UpdateQuality(Item item, int qualityIncrement)
        {
            item.Quality += qualityIncrement;

            if (item.Quality < _minQuality)
            {
                item.Quality = _minQuality;
            }

            if (item.Quality > _maxQuality)
            {
                item.Quality = _maxQuality;
            }
        }
    }
}
