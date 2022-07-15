using FluentValidation;
using Level_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level_3.ValidationRules.CustomValidators;

namespace Level_3.ValidationRules
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .Length(3, 20).WithMessage("{PropertyName} {MinLength}-{MaxLength} karakter arasında olmalı")
                .FirstUpperCase().WithMessage("{PropertyName} büyük harf ile başlamalıdır")
                .WithName("İsim");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .Length(2, 20).WithMessage("{PropertyName} {MinLength}-{MaxLength} karakter arasında olmalı")
                .FirstUpperCase().WithMessage("{PropertyName} büyük harf ile başlamalıdır")
                .WithName("Soyisim");

            RuleFor(x => x.NationalityId)
                .Must(x => x.Length == 11).When(x => x.Country == "TR").WithMessage("{PropertyName} alanı uzunluğu 11 karakter olmalıdır")
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .WithName("Kimlik No");
        }
    }
}
