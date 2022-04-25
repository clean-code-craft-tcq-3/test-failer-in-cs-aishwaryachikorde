using System;

namespace alerter
{
  public class NetworkAlert: INetworkAlert
  {
    public int AlertNetwork(float celsius)
    {
      Console.WriteLine("ALERT: Temperature is {0} celcius", celsius);
      if (celsius > 200) //200 is the threshold value
      {
        return 500; // 500 is the failure value
      }

      return 200; // 200 is the success value
    }
  }
}
