namespace QLDoanhThu.DoanhThu
{
    partial class frmDoanhThu
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
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
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
            this.popupComleteDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.popupEditDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.popupDeleteDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.popupEditHours = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemAlignment1 = new DevExpress.XtraRichEdit.Design.RepositoryItemAlignment();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listboxXuong = new DevExpress.XtraEditors.ListBoxControl();
            this.gcData = new DevExpress.XtraGrid.GridControl();
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
            this.listboxChuyen = new DevExpress.XtraEditors.ListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fac = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.Location = new System.Drawing.Point(1419, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
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
            this.popupDeleteStyle,
            this.popupComleteDoanhThu,
            this.popupEditDoanhThu,
            this.popupDeleteDoanhThu,
            this.barButtonItem3,
            this.barStaticItem1,
            this.popupEditHours});
            this.barManager1.MaxItemId = 21;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemAlignment1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1523, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 848);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1523, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 848);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1523, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 848);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.GroupIndex = 2;
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
            // 
            // popupEditStyle
            // 
            this.popupEditStyle.Caption = "Edit";
            this.popupEditStyle.Id = 13;
            this.popupEditStyle.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_edit_black_18dp;
            this.popupEditStyle.Name = "popupEditStyle";
            // 
            // popupDeleteStyle
            // 
            this.popupDeleteStyle.Caption = "Delete";
            this.popupDeleteStyle.Id = 14;
            this.popupDeleteStyle.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_delete_black_18dp1;
            this.popupDeleteStyle.Name = "popupDeleteStyle";
            // 
            // popupComleteDoanhThu
            // 
            this.popupComleteDoanhThu.Caption = "Completed";
            this.popupComleteDoanhThu.Id = 15;
            this.popupComleteDoanhThu.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_done_all_black_18dp;
            this.popupComleteDoanhThu.Name = "popupComleteDoanhThu";
            this.popupComleteDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupComleteDoanhThu_ItemClick);
            // 
            // popupEditDoanhThu
            // 
            this.popupEditDoanhThu.Caption = "Edit";
            this.popupEditDoanhThu.Id = 16;
            this.popupEditDoanhThu.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_edit_black_18dp;
            this.popupEditDoanhThu.Name = "popupEditDoanhThu";
            this.popupEditDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupEditDoanhThu_ItemClick);
            // 
            // popupDeleteDoanhThu
            // 
            this.popupDeleteDoanhThu.Caption = "Delete";
            this.popupDeleteDoanhThu.Id = 17;
            this.popupDeleteDoanhThu.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_delete_black_18dp1;
            this.popupDeleteDoanhThu.Name = "popupDeleteDoanhThu";
            this.popupDeleteDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PopupDeleteDoanhThu_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 18;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "----------------------";
            this.barStaticItem1.Id = 19;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // popupEditHours
            // 
            this.popupEditHours.Caption = "Edit Hours Profit";
            this.popupEditHours.Id = 20;
            this.popupEditHours.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.icons8_edit_link_24;
            this.popupEditHours.Name = "popupEditHours";
            this.popupEditHours.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.popupEditHours_ItemClick);
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
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.layoutControl1.Controls.Add(this.listboxXuong);
            this.layoutControl1.Controls.Add(this.gcData);
            this.layoutControl1.Controls.Add(this.listboxChuyen);
            this.layoutControl1.Location = new System.Drawing.Point(-7, 51);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1518, 799);
            this.layoutControl1.TabIndex = 27;
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
            this.listboxXuong.Size = new System.Drawing.Size(223, 238);
            this.listboxXuong.StyleController = this.layoutControl1;
            this.listboxXuong.TabIndex = 0;
            this.listboxXuong.SelectedIndexChanged += new System.EventHandler(this.ListboxXuong_SelectedIndexChanged);
            this.listboxXuong.Click += new System.EventHandler(this.ListboxXuong_Click);
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(239, 12);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1267, 775);
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
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GvData_MouseDown);
            // 
            // col_ID
            // 
            this.col_ID.AppearanceCell.Options.UseTextOptions = true;
            this.col_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ID.AppearanceHeader.Options.UseFont = true;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 0;
            this.col_ID.Width = 66;
            // 
            // colNgay
            // 
            this.colNgay.AppearanceCell.Options.UseTextOptions = true;
            this.colNgay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNgay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colNgay.AppearanceHeader.Options.UseFont = true;
            this.colNgay.Caption = "Doanh thu ngày";
            this.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 169;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colDoanhThu.AppearanceHeader.Options.UseFont = true;
            this.colDoanhThu.Caption = "Doanh thu";
            this.colDoanhThu.DisplayFormat.FormatString = "c2";
            this.colDoanhThu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDoanhThu.FieldName = "DoanhThu";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.Visible = true;
            this.colDoanhThu.VisibleIndex = 7;
            this.colDoanhThu.Width = 158;
            // 
            // colChiPhi
            // 
            this.colChiPhi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colChiPhi.AppearanceHeader.Options.UseFont = true;
            this.colChiPhi.Caption = "Chi phí";
            this.colChiPhi.FieldName = "NameChiPhi";
            this.colChiPhi.Name = "colChiPhi";
            this.colChiPhi.Visible = true;
            this.colChiPhi.VisibleIndex = 8;
            this.colChiPhi.Width = 158;
            // 
            // colLine
            // 
            this.colLine.AppearanceCell.Options.UseTextOptions = true;
            this.colLine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colLine.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colLine.AppearanceHeader.Options.UseFont = true;
            this.colLine.Caption = "Chuyền";
            this.colLine.FieldName = "NameLine";
            this.colLine.Name = "colLine";
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 2;
            this.colLine.Width = 99;
            // 
            // colStyle
            // 
            this.colStyle.AppearanceCell.Options.UseTextOptions = true;
            this.colStyle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colStyle.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colStyle.AppearanceHeader.Options.UseFont = true;
            this.colStyle.Caption = "Mã hàng";
            this.colStyle.FieldName = "NameStyle";
            this.colStyle.Name = "colStyle";
            this.colStyle.Visible = true;
            this.colStyle.VisibleIndex = 3;
            this.colStyle.Width = 123;
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
            this.colSoLuong.VisibleIndex = 5;
            this.colSoLuong.Width = 122;
            // 
            // colDVT
            // 
            this.colDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colDVT.AppearanceHeader.Options.UseFont = true;
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 6;
            this.colDVT.Width = 109;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colTinhTrang.AppearanceHeader.Options.UseFont = true;
            this.colTinhTrang.Caption = "Tình trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 9;
            this.colTinhTrang.Width = 119;
            // 
            // colMucTieu
            // 
            this.colMucTieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colMucTieu.AppearanceHeader.Options.UseFont = true;
            this.colMucTieu.Caption = "Mục Tiêu";
            this.colMucTieu.FieldName = "MucTieu";
            this.colMucTieu.Name = "colMucTieu";
            this.colMucTieu.Visible = true;
            this.colMucTieu.VisibleIndex = 4;
            this.colMucTieu.Width = 133;
            // 
            // listboxChuyen
            // 
            this.listboxChuyen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxChuyen.Appearance.Options.UseFont = true;
            this.listboxChuyen.Location = new System.Drawing.Point(12, 254);
            this.listboxChuyen.Name = "listboxChuyen";
            this.listboxChuyen.Size = new System.Drawing.Size(223, 533);
            this.listboxChuyen.StyleController = this.layoutControl1;
            this.listboxChuyen.TabIndex = 7;
            this.listboxChuyen.SelectedIndexChanged += new System.EventHandler(this.ListboxChuyen_SelectedIndexChanged);
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
            this.Root.Size = new System.Drawing.Size(1518, 799);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcData;
            this.layoutControlItem3.Location = new System.Drawing.Point(227, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1271, 779);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.listboxChuyen;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 242);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 537);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listboxXuong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(227, 242);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Doanh thu :";
            // 
            // lbl_fac
            // 
            this.lbl_fac.AutoSize = true;
            this.lbl_fac.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_fac.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fac.Location = new System.Drawing.Point(123, 29);
            this.lbl_fac.Name = "lbl_fac";
            this.lbl_fac.Size = new System.Drawing.Size(41, 17);
            this.lbl_fac.TabIndex = 33;
            this.lbl_fac.Text = "label2";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Cyan;
            this.lblLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(191, 29);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(41, 17);
            this.lblLine.TabIndex = 34;
            this.lblLine.Text = "label3";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popupComleteDoanhThu),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupEditDoanhThu),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupDeleteDoanhThu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupEditHours)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1523, 848);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lbl_fac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.FrmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnThem;
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
        private DevExpress.XtraBars.BarButtonItem popupCompleteStyle;
        private DevExpress.XtraBars.BarButtonItem popupEditStyle;
        private DevExpress.XtraBars.BarButtonItem popupDeleteStyle;
        private DevExpress.XtraRichEdit.Design.RepositoryItemAlignment repositoryItemAlignment1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ListBoxControl listboxXuong;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraEditors.ListBoxControl listboxChuyen;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lbl_fac;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraBars.BarButtonItem popupComleteDoanhThu;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem popupEditDoanhThu;
        private DevExpress.XtraBars.BarButtonItem popupDeleteDoanhThu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem popupEditHours;
        private DevExpress.XtraGrid.Columns.GridColumn colMucTieu;
    }
}