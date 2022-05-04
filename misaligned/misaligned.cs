using System;
using System.Collections.Generic;
using misaligned;

namespace MisalignedSpace
{
  public class Misaligned
  {
    public static List<ColorCodeProperties> PrintColorMap()
    {
      List<ColorCodeProperties> colorCodePairList = new List<ColorCodeProperties>();
      string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
      string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
      

      int i, j;
      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          string colorMapToPrint = string.Format("{0, -8} | {1, -8} | {2, -8}", i * 5 + j + 1, majorColors[i], minorColors[j]);
          colorCodePairList.Add(new ColorCodeProperties 
            {
              majorColor = majorColors[i], 
              minorColor = minorColors[i], 
              colorCodeToDisplay = colorMapToPrint
            });

          Console.WriteLine(colorMapToPrint);
        } 
      }
      
      return colorCodePairList;
    }
  }
}

