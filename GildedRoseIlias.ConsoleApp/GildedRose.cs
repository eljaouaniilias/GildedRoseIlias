using System;
using System.Collections.Generic;
using GildedRoseIlias.ConsoleApp.Extensions;
using GildedRoseIlias.Library;

namespace GildedRoseIlias.ConsoleApp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateSelf();
            }
        }
    }
}
