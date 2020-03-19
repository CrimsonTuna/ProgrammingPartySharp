using System;
using System.Collections.Generic;

namespace ProgrammingParty
{
    public class SimpleParty : IProgrammingParty
    {
        public void Start(IEnumerable<int> src)
        {

            // ただ表示するだけ
            foreach (int elem in src)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
