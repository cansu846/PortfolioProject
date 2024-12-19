using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Header).NotEmpty().WithMessage("Can not be empty...");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Can not be empty...");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Can not be empty...");

        }
    }
}
