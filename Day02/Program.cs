﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

            var input = "Game 1: 7 green, 14 red, 5 blue; 8 red, 4 green; 6 green, 18 red, 9 blue\r\nGame 2: 3 blue, 15 red, 5 green; 1 blue, 14 red, 5 green; 11 red; 4 green, 1 blue, 3 red; 4 green, 1 blue; 10 red, 1 green\r\nGame 3: 11 green, 3 red; 4 green, 15 blue; 14 blue, 2 red, 10 green; 1 red, 3 green, 10 blue\r\nGame 4: 1 green, 6 red, 11 blue; 3 blue, 12 red; 1 green, 14 red, 8 blue; 3 blue, 7 red; 8 blue, 5 red; 7 red, 1 green\r\nGame 5: 14 green, 3 red, 3 blue; 2 red, 1 green, 1 blue; 8 green, 3 blue, 1 red; 15 green, 8 blue, 1 red\r\nGame 6: 4 blue, 8 green, 5 red; 9 green, 10 blue, 7 red; 11 blue, 10 red, 7 green; 8 red, 6 blue, 9 green\r\nGame 7: 5 green, 11 blue, 9 red; 2 green, 6 red, 12 blue; 8 red, 4 blue, 3 green; 7 green, 8 red, 9 blue; 8 green, 5 red\r\nGame 8: 7 red, 12 green; 9 blue, 15 red, 8 green; 3 blue, 11 green, 6 red; 8 blue, 12 red, 5 green\r\nGame 9: 8 blue, 6 red, 7 green; 2 blue, 3 red, 10 green; 10 blue, 6 red, 7 green; 11 red, 7 blue, 5 green; 10 red, 11 green\r\nGame 10: 5 red, 14 green; 2 red, 6 blue, 15 green; 3 red, 4 blue, 7 green; 6 red, 1 green, 4 blue\r\nGame 11: 4 blue, 11 green, 6 red; 12 red, 1 blue, 5 green; 7 red, 1 blue; 11 red, 2 green, 3 blue; 2 blue, 6 red, 7 green\r\nGame 12: 1 green, 8 red, 3 blue; 3 green, 2 red; 2 blue, 5 red, 1 green\r\nGame 13: 2 green; 8 green, 1 blue, 12 red; 1 blue, 14 green, 2 red; 1 blue, 6 red, 6 green; 7 green, 10 red\r\nGame 14: 9 green, 4 red, 1 blue; 5 red, 2 green; 17 green, 1 red; 6 red, 10 green; 4 green, 3 red, 1 blue\r\nGame 15: 7 green, 13 blue, 4 red; 1 blue, 7 green, 9 red; 13 blue, 13 red, 7 green; 8 red, 9 blue; 9 red, 14 blue; 2 green, 7 red, 9 blue\r\nGame 16: 6 green, 18 blue, 6 red; 5 green, 2 blue, 2 red; 6 green, 2 red, 17 blue; 2 red, 2 green, 8 blue; 2 red, 10 blue\r\nGame 17: 17 red, 8 green; 4 blue, 10 green, 3 red; 8 red, 5 green, 3 blue; 12 green, 3 red\r\nGame 18: 6 red, 1 green, 14 blue; 1 red, 10 blue, 1 green; 1 red, 17 blue, 1 green; 5 red, 1 blue; 5 red, 18 blue; 2 red, 3 blue\r\nGame 19: 5 blue, 12 red; 6 blue, 3 red, 6 green; 8 blue, 6 red, 6 green; 8 green, 8 blue, 2 red; 4 green, 6 red, 6 blue; 1 green, 3 red, 13 blue\r\nGame 20: 7 green, 2 blue; 4 blue, 12 red, 2 green; 7 red, 2 green, 6 blue\r\nGame 21: 8 green, 1 red; 1 red, 9 green; 1 red, 6 green, 4 blue; 1 red, 3 green, 5 blue; 2 red, 6 green\r\nGame 22: 11 green, 12 red, 5 blue; 5 blue, 9 red, 11 green; 8 green, 4 red, 5 blue; 7 green, 1 blue, 1 red\r\nGame 23: 11 blue, 9 red, 5 green; 3 green, 3 blue; 11 blue, 9 red, 1 green; 2 red, 7 green; 4 green, 3 blue, 1 red; 5 green, 4 blue\r\nGame 24: 1 green, 4 blue, 9 red; 1 green, 2 blue, 11 red; 1 green, 13 red; 1 green, 2 blue, 3 red\r\nGame 25: 1 red, 7 green, 4 blue; 2 red, 1 green, 3 blue; 10 blue, 1 red; 7 blue, 2 red, 6 green; 7 green, 15 blue, 2 red; 14 green, 13 blue\r\nGame 26: 5 red, 2 blue; 9 red, 2 green, 12 blue; 15 red, 1 green, 5 blue; 1 green, 16 blue, 17 red\r\nGame 27: 2 green, 4 red; 4 red, 1 green; 1 blue, 3 red; 2 red\r\nGame 28: 3 green; 8 green, 9 red; 9 red, 3 blue, 10 green; 16 green, 4 blue, 4 red\r\nGame 29: 3 green, 1 red, 7 blue; 5 blue, 5 green, 2 red; 5 blue, 6 green, 2 red; 2 green, 2 red, 4 blue; 1 green, 3 red, 8 blue\r\nGame 30: 7 red, 3 green, 7 blue; 3 green, 10 red; 5 red, 5 blue, 1 green; 9 blue, 2 green, 7 red; 1 red, 10 blue; 10 blue, 2 red, 4 green\r\nGame 31: 9 green, 1 red; 9 blue, 6 red, 9 green; 17 blue, 4 green, 10 red; 19 blue, 11 green\r\nGame 32: 1 red, 1 blue, 6 green; 10 blue, 4 green; 1 red, 5 blue; 9 blue, 3 green\r\nGame 33: 4 red; 3 red; 2 red, 1 green, 1 blue; 1 green; 1 blue, 1 red\r\nGame 34: 2 green, 9 blue, 1 red; 5 blue, 7 green, 1 red; 2 green, 1 red, 16 blue; 1 blue, 5 green, 6 red\r\nGame 35: 11 red, 10 blue; 2 blue, 12 green, 12 red; 3 green, 6 red, 6 blue; 14 blue, 10 green, 1 red\r\nGame 36: 2 blue, 3 red, 15 green; 2 blue, 6 green, 2 red; 14 blue, 4 red, 7 green; 13 blue, 12 green, 2 red\r\nGame 37: 6 green, 14 blue, 7 red; 7 blue, 2 red, 6 green; 1 blue, 2 green, 6 red\r\nGame 38: 2 green, 15 red, 2 blue; 14 red, 1 blue; 14 red, 2 green, 12 blue\r\nGame 39: 5 green, 1 blue, 10 red; 4 red, 3 blue, 7 green; 2 red, 2 green, 4 blue; 10 blue, 5 green\r\nGame 40: 7 red, 10 green, 2 blue; 7 green, 3 red, 2 blue; 10 red, 9 blue, 7 green; 3 green, 5 blue, 10 red\r\nGame 41: 5 blue, 2 green, 11 red; 2 green, 18 red, 3 blue; 8 green, 10 red, 1 blue; 16 red, 13 green; 17 green, 2 blue, 17 red; 1 green, 1 blue, 9 red\r\nGame 42: 5 red, 2 green, 1 blue; 6 red, 2 blue; 3 red, 1 blue; 9 red, 5 blue; 1 green, 8 red, 1 blue\r\nGame 43: 1 red, 2 green; 12 red, 4 green, 5 blue; 4 blue, 9 red; 4 green, 10 red, 2 blue\r\nGame 44: 2 blue, 9 green, 3 red; 6 red, 4 blue, 4 green; 3 red, 4 blue; 5 red, 2 green, 1 blue; 4 blue, 1 green; 8 green, 1 red, 4 blue\r\nGame 45: 7 blue, 1 red; 2 red, 4 green, 9 blue; 3 red, 15 blue; 4 red, 4 green, 12 blue; 1 red, 18 blue\r\nGame 46: 4 red, 14 blue, 11 green; 5 blue, 6 red, 17 green; 10 red, 8 green, 17 blue; 7 red, 10 blue, 19 green\r\nGame 47: 7 blue, 3 red; 7 blue, 1 green, 2 red; 2 red, 6 blue; 1 green, 9 blue, 2 red; 3 red; 2 green, 1 blue\r\nGame 48: 12 red, 6 blue, 6 green; 9 green, 19 red, 1 blue; 2 blue, 12 green, 8 red\r\nGame 49: 1 green, 11 red, 11 blue; 10 red, 10 blue, 11 green; 4 red, 19 green, 6 blue; 11 blue, 19 green, 13 red; 9 green, 9 blue\r\nGame 50: 1 blue, 12 green, 4 red; 1 blue, 18 green, 1 red; 1 blue, 12 green, 3 red; 1 blue, 4 green\r\nGame 51: 10 red, 5 blue, 1 green; 10 red, 4 blue; 6 red, 8 blue\r\nGame 52: 1 blue; 5 green, 9 red; 2 blue, 1 green, 11 red; 2 blue, 13 red, 5 green; 6 green, 1 blue, 9 red\r\nGame 53: 8 blue, 15 red; 2 green, 4 red, 12 blue; 6 blue, 1 green, 15 red; 20 red, 12 blue; 6 red, 1 green, 2 blue\r\nGame 54: 5 red, 16 blue; 5 green, 3 red, 17 blue; 5 red, 3 blue, 5 green; 4 green, 6 blue, 9 red; 2 blue, 6 green, 2 red\r\nGame 55: 1 blue, 1 red; 1 green, 1 red, 3 blue; 4 blue, 1 green, 1 red; 5 blue; 2 blue\r\nGame 56: 4 red, 4 blue; 7 blue, 11 red; 1 red, 2 green, 9 blue; 4 blue, 16 red, 2 green; 1 red; 2 green, 5 blue, 1 red\r\nGame 57: 1 green, 8 blue; 1 red; 10 blue, 5 green; 3 blue, 4 green; 11 blue, 1 red; 4 blue, 3 green, 1 red\r\nGame 58: 8 green, 5 blue; 9 blue, 8 red, 5 green; 6 red, 6 blue, 9 green; 1 green, 5 blue, 2 red; 3 red, 3 green, 2 blue; 2 green, 1 red, 1 blue\r\nGame 59: 15 red, 4 blue, 8 green; 12 red, 6 green; 3 red\r\nGame 60: 14 blue, 11 red; 12 blue, 6 red; 11 blue, 6 red; 5 red, 13 blue; 15 blue; 1 green, 1 blue, 16 red\r\nGame 61: 5 red, 1 green; 4 red, 9 green; 1 blue, 6 green, 14 red\r\nGame 62: 19 red, 1 green; 1 blue, 3 red; 15 red, 1 blue; 1 blue, 3 red; 5 red, 1 green, 1 blue\r\nGame 63: 1 red, 3 green, 10 blue; 2 green, 1 red, 14 blue; 1 green, 5 blue, 1 red; 6 blue, 4 green, 1 red\r\nGame 64: 5 red, 2 green; 5 green, 2 red, 2 blue; 3 red, 3 blue, 1 green; 3 blue, 3 green, 3 red; 1 green, 3 red\r\nGame 65: 13 red, 2 green, 3 blue; 1 red, 2 blue, 1 green; 1 blue; 2 green, 1 red\r\nGame 66: 7 red, 12 blue, 6 green; 2 red, 5 green, 11 blue; 3 green, 2 blue, 2 red; 9 blue, 1 red, 2 green\r\nGame 67: 4 red, 3 green, 7 blue; 8 blue, 3 red; 2 red; 9 blue, 5 red, 2 green\r\nGame 68: 12 blue; 10 green, 5 blue; 8 blue; 9 blue, 7 red, 18 green; 5 red, 12 blue, 8 green; 8 green, 13 red, 10 blue\r\nGame 69: 1 green, 1 red; 2 red, 1 green, 3 blue; 1 red, 1 green, 4 blue; 1 green, 8 red\r\nGame 70: 12 green, 1 blue, 4 red; 8 green, 1 red; 1 blue, 8 green; 2 green, 3 red; 5 green, 4 red; 2 blue, 12 green, 1 red\r\nGame 71: 10 blue, 4 red, 14 green; 6 green, 7 red, 8 blue; 1 red, 1 blue, 13 green; 10 red, 6 blue, 3 green; 8 blue, 7 green, 4 red\r\nGame 72: 1 green; 1 blue, 12 green, 14 red; 3 blue, 7 green, 8 red; 12 red, 18 green; 13 green, 11 red, 1 blue; 2 blue, 6 green, 6 red\r\nGame 73: 17 red, 3 green, 15 blue; 15 blue, 2 red; 15 red, 7 blue, 4 green; 9 blue, 1 green, 18 red\r\nGame 74: 10 red, 2 blue; 1 blue, 7 red; 5 blue, 2 green, 2 red; 3 blue, 15 red, 3 green; 4 blue, 3 green, 13 red\r\nGame 75: 6 blue, 10 red; 2 green, 2 blue, 10 red; 10 green, 1 blue, 10 red; 4 blue, 6 red, 11 green\r\nGame 76: 10 blue, 1 red, 2 green; 6 blue, 2 green, 10 red; 3 red, 15 green, 1 blue\r\nGame 77: 5 green, 1 red; 2 blue, 1 green; 13 green, 2 red, 5 blue; 12 green, 1 blue, 2 red; 3 blue, 2 green, 2 red\r\nGame 78: 1 green, 16 red; 6 red, 1 blue, 1 green; 13 red; 12 red, 3 green; 1 blue, 7 red\r\nGame 79: 3 green, 7 blue; 1 red, 8 blue, 5 green; 1 red, 6 green, 7 blue; 11 green, 1 red, 7 blue; 1 blue\r\nGame 80: 3 green, 13 red, 8 blue; 17 red, 9 blue; 7 blue, 1 green, 2 red; 8 red, 6 blue, 3 green; 1 red, 2 blue; 2 green, 4 blue, 10 red\r\nGame 81: 3 red, 1 green, 7 blue; 2 green, 2 blue, 3 red; 3 red, 1 blue, 7 green; 6 green, 12 blue\r\nGame 82: 11 red, 3 green, 2 blue; 3 red, 1 green, 1 blue; 16 red, 1 green\r\nGame 83: 8 green, 3 blue, 2 red; 1 blue, 13 green, 6 red; 4 blue, 5 red, 1 green; 12 green, 4 red, 12 blue; 17 green, 7 blue, 3 red\r\nGame 84: 2 blue, 13 red, 5 green; 3 green, 3 blue, 19 red; 2 red, 11 green, 5 blue; 3 green, 3 blue, 15 red; 7 green, 4 blue, 11 red; 1 red, 10 green\r\nGame 85: 1 red, 3 blue, 4 green; 2 red, 11 green, 2 blue; 2 blue, 7 green, 1 red\r\nGame 86: 3 blue, 4 green, 8 red; 4 green, 2 red; 9 red, 4 blue, 1 green; 18 red, 1 blue\r\nGame 87: 3 red, 14 blue, 1 green; 10 blue, 1 green; 1 green, 4 red, 14 blue; 8 blue, 7 green, 4 red; 2 green, 7 red, 7 blue; 2 green, 10 blue\r\nGame 88: 12 green, 6 red; 6 red, 3 blue, 2 green; 4 red, 4 blue, 9 green; 3 red, 4 green, 8 blue; 1 blue, 3 red\r\nGame 89: 3 green, 3 red, 2 blue; 3 red, 2 green, 1 blue; 6 green, 4 blue, 12 red; 13 red, 14 blue, 1 green; 5 red; 10 red, 8 blue, 7 green\r\nGame 90: 7 green, 10 blue; 6 green, 1 red, 2 blue; 6 blue; 5 green, 9 blue, 1 red; 10 blue, 1 red, 6 green\r\nGame 91: 6 red, 2 blue; 3 blue, 3 red, 1 green; 19 blue, 7 red\r\nGame 92: 9 green, 3 blue; 1 red, 5 green; 13 green, 3 blue, 2 red; 1 red, 3 blue, 7 green\r\nGame 93: 11 red, 3 green, 11 blue; 7 green, 3 red, 10 blue; 11 green, 4 blue, 8 red; 14 green, 8 blue\r\nGame 94: 7 blue; 1 green, 11 blue, 2 red; 1 green, 1 red, 19 blue; 7 green, 2 red, 10 blue\r\nGame 95: 15 blue, 1 red, 9 green; 5 green, 1 red, 4 blue; 6 green, 17 blue; 9 blue, 11 green; 10 blue, 9 green; 9 blue, 7 green\r\nGame 96: 7 red, 13 blue; 6 blue, 15 red, 3 green; 1 green, 1 red, 1 blue; 9 red, 2 green, 8 blue; 5 green, 8 red, 1 blue; 6 blue, 3 green, 13 red\r\nGame 97: 19 blue, 10 red, 4 green; 8 red, 17 blue; 8 blue\r\nGame 98: 2 blue, 2 red, 4 green; 5 green, 3 blue, 2 red; 5 green, 15 blue; 15 blue, 5 green, 1 red\r\nGame 99: 1 blue, 2 green, 8 red; 1 blue, 7 red, 1 green; 11 red, 2 green; 1 red, 1 blue\r\nGame 100: 8 green; 2 red, 20 green; 12 green, 1 red, 1 blue; 4 red, 1 blue; 1 blue, 6 red";

            var lines = input.Split('\n');

            int sum = 0;
            foreach (string line in lines)
            {
                var str = line.Split(':');
                //int id = int.Parse(str[0].Split(' ')[1]);

                //sum += id;
                (int r, int g, int b) colors = (0, 0, 0);
                foreach (var game in str[1].Split(';'))
                {
                    //if (!CheckGameValid(game)) {
                    //    sum -= id;
                    //    break;
                    //}

                     var gc = GetColors(game);

                    if (gc.r > colors.r)
                        colors.r = gc.r;
                    if (gc.g > colors.g)
                        colors.g = gc.g;
                    if (gc.b > colors.b)
                        colors.b = gc.b;
                }

                sum += colors.r * colors.g * colors.b;
            }

            Console.WriteLine(sum);
        }

        private static bool CheckGameValid(string game)
        {
            foreach (var color in game.Split(','))
            {
                var pair = color.Trim().Split(' ');

                if (pair[1] == "red" && int.Parse(pair[0]) > 12)
                    return false;

                if (pair[1] == "green" && int.Parse(pair[0]) > 13)
                    return false;

                if (pair[1] == "blue" && int.Parse(pair[0]) > 14)
                    return false;
            }

            return true;
        }

        private static (int r, int g, int b) GetColors(string game)
        {
            (int r, int g, int b) colors = (0, 0, 0);
            foreach (var color in game.Split(','))
            {
                var pair = color.Trim().Split(' ');

                if (pair[1] == "red")
                    colors.r = int.Parse(pair[0]);

                if (pair[1] == "green")
                    colors.g = int.Parse(pair[0]);

                if (pair[1] == "blue")
                    colors.b = int.Parse(pair[0]);
            }

            return colors;
        }
    }
}
