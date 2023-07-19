using BUS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDoanhThu.Report
{
    public partial class frmBaoCao : Form
    {
        private BaoCaoBUS b;
        private BaoCaoBUS x;
        public int i1;
        public int i2;
        public int i3;
        public int i4;
        public int i5;
        public int i6;
        public int i7;
        public int i8;

        private readonly TimeSpan _dl1 = TimeSpan.Parse("7:30:00");
        private readonly TimeSpan _cl1 = TimeSpan.Parse("8:30:00");

        private readonly TimeSpan _dl2 = TimeSpan.Parse("8:31:00");
        private readonly TimeSpan _cl2 = TimeSpan.Parse("9:30:00");

        private readonly TimeSpan _dl3 = TimeSpan.Parse("9:31:00");
        private readonly TimeSpan _cl3 = TimeSpan.Parse("10:30:00");

        private readonly TimeSpan _dl4 = TimeSpan.Parse("10:31:00");
        private readonly TimeSpan _cl4 = TimeSpan.Parse("11:30:00");

        private readonly TimeSpan _dl5 = TimeSpan.Parse("12:30:00");
        private readonly TimeSpan _cl5 = TimeSpan.Parse("13:30:00");

        private readonly TimeSpan _dl6 = TimeSpan.Parse("13:31:00");
        private readonly TimeSpan _cl6 = TimeSpan.Parse("14:30:00");

        private readonly TimeSpan _dl7 = TimeSpan.Parse("14:31:00");
        private readonly TimeSpan _cl7 = TimeSpan.Parse("15:30:00");

        private readonly TimeSpan _dl8 = TimeSpan.Parse("15:31:00");
        private readonly TimeSpan _cl8 = TimeSpan.Parse("16:30:00");

        private readonly TimeSpan _dlOvertime = TimeSpan.Parse("16:31:00");
        public frmBaoCao()
        {
            InitializeComponent();
            {
                b = new BaoCaoBUS();
                x = new BaoCaoBUS();
            }
        }
        private void listboxXuong_Click(object sender, EventArgs e)
        {
            HienThiBaocao();
        }
        public void HienThiBaocao()
        {
            try
            {
                i1 = 0;
                i2 = 0;
                i3 = 0;
                i4 = 0;
                i5 = 0;
                i6 = 0;
                i7 = 0;
                i8 = 0;

                string idfac = listboxXuong.SelectedValue.ToString();
                DateTime time = dateTimePicker1.Value.Date;
                gcData.DataSource = b.LayThongTinHienThi(idfac, time);
                lbFac.Text = "Factory " + idfac.Replace("FAC", string.Empty);


                if (b.LayThongTinHienThi(idfac, time).Count() > 0)
                {
                    int count = 0;
                    decimal tong = 0;
                    foreach (var item in b.LayThongTinHienThi(idfac, time))
                    {
                        if (item.MO != null)
                        {
                            tong += (decimal)item.MO;
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        gvData.Columns.ColumnByFieldName("NameLine").Caption = "MO: " + (tong / count).ToString("C2");
                    }
                    else
                    {
                        gvData.Columns.ColumnByFieldName("NameLine").Caption = "MO:";
                    }

                }
                else
                {
                    gvData.Columns.ColumnByFieldName("NameLine").Caption = "MO:";
                }
            }
            catch
            {

            }
        }
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                
                dateTimePicker1.MaxDate = DateTime.Now;

                listboxXuong.DataSource = x.GetDataXuong();
                listboxXuong.DisplayMember = "Name";
                listboxXuong.ValueMember = "IDFac";

                gvData.Columns.ColumnByFieldName("MucTieuNgay").Visible = false;
                gvData.Columns.ColumnByFieldName("MO").Visible = false;
                gvData.Columns.ColumnByFieldName("GioBD").Visible = false;
                gvData.Columns.ColumnByFieldName("MucTieu").Visible = false;
                gvData.Columns.ColumnByFieldName("NameLine").Caption = "MO:";
                gvData.OptionsView.ShowGroupPanel = false;
                gvData.OptionsSelection.EnableAppearanceFocusedRow = false;
            }
            catch
            {

            }
        }
        public string MucTieuNgay(int row, string DTL, string soluong)
        {
            TimeSpan GioBD;
            try
            {
                 GioBD = (TimeSpan)gvData.GetRowCellValue(row, col_GioBD);
            }
            catch 
            {
                GioBD = TimeSpan.Parse("7:30:00");
            }
            string mtGio = "";
            try
            {
                mtGio = gvData.GetRowCellValue(row, col_MucTieuNgay).ToString();
            }
            catch
            {

            }
            string kq;

            if (DTL == "DTL1" && GioBD >= _cl1)
            {
                mtGio = "X";

            }
            if (DTL == "DTL2" && GioBD >= _cl2)
            {
                mtGio = "X";

            }
            if (DTL == "DTL3" && GioBD >= _cl3)
            {
                mtGio = "X";

            }
            if (DTL == "DTL4" && GioBD >= _cl4)
            {
                mtGio = "X";

            }
            if (DTL == "DTL5" && GioBD >= _cl5)
            {
                mtGio = "X";

            }
            if (DTL == "DTL6" && GioBD >= _cl6)
            {
                mtGio = "X";

            }
            if (DTL == "DTL7" && GioBD >= _cl7)
            {
                mtGio = "X";

            }
            if (DTL == "DTL8" && GioBD >= _cl8)
            {
                mtGio = "X";

            }

            if (mtGio == "X")
            {
                kq = mtGio;
            }
            else
            {
                kq = soluong + "/" + mtGio;
            }

            return kq;
        }
        private void gvData_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                string idfac = listboxXuong.SelectedValue.ToString();
                string soluong = ((int)(e.Value)).ToString();
                DateTime time = dateTimePicker1.Value.Date;
                int count = b.LayThongTinHienThi(idfac, time).Count();
                if (count > 0)
                {


                    if (e.Column.FieldName == "DTL1" && i1 < count)
                    {

                        e.DisplayText = MucTieuNgay(i1, "DTL1", soluong);
                        i1 += 1;
                    }

                    if (e.Column.FieldName == "DTL2" && i2 < count)
                    {

                        e.DisplayText = MucTieuNgay(i2, "DTL2", soluong);
                        i2 += 1;
                    }

                    if (e.Column.FieldName == "DTL3" && i3 < count)
                    {
                        e.DisplayText = MucTieuNgay(i3, "DTL3", soluong);
                        i3 += 1;
                    }

                    if (e.Column.FieldName == "DTL4" && i4 < count)
                    {
                        e.DisplayText = MucTieuNgay(i4, "DTL4", soluong);
                        i4 += 1;
                    }

                    if (e.Column.FieldName == "DTL5" && i5 < count)
                    {
                        e.DisplayText = MucTieuNgay(i5, "DTL5", soluong);
                        i5 += 1;
                    }

                    if (e.Column.FieldName == "DTL6" && i6 < count)
                    {
                        e.DisplayText = MucTieuNgay(i6, "DTL6", soluong);
                        i6 += 1;
                    }

                    if (e.Column.FieldName == "DTL7" && i7 < count)
                    {
                        e.DisplayText = MucTieuNgay(i7, "DTL7", soluong);
                        i7 += 1;
                    }

                    if (e.Column.FieldName == "DTL8" && i8 < count)
                    {
                        e.DisplayText = MucTieuNgay(i8, "DTL8", soluong);
                        i8 += 1;
                    }
                }
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                HienThiBaocao();
            }
            catch
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiBaocao();
                timer1.Start();
            }
            catch
            {

            }
        }
    }
}
