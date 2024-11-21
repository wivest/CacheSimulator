using System.Globalization;
using CacheSimulator.Cache;
using CacheSimulator.Cache.Selector;

const int SETS = 8;
const int ASSOCIATIVITY = 2;
const int BITS_PER_CELL = 4;

var cache = new Cache(SETS, ASSOCIATIVITY, BITS_PER_CELL, new LRU());

while (true)
{
    string? input = Console.ReadLine();
    if (input == null)
        continue;
    uint address = uint.Parse(input[2..], NumberStyles.AllowHexSpecifier);
    cache.Query(address);
    cache.Print();
}
