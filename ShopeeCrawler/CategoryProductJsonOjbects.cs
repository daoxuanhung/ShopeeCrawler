using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopeeCrawler
{
	public class TierVariation
	{

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string name { get; set; }

		[JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
		public IList<string> options { get; set; }

		[JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
		public IList<string> images { get; set; }

		[JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
		public IList<object> properties { get; set; }

		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
		public int type { get; set; }
	}

	public class ItemRating
	{

		[JsonProperty("rating_star", NullValueHandling = NullValueHandling.Ignore)]
		public float rating_star { get; set; }

		[JsonProperty("rating_count", NullValueHandling = NullValueHandling.Ignore)]
		public IList<int> rating_count { get; set; }

		[JsonProperty("rcount_with_context", NullValueHandling = NullValueHandling.Ignore)]
		public int rcount_with_context { get; set; }

		[JsonProperty("rcount_with_image", NullValueHandling = NullValueHandling.Ignore)]
		public int rcount_with_image { get; set; }
	}

	public class ItemBasic
	{

		[JsonProperty("itemid", NullValueHandling = NullValueHandling.Ignore)]
		public long itemid { get; set; }

		[JsonProperty("shopid", NullValueHandling = NullValueHandling.Ignore)]
		public int shopid { get; set; }

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string name { get; set; }

		[JsonProperty("label_ids", NullValueHandling = NullValueHandling.Ignore)]
		public IList<int> label_ids { get; set; }

		[JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
		public string image { get; set; }

		[JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
		public IList<string> images { get; set; }

		[JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
		public string currency { get; set; }

		[JsonProperty("stock", NullValueHandling = NullValueHandling.Ignore)]
		public int stock { get; set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public int status { get; set; }

		[JsonProperty("ctime", NullValueHandling = NullValueHandling.Ignore)]
		public int ctime { get; set; }

		[JsonProperty("sold", NullValueHandling = NullValueHandling.Ignore)]
		public int sold { get; set; }

		[JsonProperty("historical_sold", NullValueHandling = NullValueHandling.Ignore)]
		public int historical_sold { get; set; }

		[JsonProperty("liked", NullValueHandling = NullValueHandling.Ignore)]
		public bool liked { get; set; }

		[JsonProperty("liked_count", NullValueHandling = NullValueHandling.Ignore)]
		public int liked_count { get; set; }

		[JsonProperty("view_count", NullValueHandling = NullValueHandling.Ignore)]
		public int view_count { get; set; }

		[JsonProperty("catid", NullValueHandling = NullValueHandling.Ignore)]
		public int catid { get; set; }

		[JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
		public string brand { get; set; }

		[JsonProperty("cmt_count", NullValueHandling = NullValueHandling.Ignore)]
		public int cmt_count { get; set; }

		[JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
		public int flag { get; set; }

		[JsonProperty("cb_option", NullValueHandling = NullValueHandling.Ignore)]
		public int cb_option { get; set; }

		[JsonProperty("item_status", NullValueHandling = NullValueHandling.Ignore)]
		public string item_status { get; set; }

		[JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
		public long price { get; set; }

		[JsonProperty("price_min", NullValueHandling = NullValueHandling.Ignore)]
		public long price_min { get; set; }

		[JsonProperty("price_max", NullValueHandling = NullValueHandling.Ignore)]
		public long price_max { get; set; }

		[JsonProperty("price_min_before_discount", NullValueHandling = NullValueHandling.Ignore)]
		public long price_min_before_discount { get; set; }

		[JsonProperty("price_max_before_discount", NullValueHandling = NullValueHandling.Ignore)]
		public long price_max_before_discount { get; set; }

		[JsonProperty("hidden_price_display", NullValueHandling = NullValueHandling.Ignore)]
		public object hidden_price_display { get; set; }

		[JsonProperty("price_before_discount", NullValueHandling = NullValueHandling.Ignore)]
		public long price_before_discount { get; set; }

		[JsonProperty("has_lowest_price_guarantee", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_lowest_price_guarantee { get; set; }

		[JsonProperty("show_discount", NullValueHandling = NullValueHandling.Ignore)]
		public int show_discount { get; set; }

		[JsonProperty("raw_discount", NullValueHandling = NullValueHandling.Ignore)]
		public int raw_discount { get; set; }

		[JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
		public string discount { get; set; }

		[JsonProperty("is_category_failed", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_category_failed { get; set; }

		[JsonProperty("size_chart", NullValueHandling = NullValueHandling.Ignore)]
		public object size_chart { get; set; }

		[JsonProperty("video_info_list", NullValueHandling = NullValueHandling.Ignore)]
		public object video_info_list { get; set; }

		[JsonProperty("tier_variations", NullValueHandling = NullValueHandling.Ignore)]
		public IList<TierVariation> tier_variations { get; set; }

		[JsonProperty("item_rating", NullValueHandling = NullValueHandling.Ignore)]
		public ItemRating item_rating { get; set; }

		[JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
		public int item_type { get; set; }

		[JsonProperty("reference_item_id", NullValueHandling = NullValueHandling.Ignore)]
		public string reference_item_id { get; set; }

		[JsonProperty("transparent_background_image", NullValueHandling = NullValueHandling.Ignore)]
		public string transparent_background_image { get; set; }

		[JsonProperty("is_adult", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_adult { get; set; }

		[JsonProperty("badge_icon_type", NullValueHandling = NullValueHandling.Ignore)]
		public int badge_icon_type { get; set; }

		[JsonProperty("shopee_verified", NullValueHandling = NullValueHandling.Ignore)]
		public bool shopee_verified { get; set; }

		[JsonProperty("is_official_shop", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_official_shop { get; set; }

		[JsonProperty("show_official_shop_label", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_official_shop_label { get; set; }

		[JsonProperty("show_shopee_verified_label", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_shopee_verified_label { get; set; }

		[JsonProperty("show_official_shop_label_in_title", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_official_shop_label_in_title { get; set; }

		[JsonProperty("is_cc_installment_payment_eligible", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_cc_installment_payment_eligible { get; set; }

		[JsonProperty("is_non_cc_installment_payment_eligible", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_non_cc_installment_payment_eligible { get; set; }

		[JsonProperty("coin_earn_label", NullValueHandling = NullValueHandling.Ignore)]
		public object coin_earn_label { get; set; }

		[JsonProperty("show_free_shipping", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_free_shipping { get; set; }

		[JsonProperty("preview_info", NullValueHandling = NullValueHandling.Ignore)]
		public object preview_info { get; set; }

		[JsonProperty("coin_info", NullValueHandling = NullValueHandling.Ignore)]
		public object coin_info { get; set; }

		[JsonProperty("exclusive_price_info", NullValueHandling = NullValueHandling.Ignore)]
		public object exclusive_price_info { get; set; }

		[JsonProperty("bundle_deal_id", NullValueHandling = NullValueHandling.Ignore)]
		public int bundle_deal_id { get; set; }

		[JsonProperty("can_use_bundle_deal", NullValueHandling = NullValueHandling.Ignore)]
		public bool can_use_bundle_deal { get; set; }

		[JsonProperty("bundle_deal_info", NullValueHandling = NullValueHandling.Ignore)]
		public object bundle_deal_info { get; set; }

		[JsonProperty("is_group_buy_item", NullValueHandling = NullValueHandling.Ignore)]
		public object is_group_buy_item { get; set; }

		[JsonProperty("has_group_buy_stock", NullValueHandling = NullValueHandling.Ignore)]
		public object has_group_buy_stock { get; set; }

		[JsonProperty("group_buy_info", NullValueHandling = NullValueHandling.Ignore)]
		public object group_buy_info { get; set; }

		[JsonProperty("welcome_package_type", NullValueHandling = NullValueHandling.Ignore)]
		public int welcome_package_type { get; set; }

		[JsonProperty("welcome_package_info", NullValueHandling = NullValueHandling.Ignore)]
		public object welcome_package_info { get; set; }

		[JsonProperty("add_on_deal_info", NullValueHandling = NullValueHandling.Ignore)]
		public object add_on_deal_info { get; set; }

		[JsonProperty("can_use_wholesale", NullValueHandling = NullValueHandling.Ignore)]
		public bool can_use_wholesale { get; set; }

		[JsonProperty("is_preferred_plus_seller", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_preferred_plus_seller { get; set; }

		[JsonProperty("shop_location", NullValueHandling = NullValueHandling.Ignore)]
		public string shop_location { get; set; }

		[JsonProperty("has_model_with_available_shopee_stock", NullValueHandling = NullValueHandling.Ignore)]
		public bool has_model_with_available_shopee_stock { get; set; }

		[JsonProperty("voucher_info", NullValueHandling = NullValueHandling.Ignore)]
		public object voucher_info { get; set; }

		[JsonProperty("can_use_cod", NullValueHandling = NullValueHandling.Ignore)]
		public bool can_use_cod { get; set; }

		[JsonProperty("is_on_flash_sale", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_on_flash_sale { get; set; }

		[JsonProperty("spl_installment_tenure", NullValueHandling = NullValueHandling.Ignore)]
		public object spl_installment_tenure { get; set; }

		[JsonProperty("is_live_streaming_price", NullValueHandling = NullValueHandling.Ignore)]
		public object is_live_streaming_price { get; set; }

		[JsonProperty("is_mart", NullValueHandling = NullValueHandling.Ignore)]
		public bool is_mart { get; set; }

		[JsonProperty("pack_size", NullValueHandling = NullValueHandling.Ignore)]
		public object pack_size { get; set; }
	}

	public class TrackingInfo
	{

		[JsonProperty("viral_spu_tracking", NullValueHandling = NullValueHandling.Ignore)]
		public object viral_spu_tracking { get; set; }

		[JsonProperty("business_tracking", NullValueHandling = NullValueHandling.Ignore)]
		public object business_tracking { get; set; }

		[JsonProperty("multi_search_tracking", NullValueHandling = NullValueHandling.Ignore)]
		public object multi_search_tracking { get; set; }

		[JsonProperty("groupid", NullValueHandling = NullValueHandling.Ignore)]
		public int groupid { get; set; }

		[JsonProperty("ruleid", NullValueHandling = NullValueHandling.Ignore)]
		public IList<int> ruleid { get; set; }
	}

	public class ProductItem
	{

		[JsonProperty("item_basic", NullValueHandling = NullValueHandling.Ignore)]
		public ItemBasic item_basic { get; set; }

		[JsonProperty("adsid", NullValueHandling = NullValueHandling.Ignore)]
		public object adsid { get; set; }

		[JsonProperty("campaignid", NullValueHandling = NullValueHandling.Ignore)]
		public object campaignid { get; set; }

		[JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
		public object distance { get; set; }

		[JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
		public object match_type { get; set; }

		[JsonProperty("ads_keyword", NullValueHandling = NullValueHandling.Ignore)]
		public object ads_keyword { get; set; }

		[JsonProperty("deduction_info", NullValueHandling = NullValueHandling.Ignore)]
		public object deduction_info { get; set; }

		[JsonProperty("collection_id", NullValueHandling = NullValueHandling.Ignore)]
		public object collection_id { get; set; }

		[JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
		public object display_name { get; set; }

		[JsonProperty("campaign_stock", NullValueHandling = NullValueHandling.Ignore)]
		public object campaign_stock { get; set; }

		[JsonProperty("json_data", NullValueHandling = NullValueHandling.Ignore)]
		public string json_data { get; set; }

		[JsonProperty("tracking_info", NullValueHandling = NullValueHandling.Ignore)]
		public TrackingInfo tracking_info { get; set; }

		[JsonProperty("itemid", NullValueHandling = NullValueHandling.Ignore)]
		public object itemid { get; set; }

		[JsonProperty("shopid", NullValueHandling = NullValueHandling.Ignore)]
		public int shopid { get; set; }

		[JsonProperty("algo_image", NullValueHandling = NullValueHandling.Ignore)]
		public object algo_image { get; set; }

		[JsonProperty("fe_flags", NullValueHandling = NullValueHandling.Ignore)]
		public object fe_flags { get; set; }
	}

	public class Adjust
	{

		[JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
		public object count { get; set; }
	}

	public class LowResult
	{

		[JsonProperty("triggered", NullValueHandling = NullValueHandling.Ignore)]
		public bool triggered { get; set; }

		[JsonProperty("scenarios", NullValueHandling = NullValueHandling.Ignore)]
		public object scenarios { get; set; }

		[JsonProperty("total_organic_count", NullValueHandling = NullValueHandling.Ignore)]
		public int total_organic_count { get; set; }

		[JsonProperty("pre_lrp_total_organic_count", NullValueHandling = NullValueHandling.Ignore)]
		public int pre_lrp_total_organic_count { get; set; }
	}

	public class CategoryProducts
	{

		[JsonProperty("bff_meta", NullValueHandling = NullValueHandling.Ignore)]
		public object bff_meta { get; set; }

		[JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
		public object error { get; set; }

		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
		public object error_msg { get; set; }

		[JsonProperty("reserved_keyword", NullValueHandling = NullValueHandling.Ignore)]
		public object reserved_keyword { get; set; }

		[JsonProperty("suggestion_algorithm", NullValueHandling = NullValueHandling.Ignore)]
		public object suggestion_algorithm { get; set; }

		[JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
		public string algorithm { get; set; }

		[JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
		public int total_count { get; set; }

		[JsonProperty("nomore", NullValueHandling = NullValueHandling.Ignore)]
		public bool nomore { get; set; }

		[JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
		public IList<ProductItem> items { get; set; }

		[JsonProperty("price_adjust", NullValueHandling = NullValueHandling.Ignore)]
		public object price_adjust { get; set; }

		[JsonProperty("adjust", NullValueHandling = NullValueHandling.Ignore)]
		public Adjust adjust { get; set; }

		[JsonProperty("total_ads_count", NullValueHandling = NullValueHandling.Ignore)]
		public int total_ads_count { get; set; }

		[JsonProperty("hint_keywords", NullValueHandling = NullValueHandling.Ignore)]
		public object hint_keywords { get; set; }

		[JsonProperty("show_disclaimer", NullValueHandling = NullValueHandling.Ignore)]
		public bool show_disclaimer { get; set; }

		[JsonProperty("json_data", NullValueHandling = NullValueHandling.Ignore)]
		public string json_data { get; set; }

		[JsonProperty("query_rewrite", NullValueHandling = NullValueHandling.Ignore)]
		public object query_rewrite { get; set; }

		[JsonProperty("disclaimer_infos", NullValueHandling = NullValueHandling.Ignore)]
		public IList<object> disclaimer_infos { get; set; }

		[JsonProperty("need_next_search", NullValueHandling = NullValueHandling.Ignore)]
		public bool need_next_search { get; set; }

		[JsonProperty("low_result", NullValueHandling = NullValueHandling.Ignore)]
		public LowResult low_result { get; set; }

		[JsonProperty("autoplay_info", NullValueHandling = NullValueHandling.Ignore)]
		public object autoplay_info { get; set; }
	}


}
