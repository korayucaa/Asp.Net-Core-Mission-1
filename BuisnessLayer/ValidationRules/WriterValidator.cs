using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail Kısmı Boş Geçilemez");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Yazar Şifre Kısmı Boş Geçilemez");
            RuleFor(x=>x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en az 1 büyük harf icermelidir");
            RuleFor(x=>x.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en az 1 kücük harf icermelidir");
            RuleFor(x=>x.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en az 1  sayi icermelidir");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("ad uzunlugu en az 2 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 30 karakter giriniz.");
            
        }
    }
}
