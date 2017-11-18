using Fuel.BusinessLogic;
using Fuel.Models;
using Fuel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fuel.Controllers
{
    public class FuelController : Controller
    {
        private readonly FuelBusinessLogic _businessLogic;
        public FuelController ()
        {
            _businessLogic = new FuelBusinessLogic();
        }


        // GET: Fuel
        public ActionResult Index()
        {
            var model = new FuelViewModel() {FuelModel = new FuelModel() };

            return View("View", model);
        }

        [HttpPost]
        public ActionResult FuelCalculate(FuelViewModel model)
        {
            if(model.FuelModel != null && model.FuelModel.Distance != 0)
            {
                model.FuelModel.AvgConsumption = _businessLogic.CalculateAvgConsump(model.FuelModel.Fuel, model.FuelModel.Distance);
                model.ShowResult = true;
                return View("View", model);
            }

            model.ShowResult = false;
            ViewBag.Error = "Błędne dane";
            return View("View", model);
        }
    }
}