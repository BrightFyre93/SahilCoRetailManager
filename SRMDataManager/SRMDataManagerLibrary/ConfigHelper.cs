using System.Configuration;

namespace SRMDataManagerLibrary
{
    public class ConfigHelper
    {
        public static decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidTaxRate = decimal.TryParse(rateText, out decimal output);

            if (!isValidTaxRate)
            {
                throw new ConfigurationErrorsException("The Tax Rate is not setup properly.");
            }

            return output;
        }
    }
}
