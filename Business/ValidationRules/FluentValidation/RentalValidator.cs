﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator :AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.ProductId).NotEmpty();
            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).NotEmpty();


        }
    }
}
