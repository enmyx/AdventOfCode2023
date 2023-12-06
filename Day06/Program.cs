using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "Time:      7  15   30\r\nDistance:  9  40  200";
            var input = "Time:        45     98     83     73\r\nDistance:   295   1734   1278   1210";
            var lines = input.Replace("\r\n", "\n").Split('\n');

            //var times = new List<int>();
            //var distances = new List<int>();
            //var t = lines[0].Split(':')[1].Trim().Replace("  ", " ").Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToList();
            var time = long.Parse(lines[0].Split(':')[1].Trim().Replace(" ", ""));
            //var d = lines[1].Split(':')[1].Trim().Replace("  ", " ").Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToList();
            var distance = long.Parse(lines[1].Split(':')[1].Trim().Replace(" ", ""));
            //for (int i = 0; i < t.Count; i++)
            //{
            //    times.Add(int.Parse(t[i]));
            //    distances.Add(int.Parse(d[i]));
            //}


            long total = 1;
            //for (int i = 0; i < time; i++)
            {
                long wins = 0;
                for (long j = 0; j < time; j++)
                {
                    long remaining = time - j;
                    if (remaining * j > distance)
                        wins++;
                }
                total *= wins;
            }

            Console.WriteLine(total);
        }
    }
}
