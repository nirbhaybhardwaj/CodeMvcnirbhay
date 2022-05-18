using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeMvc.Models;

namespace CodeMvc.Controllers
{
    public class UserController : Controller
    {
        dbemployee db = new dbemployee();
        // GET: User
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(string test)
        {
            string name = Request.Form["Name"];
            string Contact = Request.Form["Contact"];
            string Adress = Request.Form["Adress"];
            string Email = Request.Form["Email"];

            var e = new Employee()
            {
                Name = name,
                Contact = Contact,
                Adress = Adress,
                Email = Email,
            };

            db.Employees.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int ?id)
        {
            var row = db.Employees.Where(model => model.id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            db.Entry(e).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var d = db.Employees.Where(e => e.id == id).SingleOrDefault();
                db.Employees.Remove(d);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }
    }
}