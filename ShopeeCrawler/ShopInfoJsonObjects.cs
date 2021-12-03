using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ShopeeCrawler
{
	public class FeedAccountInfo
	{
		[JsonProperty("is_kol", NullValueHandling = NullValueHandling.Ignore)]
		public object is_kol { get; set; }

		[JsonProperty("can_post_feed", NullValueHandling = NullValueHandling.Ignore)]
		public bool can_post_feed { get; set; }
	}

	public class Account
	{

		[JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
		public string username { get; set; }

		[JsonProperty("following_count", NullValueHandling = NullValueHandling.Ignore)]
		public int following_count { get; set; }

		[JsonProperty("portrait", NullValueHandling = NullValueHandling.Ignore)]
		public string portrait { get; set; }

		[JsonProperty("is_seller", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_seller { get; set; }

		[JsonProperty("phone_verified", NullValueHandling = NullValueHandling.Ignore)]
		public bool phone_verified { get; set; }

		[JsonProperty("email_verified", NullValueHandling = NullValueHandling.Ignore)]
		public bool email_verified { get; set; }

		[JsonProperty("fbid", NullValueHandling = NullValueHandling.Ignore)]
		public string fbid { get; set; }

		[JsonProperty("total_avg_star", NullValueHandling = NullValueHandling.Ignore)]
		public float total_avg_star { get; set; }

		[JsonProperty("hide_likes", NullValueHandling = NullValueHandling.Ignore)]
		public int hide_likes { get; set; }

		[JsonProperty("feed_account_info", NullValueHandling = NullValueHandling.Ignore)]
		public FeedAccountInfo feed_account_info { get; set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public int status { get; set; }
	}

	public class ShopInfoData
	{

		[JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
		public object place { get; set; }

		[JsonProperty("ctime", NullValueHandling = NullValueHandling.Ignore)]
		public int ctime { get; set; }

		[JsonProperty("mtime", NullValueHandling = NullValueHandling.Ignore)]
		public int mtime { get; set; }

		[JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
		public string country { get; set; }

		[JsonProperty("last_active_time", NullValueHandling = NullValueHandling.Ignore)]
		public int last_active_time { get; set; }

		[JsonProperty("is_shopee_verified", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_shopee_verified { get; set; }

		[JsonProperty("is_official_shop", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_official_shop { get; set; }

		[JsonProperty("chat_disabled", NullValueHandling = NullValueHandling.Ignore)]
		public bool chat_disabled { get; set; }

		[JsonProperty("disable_make_offer", NullValueHandling = NullValueHandling.Ignore)]
		public object disable_make_offer { get; set; }

		[JsonProperty("enable_display_unitno", NullValueHandling = NullValueHandling.Ignore)]
		public object enable_display_unitno { get; set; }

		[JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
		public string cover { get; set; }

		[JsonProperty("rating_normal", NullValueHandling = NullValueHandling.Ignore)]
		public float rating_normal { get; set; }

		[JsonProperty("rating_bad", NullValueHandling = NullValueHandling.Ignore)]
		public float rating_bad { get; set; }

		[JsonProperty("rating_good", NullValueHandling = NullValueHandling.Ignore)]
		public float rating_good { get; set; }

		[JsonProperty("shop_covers", NullValueHandling = NullValueHandling.Ignore)]
		public object shop_covers { get; set; }

		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
		public string description { get; set; }

		[JsonProperty("is_semi_inactive", NullValueHandling = NullValueHandling.Ignore)]
		public object is_semi_inactive { get; set; }

		[JsonProperty("is_blocking_owner", NullValueHandling = NullValueHandling.Ignore)]
		public object is_blocking_owner { get; set; }

		[JsonProperty("preparation_time", NullValueHandling = NullValueHandling.Ignore)]
		public object preparation_time { get; set; }

		[JsonProperty("cancellation_rate", NullValueHandling = NullValueHandling.Ignore)]
		public float cancellation_rate { get; set; }

		[JsonProperty("followed", NullValueHandling = NullValueHandling.Ignore)]
		public object followed { get; set; }

		[JsonProperty("buyer_rating", NullValueHandling = NullValueHandling.Ignore)]
		public object buyer_rating { get; set; }

		[JsonProperty("vacation", NullValueHandling = NullValueHandling.Ignore)]
		public bool vacation { get; set; }

		[JsonProperty("show_low_fulfillment_warning", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_low_fulfillment_warning { get; set; }

		[JsonProperty("show_official_shop_label", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_official_shop_label { get; set; }

		[JsonProperty("show_official_shop_label_in_title", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_official_shop_label_in_title { get; set; }

		[JsonProperty("show_shopee_verified_label", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_shopee_verified_label { get; set; }

		[JsonProperty("show_official_shop_label_in_normal_position", NullValueHandling = NullValueHandling.Ignore)]
		public object show_official_shop_label_in_normal_position { get; set; }

		[JsonProperty("real_url_if_matching_custom_url", NullValueHandling = NullValueHandling.Ignore)]
		public object real_url_if_matching_custom_url { get; set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public int status { get; set; }

		[JsonProperty("cb_option", NullValueHandling = NullValueHandling.Ignore)]
		public int cb_option { get; set; }

		[JsonProperty("campaign_id", NullValueHandling = NullValueHandling.Ignore)]
		public object campaign_id { get; set; }

		[JsonProperty("has_decoration", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_decoration { get; set; }

		[JsonProperty("shop_location", NullValueHandling = NullValueHandling.Ignore)]
		public string shop_location { get; set; }

		[JsonProperty("rating_star", NullValueHandling = NullValueHandling.Ignore)]
		public float rating_star { get; set; }

		[JsonProperty("is_ab_test", NullValueHandling = NullValueHandling.Ignore)]
		public object is_ab_test { get; set; }

		[JsonProperty("show_live_tab", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_live_tab { get; set; }

		[JsonProperty("has_flash_sale", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_flash_sale { get; set; }

		[JsonProperty("userid", NullValueHandling = NullValueHandling.Ignore)]
		public int userid { get; set; }

		[JsonProperty("shopid", NullValueHandling = NullValueHandling.Ignore)]
		public int shopid { get; set; }

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string name { get; set; }

		[JsonProperty("item_count", NullValueHandling = NullValueHandling.Ignore)]
		public int item_count { get; set; }

		[JsonProperty("follower_count", NullValueHandling = NullValueHandling.Ignore)]
		public int follower_count { get; set; }

		[JsonProperty("response_rate", NullValueHandling = NullValueHandling.Ignore)]
		public float response_rate { get; set; }

		[JsonProperty("response_time", NullValueHandling = NullValueHandling.Ignore)]
		public object response_time { get; set; }

		[JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
		public Account account { get; set; }

		[JsonProperty("campaign_config", NullValueHandling = NullValueHandling.Ignore)]
		public object campaign_config { get; set; }

		[JsonProperty("has_shopee_flash_sale", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_shopee_flash_sale { get; set; }

		[JsonProperty("has_in_shop_flash_sale", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_in_shop_flash_sale { get; set; }

		[JsonProperty("has_brand_sale", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_brand_sale { get; set; }

		[JsonProperty("is_preferred_plus_seller", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_preferred_plus_seller { get; set; }

		[JsonProperty("show_new_arrival_items", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_new_arrival_items { get; set; }

		[JsonProperty("new_arrival_items_start_ts", NullValueHandling = NullValueHandling.Ignore)]
		public int new_arrival_items_start_ts { get; set; }
	}

	public class ShopInfo
	{

		[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
		public ShopInfoData data { get; set; }

		[JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
		public int error { get; set; }

		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
		public string error_msg { get; set; }

		[JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
		public string version { get; set; }
	}


}
