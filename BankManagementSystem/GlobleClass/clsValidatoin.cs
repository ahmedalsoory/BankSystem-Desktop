using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.GlobleClass
{
    public static class clsValidatoin
    {
        public static bool IsFloatNumber(string str)
        {
            string Pattren = @"^[0-9]*(?:\.[0-9]*)?$";
            Regex regex = new Regex(Pattren);
            return regex.IsMatch(str);
        }
    }
}
