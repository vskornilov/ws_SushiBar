using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ws_SushiBar.ViewModels;

namespace ws_SushiBar.Controllers
{
    
    public class CatalogController : Controller
    {
        private readonly List<Product> products = new List<Product>
            {
            new Product{ Name="Суши Гункан", Img="/images/product/rolls/Guncan.jpg", Category="Суши", Description="рис, краб (имитация), спайси соус.", Price=70 },
            new Product{ Name="Норвежский", Img="/images/product/sushi/Norvezhskij.jpg", Category="Роллы", Description="Сыр, помидор, лук, лосось, стружка тунца, спайси соус", Price=235 },
            new Product{ Name="Филадельфия классическая", Img="/images/product/sushi/Filadelfiya.jpg", Category="Роллы", Description="Сыр, огурец, лосось", Price=70 },
            new Product{ Name="Вок с говядиной в остром соусе", Img="/images/product/vok/01.jpg", Category="Вок", Description="Говядина, лапша гречневая, овощной микс ( капуста, морковь, перец бол., лук репчатый, фасоль) соус (якитори, острый), масло чесночное, лук зелёный, кунжут.", Price=245 },
            new Product{ Name="Вок лосось-креветка в кисло-сладком соусе", Img="/images/product/vok/02.jpg", Category="Вок", Description="Креветка, лосось, Лапша рисовая, овощной микс ( капуста, морковь, перец бол., лук репчатый, фасоль) соус (якитори, кисло-сладкий), масло чесночное, лук зелёный, кунжут.", Price=270 },
            new Product{ Name="Морс из черной смородины 0,3л", Img="/images/product/napitki/mors.jpg", Category="Напитки", Description="0", Price=40 }
            };

        public IActionResult Catalog()
        {
            ViewData["Title"] = "SUHI BAR - Каталог";
            return View(products);
        }
    }
}