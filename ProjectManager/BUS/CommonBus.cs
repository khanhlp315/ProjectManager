using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CommonBUS
{
    public class StringValidationRule: ValidationRule
    {
        public enum LimitComparisionType
        {
            LessThanOrEqual,
            Equal,
            MoreThanOrEqual
        }
        public string DisplayName = "Value";
        public bool CanBeEmpty = false;
        public bool AllowWhiteSpace = true;
        public LimitComparisionType LimitComparision;
        public int CharacterLimit;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (CanBeEmpty = false && String.IsNullOrEmpty(value.ToString()))
                return new ValidationResult(false, DisplayName + " cannot be null");
            if (AllowWhiteSpace = false && (String.IsNullOrWhiteSpace(value.ToString()) || value.ToString().IndexOf(" ") > 0))
                return new ValidationResult(false, DisplayName + " cannot have whitespace");

            switch (LimitComparision)
            {
                case LimitComparisionType.LessThanOrEqual:
                    if (value.ToString().Length > CharacterLimit)
                        return new ValidationResult(false, DisplayName + " have to under " + CharacterLimit + " character");
                    break;
                case LimitComparisionType.Equal:
                    if (value.ToString().Length != CharacterLimit)
                        return new ValidationResult(false, DisplayName + " have to exact " + CharacterLimit + " character");
                    break;
                case LimitComparisionType.MoreThanOrEqual:
                    if (value.ToString().Length < CharacterLimit)
                        return new ValidationResult(false, DisplayName + " have to larger " + CharacterLimit + " character");
                    break;
            }
            return ValidationResult.ValidResult;
        }
    }
    public class PositiveIntegerValidationRule : ValidationRule
    {
        public string DisplayName = "Value";
        public int HigherThan = 0;
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (String.IsNullOrEmpty(value.ToString()))
                return new ValidationResult(false, "This value cannot be empty");
            if (!int.TryParse(value.ToString(), out int result))
                return new ValidationResult(false, "This value have to be an integer value");
            if (result < 0)
                return new ValidationResult(false, "Must be a positive value");
            if (result < HigherThan)
                return new ValidationResult(false, "Must be higher than");
            return ValidationResult.ValidResult;
        }
    }

}
