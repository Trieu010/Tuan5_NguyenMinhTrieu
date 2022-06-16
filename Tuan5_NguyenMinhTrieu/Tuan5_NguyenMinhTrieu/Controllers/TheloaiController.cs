using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan5_NguyenMinhTrieu.Models;

namespace Tuan5_NguyenMinhTrieu.Controllers
{
    public class TheloaiController : Controller
    {
        // GET: Theloai
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var all_theloai = from tt in data.TheLoais select tt;
            return View(all_theloai);
        }
    }
}