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
        (int index, Cell cell) = selector.Select(Cells, tag, iteration);
        Cells[index] = cell;
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
