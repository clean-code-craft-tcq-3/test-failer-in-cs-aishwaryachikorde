using System;
using System.Diagnostics;

namespace alerter
{
  class AlerterUnitTest
  {
    static void Main(string[] args)
    {
      Alerter.AlertInCelsius(303.6f, "Production");
      Debug.Assert(Alerter.alertFailureCount == 0);
      
      Alerter.AlertInCelsius(400.5f, "Test");
      Debug.Assert(Alerter.alertFailureCount == 1);

      Console.WriteLine("{0} alerts failed.", Alerter.alertFailureCount);
      Console.WriteLine("All is well (maybe!)\n");
    }
  }
}
