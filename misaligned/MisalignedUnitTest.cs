using System.Collections.Generic;
using System.Diagnostics;

namespace misaligned
{
  class MisalignedUnitTest
  {
    List<ColorCodeProperties> ColorCode;

    //Constructor
    public MisalignedUnitTest(List<ColorCodeProperties> colorCode)
    {
      ColorCode = colorCode;
    }

    //Calculate color pair count
    private static int GetCount(string[] minorColors, string[] majorColors)
    {
      return majorColors.Length * minorColors.Length;
    }

    public void ColorCodeTest(string[] minorColors, string[] majorColors)
    {
      for (int i = 0; i < ColorCode.Count; i++)
      {
        Debug.Assert(ColorCode[i] != null);
        Debug.Assert(ColorCode[i].PairNumber == i + 1);
        Debug.Assert(ColorCode[0].MajorColor == "White");
        Debug.Assert(ColorCode[0].MinorColor == "Blue");
        Debug.Assert(ColorCode[9].MajorColor == "Red");
        Debug.Assert(ColorCode[9].MinorColor == "Slate");
      }

      Debug.Assert(GetCount(majorColors, minorColors) == 25);
    }
  }
}
