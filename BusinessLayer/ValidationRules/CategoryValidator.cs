using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("ad bos gecilemez");
            RuleFor(c => c.Description).NotEmpty().WithMessage("tanim bos gecilemez");
            RuleFor(c => c.Name).MinimumLength(2).WithMessage("az olmaz");
            RuleFor(c => c.Name).MaximumLength(20).WithMessage("fazla olmaz");
        }
    }
}
