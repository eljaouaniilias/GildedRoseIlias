using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseIlias.ConsoleApp.Exceptions
{
    public class UnknownItemTypeException : Exception
    {
        public UnknownItemTypeException(string itemName) : base($"Item with name {itemName} was not recognized") { }
    }
}
