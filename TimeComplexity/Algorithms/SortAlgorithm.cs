using TimeComplexity.Extensions;

namespace TimeComplexity.Algorithms;
public class SortAlgorithm
{
    public static List<int> SelectionSort(List<int> integerList)
    {
        StepCounter.InitialiseSteps();
        List<int> sortedList = integerList.ToList();

        for (int i = 0; i < sortedList.Count; i++)
        {
            int minValue = sortedList[i];
            int minIndex = i;
            for (int j = i + 1; j < sortedList.Count; j++)
            {
                StepCounter.IncrementSteps();
                if (sortedList[j] < minValue)
                {
                    minValue = sortedList[j];
                    minIndex = j;
                }
            }
            sortedList.Swap(i, minIndex);
        }

        return sortedList;
    }
}
