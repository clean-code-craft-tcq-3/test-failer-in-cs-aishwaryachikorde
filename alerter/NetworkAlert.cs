using System;

namespace alerter
{
  public class NetworkAlert
  {
    public static int AlertNetwork(float celsius)
    {
      Console.WriteLine("ALERT: Temperature is {0} celcius", celsius);
      if (celsius > 200) //200 is the threshold value
      {
        return 500; // 500 is the failure value
      }
      
      // stub always succeeds and returns 200
      return 200;
    }
  }
}
