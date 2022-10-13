using System;
using System.Linq;
using System.Threading;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }

            }
            int[] result = new int[count];
            int countArr = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result[countArr] = number;
                    countArr++;
                }


            }
            return result; 
        }
    }
}