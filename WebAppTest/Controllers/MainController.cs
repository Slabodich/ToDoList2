using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebAppTest.DAL;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            var model = LocalStorage.Items;

            return View(model);
        }
        public IActionResult Add()
        {
            ViewBag.Statuses = Enum.GetNames(typeof(ToDoStatus));

            return RedirectToAction("Index", "Edit");
        } 

        public IActionResult Delete(int id)
        {
            var DeletedItem = LocalStorage.Items.FirstOrDefault(x => x.ID == id);
            LocalStorage.Items.Remove(DeletedItem);
            return RedirectToAction("Index", "Main");
        }
    }
}
