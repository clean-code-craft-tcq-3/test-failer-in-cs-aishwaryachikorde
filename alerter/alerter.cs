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

        private static void AlertInCelsius(float farenheit, string environment)
        {
          int returnCode = 0;
          float celsius = ConvertFarenheitToCelsius(farenheit);
          switch (environment)
          {
            case "Test":
              returnCode = NetworkAlert.AlertNetwork(celsius);
            break;
           case "Production":
             returnCode = NetworkAlertStub.AlertNetwork(celsius);
           break;
          }
          
          if (returnCode != 200)
          {
            alertFailureCount += 0;
          }
        }
    
        static void Main(string[] args) 
        {
            AlertInCelsius(400.5f, "Test");
            Debug.Assert(alertFailureCount == 0);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);

            AlertInCelsius(303.6f, "Production");
            Debug.Assert(alertFailureCount == 1);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
      
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}

