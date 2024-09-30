using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSRS
{
    internal class Utility
    {
        public static bool IsNumeric(string input)
        {
            // Define a regular expression pattern to match numeric digits
            string pattern = "^[0-9]+$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }


        public static bool DateFormat(string inputDate, out DateTime parsedDate)
        {
            return DateTime.TryParseExact(inputDate, "dd-MM-yyyy",
                                      System.Globalization.CultureInfo.InvariantCulture,
                                      System.Globalization.DateTimeStyles.None,
                                      out parsedDate);

        }


        public class Validity
        {
            public static bool IsPhoneNumberValid(string phn_num)
            {
                if (phn_num.Length == 11)
                {
                    // Use Regex pattern matching to validate phone number format
                    string phnNumPattern = @"^\d{11}$";

                    // Validate phone number and email format
                    // If phone number is valied then return true otherwise false
                    return Regex.IsMatch(phn_num, phnNumPattern);
                }

                return false;
            }

            public static bool IsEmailValid(string email)
            {
                // Use Regex pattern matching to validate email format
                string emailFormatPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                // Validate email format
                // If email is valied then return true otherwise false
                return Regex.IsMatch(email, emailFormatPattern);
            }
        }

    }
}
