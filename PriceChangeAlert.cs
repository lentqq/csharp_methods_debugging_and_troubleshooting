using System;

namespace _11.PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double thresholdValue = double.Parse(Console.ReadLine());
            double prices = double.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrices = double.Parse(Console.ReadLine());
                double percent = Percent(prices, currentPrices);
                bool significationDifference = CheckForDifference(percent, thresholdValue);
                message = GetAlertMessage(currentPrices, prices, percent, significationDifference);

                Console.WriteLine(message);
                prices = currentPrices;
            }
        }

        private static string GetAlertMessage(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string @case = string.Empty;
            if (difference == 0)
            {
                @case = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                @case = string.Format("MINOR CHANGE: {0} to {1} ({2:f2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                @case = string.Format("PRICE UP: {0} to {1} ({2:f2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
                @case = string.Format("PRICE DOWN: {0} to {1} ({2:f2}%)", lastPrice, currentPrice, difference * 100);
            return @case;
        }

        private static bool CheckForDifference(double thresholdValue, double difference)
        {
            if (Math.Abs(thresholdValue) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double Percent(double prices, double currentPrices)
        {
            double result = ((currentPrices - prices) / prices);
            return result;
        }
    }
}

