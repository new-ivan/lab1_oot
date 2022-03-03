using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace lab1_sandbox
{
    public class Coordinate
    {
        public double x;
        public double y;
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinate(string text)
        {
            text = text.Substring(1, text.Length - 2);
            text.Replace(' ', '\0');
            string[] text1 = text.Split(',');
            x = double.Parse(text1[0].Replace('.', ','));
            y = double.Parse(text1[1].Replace('.', ','));
        }
    }
}
