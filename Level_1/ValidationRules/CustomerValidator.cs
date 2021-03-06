using FluentValidation;
using Level_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_1.ValidationRules
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Bu alan boş geçilemez")
                .Length(3, 15).WithMessage("İsminiz 3-15 karakter uzunluğunda olmalı");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Bu alan boş geçilemez")
                .Length(2, 15).WithMessage("Soyisminiz 2-15 karakter uzunluğunda olmalı");

            RuleFor(x => x.NationalityId)
                .NotEmpty().WithMessage("Bu alan boş geçilemez")
                .Length(11, 11).WithMessage("Kimlik numaranız 11 karakter uzunluğunda olmalı");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Bu alan boş geçilemez")
                .Length(2, 13).WithMessage("Şehir ismi 2-13 karakter uzunluğunda olmalı");
        }
    }
}
