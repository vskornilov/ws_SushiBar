﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ws_SushiBar.ViewModels;

namespace ws_SushiBar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<News> news = new List<News>
            {
                new News{Date="14.10.2019", NewsTitle="Итальянский сушист конструирует кроссовки из риса и сырой рыбы", NewsPost="Повар Юдзия Ху делает съедобные реплики популярных кроссовок. В его ресторане можно залить соевым соусом, например, Adidas Yeezy Boost 350, Nike Kyrie 2 или Air Jordan 1 и съесть. Для создания сникерс-суши повар использует традиционные для японской кухни ингредиенты: рис, сырого лосося и сушеные водоросли нори. Свои нано-блюда Юдзия Ху любит называть Shoe - shi, все их виды можно посмотреть в инстаграме." },
                new News{Date="15.10.2019", NewsTitle="В Саратове мужчина напал на курьера по доставке суши, чтобы устроить семье классный ужин", NewsPost="В Саратове мужчина совершил разбойное нападение на курьера по доставке суши, чтобы устроить семье гастрономический праздник. Об этом со ссылкой на пресс-службу регионального Управления Росгвардии сообщает местное издание «Четвертая власть»." },
                new News{Date="16.10.2019", NewsTitle="Роспотребнадзор закрыл 63 ресторана «Суши Wok» в Москве", NewsPost="Роспотребнадзор временно закрыл 63 ресторана быстрого питания «Суши Wok» в Москве из-за многочисленных нарушений требований санитарных норм. Информация об этом появилась на сайте ведомства." }
            };
            ViewData["Title"] = "SUHI BAR - Главная";
            return View(news);
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

        public IActionResult Stocks()
        {
            List<Stocks> stocks = new List<Stocks>
            {
                new Stocks {Name = "Всего понемногу много!", Description="Купи всего по немногу и получи столько же!", Img="/images/stocks/01.jpg"},
                new Stocks {Name = "10 за 5", Description="10 штук по цене 5-ти!!!", Img="/images/stocks/02.jpg"},
                new Stocks {Name = "Всего понемногу много!", Description="Купи всего по немногу и получи столько же!", Img="/images/stocks/03.jpg"}
            };

            ViewData["Title"] = "SUHI BAR - Акции";
            return View(stocks);
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