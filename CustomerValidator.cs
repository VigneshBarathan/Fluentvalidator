using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Fluentvalidator
{
    public class CustomerValidator : AbstractValidator<Customermodel>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("name cannot be null");
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.Other).GreaterThan(0).WithMessage("other must me greater than 0");
        }
    }
}
