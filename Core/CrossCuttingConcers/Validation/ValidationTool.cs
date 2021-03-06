using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.CrossCuttingConcers.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var result = validator.Validate(entity);
            if(!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
