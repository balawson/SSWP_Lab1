// Blake Lawson
// 08/31/2023
// Lab 1 VideoGame
// Server Side Web Programming

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SSWP_Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] csvLines = File.ReadAllLines("C:\\videogames.csv");

            var games = new List<VideoGame>();

            for (int i = 1; i < csvLines.Length; i++)
            {
                VideoGame vg = new VideoGame(csvLines[i]);
                games.Add(vg);
            }

            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine(games[i]);
            }

            Console.ReadKey();
            
        }


        public class VideoGame
        {
            public string Name { get; set; }
            public string Platform { get; set; }
            public int Year { get; set; }
            public string Genre { get; set; }
            public string Publisher { get; set; }
            public double NA_Sales { get; set; }
            public double EU_Sales { get; set; }
            public double JP_Sales { get; set; }
            public double Other_Sales { get; set; }
            public double Global_Sales { get; set; }

            public VideoGame (string rowData)
            {
                string[] data = rowData.Split(',');

                this.Name = data[0];
                this.Platform = data[1];
                this.Year = Convert.ToInt32(data[2]);
                this.Genre = data[3];
                this.Publisher = data[4];
                this.NA_Sales = Convert.ToDouble(data[5]);
                this.EU_Sales = Convert.ToDouble(data[6]);
                this.JP_Sales = Convert.ToDouble(data[7]);
                this.Other_Sales = Convert.ToDouble(data[8]);
                this.Global_Sales = Convert.ToDouble(data[9]);
            }

            public override string ToString()
            {
                string str = $"{Name}" + $", {Platform}" + $", {Year}" + $", {Genre}" + $", {Publisher}" + $", {NA_Sales}" + $", {EU_Sales}" + $", {JP_Sales}" + $", {Other_Sales}" + $", {Global_Sales}";
                return str;
            }
            
        }


    }
}












