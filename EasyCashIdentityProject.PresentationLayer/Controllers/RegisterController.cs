﻿using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index( AppUserRegisterDto appUserRegisterDto)
        {
           if(ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName=appUserRegisterDto.Username,
                    Name=appUserRegisterDto.Name,
                    Surname=appUserRegisterDto.Surname,
                    Email=appUserRegisterDto.Email,
                    City="",
                    Distrinct="",
                    ImageUrl=""
                };
                var result=await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirmMail");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }

    }
}
//Şifre en az 6 karakterden oluşacak
//en az 1 küçük harf içermeli,
 //en az 1 büyük harf içermeli,
 //en az 1 sembol içermeli
 //en az 1 sayı içermeli
