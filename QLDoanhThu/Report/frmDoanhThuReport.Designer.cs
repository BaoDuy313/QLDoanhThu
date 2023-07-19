
namespace QLDoanhThu.Report
{
    partial class frmDoanhThuReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhThuNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtThoiGian = new System.Windows.Forms.DateTimePicker();
            this.chartDoanhThuThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMucTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.chartDoanhThuNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThuNam
            // 
            chartArea7.Name = "ChartArea1";
            this.chartDoanhThuNam.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartDoanhThuNam.Legends.Add(legend7);
            this.chartDoanhThuNam.Location = new System.Drawing.Point(12, 436);
            this.chartDoanhThuNam.Name = "chartDoanhThuNam";
            series7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series7.ChartArea = "ChartArea1";
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series7.IsValueShownAsLabel = true;
            series7.LabelBackColor = System.Drawing.Color.White;
            series7.Legend = "Legend1";
            series7.Name = "Doanh Thu";
            series7.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White;
            series7.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartDoanhThuNam.Series.Add(series7);
            this.chartDoanhThuNam.Size = new System.Drawing.Size(732, 413);
            this.chartDoanhThuNam.TabIndex = 22;
            this.chartDoanhThuNam.Text = "chart2";
            // 
            // dtThoiGian
            // 
            this.dtThoiGian.CustomFormat = "yyyy";
            this.dtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGian.Location = new System.Drawing.Point(417, 12);
            this.dtThoiGian.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtThoiGian.Name = "dtThoiGian";
            this.dtThoiGian.ShowUpDown = true;
            this.dtThoiGian.Size = new System.Drawing.Size(101, 38);
            this.dtThoiGian.TabIndex = 23;
            this.dtThoiGian.ValueChanged += new System.EventHandler(this.dtThoiGian_ValueChanged);
            // 
            // chartDoanhThuThang
            // 
            chartArea8.Name = "ChartArea1";
            this.chartDoanhThuThang.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartDoanhThuThang.Legends.Add(legend8);
            this.chartDoanhThuThang.Location = new System.Drawing.Point(750, 436);
            this.chartDoanhThuThang.Name = "chartDoanhThuThang";
            series8.ChartArea = "ChartArea1";
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsValueShownAsLabel = true;
            series8.LabelBackColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Doanh Thu";
            this.chartDoanhThuThang.Series.Add(series8);
            this.chartDoanhThuThang.Size = new System.Drawing.Size(1122, 413);
            this.chartDoanhThuThang.TabIndex = 20;
            this.chartDoanhThuThang.Text = "chart1";
            // 
            // gvData
            // 
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID,
            this.colNgay,
            this.colDoanhThu,
            this.colChiPhi,
            this.colLine,
            this.colStyle,
            this.colSoLuong,
            this.colDVT,
            this.colTinhTrang,
            this.colMucTieu});
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvData.GridControl = this.gcData;
            this.gvData.GroupCount = 1;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgay, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLine, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // col_ID
            // 
            this.col_ID.AppearanceCell.Options.UseTextOptions = true;
            this.col_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 0;
            this.col_ID.Width = 51;
            // 
            // colNgay
            // 
            this.colNgay.AppearanceCell.Options.UseTextOptions = true;
            this.colNgay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNgay.Caption = "Doanh thu ngày";
            this.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 152;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.Caption = "Doanh thu";
            this.colDoanhThu.DisplayFormat.FormatString = "c2";
            this.colDoanhThu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDoanhThu.FieldName = "DoanhThu";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.Visible = true;
            this.colDoanhThu.VisibleIndex = 6;
            this.colDoanhThu.Width = 115;
            // 
            // colChiPhi
            // 
            this.colChiPhi.Caption = "Chi phí";
            this.colChiPhi.FieldName = "NameChiPhi";
            this.colChiPhi.Name = "colChiPhi";
            this.colChiPhi.Visible = true;
            this.colChiPhi.VisibleIndex = 7;
            this.colChiPhi.Width = 173;
            // 
            // colLine
            // 
            this.colLine.AppearanceCell.Options.UseTextOptions = true;
            this.colLine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colLine.Caption = "Chuyền";
            this.colLine.FieldName = "NameLine";
            this.colLine.Name = "colLine";
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 1;
            this.colLine.Width = 77;
            // 
            // colStyle
            // 
            this.colStyle.AppearanceCell.Options.UseTextOptions = true;
            this.colStyle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colStyle.Caption = "Mã hàng";
            this.colStyle.FieldName = "NameStyle";
            this.colStyle.Name = "colStyle";
            this.colStyle.Visible = true;
            this.colStyle.VisibleIndex = 2;
            this.colStyle.Width = 97;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.DisplayFormat.FormatString = "n0";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 77;
            // 
            // colDVT
            // 
            this.colDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 5;
            this.colDVT.Width = 96;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Caption = "Tình trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 8;
            this.colTinhTrang.Width = 118;
            // 
            // colMucTieu
            // 
            this.colMucTieu.Caption = "Mục Tiêu";
            this.colMucTieu.FieldName = "MucTieu";
            this.colMucTieu.Name = "colMucTieu";
            this.colMucTieu.Visible = true;
            this.colMucTieu.VisibleIndex = 3;
            this.colMucTieu.Width = 56;
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(12, 12);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(885, 418);
            this.gcData.TabIndex = 21;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            this.gcData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcData_MouseClick);
            // 
            // chartDoanhThuNgay
            // 
            chartArea9.Name = "ChartArea1";
            this.chartDoanhThuNgay.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartDoanhThuNgay.Legends.Add(legend9);
            this.chartDoanhThuNgay.Location = new System.Drawing.Point(903, 12);
            this.chartDoanhThuNgay.Name = "chartDoanhThuNgay";
            series9.ChartArea = "ChartArea1";
            series9.IsValueShownAsLabel = true;
            series9.LabelBackColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "Doanh Thu";
            this.chartDoanhThuNgay.Series.Add(series9);
            this.chartDoanhThuNgay.Size = new System.Drawing.Size(969, 418);
            this.chartDoanhThuNgay.TabIndex = 24;
            this.chartDoanhThuNgay.Text = "chart1";
            // 
            // frmDoanhThuReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.chartDoanhThuNgay);
            this.Controls.Add(this.chartDoanhThuThang);
            this.Controls.Add(this.dtThoiGian);
            this.Controls.Add(this.chartDoanhThuNam);
            this.Controls.Add(this.gcData);
            this.Name = "frmDoanhThuReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu Report";
            this.Load += new System.EventHandler(this.frmDoanhThuReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuNam;
        private System.Windows.Forms.DateTimePicker dtThoiGian;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuThang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colMucTieu;
        private DevExpress.XtraGrid.GridControl gcData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuNgay;
    }
}