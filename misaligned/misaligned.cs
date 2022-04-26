using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MisalignedSpace
{
  class Misaligned
  {
    private static List<string> majorColorList = new List<string>();
    private static List<string> minorColorList = new List<string>();

    static int printColorMap()
    {
      string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
      string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
      int i = 0, j = 0;
      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
          majorColorList.Add(majorColors[i]);
          minorColorList.Add(minorColors[i]);
        }
      }
      return i * j;
    }
    static void Main(string[] args)
    {
      int result = printColorMap();
      Debug.Assert(result == 25);
      Console.WriteLine("Count status - Success");

      //Check the sequence of major and minor colors
      Debug.Assert(majorColorList[1] == "White");
      Debug.Assert(minorColorList[1] == "Blue");
      Console.WriteLine("Sequence Check - Success");

      Debug.Assert(majorColorList[10] == "Red");
      Debug.Assert(minorColorList[10] == "Slate");
      Console.WriteLine("Sequence Check - Success");
      Console.WriteLine("All is well (maybe!)");
    }
  }
}
