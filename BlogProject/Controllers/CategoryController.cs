using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.Entities;
using MVC_BlogProject.Models.Repositories.Abstract;
using MVC_BlogProject.Models.Repositories.Concrete;

public class CategoryController : Controller
{
    private readonly ICategoryRepo _categoryRepository;


    public CategoryController(ICategoryRepo categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index()
    {
        var categories = _categoryRepository.GetList();
        return View(categories);
    }

    [HttpGet]
    public IActionResult CategoryAdd()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CategoryAdd(Category p)
    {
        if (!ModelState.IsValid)
        {
            return View("CategoryAdd");
        }
        _categoryRepository.Insert(p);
        return RedirectToAction("Index");
    }

    public IActionResult CategoryDelete(int id)
    {
        var category = _categoryRepository.GetById(id);
        if (category != null)
        {
            _categoryRepository.Delete(category);
        }
        return RedirectToAction("Index");
    }

    public IActionResult CategoryUpdate(Category p)
    {
        if (!ModelState.IsValid)
        {
            return View(p); // Formu hata mesajı ile tekrar göster
        }

        var x = _categoryRepository.GetById(p.Id);
        if (x == null)
        {
            return NotFound();
        }

        if (string.IsNullOrWhiteSpace(p.Name))
        {
            ModelState.AddModelError("Name", "Kategori adı boş bırakılamaz!");
            return View(p);
        }

        x.Name = p.Name;
        _categoryRepository.Update(x);
        return RedirectToAction("Index");
    }


}

