using restaurantapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace restaurantapp.Repositories
{
	public class PymentTypeRepository
	{
		private restaurantEntities objrestaurantEntities;
		public PymentTypeRepository() { 
			objrestaurantEntities = new restaurantEntities();
		}

		public IEnumerable<SelectListItem> GetAllPymentType() {

			var objselectlistitem = new List<SelectListItem>();
			 objselectlistitem = (from obj in objrestaurantEntities.paymentTypes
								 select new SelectListItem()
								 {
									 Text = obj.paymenttypename,
									 Value = obj.paymenttypeid.ToString(),
									 Selected = true
								 }).ToList();
			return objselectlistitem;
		}
	}
}