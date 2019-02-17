using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewAlgorithms
{
    public class MyImplementatinOfHayStack : IHayStack
    {

        public int[] BuildHay(int size) {

            int[] _arrayInt = new int[size];

            Random _rnd = new Random();
            for (int i = 0; i < _arrayInt.Length; i++)
            {
                _arrayInt[i] = _rnd.Next(1, Int32.MaxValue); // 2,147,483,647            
            }
            return _arrayInt;
        }


        public int GenerateNeedle() {

            Random _rnd = new Random();
            return _rnd.Next(1, Int32.MaxValue);
        }

        public int IndexLocationOfNeedle(int[] hay, int needle)
        {
            throw new NotImplementedException();
        }

        public bool IsNeedleInHay(int[] hay, int needle)
        {
            throw new NotImplementedException();
        }
    }
}
