using System;
using System.Diagnostics;

namespace alerter
{
  class AlerterUnitTest
  {
    static void Main(string[] args)
    {
      Alerter.AlertInCelsius(303.6f);
      Debug.Assert(Alerter.AlertFailureCount == 0);

      Alerter.AlertInCelsius(-303.6f);
      Debug.Assert(Alerter.AlertFailureCount == 0);

      Alerter.AlertInCelsius(400.5f);
      Debug.Assert(Alerter.AlertFailureCount == 1);

      Alerter.AlertInCelsius(393f);
      Debug.Assert(Alerter.AlertFailureCount == 2);

      Console.WriteLine("{0} alerts failed.", Alerter.AlertFailureCount);
      Console.WriteLine("All is well (maybe!)\n");
    }
  }
}

