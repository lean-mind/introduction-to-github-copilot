using System.Diagnostics;

namespace TestSortTool;

public class Tests
{
    [Fact]
    public void should_sort_lists()
    {
        var sortTool = new SortTool.SortTool();
        
        var sortedList = sortTool.sortListOfIntegers(new List<int> { 3, 2, 1 });

        Assert.True(IsSorted(sortedList));
    }
    
    [Fact]
    public void should_sort_lists_efficiently()
    {
        var sortTool = new SortTool.SortTool();
        var largeList = GenerateLargeList(20000);

        var stopwatch = Stopwatch.StartNew();
        var sortedList = sortTool.sortListOfIntegers(largeList);
        stopwatch.Stop();

        Assert.True(IsSorted(sortedList), "La lista no está ordenada correctamente.");
        Assert.True(stopwatch.ElapsedMilliseconds < 1000, "El algoritmo de ordenación es demasiado lento.");
    }

    private List<int> GenerateLargeList(int size)
    {
        var random = new Random();
        var list = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            list.Add(random.Next());
        }
        return list;
    }

    private bool IsSorted(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i - 1] > list[i])
            {
                return false;
            }
        }
        return true;
    }
}