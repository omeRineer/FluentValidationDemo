using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_3.ValidationRules.CustomValidators
{
    public static class CustomValidators
    {
        public static IRuleBuilderOptions<T,string> FirstUpperCase<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(x=> x.FirstOrDefault().ToString() == CultureInfo.CurrentCulture.TextInfo.ToTitleCase(x.FirstOrDefault().ToString()));
        }
    }
}
