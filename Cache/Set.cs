using CacheSimulator.Cache.Selector;

namespace CacheSimulator.Cache;

class CacheSet
{
    public List<Cell?> Cells { get; set; }

    private readonly ISelector selector;

    public CacheSet(int associativity, ISelector selector)
    {
        this.selector = selector;
        Cells = new List<Cell?>(associativity);
        for (int i = 0; i < associativity; i++)
            Cells.Add(null);
    }

    public void Remember(int tag, int iteration)
    {
        (int index, int count, int iter) = selector.Select(Cells, tag, iteration);
        Cells[index] = new Cell
        {
            Tag = tag,
            LastIterationUsed = iter,
            CountUsed = count + 1
        };
    }

    public void Print(int setIndex)
    {
        Console.Write($"Set {setIndex}");
        foreach (Cell? cell in Cells)
            Console.Write(
                $" | 0x{cell?.Tag.ToString("x")} {cell?.CountUsed} {cell?.LastIterationUsed}"
            );
        Console.WriteLine();
    }
}
