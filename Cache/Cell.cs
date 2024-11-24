namespace CacheSimulator.Cache;

class Cell
{
    public int Tag { get; set; }
    public int FirstIterationUsed { get; set; }
    public int LastIterationUsed { get; set; }
    public int CountUsed { get; set; }

    public Cell(int tag, int firstIterationUsed, int lastIterationUsed, int countUsed)
    {
        Tag = tag;
        FirstIterationUsed = firstIterationUsed;
        LastIterationUsed = lastIterationUsed;
        CountUsed = countUsed;
    }
}
