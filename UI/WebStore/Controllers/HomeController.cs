using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        // добавление сиситемы логирования: либо через конструктор, либо через метод.
        // запрашиваем объект ILogger с типом HomeController
        // сохраненние логгера в приватном поле
        private readonly ILogger<HomeController> _Logger;

        public HomeController(ILogger<HomeController> Logger) => _Logger = Logger;

        public IActionResult Index()
        {
            // исп логирование внутри экшена
            _Logger.LogInformation("Запрос главной страницы!");
            return View();
        }
        public IActionResult ThrowError(string id) => throw new ApplicationException(id);

        public IActionResult Blog() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Cart() => View();
        public IActionResult CheckOut() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Login() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Shop() => View();
        public IActionResult Error404() => View();

        public IActionResult ErrorStatus(string Id)
        {
            switch (Id)
            {
                default: return Content($"Статусный код {Id}");
                case "404":
                    return RedirectToAction(nameof(Error404));
            }
        }
    }
}