﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "...........\r\n.....###.#.\r\n.###.##..#.\r\n..#.#...#..\r\n....#.#....\r\n.##..S####.\r\n.##..#...#.\r\n.......##..\r\n.##.#.####.\r\n.##..##.##.\r\n...........";
            var input = "...................................................................................................................................\r\n.#.........#......#................#...#.......#.....##............................##..#........#.#.#.#......#......#...#........#.\r\n..............#..#.....#.....##....................#....................................#....##.#.......#.......#...#...........#..\r\n.#..#..#.#...#.....#.......#......#..#..#.............#.#..................#.......#.............#..#.......#.......#..............\r\n.....................#.............#............#.#................................#.......#........#...............#....#..#......\r\n.....#...........#.......#..................................................#..............#.##.....#..............................\r\n...#.........................##...#.#................#.....................................#.......#.#........#....#.......#....#..\r\n.#....####..........#......................#........#..................................#...........#..#..#....#......#.............\r\n...#.....................#........................#...............................#.......................#....#......#............\r\n....#......#....#......#....#....##..........................#.....#................#.....#........#.....##........................\r\n................#.#....#.#..#....................#..............#........................#...#.......#.#..........#.......#.#......\r\n.........#.#.......#............#.............#...........................................#...#.....#.......................#......\r\n.....#.................#.........#.#.....................#............#..........#.#.#......#...........#.#..............#...#.....\r\n..............................#......#.......#..#..............#....................#...#.##..##..........#...............#...##...\r\n.....#........#.#............#.......#.....###...........................#.....................#................................#..\r\n..##..........#......#...#..............#.....#................#.........#.#...............#...............#.......................\r\n............................#...#.#..................#....................#.......................#.......#........#..#....#....#..\r\n...#............#..#......#...........#................#.....#............................##...##........#..............##.........\r\n..#...#............................#...#...............................#..#..............................#.............#..#....#...\r\n.#.............#...#.....#.#..........#.............#......#..........#....#.#.................#.................#..#......##..#...\r\n.......#........#..................#.....#........#.#.........#........##....#..............#.......#...#....#.............#.......\r\n.........#.........#......#.#..#....#............##......#...........#.....................#.....#.#.....#.................#.......\r\n..............................#.#......#............#..#....#....................##.............#...##....#.................###....\r\n......#...##...#....#.##...........#.#...........#...##..............#.#.....##....#..........#..#.........#.....#.................\r\n....##...###.........................#............#............#.............#.##...............#..............##.....#............\r\n.....#..#......##.#.........#.....##............#.....#.........#...................#......................#........#..........###.\r\n............#.............#........#.......#...###......#...#.#......##.#...........#..#......................#................#...\r\n..........................................................#........................#..........................#....#....##.....#...\r\n....#...#........#.......................#..........#.............#..#.#...............................#.......##.#...##...........\r\n...#........#..........#........................#...........#.............#.#.....................#...#.#.##.#..................#..\r\n.......................#....#..............#..####......##.#.............#...........#...##............#..#..........##...#.....#..\r\n..#.................#.#..................#.#.....#...#.#..##...#.........#.................#.............#....#..#.......#.........\r\n..#............#..#.....................#.................#............#.....##.#..#.#................#....................#...#...\r\n..#.###.##.......................................##.............#..#...#...........#...#....#...........###......#............#....\r\n........#....#.......#.....................#...................................#...#.#.....#..............................#....#...\r\n.#..#........#...#.....#.............##..#....#................#................................#.........#....#..............#....\r\n............#..........#............#...#.......#..#.#.#.......#....#...........#...#....#............................#.#..........\r\n............................................................#..................#..............#...............................#....\r\n.........#.....#......##........#......#.##..##............##.......................#.........................#....#...............\r\n.#...#...#.#..#...#..............................#...................#..#....................##..........................#.##......\r\n.............#...#...........#......#..#..##...#......#....##.....#................##.........#...........................#........\r\n.................#..................#.........#....#...#..................##............#..#...#.................#..#...........#..\r\n...#...#..........#.........#.....#.........................#.#................#......##...............#............#......#....##.\r\n.............#.................#.............#..#...#.............#.........#..#.#..#............##.............#...#..............\r\n......#.#........#........#...........#..##...................##....#.....................#..#.........#..........#.....##.....#.#.\r\n...........#.#.............#.......#....#..........#.#...............#.#...##.............................................#........\r\n...............#........................#.....#.......#................#........#.......#.....#.......................##...........\r\n......................................#...............................#..........#................#........#.......................\r\n.............................#....#.....##.....#....#...#...........#....#.......##..#.................................#...........\r\n............#.............#......#..#.#.##............#.............#.......#....................#....##...........................\r\n..........#...........#..#.......#.........#.............#...................#.#..#..#....#........#...#...........................\r\n.....................#........#............#.........#.........#..................#...#.........#..............#........#......#...\r\n.................#.............#.#.#.#....#...#..#...................................................#......#......................\r\n........#........#....................#...##....#.#...#..#..#.......#.....#.....#....#.............................................\r\n...#...................#.....#...................#......................#............#......#....#.#.........#.#...................\r\n.#.......................#...#.....#.#....................#.......#............#............#........#.............................\r\n...............#..#..#..............#...#..#...............#.##..................#.......#...........#....#....#...#..........#....\r\n...............#................................#..#............#....#....#.............#...............##..#......#............#..\r\n.........................#..............#.#..#....................#.#.#.....#...............#........#.##.#.......#................\r\n.#...........#.##..#...#.#...........#.......#...............................####....................##....#.........#.#...........\r\n...................#...........#........#..#.........#............#..........#.........#...#.......................................\r\n..............#..#...#..#..#.##............#..#..#.............##.##.#..#.......................#..........#..........#..#.........\r\n........##...............##..#..#...........#.............#.#.................#..........#........................#.#...#..........\r\n..............#......#........#........#.#.........#..#.....#.....#..#...##...................#..........#.............#...........\r\n.................#.......#....#.....................#....##...............##....................#......#....#..........#..#.#......\r\n.................................................................S.................................................................\r\n.........#..##...#..#.........#.................................#.........#....#.#............#..#........#.......#.......#........\r\n...................#....#..#....#...#......#....#......#...........................#.............###...............#......#........\r\n...........#...............#........................#.#......#.#............#...#.#.................#....#...#...#.................\r\n..................#...................#..#.........#...##..#...#...................#...#.....#.....#....#.......#.#................\r\n...............#..............#........#................................................#...#.#......#.#.........#....#............\r\n...............##.........#.....#....#................#.....#.#................#.......#................#..........................\r\n...........#.............#...#...................##................#.......#....#...#...........#.#................................\r\n.................#..............................#.....................#.....#...............#...#...................#..............\r\n..............................#.................#..........#............#.......#..............#.#.................................\r\n...............#..............#....#............#......#...#.........#.......##............##...#..#..........................##...\r\n..........................#.#...........#....#.........##..............##......#.........................#.....#................#..\r\n........#...................#..#...#.......................#..................#.#.............#..#.............#...........#.......\r\n.............................#............#....#.....................#.....#..........#..##.............#.#......#.......#.........\r\n....#.........................................#......##...#...........................##........#...#.#............................\r\n.....#.....................#..#....##..#..........#........................##.....#..........#................#....................\r\n.......................................#..#......#.#..##.....#...........#..#.......#.................#...#.................##..##.\r\n....#.....#............#...#......#..............#...................#...........#.........#.........................#....##..##...\r\n......#....#.................#.............#....#..#.....#........#.#........#.....#.#.#.#..#......................................\r\n.........#..........................................#..............##.......#........#...#..#............#.#.............#.#...#...\r\n............#............#.....#..#............#..#.....#.....#....#....#..#............#................#..............#......#...\r\n.###.........#....................................#.#..#......#...#.....#.......#..#.....#.....##.....##.............#....#.#......\r\n..###.......................#.......#..#..........#.............................#...............#..#..#.............##.......#.....\r\n.#.......#...........................................#..#.................#........#.#...............#.....................#.......\r\n.......#....#.....##...........#..#.............#........#..................#.......#.......#.........#......................#.....\r\n.......#...#......#................#..#.#..........#.....................................##....#.............#......#..........##..\r\n.....###.#....#.#..................#........##.#........#...#..............#...........#......#.......................#....#.....#.\r\n.#...........................................................#.#.......#..........#.#.......................#.......#.#......#.....\r\n.....#.................................#....#...#.#.#....#...#....#....#....#.....##....#.............................#.#..#.......\r\n.............#..#........#...........#.....#.......#..#....#..#...#.......................#....#...........#...............#.......\r\n...##...#.##.....#............................#.....##.........................#..#.#...........#.............#........#...........\r\n.........#..#........#..#..................#....#.#........#....#....##....#...........#...#............................#..#.......\r\n..#....#..#.#......#.......#..............#.#............................#............#.................#.......#...###.....#.#.#..\r\n..#.......#.........###....#.........#........##....#......................#...........................#.....##.........#...#......\r\n.##.............#.........#...........#..................................#.....#....#....#.##...............#......#...............\r\n.....#...........#...#......#..........#..................#..#..#.......................#..........................................\r\n.....#..................#..#..#............#..#...........#..#.......#........##...#..................#............................\r\n.....................#.......#...........#..........##........#...............#.#..#...................#........#..#....#..........\r\n.#.........#..#................#............#......#.......#.......#.....#..#.#.#..##..#..........#....##..#.......................\r\n..................##..##..................................#................#.........#...........#....#.........#..#.#.............\r\n.....#..#..............#......#................................#...........#...#...#............##...........................#.....\r\n...#................##.........#.#...#............................#.#....#.#....#...#.........#.......#............#....#.#..#..#..\r\n.................#.......#.#......#.#............##........#................................#....#..#..............................\r\n...#................#................................#.##.#.##.......#...........#....................#......#.....................\r\n.#.........#....#..........##........#.#..........#.#......#..#............##....#................#.......#.............#..........\r\n.................#....#..........#..................#........#.#..........#...............#.....#..#..............#............#.#.\r\n...#..#.......#.......................#...........##.................#....#.....#............#........##.............#.....#..#....\r\n....#.............##............#...#..#....................#.......#.........#..............................#.....................\r\n...#......................#.................#.............#............................#....#.............#......#...#.............\r\n...#.........#........................................#..#.....##......#....##.......#..#........#...#..#.....#.#.............#..#.\r\n..#.......#..................#..#.....#.....#.#.........#.....#......................#....##...............#..........#.....#......\r\n..................#..##........#....#...................#.......#..................#..#.......##...................................\r\n.....#..#.#.#.#.....#........#.....................................#......#..........##........................#......#...#..#.....\r\n...#.#.........##....#..#...................#............#.....##.............................##.........#.....#.............#.....\r\n.#....#................#..........................................#............................#........#...##................#.#..\r\n.........#..........##...#........##.#....#.....#............#.....#..............#....#.#..#............##....#.....#.......##....\r\n.............##......#.................#........#..##...............#..........................#....#.......##........#........##..\r\n......#.....##.......#....................#..........#.........................#...#.......#...##..#..............#........#.......\r\n..#..........#......#....#..............#.......................#...........#.....#................#....#.#.#...#.........#........\r\n.....##.#.#..#.#..............................#...#..##..........................#.#..............###.#............................\r\n.........#.....#...##.............#.........#.....#..........................#.....................................#..#..........#.\r\n.#..##........................#........#............#..........................................#..#..........#.....#..#.....#...#..\r\n.............#..............#.##..............#........#..................##........#.........##.......#.#.....#..#......#..#.#....\r\n..........#....#.###...#........#..#......................................#......#..............#..............#...................\r\n...........#..................#...........#..............................#....................#..#.................#...............\r\n...................................................................................................................................";

            var lines = sinput.Replace("\r\n", "\n").Split('\n').ToList();

            var map = new char[lines.Count, lines[0].Length];
            var odds = new HashSet<(int x, int y)>();
            var evens = new HashSet<(int x, int y)>();
            var queue = new Queue<(int x, int y)>();
            var tiles = new Dictionary<(int x, int y), (int odd, int even)>();
            for (int y = 0; y < lines.Count; y++)
            {
                for (int x = 0; x < lines[y].Length; x++)
                {
                    map[y, x] = lines[y][x];
                    if (map[y, x] == 'S')
                    {
                        queue.Enqueue((x, y));
                        evens.Add((x, y));
                        tiles[(0, 0)] = (0, 1);
                        map[y, x] = '.';
                    }
                }
            }

            int steps = 2000;
            for (int i = 0; i < steps; i++)
            {
                var next = new Queue<(int x, int y)>();
                bool odd = i % 2 == 0;
                var visited = odd ? odds : evens;
                while (queue.Count > 0)
                {
                    var (x, y) = queue.Dequeue();

                    Visit(map, next, visited, x, y - 1, tiles, odd);
                    Visit(map, next, visited, x, y + 1, tiles, odd);
                    Visit(map, next, visited, x - 1, y, tiles, odd);
                    Visit(map, next, visited, x + 1, y, tiles, odd);
                }
                queue = next;
                Console.Write($"{i + 1}: {visited.Count} {tiles.Count} ");

                //foreach (var tile in tiles)
                //    Console.Write($"t:{tile.Key} {tile.Value} ");
                Console.WriteLine();
            }
        }

        private static void Visit(char[,] map, Queue<(int x, int y)> next, HashSet<(int x, int y)> visited, int x, int y, Dictionary<(int x, int y), (int odd, int even)> tiles, bool odd)
        {
            int translatedX = ((x % map.GetLength(1)) + map.GetLength(1)) % map.GetLength(1);
            int translatedY = ((y % map.GetLength(0)) + map.GetLength(0)) % map.GetLength(0);
            if (!visited.Contains((x, y)) && map[translatedY, translatedX] == '.')
            {
                visited.Add((x, y));
                next.Enqueue((x, y));

                StoreTileSize(map, x, y, tiles, odd);
            }
        }

        private static void StoreTileSize(char[,] map, int x, int y, Dictionary<(int x, int y), (int odd, int even)> tiles, bool isOdd)
        {
            int tileX = x / map.GetLength(1);
            if (x < 0)
                tileX--;

            int tileY = y / map.GetLength(0);
            if (y < 0)
                tileY--;
            
            if (!tiles.ContainsKey((tileX, tileY)))
                tiles.Add((tileX, tileY), (0, 0));
            var (odd, even) = tiles[(tileX, tileY)];
            if (isOdd)
                odd++;
            else
                even++;
            tiles[(tileX, tileY)] = (odd, even);
        }

        private static long f(int x, int[] a)
        {
            int b0 = a[0];
            int b1 = a[1] - a[0];
            int b2 = a[2] - a[1];

            return b0 + b1 * x + (x * (x - 1) / 2) * (b2 - b1);
        }
    }
}
