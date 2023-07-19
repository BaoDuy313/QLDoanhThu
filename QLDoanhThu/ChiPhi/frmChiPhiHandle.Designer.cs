namespace QLDoanhThu.ChiPhi
{
    partial class frmChiPhiHandle
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChiPhi = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVND = new System.Windows.Forms.RadioButton();
            this.rdoUSD = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayCong = new DevExpress.XtraEditors.TextEdit();
            this.txtMO = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiPhi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.FloatLocation = new System.Drawing.Point(331, 511);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 0;
            this.btnSave.ImageOptions.Image = global::QLDoanhThu.Properties.Resources.baseline_save_black_18dp;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(532, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(532, 44);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(532, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 102);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Properties.MaxLength = 50;
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 43);
            this.txtID.MenuManager = this.barManager1;
            this.txtID.Name = "txtID";
            this.txtID.Properties.MaxLength = 10;
            this.txtID.Size = new System.Drawing.Size(211, 20);
            this.txtID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Line";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.EditValue = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(177, 170);
            this.dateNgayNhap.MenuManager = this.barManager1;
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateNgayNhap.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateNgayNhap.Properties.Mask.EditMask = "";
            this.dateNgayNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateNgayNhap.Properties.NullText = "[EditValue is null]";
            this.dateNgayNhap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateNgayNhap.Size = new System.Drawing.Size(211, 20);
            this.dateNgayNhap.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chi phí";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(177, 238);
            this.txtChiPhi.MenuManager = this.barManager1;
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Properties.DisplayFormat.FormatString = "n0";
            this.txtChiPhi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtChiPhi.Properties.EditFormat.FormatString = "n0";
            this.txtChiPhi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtChiPhi.Properties.Mask.EditMask = "n0";
            this.txtChiPhi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtChiPhi.Properties.MaxLength = 20;
            this.txtChiPhi.Size = new System.Drawing.Size(211, 20);
            this.txtChiPhi.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "ĐVT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVND);
            this.groupBox1.Controls.Add(this.rdoUSD);
            this.groupBox1.Location = new System.Drawing.Point(177, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 57);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn vị tính";
            // 
            // rdoVND
            // 
            this.rdoVND.AutoSize = true;
            this.rdoVND.Location = new System.Drawing.Point(123, 24);
            this.rdoVND.Name = "rdoVND";
            this.rdoVND.Size = new System.Drawing.Size(48, 17);
            this.rdoVND.TabIndex = 1;
            this.rdoVND.Text = "VNĐ";
            this.rdoVND.UseVisualStyleBackColor = true;
            // 
            // rdoUSD
            // 
            this.rdoUSD.AutoSize = true;
            this.rdoUSD.Checked = true;
            this.rdoUSD.Location = new System.Drawing.Point(31, 24);
            this.rdoUSD.Name = "rdoUSD";
            this.rdoUSD.Size = new System.Drawing.Size(48, 17);
            this.rdoUSD.TabIndex = 0;
            this.rdoUSD.TabStop = true;
            this.rdoUSD.Text = "USD";
            this.rdoUSD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Số ngày công";
            // 
            // txtNgayCong
            // 
            this.txtNgayCong.Location = new System.Drawing.Point(177, 292);
            this.txtNgayCong.MenuManager = this.barManager1;
            this.txtNgayCong.Name = "txtNgayCong";
            this.txtNgayCong.Properties.DisplayFormat.FormatString = "n0";
            this.txtNgayCong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtNgayCong.Properties.EditFormat.FormatString = "n0";
            this.txtNgayCong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtNgayCong.Properties.Mask.EditMask = "n0";
            this.txtNgayCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNgayCong.Properties.MaxLength = 20;
            this.txtNgayCong.Size = new System.Drawing.Size(211, 20);
            this.txtNgayCong.TabIndex = 38;
            // 
            // txtMO
            // 
            this.txtMO.EditValue = "0.00";
            this.txtMO.Location = new System.Drawing.Point(177, 343);
            this.txtMO.MenuManager = this.barManager1;
            this.txtMO.Name = "txtMO";
            this.txtMO.Properties.DisplayFormat.FormatString = "n2";
            this.txtMO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtMO.Properties.EditFormat.FormatString = "n2";
            this.txtMO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtMO.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMO.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMO.Properties.MaskSettings.Set("mask", "n");
            this.txtMO.Properties.MaxLength = 20;
            this.txtMO.Size = new System.Drawing.Size(211, 20);
            this.txtMO.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "MO";
            // 
            // frmChiPhiHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 539);
            this.Controls.Add(this.txtMO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayCong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChiPhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNgayNhap);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChiPhiHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi phí";
            this.Load += new System.EventHandler(this.FrmChiPhiHandle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiPhi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMO.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtChiPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateNgayNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVND;
        private System.Windows.Forms.RadioButton rdoUSD;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtNgayCong;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtMO;
        private System.Windows.Forms.Label label7;
    }
}