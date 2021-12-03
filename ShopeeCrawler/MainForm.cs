using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Drawing.Imaging;

namespace ShopeeCrawler
{
	
	public partial class MainForm : Form
	{
		private ShopInfo currentShop = null;

		public MainForm()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void ClearControlData()
		{
			lblShopID.Text = "";
			lblShopUsername.Text = "";
			proCurrentProcess.Value = 0;

			lstDanhMuc.Items.Clear();
			gridViewData.Rows.Clear();
		}

		private void btnGetInfo_Click(object sender, EventArgs e)
		{
			// check txtShopID xem có dữ liệu hay ko
			string txtSID = txtShopID.Text.Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "");
			if (txtSID == string.Empty)
			{
				MessageBox.Show("Vui lòng nhập tên hoặc ID của shop.");
				return;
			}

			// clear các control data
			ClearControlData();

			/* check xem dùng username hay ID
			 * nhập thông tin nào thì truy vấn bằng thông tin tương ứng
			 */
			int ShopID = 0;
			if (int.TryParse(txtSID, out ShopID))
				currentShop = GetShopInfo("", ShopID.ToString());
			else
				currentShop = GetShopInfo(txtSID, "");
			
			// nếu lỗi thì thoát
			if (currentShop == null)
				return;

			// lấy thành công shop info
			// hiển thị username && info
			lblShopID.Text = currentShop.data.shopid.ToString();
			lblShopUsername.Text = currentShop.data.account.username;


			/* lấy danh mục của shop  
			 *
			 */
			ShopCategories categories = GetShopCategories();
			// nếu lỗi thì thoát
			if (categories == null)
				return;
			
		
			foreach (ShopCategory cate in categories.data.shop_categories)
			{
				lstDanhMuc.Items.Add(cate);
			}
			lstDanhMuc.DisplayMember = "display_name";
		}

		private void btnSelectAll_Click(object sender, EventArgs e)
		{
			if (lstDanhMuc.Items.Count > 0)
			{
				for (int i = 0; i < lstDanhMuc.Items.Count; i++)
				{
					lstDanhMuc.SetSelected(i, true);
				}
			}
		}

		private void btnGetCategoryInfo_Click(object sender, EventArgs e)
		{
			System.Threading.Thread thr = new System.Threading.Thread(LoadProduct);
			thr.IsBackground = true;
			thr.Start();
		}

		private void LoadProduct()
		{
			// lấy total product và current để chạy cái progressbar
			int totalProducts = 0;
			int currentGetting = 0;
			int currentSTT = 1;

			foreach (ShopCategory cate in lstDanhMuc.SelectedItems)
			{
				totalProducts += cate.total;
			}

			foreach (ShopCategory cate in lstDanhMuc.SelectedItems)
			{
				List<ProductItem> items = GetCategoryItems(cate);

				// Nếu danh sách item lấy về có lỗi chỗ nào đó khiến danh sách
				// không đầy đủ thì phải update lại total cho đúng với
				// số lượng item đã lấy được của category kẻo không bao giờ hiển thị 100% progressBar
				if (items.Count != cate.total)
					totalProducts = totalProducts - cate.total + items.Count;

				foreach (ProductItem item in items)
				{
					Bitmap image = GetHinh(item.item_basic.image);

					string id = item.item_basic.itemid.ToString();
					string name = item.item_basic.name;
					string category = cate.display_name;
					string price = ((int)(item.item_basic.price / 100000)).ToString();
					string price_before_discount = ((int)(item.item_basic.price_before_discount / 100000)).ToString();
					string sold = item.item_basic.sold.ToString();
					string stock = item.item_basic.stock.ToString();

					gridViewData.Rows.Add(new object[] { currentSTT++, id, image, name, category, price, price_before_discount, sold, stock });

					currentGetting++;
					UpdateProgressBar(currentGetting, totalProducts);
				}
			}

			MessageBox.Show("Done", "vailozchimen said:");
		}

		private void btnGetImage_Click(object sender, EventArgs e)
		{
			System.Threading.Thread thr = new System.Threading.Thread(DownloadProductImage);
			thr.IsBackground = true;
			thr.Start();
		}

		private void DownloadProductImage()
		{
			string shopDir = currentShop.data.account.username;
			DirectoryInfo shopDirInfo = new DirectoryInfo(shopDir);
			if (!shopDirInfo.Exists)
			{
				shopDirInfo.Create();
			}

			// lấy total product và current để chạy cái progressbar
			int totalProducts = 0;
			int currentGetting = 0;

			foreach (ShopCategory cate in lstDanhMuc.SelectedItems)
			{
				totalProducts += cate.total;
			}

			foreach (ShopCategory cate in lstDanhMuc.SelectedItems)
			{
				List<ProductItem> items = GetCategoryItems(cate);

				// Nếu danh sách item lấy về có lỗi chỗ nào đó khiến danh sách
				// không đầy đủ thì phải update lại total cho đúng với
				// số lượng item đã lấy được của category kẻo không bao giờ hiển thị 100% progressBar
				if (items.Count != cate.total)
					totalProducts = totalProducts - cate.total + items.Count;

				foreach (ProductItem item in items)
				{
					// tạo folder cho product
					string productDir = shopDir + "\\" + item.item_basic.name.Replace("\\", "")
																			.Replace("/", "")
																			.Replace(":", "")
																			.Replace("|", "")
																			.Replace("<", "")
																			.Replace(">", "")
																			.Replace("*", "")
																			.Replace("?", "")
																			.Replace("\"", "")
																			.Replace("'", "").Trim();
					DirectoryInfo productDirInfo = new DirectoryInfo(productDir);
					if (!productDirInfo.Exists)
					{
						productDirInfo.Create();
					}

					// tải hình về
					foreach (string fileID in item.item_basic.images)
					{
						using (MemoryStream memory = GetHinhMemoryStream(fileID))
						{
							using (FileStream fs = new FileStream(productDir + "\\" + fileID + ".jpg", FileMode.Create, FileAccess.ReadWrite))
							{
								byte[] bytes = memory.ToArray();
								fs.Write(bytes, 0, bytes.Length);
							}
						}
					}

					currentGetting++;
					UpdateProgressBar(currentGetting, totalProducts);
				}
			}

			MessageBox.Show("Done", "vailozchimen said:");
		}



		private void UpdateProgressBar(int current, int total)
		{
			// update cái progressBar
			float phepchia = (float)(current * 1.0) / total;
			float phantram = phepchia * 100;
			proCurrentProcess.Value = (int)phantram;
			Application.DoEvents();
		}

		private Bitmap GetHinh(string fileID)
		{
			// tải hình về
			WebClient client = new WebClient();
			try
			{
				byte[] imageData = client.DownloadData("https://cf.shopee.vn/file/" + fileID);

				Bitmap bmp = null; ;
				using (var memory = new MemoryStream(imageData))
				{
					bmp = new Bitmap(memory);
				}

				return bmp;
			}
			catch (Exception ex)
			{
				return ShopeeCrawler.Properties.Resources.error;
			}
		}

		private MemoryStream GetHinhMemoryStream(string fileID)
		{
			// tải hình về
			WebClient client = new WebClient();
			try
			{
				byte[] imageData = client.DownloadData("https://cf.shopee.vn/file/" + fileID);

				using (var memory = new MemoryStream(imageData))
				{
					return memory;
				}
			}
			catch (Exception ex)
			{
				using (MemoryStream memory = new MemoryStream())
				{
					ShopeeCrawler.Properties.Resources.error.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
					return memory;
				}
			}
		}

		private ShopInfo GetShopInfo(string username, string id)
		{
			string URL = String.Format("https://shopee.vn/api/v4/shop/get_shop_detail?username={0}&shopid={1}", username, id);

			WebClient client = new WebClient();
			try
			{
				string json = client.DownloadString(URL);
				ShopInfo shopInfo = JsonConvert.DeserializeObject<ShopInfo>(json);

				if (shopInfo.error == 0)
				{
					return shopInfo;
				}
			}
			catch (Exception ex)
			{
				// mọi exception đều chạy xuống dưới như trường hợp shopInfo.error != 0
			}

			MessageBox.Show("Lấy thông tin shop bị lỗi!!!", "vailozchimen said:", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return null;
		}

		private ShopCategories GetShopCategories()
		{
			string URL = String.Format("https://shopee.vn/api/v4/shop/get_categories?limit=100&offset=0&shopid={0}", currentShop.data.shopid.ToString());

			WebClient client = new WebClient();
			try
			{
				string json = client.DownloadString(URL);
				ShopCategories shopCategories = JsonConvert.DeserializeObject<ShopCategories>(json);

				if (shopCategories.error == 0)
				{
					return shopCategories;
				}
			}
			catch (Exception ex)
			{
				// mọi exception đều chạy xuống dưới như trường hợp shopCategories.error != 0
			}

			MessageBox.Show("Lấy danh mục shop bị lỗi!!!", "vailozchimen said:", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return null;
		}


		/*private CategoryProducts GetCategory(ShopCategory cate)
		{
			string URL = String.Format("https://shopee.vn/api/v4/search/search_items?by=pop&limit=100&match_id={0}&newest=0&order=desc&page_type=shop&scenario=PAGE_OTHERS&shop_categoryids={1}&version=2", currentShop.data.shopid.ToString(), cate.shop_category_id.ToString());

			WebClient client = new WebClient();
			try {
				string json = client.DownloadString(URL);
				CategoryProducts categoryProducts = JsonConvert.DeserializeObject<CategoryProducts>(json);

				if (categoryProducts.error == null)
				{
					return categoryProducts;
				}
			}
			catch (Exception ex)
			{
				// mọi exception đều chạy xuống dưới như trường hợp categoryProducts.error != null
			}

			MessageBox.Show("Lấy danh sách sản phẩm trong danh mục bị lỗi!!!", "vailozchimen said:", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return null;
		}*/

		private List<ProductItem> GetCategoryItems(ShopCategory cate)
		{
			int newestParam = 0;
			int limit = 30;
			int total = cate.total - 1;
			List<ProductItem> items = new List<ProductItem>();

			while (newestParam < total)
			{
				string URL = String.Format("https://shopee.vn/api/v4/search/search_items?by=pop&limit={0}&match_id={1}&newest={2}&order=desc&page_type=shop&scenario=PAGE_OTHERS&shop_categoryids={3}&version=2",
											limit.ToString(), currentShop.data.shopid.ToString(),
											newestParam.ToString(), cate.shop_category_id.ToString());

				WebClient client = new WebClient();
				try
				{
					string json = client.DownloadString(URL);
					CategoryProducts categoryProducts = JsonConvert.DeserializeObject<CategoryProducts>(json);

					if (categoryProducts.error == null)
					{
						items.AddRange(categoryProducts.items);
					}
				}
				catch (WebException ex)
				{
					MessageBox.Show("Lấy danh sách sản phẩm trong danh mục bị lỗi!!!\n\n" + ex.Message, "vailozchimen said:", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{

				}

				newestParam += limit;
			}

			return items;
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Excel 2010-2019|*.xlsx|Excel|*.xls";
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result != DialogResult.OK)
				return;
			
			try
			{
				Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
				// creating new WorkBook within Excel application
				Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
				// creating new Excelsheet in workbook  
				Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
				// see the excel sheet behind the program  
				app.Visible = true;
				// get the reference of first sheet. By default its name is Sheet1.  
				// store its reference to worksheet  
				worksheet = workbook.Sheets["Sheet1"];
				worksheet = workbook.ActiveSheet;
				// changing the name of active sheet  
				worksheet.Name = "Exported from ShopeeCrawler";
				// storing header part in Excel  
				for (int i = 1; i < gridViewData.Columns.Count + 1; i++)
				{
					worksheet.Cells[1, i] = gridViewData.Columns[i - 1].HeaderText;
				}
				// storing Each row and column value to excel sheet  
				for (int i = 0; i < gridViewData.Rows.Count - 1; i++)
				{
					for (int j = 0; j < gridViewData.Columns.Count; j++)
					{
						if (gridViewData.Rows[i].Cells[j].GetType() == typeof(DataGridViewImageCell))
						{
							// nếu là ảnh thì vứt, library tùm lum mệt quá
						}
						else
							worksheet.Cells[i + 2, j + 1] = gridViewData.Rows[i].Cells[j].Value.ToString();
					}
				}
				// save the application  
				workbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				// Exit from the application  
				app.Quit();
			}
			catch {
				MessageBox.Show("Lỗi, chắc là thím chưa cài Excel.", "vailozchimen said:");
			}
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://voz.vn/u/vailozchimen.1720384/");
			}
			catch { 
				try
				{
					System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "https://voz.vn/u/vailozchimen.1720384/");
				}
				catch {
					try
					{
						System.Diagnostics.Process.Start("IEXPLORE.EXE", "https://voz.vn/u/vailozchimen.1720384/");
					}
					catch
					{

					}
				}
			}
		}

		public byte[] ImageToByteArray(System.Drawing.Image imageIn)
		{
			using (var ms = new MemoryStream())
			{
				imageIn.Save(ms, ImageFormat.Png);
				return ms.ToArray();
			}
		}
		public Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
			Image returnImage = Bitmap.FromStream(ms);
			return returnImage;
		}
	}
}
