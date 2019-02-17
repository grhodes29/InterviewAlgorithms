using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            MyImplementatinOfHayStack _hs = new MyImplementatinOfHayStack(10000, 1, 1000);

            bool _Isfound = _hs.IsNeedleInHay(_hs.Hay, _hs.Needle);

            if (_Isfound)
            {

                Console.WriteLine("FOUND IT AT {0}", _hs.IndexLocationOfNeedle(_hs.Hay, _hs.Needle));

            }
            else
            {

                Console.WriteLine("DID NOT FIND IT");
            }

            Console.ReadKey();
        }
    }
}
