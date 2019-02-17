namespace InterviewAlgorithms
{
    public interface IHayStack
    {
        int[] BuildHay(int size);
        int GenerateNeedle();
        bool IsNeedleInHay(int[] hay, int needle);
        int IndexLocationOfNeedle(int[] hay, int needle);
    }
}