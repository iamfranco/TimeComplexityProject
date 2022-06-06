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

    public static List<int> QuickSort(List<int> integerList)
    {
        StepCounter.InitialiseSteps();
        List<int> sortedList = integerList.ToList();
        QuickSort(sortedList, 0, sortedList.Count-1);

        return sortedList;

        void QuickSort(List<int> integerList, int startIdx, int endIdx)
        {
            if (startIdx >= endIdx || startIdx < 0)
                return;

            int p = Partition(integerList, startIdx, endIdx);

            QuickSort(integerList, startIdx, p - 1);
            QuickSort(integerList, p + 1, endIdx);
        }

        int Partition(List<int> integerList, int startIdx, int endIdx)
        {
            int pivot = integerList[endIdx];

            int i = startIdx - 1;

            for (int j = startIdx; j < endIdx; j++)
            {
                StepCounter.IncrementSteps();
                if (integerList[j] <= pivot)
                {
                    i++;
                    integerList.Swap(i, j);
                }
            }
            i++;
            integerList.Swap(i, endIdx);
            return i;
        }
    }
}
