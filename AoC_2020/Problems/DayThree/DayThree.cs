using System;
using System.Collections.Generic;
using System.Text;

namespace AoC_2020.Problems.DayThree
{
    public  class DayThree
    {
        public DayThree()
        {
            XPosition = 0;
            YPosition = 0;
        }
        public int MapHeight { get; set; }
        public int MapWidth { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int TreesCounter { get; set; }
        public int NextLineMovement { get; set; }
        public long TreesEncountered(string[] treeLines)
        {
            MapWidth = treeLines[0].Length;
            MapHeight = treeLines.Length;
          
            for(int i = 0; i < treeLines.Length; i++)
            {
                char[] treeLine = treeLines[i].ToCharArray();
                var x = 5;
            }

            return 0;
        }
    }
}
