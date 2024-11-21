namespace CacheSimulator.Cache.Selector;

class FIFO : ISelector
{
    public (int, int, int) Select(List<Cell?> cells, int tag, int iteration)
    {
        int index = 0;
        for (int i = 0; i < cells.Count; i++)
        {
            if (cells[i]?.Tag == tag)
                return (i, cells[i].CountUsed, cells[i].LastIterationUsed);
            else if (cells[i] == null)
                return (i, 0, iteration);
            else if (cells[i]?.LastIterationUsed < cells[index]?.LastIterationUsed)
                index = i;
        }
        return (index, 0, iteration);
    }
}
