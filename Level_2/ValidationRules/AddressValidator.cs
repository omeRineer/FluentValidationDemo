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
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .MaximumLength(100)
                .WithName("Sokak");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("{PropertyName} boş geçilemez")
                .Length(2, 13).WithMessage("{PropertyName} alanı {MinLength}-{MaxLength} karakter uzunluğunda olmalı")
                .WithName("Şehir");
        }
    }
}
