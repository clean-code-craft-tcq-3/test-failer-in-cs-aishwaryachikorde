namespace alerter {
    class Alerter {
        public static int AlertFailureCount;

        private static float ConvertFarenheitToCelsius(float farenheit)
        {
          float celsius = (farenheit - 32) * 5 / 9;

          return celsius;
        }

        public static void AlertInCelsius(float farenheit)
        {
          int returnCode;
          float celsius = ConvertFarenheitToCelsius(farenheit);
         returnCode = NetworkAlert.AlertNetwork(celsius);
        
          if (returnCode != 200)
          {
            AlertFailureCount += 1;
          }
        }
    }
}
