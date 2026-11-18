using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomMapGenerator
{
    static class Constants
    {
        /// <summary>VERA20K supports width + height up to 1024 (vanilla RA2/YR: 512).</summary>
        public const int MaxMapSpan = 1024;
        /// <summary>VERA20K supports up to 30 starting players (vanilla RA2/YR: 8).</summary>
        public const int MaxPlayers = 30;
        /// <summary>Retail maps use a 512x512 overlay plane; extended maps use 1024x1024.</summary>
        public const int RetailCellGridSize = 512;
        public const int ExtendedCellGridSize = 1024;

        public static string WorkFolder { get; set; } = @"C:\Users\hanfangxu\Documents\GitHub\MapEditor_RA2\";
        public static string FileName = "map.yrm";
        public static string SaveFileName = "Output.txt";
        public static string MapPackName = "IsoMapPack5";
        public static string FilePath = WorkFolder + FileName;
        public static string SaveFilePath = WorkFolder + SaveFileName;
        public static string BitMapName = "bitmap.bmp";
        public static string BitMapPath = WorkFolder + BitMapName;
        public static string TemplateMapName = "templateMap.map";
        public static string TemplateMapPath = WorkFolder + TemplateMapName;
        public static string TEMPERATEPath = WorkFolder + @"TileInfo\TEMPERATE\";
        public static string SNOWPath = WorkFolder + @"TileInfo\SNOW\";
        public static string URBANPath = WorkFolder + @"TileInfo\URBAN\";
        public static string NEWURBANPath = WorkFolder + @"TileInfo\NEWURBAN\";
        public static string LUNARPath = WorkFolder + @"TileInfo\LUNAR\";
        public static string DESERTPath = WorkFolder + @"TileInfo\DESERT\";

        public static int FailureTimes = 10000;
        public static string RenderPath = WorkFolder + @"Map Renderer\CNCMaps.Renderer.exe";
        public static string GamePath = @"D:\Games\YURI\Red Alert 2";
    }
}
