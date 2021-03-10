using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DealerValidator : AbstractValidator<Dealer>
    {
        public DealerValidator()
        {
            RuleFor(p => p.DealerStatusName).NotEmpty();
            RuleFor(p => p.DealerExplanation).NotEmpty();
        }
    }
}
