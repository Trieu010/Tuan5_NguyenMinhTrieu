using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan5_NguyenMinhTrieu.Models;


namespace Tuan5_NguyenMinhTrieu.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult ListSach()
        {
            var all_sach = from ss in data.TheLoais select ss;
            return View(all_sach);
        }
    }
}