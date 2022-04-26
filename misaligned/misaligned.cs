using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MisalignedSpace
{
  class Misaligned
  {
    private static List<string> _majorColorList = new List<string>();
    private static List<string> _minorColorList = new List<string>();
    private static List<int> _pairNumber = new List<int>();

    static int PrintColorMap()
    {
      string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
      string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
      int i = 0, j = 0;
      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
          _pairNumber.Add(i * 5 + j);
          _majorColorList.Add(majorColors[i]);
          _minorColorList.Add(minorColors[i]);
        }
      }
      return i * j;
    }
    static void Main(string[] args)
    {
      int result = PrintColorMap();
      Debug.Assert(result == 25);
      Console.WriteLine("Count status - Success");

      //Check the sequence of major and minor colors
      Debug.Assert(_majorColorList[1] == "White");
      Debug.Assert(_minorColorList[1] == "Blue");
      Console.WriteLine("Sequence Check - Success");

      Debug.Assert(_majorColorList[10] == "Red");
      Debug.Assert(_minorColorList[10] == "Slate");
      Console.WriteLine("Sequence Check - Success");

      //Check the pair number
      Debug.Assert(_pairNumber[10] == 11);
      Console.WriteLine("Pair Number Check - Success");

      Console.WriteLine("All is well (maybe!)");
    }
  }
}

