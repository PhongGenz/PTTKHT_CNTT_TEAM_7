using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEAM7.Models;


namespace TEAM7.Controllers
{
    public class FullContractController : Controller
    {
        // GET: FullContract
        public ActionResult ThemHopdong()
        {
            QUANLYBDS_TEAMB4BEntities db = new QUANLYBDS_TEAMB4BEntities();
            List<Full_Contract> hopDong = db.Full_Contract.ToList();
            return View(hopDong);
        }
        public ActionResult Viewlist()
        {
            QUANLYBDS_TEAMB4BEntities db = new QUANLYBDS_TEAMB4BEntities();
            List<Full_Contract> dsHopDong = db.Full_Contract.ToList();
            return View(dsHopDong);
        }

        public ActionResult ThemMoi()
        {
            return View();
        }
        public ActionResult ThemMoi(Full_Contract model)
        {
            QUANLYBDS_TEAMB4BEntities db = new QUANLYBDS_TEAMB4BEntities();
            db.Full_Contract.Add(model);
            //lưu lại thay đổi
            db.SaveChanges();
            return RedirectToAction("Viewlist");

        }
        

        




    } 
}