using System;
using System.Collections.Generic;
using misaligned;

namespace MisalignedSpace
{
  public class Misaligned
  {
    static void Main()
    {
      string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
      string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

      List<ColorCodeProperties> colorCode = GetColorCodeMap(minorColors, majorColors);

      PrintColorMapOnConsole(colorCode);

      MisalignedUnitTest unitTest = new MisalignedUnitTest(colorCode);
      unitTest.ColorCodeTest(minorColors, majorColors);

      Console.WriteLine("All is well (maybe!)");
    }

    private static void PrintColorMapOnConsole(List<ColorCodeProperties> colorPair)
    {
      foreach (ColorCodeProperties colorCode in colorPair)
      {
        Console.WriteLine("{0, -8} | {1, -8} | {2, -8}", colorCode.PairNumber, colorCode.MajorColor, colorCode.MinorColor);
      }
    }

    public static List<ColorCodeProperties> GetColorCodeMap(string[] minorColors, string[] majorColors)
    {
      List<ColorCodeProperties> colorCodePairList = new List<ColorCodeProperties>();
      for (int i = 0; i < majorColors.Length; i++)
      {
        for (int j = 0; j < minorColors.Length; j++)
        {
          colorCodePairList.Add(new ColorCodeProperties
          {
            MinorColor = minorColors[j],
            MajorColor = majorColors[i],
            PairNumber = (i*5+j) +1

          });
        }
      }

      return colorCodePairList;
    }
  }
}


