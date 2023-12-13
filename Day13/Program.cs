﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "#.##..##.\r\n..#.##.#.\r\n##......#\r\n##......#\r\n..#.##.#.\r\n..##..##.\r\n#.#.##.#.\r\n\r\n#...##..#\r\n#....#..#\r\n..##..###\r\n#####.##.\r\n#####.##.\r\n..##..###\r\n#....#..#";
            var input = "....#....#.\r\n..##.####.#\r\n####.####.#\r\n####..##..#\r\n######..###\r\n....##..##.\r\n.....####..\r\n####......#\r\n..##.####.#\r\n..##..##..#\r\n..#.#.##.#.\r\n###.##..##.\r\n#.#.#.##.#.\r\n####.####.#\r\n#####.##.##\r\n\r\n.#......##.#.#...\r\n.##.#..######.#..\r\n..#.##..#..##.###\r\n##....#######...#\r\n...##..#.#...###.\r\n...##..#.#...###.\r\n##....#######...#\r\n..#.##..#..##.###\r\n.##.#..######.#..\r\n.#......##.#.#...\r\n.#.########....#.\r\n..##.##.#..##.##.\r\n..##.##....##.##.\r\n.#.########....#.\r\n.#......##.#.#...\r\n.##.#..######.#..\r\n..#.##..#..##.###\r\n\r\n##..####..###\r\n.#..####..#..\r\n#...#..#...##\r\n##.#....#.###\r\n...#.##.#.#..\r\n.###....###..\r\n#.########.##\r\n#..##..##..##\r\n.#.#....#.#..\r\n\r\n...##.#..#.##..\r\n..##.#.##.#.##.\r\n###.#..##..#.##\r\n###.#......#.##\r\n..##..#..#..##.\r\n..#....##....#.\r\n....##.##.##...\r\n####.######.###\r\n....#.####.....\r\n..####....####.\r\n..###.#..#.###.\r\n###..######..##\r\n...#........#..\r\n\r\n...##..###.....\r\n..#....#..##...\r\n...#.###.#.##..\r\n...#..##.#.##..\r\n..#....#..##...\r\n...##..###.....\r\n#.##.########.#\r\n#....#.#.#..#..\r\n###....###..##.\r\n...###..###.###\r\n#..#...#..#..#.\r\n#####.#........\r\n#..##.#...#..#.\r\n#..##.#...#..#.\r\n#####.#........\r\n#..#...#..#..#.\r\n...###..###.###\r\n\r\n..##....#\r\n....####.\r\n####....#\r\n##.......\r\n....#..#.\r\n....####.\r\n..#......\r\n..#......\r\n###......\r\n###.###..\r\n..##.##.#\r\n###......\r\n...#.##.#\r\n\r\n.#...#.#.#.\r\n.#...#...#.\r\n..######.#.\r\n.#.###.#.#.\r\n.##...#.#..\r\n.#..#......\r\n..#.....#..\r\n#.##.#.#.#.\r\n.....##.###\r\n.....##.###\r\n#.##.#.#.#.\r\n..#.....#..\r\n.#..#......\r\n.##...#.#..\r\n.#.###.#.#.\r\n..######.#.\r\n.#...#...#.\r\n\r\n#.#...##..#\r\n####..##.#.\r\n#..#.......\r\n#..#.......\r\n####..##.#.\r\n#.#.#.##..#\r\n...#.#####.\r\n##..#.##...\r\n#.#...#....\r\n##.#.#.#.##\r\n.###...#.##\r\n.#.#.######\r\n.#.##.#..##\r\n.##.##.##.#\r\n.##.##.##.#\r\n\r\n#.....#\r\n.##..#.\r\n.####.#\r\n.####.#\r\n.##..#.\r\n#.....#\r\n#####..\r\n#####..\r\n#....##\r\n.##..#.\r\n.####.#\r\n\r\n...#.##.#..\r\n#...##...##\r\n#..##....##\r\n.####.#.###\r\n.##.###.#..\r\n...#.######\r\n#.#..###.##\r\n#.#..###.##\r\n...#.######\r\n.##.###.#..\r\n.##.#.#.###\r\n#..##....##\r\n#...##...##\r\n\r\n.#####..#\r\n...##.##.\r\n#.###....\r\n#.###....\r\n...##.##.\r\n.#####..#\r\n######..#\r\n..##...#.\r\n...#..##.\r\n##..#.##.\r\n.##......\r\n....#.##.\r\n..####..#\r\n\r\n.#....#.###...###\r\n.######..##.#..#.\r\n.######..##.#..#.\r\n.#....#.###...###\r\n#.####.#....#.#..\r\n...........#.....\r\n.#.##.#.#.##....#\r\n#......##.##...#.\r\n#..##...##.....#.\r\n.##..##..#.###..#\r\n.#.##.#.#...#.#..\r\n#......#.#..#.#.#\r\n###..###.#..##...\r\n.######.#.#.#.##.\r\n#..##..#.#....#.#\r\n..#..#.....#.##..\r\n#.####.#.#.##.#..\r\n\r\n...##.##.##..\r\n..#.....#..#.\r\n..#.#....#.#.\r\n###.##..##.##\r\n...#.####.#..\r\n..##..##..##.\r\n..#.#.##.#.#.\r\n##..........#\r\n.....#..#....\r\n...#.####.#..\r\n..##..##..##.\r\n\r\n##.#.#.#.\r\n.##..####\r\n...#.#...\r\n..#.#..##\r\n.####....\r\n.###.....\r\n.#....###\r\n...##..##\r\n#.#.#.#..\r\n#.##.#.##\r\n##...#.##\r\n####..#..\r\n.#..##...\r\n.#...####\r\n##...#...\r\n...####..\r\n...####..\r\n\r\n......##.##.#\r\n........#..#.\r\n##..##.#.##.#\r\n#....###....#\r\n.####.#......\r\n##..#####..##\r\n..##..#.#..#.\r\n##..#########\r\n#....#.#..#.#\r\n\r\n.##.##.#.##..##.#\r\n#######..#....#..\r\n####.#.#.#....#.#\r\n#..##...#..##..#.\r\n####.#...#.##.#..\r\n#..#...........#.\r\n.##..#...........\r\n####.#.##########\r\n####.##.########.\r\n####..##.##..##.#\r\n....#.###########\r\n#..#.......##....\r\n....#.###.#..#.##\r\n\r\n#..##..########..\r\n##.##.###.##.#..#\r\n..#..#...#.#..#..\r\n...##....#...#..#\r\n##....####.#.###.\r\n##....#####.##...\r\n##....###.#....#.\r\n..####.#..##....#\r\n#..##..#.#.#..###\r\n.........#.#....#\r\n##.##.#####.##..#\r\n##.##.#####.##..#\r\n.........#.#....#\r\n\r\n...####.#####..\r\n.###..####.#...\r\n.###..####.#...\r\n....###.#####..\r\n####...#.#..###\r\n##.###.##..####\r\n.########.#####\r\n###.###.#......\r\n####..####.##.#\r\n####..####.##.#\r\n###.###.#......\r\n.########.#####\r\n##.###.##..####\r\n####...#.#..###\r\n....###.#####..\r\n\r\n##.##..##\r\n##.##..##\r\n##.####.#\r\n.....#..#\r\n###.#.#..\r\n.##..#...\r\n###......\r\n###......\r\n.##..#...\r\n.##.#.#..\r\n.....#..#\r\n##.####.#\r\n##.##..##\r\n\r\n#.#.#..##...##.\r\n#.#..#.#.##....\r\n##......#.#.##.\r\n.##.##..###.##.\r\n...#.###.#.#..#\r\n...#.###.#.#..#\r\n.#..##..###.##.\r\n\r\n##.#......#.###\r\n#...#..#.#...##\r\n##.#......#.###\r\n#####.##.######\r\n###.##..##.####\r\n#.##.####.##.##\r\n..#.#....#.#...\r\n.##........##..\r\n#..##.##.##..##\r\n....#....#.....\r\n..####..####...\r\n.##.##..##.##..\r\n###.#....#.####\r\n.#.#.####.#.#..\r\n##...####...###\r\n..#..####..#...\r\n###...##...####\r\n\r\n..#####\r\n##.....\r\n.#..#..\r\n.#..#..\r\n##.....\r\n..#####\r\n..#...#\r\n##....#\r\n#####..\r\n..###..\r\n#.###..\r\n#####..\r\n##....#\r\n..#...#\r\n..#####\r\n##.....\r\n.#..#..\r\n\r\n#.##.#.######\r\n##.#..#######\r\n#...#.#......\r\n#...#.#......\r\n.#.#..#######\r\n#.##.#.######\r\n#..###...##..\r\n#.####.#....#\r\n..####.#.##.#\r\n\r\n#.#######..##...#\r\n..##..###.#.##..#\r\n..#...#.######...\r\n..#...#.######...\r\n..##..###.#.##..#\r\n#.#######..##...#\r\n...####...#####.#\r\n#..#.#..##..#.###\r\n.#.#.#..###..#.#.\r\n####..#.###.#....\r\n.....##.#.####..#\r\n.....##.#.####..#\r\n####..#.###.#....\r\n.#.#.#..###..#.#.\r\n#....#..##..#.###\r\n\r\n##..###.##.##\r\n###..#.....##\r\n.##..#.###.##\r\n...##.....#..\r\n###..#.###.##\r\n..#...#.#####\r\n..##..#.#....\r\n#.##.####.#..\r\n.#...#.#.#.##\r\n.#...#.#.#.##\r\n#.##.####.#..\r\n..##..#.#....\r\n..#...#.#####\r\n###..#.###.##\r\n...##...#.#..\r\n.##..#.###.##\r\n###..#.....##\r\n\r\n..#..#.#.\r\n.##.#.###\r\n.##.#.###\r\n..#..#.#.\r\n.###.##..\r\n.##...#..\r\n.#......#\r\n#.#.##.#.\r\n#.#.##.#.\r\n.#......#\r\n.##...#..\r\n.#.#.##..\r\n..#..#.#.\r\n\r\n.##..#.\r\n.#.##..\r\n#.#....\r\n#.#....\r\n.#.##..\r\n.##..#.\r\n#...#..\r\n###...#\r\n.###...\r\n##.#.##\r\n##.#.##\r\n.#.#...\r\n###...#\r\n#...#..\r\n.##..#.\r\n\r\n#.###..#.##.#\r\n#..###.######\r\n.#.#..##....#\r\n.#.#..##....#\r\n...###.######\r\n#.###..#.##.#\r\n#.#...#..##..\r\n#.....#......\r\n####.#..#..#.\r\n\r\n.#.####\r\n..#..#.\r\n#..##..\r\n..#....\r\n##...##\r\n.#.##.#\r\n.##..##\r\n.##..##\r\n.####.#\r\n##...##\r\n..#....\r\n#..##..\r\n..#..#.\r\n.#.####\r\n.#.####\r\n..#..#.\r\n#..##..\r\n\r\n.#...###.....\r\n..#.#.######.\r\n##.....#.#..#\r\n.#.....#.#..#\r\n..#.#.######.\r\n.#...###.....\r\n..#..#...#..#\r\n#..#..#....##\r\n#..#..#....##\r\n\r\n##.##.##.#....#\r\n..######.#..###\r\n....##..#.#..##\r\n#..#.###.##....\r\n#..#.###.##....\r\n....##..#.#..##\r\n..######.#.####\r\n##.##.##.#....#\r\n.#....####.....\r\n##.###.##.##.#.\r\n......####..#..\r\n.###.#.#.....##\r\n..##.#..#....#.\r\n###.....##...##\r\n##.#####....##.\r\n...####..#.#..#\r\n...####..#.#..#\r\n\r\n##.##.#...##.#.#.\r\n##.##.#...#.#.##.\r\n##..##.#.###.#.#.\r\n...#.#.#.#....###\r\n##.##....#....##.\r\n##.##....#....##.\r\n...#.#.#.#....###\r\n##..##.#.###.#.#.\r\n##.##.#...#.#.##.\r\n#####.#...##.#.#.\r\n..#.#...###.#.###\r\n..#...#....##.##.\r\n..#..#..#.###.#..\r\n####..#.#.#####.#\r\n...######.####..#\r\n\r\n..###.####.###.\r\n####.#.##.#.###\r\n...#.#....#.#..\r\n..##..#..#..##.\r\n##.####..##.#.#\r\n##.#.#.##.#.#.#\r\n.....#....#....\r\n\r\n...##..##.##.\r\n.###...#.##..\r\n#.#...#.#....\r\n#.#...#.#....\r\n.###...#.##..\r\n#..##..##.##.\r\n###.#..#....#\r\n#..##.#....##\r\n#..#..##..#.#\r\n.....##..#..#\r\n.####..#..###\r\n#####..###.#.\r\n.#.#.....#.##\r\n.#.#.....#.##\r\n#####..###.#.\r\n.####..#..###\r\n.....##..#..#\r\n\r\n#.###.#...###.#\r\n....#..#..#.##.\r\n#..#..#...###.#\r\n.###.#..#.#####\r\n#...#....##..#.\r\n####.#.....####\r\n...#####.##..##\r\n...#####.##..##\r\n####.#...#.####\r\n#...#....##..#.\r\n.###.#..#.#####\r\n#..#..#...###.#\r\n....#..#..#.##.\r\n#.###.#...###.#\r\n#.###.#...###.#\r\n\r\n######.##.#\r\n#.##.######\r\n..##..####.\r\n#.##.#....#\r\n#....#.##.#\r\n.####......\r\n#...##....#\r\n\r\n#.#####\r\n..#.#..\r\n#...#..\r\n##.##..\r\n....##.\r\n###.###\r\n...####\r\n.##....\r\n#.#.###\r\n#..#.##\r\n#....##\r\n..##...\r\n..##...\r\n\r\n..#...##...#.\r\n...#..##..#..\r\n...##....##..\r\n.....#..#.#..\r\n#####.##.####\r\n##...#..#...#\r\n...#.####.#..\r\n####.####.###\r\n..##.####.##.\r\n###.######.##\r\n###..#..#..##\r\n\r\n..####...#.##..##\r\n####.#.......##..\r\n......##..#..##..\r\n#.....#####......\r\n.#.###...#.......\r\n..#.#..#.#...##..\r\n....##.##.#######\r\n###.##...#.#.##.#\r\n.##....###.##..##\r\n\r\n..##....##.#..#..\r\n..##....##.#..#..\r\n##..###.......#..\r\n#.##.###..#.#.###\r\n.#..###.#######.#\r\n.####.###.##....#\r\n.#..#.#..#..##.#.\r\n#....##.#.##..#..\r\n#########.#.#####\r\n.......#...#..###\r\n#######.#..#...##\r\n##..####...####..\r\n.#..#..#.#.##....\r\n\r\n....#..\r\n##.##.#\r\n#.####.\r\n#.####.\r\n##.##.#\r\n###..##\r\n..#..#.\r\n..#..#.\r\n###..##\r\n\r\n.####..\r\n######.\r\n.####.#\r\n#....#.\r\n..##...\r\n..##...\r\n#....#.\r\n.####.#\r\n.####..\r\n\r\n###.##.####....\r\n.##....##...##.\r\n..##..##.......\r\n..##..##...#..#\r\n.#.####.#.##..#\r\n##.#..#.###.##.\r\n...#.......#..#\r\n\r\n#####.#.##.\r\n#..##......\r\n#..#..#....\r\n.##....#..#\r\n####....##.\r\n.....##.##.\r\n....#######\r\n....#...##.\r\n######.....\r\n#..#..##..#\r\n#####.#.###\r\n#####......\r\n.##.#..#..#\r\n#..#.######\r\n....#..#..#\r\n\r\n###..##.##.##.##.\r\n##.#.#....#.#..#.\r\n#.#.....#.##.#..#\r\n..##.###.#.#.....\r\n...##..#...#.....\r\n..##.#..##...####\r\n.#..#.#..#...#..#\r\n###...#...#.#....\r\n#..##....#.###..#\r\n#.#.#.......#####\r\n.#.##...#.###....\r\n.#.##...#.###....\r\n#.#.#.......#####\r\n\r\n.#...#.##.#...#..\r\n#.##.#.##.#.##.##\r\n...#..#..#..#....\r\n..#.##.##.##.#...\r\n###..#....#..####\r\n###..#....#..####\r\n#..#.######.#..#.\r\n\r\n.##..###.\r\n#..#...##\r\n#..#.####\r\n.......##\r\n#..#.....\r\n#####....\r\n.##.##.##\r\n\r\n####.###.#.\r\n####...#.#.\r\n#...#....##\r\n#..##..#.#.\r\n#..#.#.#..#\r\n#..#.##.##.\r\n#..##..##.#\r\n.##..##.#.#\r\n.##.#..###.\r\n########...\r\n########...\r\n.##.#..###.\r\n.##..##.#.#\r\n\r\n..#.##.####\r\n###.###.##.\r\n##..###....\r\n##...##....\r\n###.###.##.\r\n..#.##.####\r\n.#...##....\r\n...##......\r\n.#.#.##....\r\n#.###.#....\r\n..#..##.##.\r\n\r\n##...#...#...\r\n##...#..##...\r\n#...#...#####\r\n#.#..#.......\r\n#.#####.#....\r\n#####..####..\r\n..##.##.#..##\r\n\r\n.#####.\r\n.#.#..#\r\n#.###.#\r\n.#.####\r\n#.#..#.\r\n.#.##..\r\n.#.##..\r\n#.#..#.\r\n.#.####\r\n#.###.#\r\n.#.#..#\r\n.#.###.\r\n.#..###\r\n.#..#..\r\n.#..#..\r\n\r\n#.#..#.#.######.#\r\n#.#..#.#.######.#\r\n.........#.##.#..\r\n...#..#..##..##..\r\n.#.#.####......##\r\n.###.##..######..\r\n###..####.##.#.##\r\n..#######.#..#.##\r\n#..##...#.####.#.\r\n##.##.#..##..##..\r\n##.#.#.#..#..#..#\r\n#..##.#..........\r\n##.##...##.##.##.\r\n.#..####.######.#\r\n..###..##.####.##\r\n....####..####..#\r\n#..##....#....#..\r\n\r\n..####..#..##..\r\n.#....#.#.#..#.\r\n.##..##..######\r\n#..##..###.##.#\r\n.##..##....##..\r\n....#...#..##..\r\n..####..#......\r\n\r\n##.###.#####...\r\n##.##...#..#.##\r\n##.##...#..#.##\r\n.#.###.#####...\r\n####.####.#.###\r\n##...#####..###\r\n#.###.#.#######\r\n..##.#..####...\r\n.###..#####.#..\r\n....#.#.##..###\r\n#....#.#.##.#..\r\n#..#..#.#####..\r\n....#..####.###\r\n.#...####.#####\r\n###.#.#.##.####\r\n\r\n#..#..#..##.#\r\n#..#.#.##.#.#\r\n.##...#..#...\r\n####.#....#.#\r\n#..##.####.##\r\n#..##......##\r\n####...##...#\r\n\r\n#...##.##.#\r\n##.##..#.#.\r\n.###..##..#\r\n.###..##..#\r\n##.##..###.\r\n#...##.##.#\r\n#........#.\r\n#........#.\r\n#...##.##.#\r\n##.##..###.\r\n.###..##..#\r\n\r\n.#..########.\r\n#...#....#.##\r\n...#.#.#.#..#\r\n########.#..#\r\n########.#..#\r\n...#.#.#.#..#\r\n#...#....#.##\r\n.#..########.\r\n##.###.#...#.\r\n#...##..#.##.\r\n###.....#...#\r\n#.#.#...#....\r\n#....####..#.\r\n#.....###..##\r\n..#####..#.#.\r\n#.##.#.#...##\r\n#.##.#.#...#.\r\n\r\n#.###...####...##\r\n...##..#....#..##\r\n.##..#.##..##.#..\r\n#.#.#....##....#.\r\n##....#......#...\r\n##.....#....#....\r\n....#.#......#.#.\r\n#.##..#.####.#..#\r\n#...##.#.##.#.##.\r\n#...##.#.##.#.##.\r\n####..#.####.#..#\r\n....#.#......#.#.\r\n##.....#....#....\r\n\r\n#.###.#...#..\r\n##...#...#.##\r\n.......###...\r\n.####.##.####\r\n##.###..##...\r\n....#####..##\r\n##.###.#.####\r\n.###..##.#.##\r\n.##.#....####\r\n..#.....#.###\r\n####..#....##\r\n###.....#..##\r\n#.#.#.#.#.#..\r\n#.#.#..##.###\r\n#.#.#..##.###\r\n#.#.###.#.#..\r\n###.....#..##\r\n\r\n###..###.#.#.\r\n#.#..#.###..#\r\n#.#..#.###.#.\r\n##....###.#..\r\n.#....#..###.\r\n...##...#..#.\r\n#..##..#..#.#\r\n#..##..#..#.#\r\n...##...#.##.\r\n.#....#..###.\r\n##....###.#..\r\n#.#..#.###.#.\r\n#.#..#.###..#\r\n###..###.#.#.\r\n.######.#..#.\r\n\r\n#..##.#...#.#..\r\n.#...###.####.#\r\n.###.##.#......\r\n#.#.#..####....\r\n#.#.#..####....\r\n.###.##.#......\r\n.#...###.####.#\r\n#..##.#...#.#..\r\n.##.###.#.#.##.\r\n.##.###.#.#.##.\r\n#..##.#...#.#..\r\n.#...########.#\r\n.###.##.#......\r\n\r\n....#.####....###\r\n...##.#.########.\r\n.....#...........\r\n####..#..........\r\n.##.#.#.#.#..#.#.\r\n####.#..#.####.#.\r\n#..#.####.#..#.##\r\n....#....#.##.#..\r\n#####..#...##...#\r\n.##.###...####...\r\n.##..##...#..#...\r\n\r\n#..#..###...#.#\r\n####..#.#....#.\r\n........##...##\r\n###.#.#.#....##\r\n..#...#.#.###..\r\n.....##...#..##\r\n...#..#.#..####\r\n##.#...##..#...\r\n##.#...##..#...\r\n...#..#.#..####\r\n.....##...#..##\r\n..#...#.#.###..\r\n###.#.#.#....##\r\n........##...##\r\n####..#.#....#.\r\n\r\n.....#.##.#..\r\n##....####...\r\n..#...#..#...\r\n###.##....##.\r\n##...##..##..\r\n####.#....#.#\r\n##..########.\r\n.....##..##..\r\n##.##..#...##\r\n..###......##\r\n##...#.##.#..\r\n##..########.\r\n...##########\r\n..##...##...#\r\n...###.##.###\r\n\r\n##......####..#..\r\n##.#..#.###....##\r\n##..##..##.#.#..#\r\n##..##..##.#.#..#\r\n##.#..#.###....##\r\n##......####..#..\r\n.##.##.##...#..##\r\n.#..##..#.##....#\r\n##########...####\r\n###.##.###...#.#.\r\n#.#....#.#..###..\r\n.#..##..#.#.#.#.#\r\n.########..#..##.\r\n##########.###...\r\n..####.#..#.##.#.\r\n...#..#...##.##..\r\n##.#..#.####..#.#\r\n\r\n..##.....#..#..\r\n.#..#.#.#.##.#.\r\n#.##.#.#.####.#\r\n######.#######.\r\n##..##.#..##..#\r\n##..##..#.##.#.\r\n......#..#..#..\r\n#....##.##..##.\r\n.#..#.####..###\r\n######..##..##.\r\n######.###..###\r\n.####...#.##.#.\r\n#.##.#.#......#\r\n\r\n..##.#.\r\n######.\r\n#.##.#.\r\n.####.#\r\n##..##.\r\n..##..#\r\n.####.#\r\n.####.#\r\n..##..#\r\n\r\n###..#.\r\n##..#.#\r\n...##.#\r\n..##..#\r\n...##..\r\n##..#.#\r\n..##.#.\r\n..#....\r\n......#\r\n......#\r\n..#....\r\n..##.#.\r\n##..#.#\r\n...##..\r\n..##..#\r\n...##.#\r\n##..###\r\n\r\n.###...##....\r\n##..##.#..##.\r\n####..##..##.\r\n#...##...#...\r\n.########.##.\r\n..###..######\r\n....##.##....\r\n#...##.#.####\r\n..##.##.#....\r\n#...##.#..##.\r\n..#.###...##.\r\n..#.###...##.\r\n#...##.#..##.\r\n..##.##.#....\r\n#...##.#.####\r\n\r\n....#.####.\r\n......##..#\r\n.....#..##.\r\n#..###.####\r\n#..##..####\r\n#..##.##...\r\n......###.#\r\n....#..#.##\r\n.....#..#..\r\n####.#..##.\r\n####.#..#..\r\n####.#..#..\r\n####.#...#.\r\n.....#..#..\r\n....#..#.##\r\n......###.#\r\n#..##.##...\r\n\r\n########......#\r\n...##...######.\r\n...##...##..##.\r\n.##..##..#..#..\r\n..####..#.##.#.\r\n#......#......#\r\n......#........\r\n\r\n###...#.#####\r\n###...#.##.##\r\n#########.#..\r\n..#.#.#.##..#\r\n....#..#.....\r\n..###.##..##.\r\n##.####..####\r\n\r\n...##.#..\r\n..##.#.##\r\n#.##..###\r\n.#..#####\r\n..#...#..\r\n.#.######\r\n.########\r\n\r\n...###.\r\n...###.\r\n..#.#..\r\n.#.##.#\r\n.#...#.\r\n#.###.#\r\n#.###.#\r\n.#...#.\r\n.#.##.#\r\n..#.#..\r\n#..###.\r\n\r\n.##..##\r\n....#..\r\n##..#..\r\n#.#....\r\n#.#....\r\n##..#..\r\n....#..\r\n.##.###\r\n#..#.##\r\n\r\n.##.###.#.#\r\n#....##..#.\r\n#.#.#.####.\r\n#.#.#.####.\r\n#....##..#.\r\n.##.###.#.#\r\n#.#.######.\r\n##.#..##..#\r\n#...#...#.#\r\n##...#..#.#\r\n.#.#.#.#...\r\n.#.#.#.#...\r\n##...#....#\r\n#...#...#.#\r\n##.#..##..#\r\n\r\n##.#..###...#\r\n###.##......#\r\n####.#..###.#\r\n....##....#.#\r\n...#.##.#...#\r\n###.#..######\r\n.....####....\r\n.....####....\r\n###.#..######\r\n...#.##.#...#\r\n....##....#.#\r\n####.#..###.#\r\n###.#.......#\r\n##.#..###...#\r\n####.########\r\n\r\n....#....##\r\n####..#.#..\r\n#####....##\r\n#..##...#.#\r\n#..#.....##\r\n#..#..#..##\r\n....#.#.#..\r\n....###.###\r\n......#.###\r\n#######..##\r\n######.#.##\r\n\r\n.####..######\r\n#....##..##..\r\n#.##.#..#..#.\r\n......#.####.\r\n#######..##..\r\n#.##.##..##..\r\n.####.#.####.\r\n#######.#..##\r\n##..##.#.##.#\r\n#....#.#....#\r\n.####..#.##.#\r\n#....##......\r\n#....###....#\r\n......#.####.\r\n.####..######\r\n\r\n...##....\r\n##...#..#\r\n#..#####.\r\n.#.##.#..\r\n..####..#\r\n###...###\r\n###...###\r\n...###..#\r\n.#.##.#..\r\n#..#####.\r\n##...#..#\r\n...##....\r\n.#.#..#..\r\n.#.#..#..\r\n...##....\r\n##...#..#\r\n#..#####.\r\n\r\n..##..#..#.#.#.##\r\n..##..#..#.#...##\r\n....##.####..#.##\r\n#.#...#.###.###..\r\n##.#.###.#...#...\r\n##.#.###.#...#...\r\n#.#...#.###.###..\r\n....##.####..#.##\r\n..##..#..#.#...##\r\n..##..#..#.#.#.##\r\n##....###..#..#.#\r\n......#.#.....##.\r\n#.#..#####......#\r\n.###..##.#.#.#..#\r\n..#.###..#.##.###\r\n\r\n###.##....##.##\r\n#..##.####.##..\r\n#..##.####.##..\r\n###.##....##.##\r\n.#..##.##.##..#\r\n##.....##.....#\r\n..#.##....##.#.\r\n.#....#..#....#\r\n##.##.#..#.##.#\r\n..#..........#.\r\n#..##......##..\r\n#......##....#.\r\n##...##..##...#\r\n\r\n.....##..##..##\r\n..#..#.##.###.#\r\n..##..#..##..#.\r\n..#.##.#.##.#.#\r\n#.#..##.####.##\r\n..#.....####...\r\n.#...#.######.#\r\n#.#............\r\n#.#............\r\n.#...#.######.#\r\n..#.....####...\r\n#.#..##.####.##\r\n..#.##.#.##.#.#\r\n\r\n.......##.#\r\n.##..#.#..#\r\n.##..#.#..#\r\n.......##.#\r\n#..###..###\r\n####.#####.\r\n#..###.####\r\n......##.##\r\n.#..####.##\r\n#..###...##\r\n.......##..\r\n\r\n##.#.#.#..##...\r\n#.#..####.##..#\r\n...##..#.#.####\r\n#.##...######..\r\n#..###..#.#.#..\r\n##..####.##..##\r\n#..#....#.#.###\r\n#..#....#.#.###\r\n##..####.##..##\r\n\r\n.#.......\r\n.#....#..\r\n.#....#..\r\n.#.......\r\n.####..##\r\n..##.##.#\r\n.#.......\r\n####....#\r\n###..##..\r\n.##.#..#.\r\n.########\r\n\r\n..#....#...\r\n..######...\r\n..#....#...\r\n#..#.##..##\r\n#...##...##\r\n.##....##.#\r\n#...##...#.\r\n#...##...#.\r\n.##....##.#\r\n\r\n.###..#\r\n.##....\r\n..####.\r\n.##.###\r\n#..###.\r\n.###.#.\r\n.###.#.\r\n#..###.\r\n..#.###\r\n..####.\r\n.##....\r\n.###..#\r\n.###..#\r\n.##....\r\n..####.\r\n\r\n.##..##\r\n#......\r\n..####.\r\n#..##..\r\n.##..##\r\n#..##..\r\n###..##\r\n\r\n##....##.\r\n....#.#.#\r\n#...#.#.#\r\n##....##.\r\n..#..##..\r\n...##..#.\r\n.#......#\r\n.#.#.#.##\r\n.#.#.#.##\r\n\r\n###...#.#\r\n......#.#\r\n###.###..\r\n###.###..\r\n......#.#\r\n###...#.#\r\n..#####.#\r\n##.....#.\r\n.##..##.#\r\n...#####.\r\n####..#.#\r\n\r\n...#....#.....#\r\n..########..#..\r\n..#......#..##.\r\n..########...#.\r\n##..####..##..#\r\n##.######.##...\r\n....#..#.....##\r\n###..##..#####.\r\n.#..#..#..#...#\r\n..#.####.#...#.\r\n...######....##\r\n###......#####.\r\n##..####..##..#\r\n###......####.#\r\n..#.#..#.#..##.\r\n####.##.#####.#\r\n..#......#..###\r\n\r\n...#..####.##...#\r\n.##.#.#..#.#.##.#\r\n.##...####...##.#\r\n..###......###..#\r\n#.#.#......#.#.##\r\n...#.##..##.#....\r\n.#...#....#...#.#\r\n##..#......#..##.\r\n#..#.######.#..##\r\n###...####...####\r\n###...####...####\r\n#..#.######.#..##\r\n##..#......#..##.\r\n.#...#....#...#.#\r\n...#.##..##.#....\r\n\r\n.#.#.##.#.###\r\n#.#.#..#.#.##\r\n###..##..####\r\n.##......##..\r\n.##.#..#.##.#\r\n############.\r\n############.\r\n.##.#..#.##.#\r\n.##......##..\r\n###..##..####\r\n#.#.#..#.#.##\r\n\r\n##...#...#...####\r\n#...##.##.....###\r\n#...##.##.....###\r\n##...#...##..####\r\n#.#.####.........\r\n#####..#...#.##..\r\n#.....#.#....#...\r\n.#.....##..##.#..\r\n##.#.#.###..#####\r\n\r\n##....#.#...####.\r\n##....#.#...####.\r\n###.##.#.##.#####\r\n#..#.##.##..##...\r\n.#..#..........##\r\n###.####.#.#####.\r\n.#....#.#.#.#.#..\r\n.#...##.###.#..##\r\n.#....#.###.#..##\r\n.#....#.#.#.#.#..\r\n###.####.#.#####.\r\n.#..#..........##\r\n#..#.##.##..##...\r\n###.##.#.##.#####\r\n##....#.#...####.\r\n\r\n#.##.##\r\n##..###\r\n..##...\r\n.#.#...\r\n#......\r\n..###..\r\n.####..\r\n#.###..\r\n..###..\r\n\r\n##.......##....\r\n####.#..#..#..#\r\n#...####....###\r\n###.#.#..##..#.\r\n##..#.#..##..#.\r\n#...####....###\r\n####.#..#..#..#\r\n##.......##....\r\n..##....####...\r\n\r\n#.#.######.#.####\r\n##.#.#..#.#.#####\r\n###.#....#.######\r\n#..#..##..#..#..#\r\n.#...#..#...#.##.\r\n#..###..###..####\r\n.##..#..#..##.##.\r\n.#...####...#.##.\r\n....##..##.......\r\n..##.#..#.##..##.\r\n.....#..#..#..##.\r\n##.###..###.#####\r\n.#.##....##.#....\r\n\r\n.####..####..#..#\r\n#.#..##..#.#.##..\r\n..##....##....##.\r\n.#..#..#..#.#..##\r\n#....##....#.#.#.\r\n.#..#..#..#.#####\r\n#....##....##..##";

            var lines = input.Replace("\r\n", "\n").Split('\n').ToList();
            lines.Add("");


            int sum = 0;
            int map = 1;

            int start = 0;
            int foundRow = 0;
            var verticals = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                if (string.IsNullOrEmpty(lines[i]))
                {
                    if (foundRow != 0)
                    {
                        sum += (foundRow - start) * 100;
                    }
                    else
                    {
                        //vertical check
                        for (int j = 1; j < verticals.Count; j++)
                        {
                            int smudge = 1;
                            int diff = verticals[j].Zip(verticals[j - 1], (x, y) => x == y).Count(z => !z);
                            if (diff <= smudge)
                            {
                                smudge -= diff;
                                bool match = true;
                                for (int left = j - 2, right = j + 1; left >= 0 && right < verticals.Count; left--, right++)
                                {
                                    diff = verticals[left].Zip(verticals[right], (x, y) => x == y).Count(z => !z);
                                    if (diff > 0)
                                    {
                                        if (smudge == 1 && diff == 1)
                                        {
                                            smudge--;
                                            continue;
                                        }
                                        match = false;
                                        break;
                                    }
                                }
                                if (match && smudge == 0)
                                {
                                    Console.WriteLine($"{map} V: {j}");
                                    sum += j;
                                }
                            }
                        }
                    }

                    start = i + 1;
                    foundRow = 0;
                    verticals = new List<string>();
                    map++;
                    continue;
                }

                for (int c = 0; c < lines[i].Length; c++)
                {
                    if (verticals.Count <= c)
                        verticals.Add("");
                    verticals[c] += (lines[i][c]);
                }

                // check H
                if (i == start /*|| foundRow > 0*/)
                    continue;

                int smudgeH = 1;
                int diffH = lines[i].Zip(lines[i - 1], (x, y) => x == y).Count(z => !z);
                if (diffH <= smudgeH)
                {
                    smudgeH -= diffH;
                    bool match = true;
                    for (int up = i - 2, down = i + 1; up >= 0 && !string.IsNullOrWhiteSpace(lines[up]) && !string.IsNullOrWhiteSpace(lines[down]); up--, down++)
                    {
                        diffH = lines[up].Zip(lines[down], (x, y) => x == y).Count(z => !z);
                        if (diffH > 0)
                        {
                            if (smudgeH == 1 && diffH == 1)
                            {
                                smudgeH--;
                                continue;
                            }
                            match = false;
                            break;
                        }
                    }
                    if (match && smudgeH == 0)
                    {
                        Console.WriteLine($"{map} H: {i - start}");
                        foundRow = i;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
