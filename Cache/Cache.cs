using CacheSimulator.Cache.Selector;

namespace CacheSimulator.Cache;

class Cache
{
    public List<CacheSet> Sets { get; set; }
    public readonly byte BitsPerCell;

    private int iteration = 0;

    public Cache(int sets, int associativity, byte bitsPerCell, ISelector selector)
    {
        BitsPerCell = bitsPerCell;
        Sets = new List<CacheSet>(sets);
        for (int i = 0; i < sets; i++)
        {
            Sets.Add(new CacheSet(associativity, selector));
        }
    }

    public void Query(uint address)
    {
        int shift = (int)(address >> BitsPerCell);
        int index = shift % Sets.Count;
        int tag = shift / Sets.Count;

        Sets[index].Remember(tag, iteration);
        iteration++;
    }

    public void Print()
    {
        for (int i = 0; i < Sets.Count; i++)
            Sets[i].Print(i);
    }
}
