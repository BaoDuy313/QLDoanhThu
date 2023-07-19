namespace QLDoanhThu.Style
{
    partial class frmStyle
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
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IDStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLine = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.popupCompleteStyle = new DevExpress.XtraBars.BarButtonItem();
            this.popupEditStyle = new DevExpress.XtraBars.BarButtonItem();
            this.popupDeleteStyle = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemAlignment1 = new DevExpress.XtraRichEdit.Design.RepositoryItemAlignment();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listboxChuyen = new DevExpress.XtraEditors.ListBoxControl();
            this.listboxXuong = new DevExpress.XtraEditors.ListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listboxChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxXuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(224, 12);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1079, 714);
            this.gcData.TabIndex = 10;
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
            this.col_IDStyle,
            this.colSoLuong,
            this.colDonGia,
            this.colNgay,
            this.colTinhTrang,
            this.colIDLine});
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GvData_MouseDown);
            // 
            // col_IDStyle
            // 
            this.col_IDStyle.AppearanceCell.Options.UseTextOptions = true;
            this.col_IDStyle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_IDStyle.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_IDStyle.AppearanceHeader.Options.UseFont = true;
            this.col_IDStyle.Caption = "ID Style";
            this.col_IDStyle.FieldName = "ID";
            this.col_IDStyle.Name = "col_IDStyle";
            this.col_IDStyle.Visible = true;
            this.col_IDStyle.VisibleIndex = 0;
            this.col_IDStyle.Width = 215;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.DisplayFormat.FormatString = "n0";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            this.colSoLuong.Width = 194;
            // 
            // colDonGia
            // 
            this.colDonGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colDonGia.AppearanceHeader.Options.UseFont = true;
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "n2";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 2;
            this.colDonGia.Width = 194;
            // 
            // colNgay
            // 
            this.colNgay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colNgay.AppearanceHeader.Options.UseFont = true;
            this.colNgay.Caption = "Ngày lên chuyền";
            this.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 3;
            this.colNgay.Width = 205;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colTinhTrang.AppearanceHeader.Options.UseFont = true;
            this.colTinhTrang.Caption = "Tình trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 4;
            this.colTinhTrang.Width = 146;
            // 
            // colIDLine
            // 
            this.colIDLine.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colIDLine.AppearanceHeader.Options.UseFont = true;
            this.colIDLine.Caption = "ID Line";
            this.colIDLine.FieldName = "IDLine";
            this.colIDLine.Name = "colIDLine";
            this.colIDLine.Visible = true;
            this.colIDLine.VisibleIndex = 5;
            this.colIDLine.Width = 107;
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
            this.popupDeleteChiPhi,
            this.popupCompleteStyle,
            this.popupEditStyle,
            this.popupDeleteStyle});
            this.barManager1.MaxItemId = 15;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemAlignment1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1320, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 785);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1320, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 785);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1320, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 785);
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
            // 
            // popupEditChiPhi
            // 
            this.popupEditChiPhi.Caption = "Edit";
            this.popupEditChiPhi.Id = 7;
            this.popupEditChiPhi.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_edit_black_18dp;
            this.popupEditChiPhi.Name = "popupEditChiPhi";
            // 
            // popupDeleteChiPhi
            // 
            this.popupDeleteChiPhi.Caption = "Delete";
            this.popupDeleteChiPhi.Id = 8;
            this.popupDeleteChiPhi.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_delete_black_18dp1;
            this.popupDeleteChiPhi.Name = "popupDeleteChiPhi";
            // 
            // popupCompleteStyle
            // 
            this.popupCompleteStyle.Caption = "Complete";
            this.popupCompleteStyle.Id = 12;
            this.popupCompleteStyle.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_done_all_black_18dp;
            this.popupCompleteStyle.Name = "popupCompleteStyle";
            this.popupCompleteStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupCompleteStyle_ItemClick);
            // 
            // popupEditStyle
            // 
            this.popupEditStyle.Caption = "Edit";
            this.popupEditStyle.Id = 13;
            this.popupEditStyle.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_edit_black_18dp;
            this.popupEditStyle.Name = "popupEditStyle";
            this.popupEditStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupEditStyle_ItemClick);
            // 
            // popupDeleteStyle
            // 
            this.popupDeleteStyle.Caption = "Delete";
            this.popupDeleteStyle.Id = 14;
            this.popupDeleteStyle.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_delete_black_18dp1;
            this.popupDeleteStyle.Name = "popupDeleteStyle";
            this.popupDeleteStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupDeleteStyle_ItemClick);
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
            this.btnThem.Location = new System.Drawing.Point(1233, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.listboxChuyen);
            this.layoutControl1.Controls.Add(this.listboxXuong);
            this.layoutControl1.Controls.Add(this.gcData);
            this.layoutControl1.Location = new System.Drawing.Point(3, 54);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1315, 738);
            this.layoutControl1.TabIndex = 20;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // listboxChuyen
            // 
            this.listboxChuyen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxChuyen.Appearance.Options.UseFont = true;
            this.listboxChuyen.Location = new System.Drawing.Point(12, 201);
            this.listboxChuyen.Name = "listboxChuyen";
            this.listboxChuyen.Size = new System.Drawing.Size(208, 525);
            this.listboxChuyen.StyleController = this.layoutControl1;
            this.listboxChuyen.TabIndex = 22;
            this.listboxChuyen.Click += new System.EventHandler(this.ListboxChuyen_Click);
            // 
            // listboxXuong
            // 
            this.listboxXuong.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxXuong.Appearance.Options.UseFont = true;
            this.listboxXuong.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.listboxXuong.AppearanceSelected.Options.UseBackColor = true;
            this.listboxXuong.Location = new System.Drawing.Point(12, 12);
            this.listboxXuong.Name = "listboxXuong";
            this.listboxXuong.Size = new System.Drawing.Size(208, 185);
            this.listboxXuong.StyleController = this.layoutControl1;
            this.listboxXuong.TabIndex = 21;
            this.listboxXuong.Click += new System.EventHandler(this.ListboxXuong_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1315, 738);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listboxXuong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(212, 189);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcData;
            this.layoutControlItem2.Location = new System.Drawing.Point(212, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1083, 718);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.listboxChuyen;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(212, 529);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(227, 28);
            this.txtSearch.MenuManager = this.barManager1;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 20);
            this.txtSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSearch.Location = new System.Drawing.Point(439, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popupCompleteStyle),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupEditStyle),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupDeleteStyle)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 785);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStyle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Style";
            this.Load += new System.EventHandler(this.FrmStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listboxChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxXuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn col_IDStyle;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem popupEdit;
        private DevExpress.XtraBars.BarButtonItem popupDelete;
        private DevExpress.XtraBars.BarButtonItem popupCompleteChiPhi;
        private DevExpress.XtraBars.BarButtonItem popupEditChiPhi;
        private DevExpress.XtraBars.BarButtonItem popupDeleteChiPhi;
        private DevExpress.XtraRichEdit.Design.RepositoryItemAlignment repositoryItemAlignment1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLine;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.ListBoxControl listboxChuyen;
        private DevExpress.XtraEditors.ListBoxControl listboxXuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarButtonItem popupCompleteStyle;
        private DevExpress.XtraBars.BarButtonItem popupEditStyle;
        private DevExpress.XtraBars.BarButtonItem popupDeleteStyle;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}