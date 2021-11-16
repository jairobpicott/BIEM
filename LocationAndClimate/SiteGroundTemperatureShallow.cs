﻿using System.Collections.Generic;
using System.IO;

namespace BIEM.LocationAndClimate
{
    class SiteGroundTemperatureShallow
    {
        private double? _january = 13;
        public double? January
        {
            get => _january;
            set => _january = value;
        }

        private double? _february = 13;
        public double? February
        {
            get => _february;
            set => _february = value;
        }

        private double? _march = 13;
        public double? March
        {
            get => _march;
            set => _march = value;
        }

        private double? _april = 13;
        public double? April
        {
            get => _april;
            set => _april = value;
        }

        private double? _may = 13;
        public double? May
        {
            get => _may;
            set => _may = value;
        }

        private double? _june = 13;
        public double? June
        {
            get => _june;
            set => _june = value;
        }

        private double? _july = 13;
        public double? July
        {
            get => _july;
            set => _july = value;
        }

        private double? _august = 13;
        public double? August
        {
            get => _august;
            set => _august = value;
        }

        private double? _septembre = 13;
        public double? September
        {
            get => _septembre;
            set => _septembre = value;
        }

        private double? _october = 13;
        public double? October
        {
            get => _october;
            set => _october = value;
        }

        private double? _november = 13;
        public double? November
        {
            get => _november;
            set => _november = value;
        }

        private double? _december = 13;
        public double? December
        {
            get => _december;
            set => _december = value;
        }

        public SiteGroundTemperatureShallow() { }
        private static List<SiteGroundTemperatureShallow> list = new List<SiteGroundTemperatureShallow>();

        public static void Add(SiteGroundTemperatureShallow siteGroundTemperatureShallow)
        {
            list.Add(siteGroundTemperatureShallow);
        }
        private static string[] Read()
        {
            string[] print = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                print[i] = $"Site:GroundTemperature:Shallow,\n" +
                    ($"  {list[i].January}" + ",").PadRight(27, ' ') + " !-January{{ C }}\n" +
                    ($"  {list[i].February}" + ",").PadRight(27, ' ') + " !-February{{ C }}\n" +
                    ($"  {list[i].March}" + ",").PadRight(27, ' ') + " !-March{{ C }}\n" +
                    ($"  {list[i].April}" + ",").PadRight(27, ' ') + " !-April{{ C }}\n" +
                    ($"  {list[i].May}" + ",").PadRight(27, ' ') + " !-May{{ C }}\n" +
                    ($"  {list[i].June}" + ",").PadRight(27, ' ') + " !-June{{ C }}\n" +
                    ($"  {list[i].July}" + ",").PadRight(27, ' ') + " !-July{{ C }}\n" +
                    ($"  {list[i].August}" + ",").PadRight(27, ' ') + " !-August{{ C }}\n" +
                    ($"  {list[i].September}" + ",").PadRight(27, ' ') + " !-September{{ C }}\n" +
                    ($"  {list[i].October}" + ",").PadRight(27, ' ') + " !-October{{ C }}\n" +
                    ($"  {list[i].November}" + ",").PadRight(27, ' ') + " !-November{{ C }}\n" +
                    ($"  {list[i].December}" + ";").PadRight(27, ' ') + " !-December{{ C }}";

            }

            return print;
        }

        public static void Get(string idfFile)
        {
            using (StreamWriter sw = File.AppendText(idfFile))
            {
                foreach (string line in SiteGroundTemperatureShallow.Read())
                {
                    sw.WriteLine(line);
                }
            }

        }
        public static void Clear()
        {
            list.Clear();
        }
    }
}
