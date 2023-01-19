using restaurantapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurantapp.Repositories
{
	public class CustomerRepository
	{
		private restaurantEntities objrestaurantEntities;
		public CustomerRepository()
		{
			objrestaurantEntities = new restaurantEntities();
 		}

		public IEnumerable<SelectListItem> GetAllCustomer()
		{

			var objselectlistitem = new List<SelectListItem>();
			objselectlistitem = (from obj in objrestaurantEntities.customers
								 select new SelectListItem()
								 {
									 Text = obj.customername,
									 Value = obj.customerid.ToString(),
									 Selected = true
								 }).ToList();
			return objselectlistitem;
		}
	}
}