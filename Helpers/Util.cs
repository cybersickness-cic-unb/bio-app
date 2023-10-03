using System;
using System.Collections.Generic;

namespace BC.Resources
{
    public static  class Util
    {
        public static int ConvertToNumericValue(string input)
        {
            Dictionary<string, int> mapping = new Dictionary<string, int>()
            {
                { "none", 0 },
                { "level-1", 1 },
                { "level-2", 2 },
                { "level-3", 3 }
            };

            if (mapping.ContainsKey(input))
                return mapping[input];
            else
                return 0;
        }

        public static string GetTimeStamp(DateTime startTime)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            int seconds = (int)elapsedTime.TotalSeconds;
            int milliseconds = elapsedTime.Milliseconds;

            return ($"{seconds:D2}.{milliseconds:D3}");
        }

    }
}
