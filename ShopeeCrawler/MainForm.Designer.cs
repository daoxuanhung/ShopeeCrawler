
namespace ShopeeCrawler
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.lstDanhMuc = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblShopUsername = new System.Windows.Forms.Label();
			this.lblShopID = new System.Windows.Forms.Label();
			this.lblusername = new System.Windows.Forms.Label();
			this.lblid = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtShopID = new System.Windows.Forms.TextBox();
			this.btnGetInfo = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnGetImage = new System.Windows.Forms.Button();
			this.btnGetCategoryInfo = new System.Windows.Forms.Button();
			this.proCurrentProcess = new System.Windows.Forms.ProgressBar();
			this.gridViewData = new System.Windows.Forms.DataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Image = new System.Windows.Forms.DataGridViewImageColumn();
			this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OriginPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSelectAll);
			this.groupBox1.Controls.Add(this.lstDanhMuc);
			this.groupBox1.Location = new System.Drawing.Point(12, 146);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 360);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh mục Shop";
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Location = new System.Drawing.Point(6, 331);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
			this.btnSelectAll.TabIndex = 1;
			this.btnSelectAll.Text = "Chọn hết";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// lstDanhMuc
			// 
			this.lstDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lstDanhMuc.FormattingEnabled = true;
			this.lstDanhMuc.ItemHeight = 20;
			this.lstDanhMuc.Location = new System.Drawing.Point(6, 22);
			this.lstDanhMuc.Name = "lstDanhMuc";
			this.lstDanhMuc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstDanhMuc.Size = new System.Drawing.Size(187, 304);
			this.lstDanhMuc.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblShopUsername);
			this.groupBox2.Controls.Add(this.lblShopID);
			this.groupBox2.Controls.Add(this.lblusername);
			this.groupBox2.Controls.Add(this.lblid);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtShopID);
			this.groupBox2.Controls.Add(this.btnGetInfo);
			this.groupBox2.Location = new System.Drawing.Point(12, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(274, 129);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin shop";
			// 
			// lblShopUsername
			// 
			this.lblShopUsername.BackColor = System.Drawing.Color.Transparent;
			this.lblShopUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblShopUsername.Location = new System.Drawing.Point(97, 48);
			this.lblShopUsername.Name = "lblShopUsername";
			this.lblShopUsername.Size = new System.Drawing.Size(171, 18);
			this.lblShopUsername.TabIndex = 6;
			// 
			// lblShopID
			// 
			this.lblShopID.BackColor = System.Drawing.Color.Transparent;
			this.lblShopID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblShopID.Location = new System.Drawing.Point(97, 24);
			this.lblShopID.Name = "lblShopID";
			this.lblShopID.Size = new System.Drawing.Size(171, 18);
			this.lblShopID.TabIndex = 5;
			// 
			// lblusername
			// 
			this.lblusername.AutoSize = true;
			this.lblusername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblusername.Location = new System.Drawing.Point(6, 47);
			this.lblusername.Name = "lblusername";
			this.lblusername.Size = new System.Drawing.Size(82, 20);
			this.lblusername.TabIndex = 4;
			this.lblusername.Text = "Username: ";
			// 
			// lblid
			// 
			this.lblid.AutoSize = true;
			this.lblid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblid.Location = new System.Drawing.Point(7, 23);
			this.lblid.Name = "lblid";
			this.lblid.Size = new System.Drawing.Size(31, 20);
			this.lblid.TabIndex = 3;
			this.lblid.Text = "ID: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(6, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Shop ID:";
			// 
			// txtShopID
			// 
			this.txtShopID.Location = new System.Drawing.Point(97, 71);
			this.txtShopID.Name = "txtShopID";
			this.txtShopID.Size = new System.Drawing.Size(171, 23);
			this.txtShopID.TabIndex = 1;
			this.txtShopID.Text = "huyentrangbabyshop";
			// 
			// btnGetInfo
			// 
			this.btnGetInfo.Location = new System.Drawing.Point(96, 100);
			this.btnGetInfo.Name = "btnGetInfo";
			this.btnGetInfo.Size = new System.Drawing.Size(172, 23);
			this.btnGetInfo.TabIndex = 0;
			this.btnGetInfo.Text = "Lấy thông tin";
			this.btnGetInfo.UseVisualStyleBackColor = true;
			this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnExportExcel);
			this.groupBox3.Controls.Add(this.btnGetImage);
			this.groupBox3.Controls.Add(this.btnGetCategoryInfo);
			this.groupBox3.Location = new System.Drawing.Point(218, 146);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(68, 360);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Actions";
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Location = new System.Drawing.Point(6, 95);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(56, 67);
			this.btnExportExcel.TabIndex = 2;
			this.btnExportExcel.Text = "2. Xuất Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnGetImage
			// 
			this.btnGetImage.Location = new System.Drawing.Point(6, 287);
			this.btnGetImage.Name = "btnGetImage";
			this.btnGetImage.Size = new System.Drawing.Size(56, 67);
			this.btnGetImage.TabIndex = 1;
			this.btnGetImage.Text = "Tải hình";
			this.btnGetImage.UseVisualStyleBackColor = true;
			this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
			// 
			// btnGetCategoryInfo
			// 
			this.btnGetCategoryInfo.Location = new System.Drawing.Point(6, 22);
			this.btnGetCategoryInfo.Name = "btnGetCategoryInfo";
			this.btnGetCategoryInfo.Size = new System.Drawing.Size(56, 67);
			this.btnGetCategoryInfo.TabIndex = 0;
			this.btnGetCategoryInfo.Text = "1. Lấy thông tin";
			this.btnGetCategoryInfo.UseVisualStyleBackColor = true;
			this.btnGetCategoryInfo.Click += new System.EventHandler(this.btnGetCategoryInfo_Click);
			// 
			// proCurrentProcess
			// 
			this.proCurrentProcess.Location = new System.Drawing.Point(12, 512);
			this.proCurrentProcess.Name = "proCurrentProcess";
			this.proCurrentProcess.Size = new System.Drawing.Size(274, 23);
			this.proCurrentProcess.TabIndex = 3;
			// 
			// gridViewData
			// 
			this.gridViewData.AllowUserToAddRows = false;
			this.gridViewData.AllowUserToDeleteRows = false;
			this.gridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.Image,
            this.ProName,
            this.Category,
            this.Price,
            this.OriginPrice,
            this.Sold,
            this.Stock});
			this.gridViewData.Location = new System.Drawing.Point(292, 12);
			this.gridViewData.Name = "gridViewData";
			this.gridViewData.ReadOnly = true;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridViewData.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridViewData.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridViewData.RowTemplate.Height = 120;
			this.gridViewData.Size = new System.Drawing.Size(1014, 523);
			this.gridViewData.TabIndex = 4;
			// 
			// STT
			// 
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Image
			// 
			this.Image.HeaderText = "Ảnh";
			this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.Image.Name = "Image";
			this.Image.ReadOnly = true;
			this.Image.Width = 120;
			// 
			// ProName
			// 
			this.ProName.HeaderText = "Tên";
			this.ProName.Name = "ProName";
			this.ProName.ReadOnly = true;
			// 
			// Category
			// 
			this.Category.HeaderText = "Danh mục";
			this.Category.Name = "Category";
			this.Category.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.HeaderText = "Giá";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// OriginPrice
			// 
			this.OriginPrice.HeaderText = "Giá gốc";
			this.OriginPrice.Name = "OriginPrice";
			this.OriginPrice.ReadOnly = true;
			// 
			// Sold
			// 
			this.Sold.HeaderText = "Đã bán";
			this.Sold.Name = "Sold";
			this.Sold.ReadOnly = true;
			// 
			// Stock
			// 
			this.Stock.HeaderText = "Tồn";
			this.Stock.Name = "Stock";
			this.Stock.ReadOnly = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 541);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(1318, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(54, 17);
			this.toolStripStatusLabel2.Text = "from Voz";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.IsLink = true;
			this.toolStripStatusLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
			this.toolStripStatusLabel1.Text = "vailozchimen";
			this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1318, 563);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gridViewData);
			this.Controls.Add(this.proCurrentProcess);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtShopID;
		private System.Windows.Forms.Button btnGetInfo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ProgressBar proCurrentProcess;
		private System.Windows.Forms.DataGridView gridViewData;
		private System.Windows.Forms.Label lblusername;
		private System.Windows.Forms.Label lblid;
		private System.Windows.Forms.ListBox lstDanhMuc;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.Label lblShopUsername;
		private System.Windows.Forms.Label lblShopID;
		private System.Windows.Forms.Button btnGetImage;
		private System.Windows.Forms.Button btnGetCategoryInfo;
		private System.Windows.Forms.Button btnExportExcel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewImageColumn Image;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Category;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn OriginPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sold;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
	}
}

