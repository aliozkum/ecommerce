using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(expression: p => p.Name).NotEmpty();
            RuleFor(expression: p => p.Name).Length(2, 30);
            RuleFor(expression: p => p.UnitPrice).NotEmpty();
            RuleFor(expression: p => p.UnitPrice).GreaterThanOrEqualTo(1);

        }
    }
}
