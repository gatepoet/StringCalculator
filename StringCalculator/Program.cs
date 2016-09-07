using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            var nums = numbers.Split(',');

            return nums.Sum(Convert.ToInt32);
        }
    }
}
