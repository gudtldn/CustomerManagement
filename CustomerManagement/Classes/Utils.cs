using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Classes
{
    public static class Utils
    {
        public static string FormatPhoneNumber(string phone_number)
        {
            if (string.IsNullOrEmpty(phone_number))
                return string.Empty;

            if (phone_number.Length < 9 || phone_number.Length > 11)
                return phone_number;

            if (phone_number.Length == 9)
                return phone_number.Substring(0, 2) + "-" + phone_number.Substring(2, 3) + "-" + phone_number.Substring(5);
            else if (phone_number.Length == 10)
                return phone_number.Substring(0, 3) + "-" + phone_number.Substring(3, 3) + "-" + phone_number.Substring(6);
            else // phone_number.Length == 11
                return phone_number.Substring(0, 3) + "-" + phone_number.Substring(3, 4) + "-" + phone_number.Substring(7);
        }
    }
}
