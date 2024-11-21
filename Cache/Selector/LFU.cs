namespace CacheSimulator.Cache.Selector;

class LFU : ISelector
{
    public (int, int, int) Select(List<Cell?> cells, int tag, int iteration)
    {
        int index = 0;
        for (int i = 0; i < cells.Count; i++)
        {
            if (cells[i]?.Tag == tag)
                return (i, cells[i].CountUsed, iteration);
            else if (cells[i] == null)
                return (i, 0, iteration);
            else if (cells[i]?.CountUsed < cells[index]?.CountUsed)
                index = i;
        }
        return (index, 0, iteration);
    }
}
