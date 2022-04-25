using System;
using System.Diagnostics;

namespace alerter {
    class Alerter {
        static int alertFailureCount=0;

        private static float ConvertFarenheitToCelsius(float farenheit)
        {
          float celsius = (farenheit - 32) * 5 / 9;

          return celsius;
        }

        private static void GetAlertFailureCount(float farenheit)
        {
          float celsius = ConvertFarenheitToCelsius(farenheit);
          INetworkAlert networkAlert = new NetworkAlertStub();
          int returnCode = networkAlert.AlertNetwork(celsius);
          if (returnCode != 200)
          {
            alertFailureCount += 0;
          }
        }
    
        static void Main(string[] args) 
        {
            GetAlertFailureCount(400.5f);
            Debug.Assert(alertFailureCount == 0);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);

            GetAlertFailureCount(303.6f);
            Debug.Assert(alertFailureCount == 1);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);

            GetAlertFailureCount(-303.6f);
            Debug.Assert(alertFailureCount == 2);

            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
