using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewAlgorithms
{
    public class MyImplementatinOfHayStack : IHayStack
    {
        public int[] Hay { get; set; }
        public int Needle { get; set; }
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }

        public MyImplementatinOfHayStack() {

           
            this.LowerBound = 1;
            this.UpperBound = 1000;
            this.Hay = GenerateHay(100,1,1000); //default to 100
            this.Needle = GenerateNeedle(LowerBound, UpperBound);

        }

        public MyImplementatinOfHayStack(int size, int lowerbound, int upperbound) {

            
            this.LowerBound = lowerbound;
            this.UpperBound = upperbound;
            this.Hay = GenerateHay(size, lowerbound, upperbound);
            this.Needle = GenerateNeedle(LowerBound, UpperBound);
        }
     
        public int[] GenerateHay(int size, int lowerbound, int upperbound)
        {
            int[] _arrayInt = new int[size];

            Random _rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < _arrayInt.Length; i++)
            {
                _arrayInt[i] = _rnd.Next(lowerbound, upperbound); // 2,147,483,647            
            }
            return _arrayInt;
        }

        public int GenerateNeedle(int lowerbound, int upperbound) {

            Random _rnd = new Random(Guid.NewGuid().GetHashCode());
            return _rnd.Next(lowerbound, upperbound);
        }

        public int IndexLocationOfNeedle(int[] hay, int needle)
        {
            for (int i = 0; i < hay.Length; i++)
            {
                if (hay[i] == needle) {
                    return i;
                }
            }
            return -1; // -1 is not a valid index therefore not found
        }

        public bool IsNeedleInHay(int[] hay, int needle)
        {
            // simplest and slowest solution is no sorting
            foreach (var item in hay)
            {
                if (item == needle) {
                    return true;                   
                }
            }
            return false;
        }
    }
}
