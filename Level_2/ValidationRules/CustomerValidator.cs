using FluentValidation;
using Level_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2.ValidationRules
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .Length(3,15).WithMessage("{PropertyName} alanı {MinLength}-{MaxLength} karakter uzunluğunda olmalı")
                .WithName("İsim");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .Length(2, 15).WithMessage("{PropertyName} alanı {MinLength}-{MaxLength} karakter uzunluğunda olmalı")
                .WithName("Soyadı");

            RuleFor(x => x.NationalityId)
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez")
                .Length(11, 11).WithMessage("{PropertyName} alanı {MinLength} karakter uzunluğunda olmalı")
                .WithName("Kimlik no");

            RuleFor(x => x.Address).SetValidator(new AddressValidator());

        }
    }
}
