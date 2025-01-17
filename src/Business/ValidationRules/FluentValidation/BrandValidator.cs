﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).MinimumLength(2).WithMessage("Marka en az 2 karakter olmalı");
        }
    }
}
