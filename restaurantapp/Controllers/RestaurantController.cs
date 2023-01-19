using restaurantapp.Models;
using restaurantapp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurantapp.Controllers
{
    public class RestaurantController : Controller
    {
		private restaurantEntities objrestaurantEntities;
		public RestaurantController() {

			objrestaurantEntities = new restaurantEntities();
		}
        // GET: Restaurant
        public ActionResult order()
        {
          
            CustomerRepository objCustomerRepositry= new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PymentTypeRepository objPaymentTypeRepostry = new PymentTypeRepository();

			var objMultipleModel = new Tuple<IEnumerable<SelectListItem>,IEnumerable<SelectListItem>,IEnumerable<SelectListItem>>
                (objCustomerRepositry.GetAllCustomer(), objItemRepository.GetAllItem(), objPaymentTypeRepostry.GetAllPymentType());
            return View(objMultipleModel);
        }


        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId) {

            decimal unitprice = (decimal)objrestaurantEntities.items.Single(model => model.itemid == itemId).itemprice;
            return Json(unitprice, JsonRequestBehavior.AllowGet);

        }

	}
}