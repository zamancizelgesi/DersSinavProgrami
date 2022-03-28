using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DersValidator : AbstractValidator<Ders>
    {
        public DersValidator()
        {
            RuleFor(x => x.DersAdi).NotEmpty().WithMessage("Boş geçilemez");
        }
    }

    
}
