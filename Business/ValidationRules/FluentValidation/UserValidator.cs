using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).MinimumLength(3);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
           // RuleFor(p => p.EMail).EmailAddress();

            RuleFor(p => p.FirstName).Length(5);
            // RuleFor(p => p.FirstName).Length(5).When(p => p.Status == true);
            // RuleFor(p => p.FirstName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("a");
        }
    }
}
