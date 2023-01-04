using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator() {
            RuleFor(x => x.Content).NotEmpty().WithMessage("bas gecilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("bas gecilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("bas gecilemez");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("150 den fazla olamaz");
            RuleFor(x => x.Title).MaximumLength(5).WithMessage("5 den az olamaz");
            
            
        }
    }
}
