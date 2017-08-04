using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myAPI.Models {
	public class Schedule {
		public string primary_description { get; set; }
		public string secondary_description { get; set; }
		public string tertiary_description { get; set; }
		public string start_datetime { get; set; }
		public string end_datetime { get; set; }
		public string lecturer_name { get; set; }
		public string lecturer_email { get; set; }
		public string location_name { get; set; }
	}
}