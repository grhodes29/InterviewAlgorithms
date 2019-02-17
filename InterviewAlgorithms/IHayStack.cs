namespace InterviewAlgorithms
{
    public interface IHayStack
    {
        int[] Hay { get; set; } 
        int Needle { get; set; }
        int LowerBound { get; set; }
        int UpperBound { get; set; }

        int[] GenerateHay(int size, int lowerbound, int upperbound);
        int GenerateNeedle(int lowerbound, int upperbound);
        bool IsNeedleInHay(int[] hay, int needle);
        int IndexLocationOfNeedle(int[] hay, int needle);
    }
}