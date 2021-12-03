using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopeeCrawler
{
	public class ShopCategory
	{

		[JsonProperty("shop_category_id", NullValueHandling = NullValueHandling.Ignore)]
		public int shop_category_id { get; set; }

		[JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
		public string display_name { get; set; }

		[JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
		public string image { get; set; }

		[JsonProperty("is_generated", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_generated { get; set; }

		[JsonProperty("category_type", NullValueHandling = NullValueHandling.Ignore)]
		public int category_type { get; set; }

		[JsonProperty("rcmd_info", NullValueHandling = NullValueHandling.Ignore)]
		public object rcmd_info { get; set; }

		[JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
		public int total { get; set; }

		[JsonProperty("is_adult", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_adult { get; set; }
	}

	public class AllProductsCover
	{

		[JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
		public string image { get; set; }

		[JsonProperty("is_adult", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_adult { get; set; }
	}

	public class CategoryData
	{
		[JsonProperty("shop_categories", NullValueHandling = NullValueHandling.Ignore)]
		public IList<ShopCategory> shop_categories { get; set; }

		[JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
		public int total { get; set; }

		[JsonProperty("has_more", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_more { get; set; }

		[JsonProperty("all_products_cover", NullValueHandling = NullValueHandling.Ignore)]
		public AllProductsCover all_products_cover { get; set; }
	}

	public class ShopCategories
	{

		[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
		public CategoryData data { get; set; }

		[JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
		public int error { get; set; }

		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
		public string error_msg { get; set; }
	}


}
