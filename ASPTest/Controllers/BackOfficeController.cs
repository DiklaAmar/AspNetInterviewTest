using ASPTest.BL;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class BackOfficeController : Controller
    {
        // GET: BackOffice
        public ActionResult Index()
        {
            return View();
        }

        IData _dataRep = new DataRepository();

        [NonAction]
        public List<Tuple<int, int>> GetItemsAccording(DateTime Date)
        {
            return _dataRep.GetItemsAccroding(Date);
        }

        [NonAction]
        public List<Tuple<int, int>> GetItemsAndCount()
        {
            return _dataRep.GetItemsAndCount();
        }
    }
}