namespace TimeComplexity;
public class StepCounter
{
    public static int Steps { get; private set; }
    public static void IncrementSteps() => Steps++;
    public static void InitialiseSteps() => Steps = 0;
}
