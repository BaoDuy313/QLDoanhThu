
namespace QLDoanhThu.Report
{
    partial class frmStyleReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IDStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDataTong = new DevExpress.XtraGrid.GridControl();
            this.gvDataTong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_NameFac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Tong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTongStyle = new System.Windows.Forms.Label();
            this.lbStyle = new System.Windows.Forms.Label();
            this.colIDLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataTong)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcData;
            this.gridView2.Name = "gridView2";
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(3, 47);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1254, 339);
            this.gcData.TabIndex = 11;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData,
            this.gridView2});
            this.gcData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcData_MouseClick);
            // 
            // gvData
            // 
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IDStyle,
            this.colSoLuong,
            this.colDonGia,
            this.colNgay,
            this.colTinhTrang});
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ShowFooter = true;
            // 
            // col_IDStyle
            // 
            this.col_IDStyle.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_IDStyle.AppearanceCell.Options.UseFont = true;
            this.col_IDStyle.AppearanceCell.Options.UseTextOptions = true;
            this.col_IDStyle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_IDStyle.Caption = "ID Style";
            this.col_IDStyle.FieldName = "ID";
            this.col_IDStyle.Name = "col_IDStyle";
            this.col_IDStyle.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "Số mã :{0}")});
            this.col_IDStyle.Visible = true;
            this.col_IDStyle.VisibleIndex = 0;
            this.col_IDStyle.Width = 136;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoLuong.AppearanceCell.Options.UseFont = true;
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.DisplayFormat.FormatString = "n0";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            this.colSoLuong.Width = 80;
            // 
            // colDonGia
            // 
            this.colDonGia.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDonGia.AppearanceCell.Options.UseFont = true;
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "n2";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 2;
            this.colDonGia.Width = 80;
            // 
            // colNgay
            // 
            this.colNgay.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgay.AppearanceCell.Options.UseFont = true;
            this.colNgay.Caption = "Ngày lên chuyền";
            this.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 3;
            this.colNgay.Width = 175;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTinhTrang.AppearanceCell.Options.UseFont = true;
            this.colTinhTrang.Caption = "Tình trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 4;
            this.colTinhTrang.Width = 134;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDataTong;
            this.gridView1.Name = "gridView1";
            // 
            // gcDataTong
            // 
            this.gcDataTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDataTong.Location = new System.Drawing.Point(3, 436);
            this.gcDataTong.MainView = this.gvDataTong;
            this.gcDataTong.Name = "gcDataTong";
            this.gcDataTong.Size = new System.Drawing.Size(1254, 344);
            this.gcDataTong.TabIndex = 12;
            this.gcDataTong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDataTong,
            this.gridView1});
            // 
            // gvDataTong
            // 
            this.gvDataTong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_NameFac,
            this.col_NameLine,
            this.col_ID,
            this.col_SoLuong,
            this.col_DonGia,
            this.col_Tong,
            this.col_Ngay});
            this.gvDataTong.GridControl = this.gcDataTong;
            this.gvDataTong.Name = "gvDataTong";
            this.gvDataTong.OptionsBehavior.Editable = false;
            this.gvDataTong.OptionsView.ShowFooter = true;
            // 
            // col_NameFac
            // 
            this.col_NameFac.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_NameFac.AppearanceCell.Options.UseFont = true;
            this.col_NameFac.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_NameFac.AppearanceHeader.Options.UseFont = true;
            this.col_NameFac.Caption = "Xưởng";
            this.col_NameFac.FieldName = "NameFac";
            this.col_NameFac.Name = "col_NameFac";
            this.col_NameFac.Visible = true;
            this.col_NameFac.VisibleIndex = 0;
            this.col_NameFac.Width = 101;
            // 
            // col_NameLine
            // 
            this.col_NameLine.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_NameLine.AppearanceCell.Options.UseFont = true;
            this.col_NameLine.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_NameLine.AppearanceHeader.Options.UseFont = true;
            this.col_NameLine.Caption = "Chuyền";
            this.col_NameLine.FieldName = "NameLine";
            this.col_NameLine.Name = "col_NameLine";
            this.col_NameLine.Visible = true;
            this.col_NameLine.VisibleIndex = 1;
            this.col_NameLine.Width = 101;
            // 
            // col_ID
            // 
            this.col_ID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ID.AppearanceCell.Options.UseFont = true;
            this.col_ID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ID.AppearanceHeader.Options.UseFont = true;
            this.col_ID.Caption = "ID Style";
            this.col_ID.FieldName = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 2;
            this.col_ID.Width = 166;
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_SoLuong.AppearanceCell.Options.UseFont = true;
            this.col_SoLuong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_SoLuong.AppearanceHeader.Options.UseFont = true;
            this.col_SoLuong.Caption = "Số Lượng";
            this.col_SoLuong.FieldName = "SoLuong";
            this.col_SoLuong.Name = "col_SoLuong";
            this.col_SoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "Số Lượng={0:0.##}")});
            this.col_SoLuong.Visible = true;
            this.col_SoLuong.VisibleIndex = 3;
            this.col_SoLuong.Width = 109;
            // 
            // col_DonGia
            // 
            this.col_DonGia.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_DonGia.AppearanceCell.Options.UseFont = true;
            this.col_DonGia.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_DonGia.AppearanceHeader.Options.UseFont = true;
            this.col_DonGia.Caption = "Đơn Giá";
            this.col_DonGia.FieldName = "DonGia";
            this.col_DonGia.Name = "col_DonGia";
            this.col_DonGia.Visible = true;
            this.col_DonGia.VisibleIndex = 4;
            this.col_DonGia.Width = 98;
            // 
            // col_Tong
            // 
            this.col_Tong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Tong.AppearanceCell.Options.UseFont = true;
            this.col_Tong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Tong.AppearanceHeader.Options.UseFont = true;
            this.col_Tong.Caption = "Tổng";
            this.col_Tong.DisplayFormat.FormatString = "C2";
            this.col_Tong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_Tong.FieldName = "Tong";
            this.col_Tong.Name = "col_Tong";
            this.col_Tong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tong", "Tổng={0:C2}")});
            this.col_Tong.Visible = true;
            this.col_Tong.VisibleIndex = 5;
            this.col_Tong.Width = 166;
            // 
            // col_Ngay
            // 
            this.col_Ngay.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Ngay.AppearanceCell.Options.UseFont = true;
            this.col_Ngay.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Ngay.AppearanceHeader.Options.UseFont = true;
            this.col_Ngay.Caption = "Ngày";
            this.col_Ngay.FieldName = "Ngay";
            this.col_Ngay.Name = "col_Ngay";
            this.col_Ngay.Visible = true;
            this.col_Ngay.VisibleIndex = 6;
            this.col_Ngay.Width = 158;
            // 
            // lbTongStyle
            // 
            this.lbTongStyle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTongStyle.AutoSize = true;
            this.lbTongStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongStyle.ForeColor = System.Drawing.Color.Navy;
            this.lbTongStyle.Location = new System.Drawing.Point(477, 395);
            this.lbTongStyle.Name = "lbTongStyle";
            this.lbTongStyle.Size = new System.Drawing.Size(305, 31);
            this.lbTongStyle.TabIndex = 2;
            this.lbTongStyle.Text = "Tổng Doanh Thu Style";
            this.lbTongStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStyle
            // 
            this.lbStyle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStyle.AutoSize = true;
            this.lbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStyle.ForeColor = System.Drawing.Color.Navy;
            this.lbStyle.Location = new System.Drawing.Point(590, 6);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(80, 31);
            this.lbStyle.TabIndex = 1;
            this.lbStyle.Text = "Style";
            this.lbStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colIDLine
            // 
            this.colIDLine.Caption = "ID Line";
            this.colIDLine.FieldName = "IDLine";
            this.colIDLine.Name = "colIDLine";
            this.colIDLine.Width = 107;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbTongStyle, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbStyle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcDataTong, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.gcData, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.698779F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23338F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.698779F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.64043F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1260, 783);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // frmStyleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 807);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmStyleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Style Report";
            this.Load += new System.EventHandler(this.frmStyleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataTong)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn col_IDStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcDataTong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDataTong;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameFac;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameLine;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn col_DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn col_Tong;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ngay;
        private System.Windows.Forms.Label lbTongStyle;
        private System.Windows.Forms.Label lbStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}