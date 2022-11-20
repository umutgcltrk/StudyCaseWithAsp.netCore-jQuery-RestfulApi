using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class StudyValidator : AbstractValidator<Study>
    {
        public StudyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50).WithMessage("İsim alanını boş geçemezsiniz ! ve 50 karakter üstünde olamaz !.");
            RuleFor(x => x.Surname).NotEmpty().MaximumLength(50).WithMessage("Soyisim alanını boş geçemezsiniz ! ve 50 karakter üstünde olamaz !.");
            RuleFor(x => x.Midterm).NotEmpty().WithMessage("Lütfen vize notunu giriniz !");
            RuleFor(x => x.Final).NotEmpty().WithMessage("Lütfen final notunu giriniz !");

        }
    }
}
