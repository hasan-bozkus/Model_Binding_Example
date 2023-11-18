using Microsoft.AspNetCore.Mvc;
using Model_Binding_incelemesi.Models;

namespace Model_Binding_incelemesi.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(Person person)
        {
            return View(person);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Person person)
        {
            return View("Index", person);
        }
    }
}
