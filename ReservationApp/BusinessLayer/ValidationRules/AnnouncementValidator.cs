using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("en az 5 karakter olmalıdır");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("en az 20 karakter olmalıdır");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("en fazla 50 karakter olmalıdır");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("en fazla 500 karakter olmalıdır");
        }
    }
}
