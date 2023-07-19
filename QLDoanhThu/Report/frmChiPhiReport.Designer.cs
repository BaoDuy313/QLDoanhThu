
namespace QLDoanhThu.Report
{
    partial class frmChiPhiReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartChiPhiThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IDLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartChiPhiNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtThoiGian = new System.Windows.Forms.DateTimePicker();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhiThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhiNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartChiPhiThang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChiPhiThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChiPhiThang.Legends.Add(legend1);
            this.chartChiPhiThang.Location = new System.Drawing.Point(12, 424);
            this.chartChiPhiThang.Name = "chartChiPhiThang";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Chi Phí";
            this.chartChiPhiThang.Series.Add(series1);
            this.chartChiPhiThang.Size = new System.Drawing.Size(1760, 412);
            this.chartChiPhiThang.TabIndex = 19;
            this.chartChiPhiThang.Text = "chart2";
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(12, 12);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(874, 406);
            this.gcData.TabIndex = 14;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData,
            this.gridView1});
            // 
            // gvData
            // 
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.col_MO,
            this.col_IDLine});
            this.gvData.CustomizationFormBounds = new System.Drawing.Rectangle(1575, 728, 264, 272);
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvData.GridControl = this.gcData;
            this.gvData.GroupCount = 1;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_IDLine, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // col_ID
            // 
            this.col_ID.AppearanceCell.Options.UseTextOptions = true;
            this.col_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "IDChiPhi";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 0;
            this.col_ID.Width = 93;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 169;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày nhập";
            this.gridColumn2.DisplayFormat.FormatString = "MM/yyyy";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn2.FieldName = "Ngay";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 187;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.Caption = "Chi phí";
            this.gridColumn3.DisplayFormat.FormatString = "n0";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn3.FieldName = "ChiPhi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ChiPhi", "Tổng= {0:n0}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 199;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đvt";
            this.gridColumn4.FieldName = "DVT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 69;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tình trạng";
            this.gridColumn5.FieldName = "TinhTrang";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 79;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.Caption = "Số ngày công";
            this.gridColumn6.FieldName = "NgayCong";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 114;
            // 
            // col_MO
            // 
            this.col_MO.Caption = "MO";
            this.col_MO.FieldName = "MO";
            this.col_MO.Name = "col_MO";
            this.col_MO.Visible = true;
            this.col_MO.VisibleIndex = 6;
            // 
            // col_IDLine
            // 
            this.col_IDLine.Caption = "ID Line";
            this.col_IDLine.FieldName = "IDLine";
            this.col_IDLine.Name = "col_IDLine";
            this.col_IDLine.Visible = true;
            this.col_IDLine.VisibleIndex = 1;
            this.col_IDLine.Width = 51;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcData;
            this.gridView1.Name = "gridView1";
            // 
            // chartChiPhiNam
            // 
            chartArea2.Name = "ChartArea1";
            this.chartChiPhiNam.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartChiPhiNam.Legends.Add(legend2);
            this.chartChiPhiNam.Location = new System.Drawing.Point(892, 12);
            this.chartChiPhiNam.Name = "chartChiPhiNam";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Chi Phí";
            this.chartChiPhiNam.Series.Add(series2);
            this.chartChiPhiNam.Size = new System.Drawing.Size(880, 406);
            this.chartChiPhiNam.TabIndex = 15;
            this.chartChiPhiNam.Text = "chart1";
            // 
            // dtThoiGian
            // 
            this.dtThoiGian.CustomFormat = "yyyy";
            this.dtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGian.Location = new System.Drawing.Point(406, 12);
            this.dtThoiGian.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtThoiGian.Name = "dtThoiGian";
            this.dtThoiGian.ShowUpDown = true;
            this.dtThoiGian.Size = new System.Drawing.Size(98, 38);
            this.dtThoiGian.TabIndex = 21;
            this.dtThoiGian.ValueChanged += new System.EventHandler(this.dtThoiGian_ValueChanged);
            // 
            // frmChiPhiReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 861);
            this.Controls.Add(this.chartChiPhiThang);
            this.Controls.Add(this.dtThoiGian);
            this.Controls.Add(this.chartChiPhiNam);
            this.Controls.Add(this.gcData);
            this.Name = "frmChiPhiReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Phí Report";
            this.Load += new System.EventHandler(this.frmChiPhiReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhiThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhiNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiPhiThang;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn col_MO;
        private DevExpress.XtraGrid.Columns.GridColumn col_IDLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiPhiNam;
        private System.Windows.Forms.DateTimePicker dtThoiGian;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}