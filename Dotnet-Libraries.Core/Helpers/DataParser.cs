namespace Dotnet_Libraries.Core.Helpers
{
    public static class DataParser
    {
        /// <summary>
        /// Clear Turkish Characters
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ClearTurkishCharacters(string text)
        {
            text = text.Replace("ı", "i");
            text = text.Replace("İ", "I");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ü", "u");
            text = text.Replace("Ü", "U");
            text = text.Replace("ş", "s");
            text = text.Replace("Ş", "S");
            text = text.Replace("ö", "o");
            text = text.Replace("Ö", "O");
            text = text.Replace("ç", "c");
            text = text.Replace("Ç", "C");
            return text;
        }

        /// <summary>
        /// Clear Phone Number
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ClearPhoneNumber(string text)
        {
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace(" ", "");
            text = text.Replace("-", "");
            return text;
        }

        /// <summary>
        /// Convert To Decimal By String
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static decimal ConvertToDecimalByString(string text)
        {
            if (decimal.TryParse(text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
