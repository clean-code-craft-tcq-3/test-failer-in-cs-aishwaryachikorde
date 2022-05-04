namespace alerter {
    class Alerter {
        public static int alertFailureCount = 0;

        private static float ConvertFarenheitToCelsius(float farenheit)
        {
          float celsius = (farenheit - 32) * 5 / 9;

          return celsius;
        }

        public static void AlertInCelsius(float farenheit, string environment)
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
            alertFailureCount += 1;
          }
        }
    }
}
