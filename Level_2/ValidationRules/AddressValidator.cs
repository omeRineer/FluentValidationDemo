using FluentValidation;
using Level_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("Bu alan boş geçilemez")
                .MaximumLength(100);

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Bu alan boş geçilemez")
                .Length(2, 13).WithMessage("Şehir ismi 2-13 karakter uzunluğunda olmalı");
        }
    }
}
