using myAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace myAPI.Controllers {
	public class ProductsController : ApiController {
		Product[] productList = new Product[]
		{
			new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
			new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
			new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
		};

		[AcceptVerbs("GET", "HEAD")]
		public IEnumerable<Product> products() {
			return productList;
		}

		[AcceptVerbs("GET", "HEAD")]
		public IHttpActionResult product(int id) {
			var product = productList.FirstOrDefault((p) => p.Id == id);
			if (product == null) {
				return NotFound();
			}
			return Ok(product);
		}
	}
}
