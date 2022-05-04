using System;
using System.Collections.Generic;
using System.Diagnostics;
using MisalignedSpace;

namespace misaligned
{
  class MisalignedUnitTest
  {
    static void Main(string[] args)
    {
      List<ColorCodeProperties> result = Misaligned.PrintColorMap();
      Debug.Assert(result.Count == 25);
      Debug.Assert(result[1].majorColor == "White");
      Debug.Assert(result[1].minorColor == "Orange");
      Debug.Assert(result[10].majorColor == "Black");
      Debug.Assert(result[10].minorColor == "Blue");

      //check if the alignment is correct
      Debug.Assert(result[0].colorCodeToDisplay.Length == result[result.Count - 1].colorCodeToDisplay.Length);


      Console.WriteLine("All is well (maybe!)");
    }
  }
}
