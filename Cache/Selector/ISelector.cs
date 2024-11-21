namespace CacheSimulator.Cache.Selector;

interface ISelector
{
    public (int, int, int) Select(List<Cell?> cells, int tag, int iteration);
}
