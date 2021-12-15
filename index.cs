    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void Main()
            {
                foreach(var item in OneToHundred())
                {
                    Console.WriteLine(item);
                }
            }
            
            public IEnumerable<int> OneToHundred()
            {
                for(var i = 1; i <= 100; i++)
                {
                    yield return i;
                }
            }
        }
    }