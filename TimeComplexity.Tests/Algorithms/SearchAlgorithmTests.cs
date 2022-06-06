using TimeComplexity.Algorithms;

namespace TimeComplexity.Tests.Algorithms;
internal class SearchAlgorithmTests
{
    List<int> values = new();
    [SetUp]
    public void Setup()
    {
        values = Enumerable.Range(-500, 1001).ToList();
    }

    [Test]
    public void LinearSearch_Should_Return_Index_Of_Match_Item()
    {
        Search_Should_Return_Index_Of_Match_Item(SearchAlgorithm.LinearSearch);
    }

    [Test]
    public void BinarySearch_Should_Return_Index_Of_Match_Item()
    {
        Search_Should_Return_Index_Of_Match_Item(SearchAlgorithm.BinarySearch);
    }

    private void Search_Should_Return_Index_Of_Match_Item(Func<List<int>, int, int> searchFunc)
    {
        List<int> steps = new();
        foreach (var item in values)
        {
            int index = searchFunc(values, item);

            index.Should().NotBe(-1);
            values[index].Should().Be(item);

            steps.Add(StepCounter.Steps);
        }
        
        searchFunc(values, int.MaxValue).Should().Be(-1);
        steps.Add(StepCounter.Steps);

        Console.WriteLine($"                 N: {values.Count}");
        Console.WriteLine($"   Best Case Steps: {steps.Min()}");
        Console.WriteLine($"Average Case Steps: {steps.Average()}");
        Console.WriteLine($"  Worst Case Steps: {steps.Max()}");
    }
}
