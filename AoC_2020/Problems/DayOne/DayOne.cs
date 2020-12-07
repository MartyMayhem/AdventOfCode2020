using System;
using System.Collections.Generic;
using System.Text;

namespace AoC_2020.Problems.DayOne
{

   
    public static class DayOne
    {
        public static long LargestMultipledValue { get; set; }
        public static long MultipliedTwoValues(string[] lines)
        {
            LargestMultipledValue = 0;
            
            for(var i = 0; i<lines.Length; i++)
            {
                for(var j = i+1; j<lines.Length; j++)
                {
                    if(long.Parse(lines[j]) + long.Parse(lines[i]) == 2020)
                    {
                        long multipledValue = long.Parse(lines[j]) * long.Parse(lines[i]);
                        if(multipledValue > LargestMultipledValue)
                        {
                            LargestMultipledValue = multipledValue;
                        }
                    }

                }

            }
            return LargestMultipledValue;
        }
        public static long MultipliedThreeValues(string[] lines)
        {
            LargestMultipledValue = 0;

            for (var i = 0; i < lines.Length; i++)
            {
                for (var j = i + 1; j < lines.Length; j++)
                {
                    for(var k = j+1; k<lines.Length; k++)
                    {
                        if (long.Parse(lines[j]) + long.Parse(lines[i]) + long.Parse(lines[k]) == 2020)
                        {
                            long multipledValue = long.Parse(lines[j]) * long.Parse(lines[i]) * long.Parse(lines[k]);
                            if (multipledValue > LargestMultipledValue)
                            {
                                LargestMultipledValue = multipledValue;
                            }
                        }

                    }
                }

            }
            return LargestMultipledValue;
        }
    }
}
