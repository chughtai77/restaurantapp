using restaurantapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurantapp.Repositories
{
	public class ItemRepository
	{
		private restaurantEntities objrestaurantEntities;
		public ItemRepository()
		{
			objrestaurantEntities = new restaurantEntities();
		}

		public IEnumerable<SelectListItem> GetAllItem()
		{

			var objselectlistitem = new List<SelectListItem>();
			objselectlistitem = (from obj in objrestaurantEntities.items
								 select new SelectListItem()
								 {
									 Text = obj.itemname,
									 Value = obj.itemid.ToString(),
									 Selected = true
								 }).ToList();
			return objselectlistitem; 
		}

	}
}