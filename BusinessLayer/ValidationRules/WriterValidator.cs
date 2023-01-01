using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().WithMessage("ad bos gecilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("ad en az 3 char olmalidir");
            RuleFor(x => x.Name).MinimumLength(50).WithMessage("ad cok uuzn");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("mail bos gecilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("sifre bos gecilemez");            
        }
    }
}
