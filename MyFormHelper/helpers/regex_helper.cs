using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyFormHelper.helpers
{
    public class regex_helper
    {
        public static bool Validate(string value, string expression)
        {
            bool is_match = false;

            if (Regex.IsMatch(value, expression))
            {
                if (Regex.Replace(value, expression, string.Empty).Length == 0)
                {
                    is_match = true;
                }
            }

            return is_match;
        }

        public static bool ValidatePassword(string pass)
        {
            return Validate(pass, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,15}$");
        }
    }
}
