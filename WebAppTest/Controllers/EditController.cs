using Microsoft.AspNetCore.Mvc;

using System;
using System.Linq;

using WebAppTest.DAL;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Index(int id)
        {
            var model = LocalStorage.Items.FirstOrDefault(x => x.ID == id);
            if (model is null)
            {
                model = new ToDoItem();
                model.ID = default;
                //throw new ArgumentNullException(nameof(model));
            }
            ViewBag.Statuses = LocalStorage.Statuses;

            return View(model);
        }

        public IActionResult Save(ToDoItem item)
        {
                if (item is null)
                {
                    throw new ArgumentNullException(nameof(item));
                }

                if (item.ID == default)
                {
                    var maxID = LocalStorage.Items.Max(x => x.ID);
                    item.ID = ++maxID;
                    LocalStorage.Items.Add(item);
                }
                else
                {
                    var existedItem = LocalStorage.Items.FirstOrDefault(x => x.ID == item.ID);
                    existedItem.Name = item.Name;
                    existedItem.StartDate = item.StartDate;
                    existedItem.EndDate = item.EndDate;
                    existedItem.Description = item.Description;
                    existedItem.Status = item.Status;
                }

                return Redirect("/Main/Index");
        }
    }
}
