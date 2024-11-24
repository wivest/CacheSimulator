namespace CacheSimulator.Cache.Selector;

interface ISelector
{
    public (int, Cell) Select(List<Cell?> cells, int tag, int iteration);
}
