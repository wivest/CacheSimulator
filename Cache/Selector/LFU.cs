namespace CacheSimulator.Cache.Selector;

class LFU : ISelector
{
    public (int, Cell) Select(List<Cell?> cells, int tag, int iteration)
    {
        int index = 0;
        for (int i = 0; i < cells.Count; i++)
        {
            if (cells[i]?.Tag == tag)
                return (
                    i,
                    new Cell(tag, cells[i].FirstIterationUsed, iteration, cells[i].CountUsed + 1)
                );
            else if (cells[i] == null)
                return (i, new Cell(tag, iteration, iteration, 1));
            else if (cells[i]?.CountUsed < cells[index]?.CountUsed)
                index = i;
        }
        return (index, new Cell(tag, iteration, iteration, 1));
    }
}
