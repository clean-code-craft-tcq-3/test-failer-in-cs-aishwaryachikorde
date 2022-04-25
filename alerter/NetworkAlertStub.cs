using System;

namespace alerter
{
  public class NetworkAlertStub: INetworkAlert
  {
    public int AlertNetwork(float celsius)
    {
      Console.WriteLine("ALERT: Temperature is {0} celsius", celsius);
      // Return 200 for ok
      // Return 500 for not-ok
      // stub always succeeds and returns 200
      return 200;
    }
  }
}
