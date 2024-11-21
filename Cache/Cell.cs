namespace CacheSimulator.Cache;

class Cell
{
    public int Tag { get; set; }
    public int LastIterationUsed { get; set; }
    public int CountUsed { get; set; }
}
