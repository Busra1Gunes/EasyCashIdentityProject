using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    //Doğrulayıcılar (validators), sunucuya gitmeden önce verilerin kontrol edilmesi için kullanılır
    // AbstractValidator, bir dizi kuralı uygulamak için kullanılan bir soyut sınıf veya arabirim
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto> //eğer AppUserRegisterDto sınıfı yerine AppUser sınıfını yazsaydık kullanmayacağımız çok fazla 
                                                                           //property olacagı için SOLID prensiplerine uygun olmazdı 
    {

        public AppUserRegisterValidator()
        {
            //RuleFor, FluentValidation kullanarak bir nesnenin bir özelliği için doğrulama kurallarını tanımlamak için kullanılan bir yöntemdir.
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parola eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");


        }
    }
}
