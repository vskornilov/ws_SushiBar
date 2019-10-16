﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ws_SushiBar.ViewModels;

namespace ws_SushiBar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "SUHI BAR - Главная";
            return View();
        }

        public IActionResult Catalog()
        {
            List<Product> products = new List<Product>
            {
            new Product{Id=1, Name="Суши Гункан", Img="/images/product/rolls/Guncan.jpg", Category="Суши", Description="рис, краб (имитация), спайси соус.", Price=70 },
            new Product{Id=2, Name="Норвежский", Img="/images/product/sushi/Norvezhskij.jpg", Category="Роллы", Description="Сыр, помидор, лук, лосось, стружка тунца, спайси соус", Price=235 },
            new Product{Id=3, Name="Филадельфия классическая", Img="/images/product/sushi/Filadelfiya.jpg", Category="Роллы", Description="Сыр, огурец, лосось", Price=70 },
            new Product{Id=4, Name="Вок с говядиной в остром соусе", Img="/images/product/vok/01.jpg", Category="Вок", Description="Говядина, лапша гречневая, овощной микс ( капуста, морковь, перец бол., лук репчатый, фасоль) соус (якитори, острый), масло чесночное, лук зелёный, кунжут.", Price=245 },
            new Product{Id=5, Name="Вок лосось-креветка в кисло-сладком соусе", Img="/images/product/vok/02.jpg", Category="Вок", Description="Креветка, лосось, Лапша рисовая, овощной микс ( капуста, морковь, перец бол., лук репчатый, фасоль) соус (якитори, кисло-сладкий), масло чесночное, лук зелёный, кунжут.", Price=270 },
            new Product{Id=6, Name="Морс из черной смородины 0,3л", Img="/images/product/napitki/mors.jpg", Category="Напитки", Description="0", Price=40 }
            };

            ViewData["Title"] = "SUHI BAR - Каталог";
            return View(products);
        }

        public IActionResult Foto()
        {
            List<FotoView> fotoViews = new List<FotoView>
                {
                    new FotoView{ Id=1, Img="/images/gallery/01.jpg"},
                    new FotoView{ Id=2, Img="/images/gallery/02.jpg"},
                    new FotoView{ Id=3, Img="/images/gallery/04.jpg"},
                    new FotoView{ Id=4, Img="/images/gallery/05.jpg"},
                    new FotoView{ Id=5, Img="/images/gallery/06.jpg"},
                    new FotoView{ Id=6, Img="/images/gallery/07.jpg"},
                    new FotoView{ Id=7, Img="/images/gallery/08.jpg"},
                    new FotoView{ Id=8, Img="/images/gallery/09.jpg"},
                    new FotoView{ Id=9, Img="/images/gallery/10.jpg"},
                    new FotoView{ Id=10, Img="/images/gallery/11.jpg"},
                    new FotoView{ Id=11, Img="/images/gallery/12.jpg"},
                    new FotoView{ Id=12, Img="/images/gallery/13.jpg"}
                };

            ViewData["Title"] = "SUHI BAR - Галерея";
            return View(fotoViews);
        }

        public IActionResult Stock()
        {
            ViewData["Title"] = "SUHI BAR - Акции";
            return View();
        }

        public IActionResult Contact()
        {
            Contact contact = new Contact
            {
                Address = "г. Ульяновс, ул. Гончарова",
                Phone = "+7(8422) 55-55-55",
                Email = "vs-kornilov@mail.ru",
                Map = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d37215.65317378777!2d48.3273599163711!3d54.33969126886122!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x415d30b3af0e0669%3A0xf27e66ba2f2f305e!2z0JvQtdC90LjQvdGB0LrQuNC5INGALdC9LCDQo9C70YzRj9C90L7QstGB0LosINCj0LvRjNGP0L3QvtCy0YHQutCw0Y8g0L7QsdC7Lg!5e0!3m2!1sru!2sru!4v1571199916302!5m2!1sru!2sru"
            };

            ViewData["Title"] = "SUHI BAR - Контакты";
            return View(contact);
        }
    }
}