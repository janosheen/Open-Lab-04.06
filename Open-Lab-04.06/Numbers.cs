using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> arrList = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    arrList.Add(number);
                }
            }
        return arrList.ToArray();
        }
    }
}
