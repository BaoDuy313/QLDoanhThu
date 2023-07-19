namespace QLDoanhThu.ChiPhi
{
    partial class frmChiPhi
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listboxXuong = new DevExpress.XtraEditors.ListBoxControl();
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
            this.listboxChuyen = new DevExpress.XtraEditors.ListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.popupEdit = new DevExpress.XtraBars.BarButtonItem();
            this.popupDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupCompleteChiPhi = new DevExpress.XtraBars.BarButtonItem();
            this.popupEditChiPhi = new DevExpress.XtraBars.BarButtonItem();
            this.popupDeleteChiPhi = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemAlignment1 = new DevExpress.XtraRichEdit.Design.RepositoryItemAlignment();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.colNgayCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ChiPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listboxXuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.layoutControl1.Controls.Add(this.listboxXuong);
            this.layoutControl1.Controls.Add(this.gcData);
            this.layoutControl1.Controls.Add(this.listboxChuyen);
            this.layoutControl1.Location = new System.Drawing.Point(2, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1507, 769);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // listboxXuong
            // 
            this.listboxXuong.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxXuong.Appearance.Options.UseFont = true;
            this.listboxXuong.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.listboxXuong.AppearanceSelected.Options.UseBackColor = true;
            this.listboxXuong.Location = new System.Drawing.Point(12, 12);
            this.listboxXuong.Name = "listboxXuong";
            this.listboxXuong.Size = new System.Drawing.Size(221, 229);
            this.listboxXuong.StyleController = this.layoutControl1;
            this.listboxXuong.TabIndex = 0;
            this.listboxXuong.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.ListboxXuong_DrawItem);
            this.listboxXuong.Click += new System.EventHandler(this.ListboxXuong_Click);
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(237, 12);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1258, 745);
            this.gcData.TabIndex = 13;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.ColumnPanelRowHeight = 30;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.col_MO});
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GvData_MouseDown);
            // 
            // col_ID
            // 
            this.col_ID.AppearanceCell.Options.UseTextOptions = true;
            this.col_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.col_ID.AppearanceHeader.Options.UseFont = true;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "IDChiPhi";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 0;
            this.col_ID.Width = 136;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 248;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
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
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Chi phí";
            this.gridColumn3.DisplayFormat.FormatString = "n0";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn3.FieldName = "ChiPhi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 291;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Đvt";
            this.gridColumn4.FieldName = "DVT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 101;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Tình trạng";
            this.gridColumn5.FieldName = "TinhTrang";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 147;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Số ngày công";
            this.gridColumn6.FieldName = "NgayCong";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 168;
            // 
            // col_MO
            // 
            this.col_MO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.col_MO.AppearanceHeader.Options.UseFont = true;
            this.col_MO.Caption = "MO";
            this.col_MO.FieldName = "MO";
            this.col_MO.Name = "col_MO";
            this.col_MO.Visible = true;
            this.col_MO.VisibleIndex = 6;
            // 
            // listboxChuyen
            // 
            this.listboxChuyen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxChuyen.Appearance.Options.UseFont = true;
            this.listboxChuyen.Location = new System.Drawing.Point(12, 245);
            this.listboxChuyen.Name = "listboxChuyen";
            this.listboxChuyen.Size = new System.Drawing.Size(221, 512);
            this.listboxChuyen.StyleController = this.layoutControl1;
            this.listboxChuyen.TabIndex = 7;
            this.listboxChuyen.Click += new System.EventHandler(this.ListboxChuyen_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1507, 769);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcData;
            this.layoutControlItem3.Location = new System.Drawing.Point(225, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1262, 749);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.listboxChuyen;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 233);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(225, 516);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listboxXuong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(225, 233);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.popupEdit,
            this.popupDelete,
            this.popupCompleteChiPhi,
            this.popupEditChiPhi,
            this.popupDeleteChiPhi});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemAlignment1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1507, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 850);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1507, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 850);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1507, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 850);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // popupEdit
            // 
            this.popupEdit.Caption = "Edit";
            this.popupEdit.Id = 3;
            this.popupEdit.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_edit_black_18dp;
            this.popupEdit.Name = "popupEdit";
            // 
            // popupDelete
            // 
            this.popupDelete.Caption = "Delete";
            this.popupDelete.Id = 4;
            this.popupDelete.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_delete_black_18dp1;
            this.popupDelete.Name = "popupDelete";
            // 
            // popupCompleteChiPhi
            // 
            this.popupCompleteChiPhi.Caption = "Complete";
            this.popupCompleteChiPhi.Id = 6;
            this.popupCompleteChiPhi.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_done_all_black_18dp;
            this.popupCompleteChiPhi.Name = "popupCompleteChiPhi";
            this.popupCompleteChiPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupCompleteChiPhi_ItemClick);
            // 
            // popupEditChiPhi
            // 
            this.popupEditChiPhi.Caption = "Edit";
            this.popupEditChiPhi.Id = 7;
            this.popupEditChiPhi.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_edit_black_18dp;
            this.popupEditChiPhi.Name = "popupEditChiPhi";
            this.popupEditChiPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupEditChiPhi_ItemClick);
            // 
            // popupDeleteChiPhi
            // 
            this.popupDeleteChiPhi.Caption = "Delete";
            this.popupDeleteChiPhi.Id = 8;
            this.popupDeleteChiPhi.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_delete_black_18dp1;
            this.popupDeleteChiPhi.Name = "popupDeleteChiPhi";
            this.popupDeleteChiPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupDeleteChiPhi_ItemClick);
            // 
            // repositoryItemAlignment1
            // 
            this.repositoryItemAlignment1.AutoHeight = false;
            this.repositoryItemAlignment1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAlignment1.HasArabic = false;
            this.repositoryItemAlignment1.HasDistribute = false;
            this.repositoryItemAlignment1.HasThaiDistribute = false;
            this.repositoryItemAlignment1.Name = "repositoryItemAlignment1";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.Location = new System.Drawing.Point(1412, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popupCompleteChiPhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupEditChiPhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupDeleteChiPhi)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // colNgayCong
            // 
            this.colNgayCong.Caption = "Số ngày công";
            this.colNgayCong.FieldName = "NgayCong";
            this.colNgayCong.Name = "colNgayCong";
            this.colNgayCong.Width = 168;
            // 
            // col_TinhTrang
            // 
            this.col_TinhTrang.Caption = "Tình trạng";
            this.col_TinhTrang.FieldName = "TinhTrang";
            this.col_TinhTrang.Name = "col_TinhTrang";
            this.col_TinhTrang.Width = 147;
            // 
            // col_DVT
            // 
            this.col_DVT.Caption = "Đvt";
            this.col_DVT.FieldName = "DVT";
            this.col_DVT.Name = "col_DVT";
            this.col_DVT.Width = 101;
            // 
            // col_ChiPhi
            // 
            this.col_ChiPhi.AppearanceCell.Options.UseTextOptions = true;
            this.col_ChiPhi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_ChiPhi.Caption = "Chi phí";
            this.col_ChiPhi.DisplayFormat.FormatString = "n0";
            this.col_ChiPhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_ChiPhi.FieldName = "ChiPhi";
            this.col_ChiPhi.Name = "col_ChiPhi";
            this.col_ChiPhi.Width = 291;
            // 
            // col_Ngay
            // 
            this.col_Ngay.Caption = "Ngày nhập";
            this.col_Ngay.DisplayFormat.FormatString = "MM/yyyy";
            this.col_Ngay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_Ngay.FieldName = "Ngay";
            this.col_Ngay.Name = "col_Ngay";
            this.col_Ngay.Width = 187;
            // 
            // col_Name
            // 
            this.col_Name.Caption = "Name";
            this.col_Name.FieldName = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.Width = 248;
            // 
            // frmChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1507, 850);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Phí";
            this.Load += new System.EventHandler(this.FrmChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listboxXuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem popupEdit;
        private DevExpress.XtraBars.BarButtonItem popupDelete;
        private DevExpress.XtraRichEdit.Design.RepositoryItemAlignment repositoryItemAlignment1;
        private DevExpress.XtraBars.BarButtonItem popupCompleteChiPhi;
        private DevExpress.XtraBars.BarButtonItem popupEditChiPhi;
        private DevExpress.XtraBars.BarButtonItem popupDeleteChiPhi;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.ListBoxControl listboxChuyen;
        private DevExpress.XtraEditors.ListBoxControl listboxXuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCong;
        private DevExpress.XtraGrid.Columns.GridColumn col_TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn col_DVT;
        private DevExpress.XtraGrid.Columns.GridColumn col_ChiPhi;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn col_Name;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col_MO;
    }
}