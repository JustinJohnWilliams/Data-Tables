using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataTables.Models;
using System.Configuration;

namespace DataTables.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Query(jQueryDataTableParamModel model)
        {
            var customers = CustomerRepo.Customers;

            var totalCount = customers.Count();

            if (!string.IsNullOrEmpty(model.sSearch))
            {
                customers = customers.Where(c => c.Address.Contains(model.sSearch)
                                              || c.Email.Contains(model.sSearch)
                                              || c.Name.Contains(model.sSearch)
                                              || c.Phone.Contains(model.sSearch));
            }

            var filteredCount = customers.Count();

            if (model.iSortCol_0 != null)
            {
                var sortColumns = new Dictionary<int, Action>()
                {
                    { 0, () => customers = model.sSortDir_0 == "asc" ? customers.OrderBy(c => c.Name) : customers.OrderByDescending(c => c.Name) },
                    { 1, () => customers = model.sSortDir_0 == "asc" ? customers.OrderBy(c => c.Email) : customers.OrderByDescending(c => c.Email) },
                    { 2, () => customers = model.sSortDir_0 == "asc" ? customers.OrderBy(c => c.Address) : customers.OrderByDescending(c => c.Address) },
                    { 3, () => customers = model.sSortDir_0 == "asc" ? customers.OrderBy(c => c.Phone) : customers.OrderByDescending(c => c.Phone) },
                    { 4, () => customers = model.sSortDir_0 == "asc" ? customers.OrderBy(c => c.Active) : customers.OrderByDescending(c => c.Active) }
                };

                sortColumns[model.iSortCol_0.Value].Invoke();
            }

            customers = customers.Skip(model.iDisplayStart)
                                 .Take(model.iDisplayLength);

            var result = from c in customers
                         select new[]
                         {
                             c.Name,
                             c.Email,
                             c.Address,
                             c.Phone,
                             c.Active.ToString(),
                             Convert.ToBoolean(ConfigurationManager.AppSettings["IsAdmin"]) ? c.Id.ToString() : null
                         };

            return Json(new 
            { 
                sEcho = model.sEcho,
                iTotalRecords = totalCount,
                iTotalDisplayRecords = filteredCount,
                aaData = result
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
