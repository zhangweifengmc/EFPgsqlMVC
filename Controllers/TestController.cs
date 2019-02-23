using EFPgsqlMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFPgsqlMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Database myDatabase = new Database();
            //查询
            var list = from s in myDatabase.adminuser
                       select s;
            return View(list);
        }
    }
}