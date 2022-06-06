namespace TimeComplexity.Algorithms;
public class SearchAlgorithm
{
    public static int LinearSearch(List<int> values, int item)
    {
        StepCounter.InitialiseSteps();
        for (int i=0; i<values.Count; i++)
        {
            StepCounter.IncrementSteps();
            if (values[i] == item)
                return i;
        }
        return -1;
    }

    public static int BinarySearch(List<int> values, int item)
    {
        StepCounter.InitialiseSteps();
        int startIdx = 0;
        int endIdx = values.Count - 1;
        
        while (startIdx <= endIdx)
        {
            StepCounter.IncrementSteps();
            int midIdx = (startIdx + endIdx) / 2;
            int midValue = values[midIdx];

            if (item > midValue)
                startIdx = midIdx + 1;
            else if (item < midValue)
                endIdx = midIdx - 1;
            else
                return midIdx;
        }

        return -1;
    }
}
