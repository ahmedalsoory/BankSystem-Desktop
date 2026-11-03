using System;
namespace Bank_Business
{
    public static class clsUtil
    {
        public static string GetRandomNumber(byte NumberOfDigits)
        {
            int Min =(int)Math.Pow(10, NumberOfDigits);
            int Max = (int)(Math.Pow(10, NumberOfDigits+1)-1);

            Random random = new Random();
            return random.Next(Min, Max).ToString();
        }
    }
}
