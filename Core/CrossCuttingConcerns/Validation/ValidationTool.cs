using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<Object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new Exception(result.ToString());
            }
        }
    }
}
