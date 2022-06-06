using System.Diagnostics;
using TimeComplexity.Algorithms;

namespace TimeComplexity.Tests.Algorithms;
internal class SortAlgorithmTests
{
    List<int> integerList;
    List<int> sortedList;
    Stopwatch stopwatch;

    [SetUp]
    public void Setup()
    {
        integerList = Enumerable.Range(-500, 1001).Reverse().ToList();
        sortedList = Enumerable.Range(-500, 1001).ToList();
        stopwatch = new Stopwatch();
    }

    [Test]
    public void SelectionSort_Should_Return_SortedList()
    {
        Sort_Should_Return_SortedList(SortAlgorithm.SelectionSort);
    }

    private void Sort_Should_Return_SortedList(Func<List<int>, List<int>> sortFunc)
    {
        stopwatch.Start();
        List<int> actualResult = sortFunc(integerList);
        stopwatch.Stop();

        actualResult.Should().Equal(sortedList);
        
        Console.WriteLine($"    N: {integerList.Count}");
        Console.WriteLine($"Steps: {StepCounter.Steps}");
        Console.WriteLine($" Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
}
