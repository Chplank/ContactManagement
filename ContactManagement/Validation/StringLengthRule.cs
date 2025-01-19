using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ContactManagement.Validation
{
    public class StringLengthRule : ValidationRule
    {
        public int Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var input = value as string;

            if (input is null)
                return new ValidationResult(false, "Invalid input");

            if (input.Length > Max)
                return new ValidationResult(false, $"Your input exceeds the max input length ({Max})");

            return new ValidationResult(true, null);
        }
    }
}
