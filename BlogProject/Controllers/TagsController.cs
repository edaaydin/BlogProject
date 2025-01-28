using Microsoft.AspNetCore.Mvc;
using MVC_BlogProject.Models.Entities;
using MVC_BlogProject.Models.Repositories.Abstract;

namespace MVC_BlogProject.Controllers
{
    public class TagsController : Controller
    {
        private readonly ITagRepo _tagRepo;

        public TagsController(ITagRepo tagRepo)
        {
            _tagRepo = tagRepo;
        }

        // Listeleme
        public IActionResult Index()
        {
            var tags = _tagRepo.GetList();
            return View(tags);
        }

        // Yeni Tag Ekleme Sayfası
        public IActionResult Create()
        {
            return View();
        }

        // Yeni Tag Ekleme
        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            if (ModelState.IsValid)
            {
                _tagRepo.Insert(tag);
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // Güncelleme Sayfası
        public IActionResult Edit(int id)
        {
            var tag = _tagRepo.GetById(id);
            if (tag == null) return NotFound();
            return View(tag);
        }

        // Tag Güncelleme
        [HttpPost]
        public IActionResult Edit(Tag tag)
        {
            if (ModelState.IsValid)
            {
                _tagRepo.Update(tag);
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }


        // Silme İşlemi
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var tag = _tagRepo.GetById(id);
            if (tag != null)
            {
                _tagRepo.Delete(tag);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
