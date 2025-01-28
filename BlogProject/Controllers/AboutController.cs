using BlogProject.Models.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutRepo _aboutRepo;

        public AboutController(IAboutRepo aboutRepo)
        {
            _aboutRepo = aboutRepo;
        }

        public IActionResult Index()
        {
            var value = _aboutRepo.GetList();
            return View(value);
        }
    }
}
