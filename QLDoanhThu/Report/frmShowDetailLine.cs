using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoanhThu.Report
{
    public partial class frmShowDetailLine : Form
    {
        private XuongBUS x;
        private HienThiChuyenBUS c;

        private HienThiChuyenBUS h;
        private DoanhThuCustomBUS getData;

        private HienThiChuyen _dataHienThi;

        private int _idChiPhi;
        private decimal _mucTieuNgay;
        private int _mucTieuGio;

        private int _tongDoanhThu;
        private int _idCtdt;

        private int mucTieu;
        private int idCTDT;

        private TimeSpan GioBD;
        private int soGioLamViec;

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
        // private readonly TimeSpan _cl9 = TimeSpan.Parse("17:30:00");

        public frmShowDetailLine()
        {
            InitializeComponent();
            x = new XuongBUS();
            c = new HienThiChuyenBUS();
            h = new HienThiChuyenBUS();
        }

        private void frmShowDetail_Load(object sender, EventArgs e)
        {
            try
            {
                HienThiThongTin();
            }
            catch
            {

            }
            timer1.Start();
            timer2.Start();
            lbGio.Text = DateTime.Now.ToLongTimeString();
            lbNgay.Text = $@"{DateTime.Now:dd/MM/yyyy}";
            listboxXuong.DataSource = x.GetDataXuong();
            listboxXuong.DisplayMember = "Name";
            listboxXuong.ValueMember = "IDFac";
        }

        private void listboxXuong_Click(object sender, EventArgs e)
        {
            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = c.GetDataChuyenTheoMaCheck(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";
        }

        private void listboxChuyen_Click(object sender, EventArgs e)
        {
            string idline = listboxChuyen.SelectedValue.ToString();
            lbLine.Text = idline;
            getData = h.GetDataDoanhThu(idline);
            if (getData != null)
            {
                try
                {
                    this._idChiPhi = (int)getData.IDChiPhi;
                    this.idCTDT = getData.ID;
                    this.mucTieu = (int)getData.MucTieu;
                    HienThiThongTin();
                }
                catch
                {

                }
            }
            else
            {
                lbTarget.Text = lbTarget1.Text = lbTarget2.Text = lbTarget3.Text = lbTarget4.Text = lbTarget5.Text = lbTarget6.Text = lbTarget7.Text = lbTarget8.Text = "0";
                lbDT1.Text = lbDT2.Text = lbDT3.Text = lbDT4.Text = lbDT5.Text = lbDT6.Text = lbDT7.Text = lbDT8.Text = lbDTOverTime.Text = "";
                lbActual.Text = lbProfit.Text = lbSoLuongTong.Text = "";
                lbPhanTram.Text = "" + "%";
                lbMO.Text = "$00.00 (1 CÔNG NHÂN = $00.00 / 8H)";
            }
        }
        private void HienThiThongTin()
        {
            _dataHienThi = h.LayThongTinHienThi(_idChiPhi, idCTDT);
            lbLine.Text = _dataHienThi.NameLine;
            lbStyle.Text = _dataHienThi.Style;

            _idCtdt = _dataHienThi.ID;

            // _mucTieuNgay = _dataHienThi.DayTarget > _dataHienThi.MucTieuTrungBinhNgay ? _dataHienThi.DayTarget : _dataHienThi.MucTieuTrungBinhNgay;
            _mucTieuNgay = _dataHienThi.MucTieuTrungBinhNgay;
            // if (Math.Ceiling(_mucTieuNgay) % 8 == 0)

            //Lấy giờ bắt đầu
            GioBD = (TimeSpan)_dataHienThi.GioBD;
            GioBD = (TimeSpan)_dataHienThi.GioBD;
            if (GioBD < _dl5)
            {
                soGioLamViec = (_cl8 - GioBD).Hours - 1;
            }
            else
            {
                soGioLamViec = (_cl8 - GioBD).Hours;
            }
            //End Lấy giờ bắt đầu

            if (mucTieu % soGioLamViec == 0)
            {
                // _mucTieuGio = (int)(Math.Ceiling(_mucTieuNgay) / 8);
                _mucTieuGio = mucTieu / soGioLamViec;
                if (GioBD >= _cl1)
                {
                    lbTarget1.Text = "X";
                    lbTarget1.BackColor = Color.Red;
                    lbDT1.Visible = false;

                }
                else
                {
                    lbTarget1.Text = _mucTieuGio.ToString();
                    lbDT1.Visible = true;

                }

                if (GioBD >= _cl2)
                {
                    lbTarget2.Text = "X";
                    lbTarget2.BackColor = Color.Red;
                    lbDT2.Visible = false;

                }
                else
                {
                    lbTarget2.Text = _mucTieuGio.ToString();
                    lbDT2.Visible = true;

                }
                if (GioBD >= _cl3)
                {
                    lbTarget3.Text = "X";
                    lbTarget3.BackColor = Color.Red;
                    lbDT3.Visible = false;
                }
                else
                {
                    lbTarget3.Text = _mucTieuGio.ToString();
                    lbDT3.Visible = true;
                }

                if (GioBD >= _cl4)
                {
                    lbTarget4.Text = "X";
                    lbTarget4.BackColor = Color.Red;
                    lbDT4.Visible = false;
                }
                else
                {
                    lbTarget4.Text = _mucTieuGio.ToString();
                    lbDT4.Visible = true;
                }

                if (GioBD >= _cl5)
                {
                    lbTarget5.Text = "X";
                    lbTarget5.BackColor = Color.Red;
                    lbDT5.Visible = false;
                }
                else
                {
                    lbTarget5.Text = _mucTieuGio.ToString();
                    lbDT5.Visible = true;
                }

                if (GioBD >= _cl6)
                {
                    lbTarget6.Text = "X";
                    lbTarget6.BackColor = Color.Red;
                    lbDT6.Visible = false;
                }
                else
                {
                    lbTarget6.Text = _mucTieuGio.ToString();
                    lbDT6.Visible = true;
                }
                if (GioBD >= _cl7)
                {
                    lbTarget7.Text = "X";
                    lbTarget7.BackColor = Color.Red;
                    lbDT7.Visible = false;
                }
                else
                {
                    lbTarget7.Text = _mucTieuGio.ToString();
                    lbDT7.Visible = true;
                }

                if (GioBD >= _cl8)
                {
                    lbTarget8.Text = "X";
                    lbTarget8.BackColor = Color.Red;
                    lbDT8.Visible = false;
                }
                else
                {
                    lbTarget8.Text = _mucTieuGio.ToString();
                    lbDT8.Visible = true;
                }
                /*lbTarget1.Text = _mucTieuGio.ToString();
                lbTarget2.Text = _mucTieuGio.ToString();
                lbTarget3.Text = _mucTieuGio.ToString();
                lbTarget4.Text = _mucTieuGio.ToString();
                lbTarget5.Text = _mucTieuGio.ToString();
                lbTarget6.Text = _mucTieuGio.ToString();
                lbTarget7.Text = _mucTieuGio.ToString();
                lbTarget8.Text = _mucTieuGio.ToString();*/
                // lbTarget9.Text = _mucTieuGio.ToString();
            }
            else
            {
                _mucTieuGio = (mucTieu / soGioLamViec) + 1;
                if (GioBD >= _cl1)
                {
                    lbTarget1.Text = "X";
                    lbTarget1.BackColor = Color.Red;
                    lbDT1.Visible = false;
                }
                else
                {
                    lbTarget1.Text = _mucTieuGio.ToString();
                    lbDT1.Visible = true;
                }

                if (GioBD >= _cl2)
                {
                    lbTarget2.Text = "X";
                    lbTarget2.BackColor = Color.Red;
                    lbDT2.Visible = false;
                }
                else
                {
                    lbTarget2.Text = _mucTieuGio.ToString();
                    lbDT2.Visible = true;
                }
                if (GioBD >= _cl3)
                {
                    lbTarget3.Text = "X";
                    lbTarget3.BackColor = Color.Red;
                    lbDT3.Visible = false;
                }
                else
                {
                    lbTarget3.Text = _mucTieuGio.ToString();
                    lbDT3.Visible = true;
                }

                if (GioBD >= _cl4)
                {
                    lbTarget4.Text = "X";
                    lbTarget4.BackColor = Color.Red;
                    lbDT4.Visible = false;
                }
                else
                {
                    lbTarget4.Text = _mucTieuGio.ToString();
                    lbDT4.Visible = true;
                }

                if (GioBD >= _cl5)
                {
                    lbTarget5.Text = "X";
                    lbTarget5.BackColor = Color.Red;
                    lbDT5.Visible = false;
                }
                else
                {
                    lbTarget5.Text = _mucTieuGio.ToString();
                    lbDT5.Visible = true;
                }

                if (GioBD >= _cl6)
                {
                    lbTarget6.Text = "X";
                    lbTarget6.BackColor = Color.Red;
                    lbDT6.Visible = false;
                }
                else
                {
                    lbTarget6.Text = _mucTieuGio.ToString();
                    lbDT6.Visible = true;
                }
                if (GioBD >= _cl7)
                {
                    lbTarget7.Text = "X";
                    lbTarget7.BackColor = Color.Red;
                    lbDT7.Visible = false;
                }
                else
                {
                    lbTarget7.Text = _mucTieuGio.ToString();
                    lbDT7.Visible = true;
                }

                if (GioBD >= _cl8)
                {
                    lbTarget8.Text = "X";
                    lbTarget8.BackColor = Color.Red;
                    lbDT8.Visible = false;
                }
                else
                {
                    lbTarget8.Text = _mucTieuGio.ToString();
                    lbDT8.Visible = true;
                }
                /*_mucTieuGio = (int)(Math.Ceiling((decimal) (mucTieu/8))) + 1;
                lbTarget1.Text = _mucTieuGio.ToString();
                lbTarget2.Text = _mucTieuGio.ToString();
                lbTarget3.Text = _mucTieuGio.ToString();
                lbTarget4.Text = _mucTieuGio.ToString();
                lbTarget5.Text = _mucTieuGio.ToString();
                lbTarget6.Text = _mucTieuGio.ToString();
                lbTarget7.Text = _mucTieuGio.ToString();
                lbTarget8.Text = _mucTieuGio.ToString();*/
                // lbTarget9.Text = _mucTieuGio.ToString();
            }


            lbDT1.Text = _dataHienThi.DTL1 == null ? "" : _dataHienThi.DTL1.ToString();
            lbDT2.Text = _dataHienThi.DTL2 == null ? "" : _dataHienThi.DTL2.ToString();
            lbDT3.Text = _dataHienThi.DTL3 == null ? "" : _dataHienThi.DTL3.ToString();
            lbDT4.Text = _dataHienThi.DTL4 == null ? "" : _dataHienThi.DTL4.ToString();
            lbDT5.Text = _dataHienThi.DTL5 == null ? "" : _dataHienThi.DTL5.ToString();
            lbDT6.Text = _dataHienThi.DTL6 == null ? "" : _dataHienThi.DTL6.ToString();
            lbDT7.Text = _dataHienThi.DTL7 == null ? "" : _dataHienThi.DTL7.ToString();
            lbDT8.Text = _dataHienThi.DTL8 == null ? "" : _dataHienThi.DTL8.ToString();

            lbDTOverTime.Text = _dataHienThi.DTOverTime == null ? "" : _dataHienThi.DTOverTime.ToString();

            HienThiPhanTram();


            lbTarget.Text = $@"{_mucTieuNgay * _dataHienThi.Dongia:c0}";



            lbActual.Text = String.Format("{0:c1}", _tongDoanhThu * _dataHienThi.Dongia);


            lbProfit.Text = String.Format("{0:c1}", decimal.Parse(lbActual.Text.Replace("$", "")) - decimal.Parse(lbTarget.Text.Replace("$", "")));

            //Update 2023
            String _dataMO = String.Format("{0:c2}", Convert.ToDecimal(_dataHienThi.MO == null ? "0.00" : _dataHienThi.MO.ToString()));
            lbMO.Text = _dataMO + " (1 CÔNG NHÂN = " + _dataMO + " / 8H)";

            //lbMO.Text = String.Format("{0:c2}", Convert.ToDecimal(_dataHienThi.MO == null ? "0.00" : _dataHienThi.MO.ToString())) + " (1 CÔNG NHÂN = " + String.Format("{0:c2}", Convert.ToDecimal(_dataHienThi.MO == null ? "0.00" : _dataHienThi.MO.ToString())) + " / 8H)";

        }
        private void HienThiPhanTram()
        {
            _tongDoanhThu = int.Parse(lbDT1.Text != "" ? lbDT1.Text : "0") + int.Parse(lbDT2.Text != "" ? lbDT2.Text : "0") + int.Parse(lbDT3.Text != "" ? lbDT3.Text : "0") +
                           int.Parse(lbDT4.Text != "" ? lbDT4.Text : "0") + int.Parse(lbDT5.Text != "" ? lbDT5.Text : "0") + int.Parse(lbDT6.Text != "" ? lbDT6.Text : "0") +
                           int.Parse(lbDT7.Text != "" ? lbDT7.Text : "0") + int.Parse(lbDT8.Text != "" ? lbDT8.Text : "0") + int.Parse(lbDTOverTime.Text != "" ? lbDTOverTime.Text : "0");
            lbSoLuongTong.Text = _tongDoanhThu.ToString();
            lbPhanTram.Text = (_tongDoanhThu * 100) / (_mucTieuGio * 8) + "%";
        }


        private void lbDT1_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo1.Text = "";
            int muctieu;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT1.Text) && Int32.TryParse(lbTarget1.Text, out muctieu))
            {
                soluong = Int32.Parse(lbDT1.Text) - muctieu;
                if (soluong > 0)
                {
                    lblHieuSo1.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo1.ForeColor = Color.Red;
                }

                lblHieuSo1.Text = soluong + "";
            }
        }

        private void lbDT2_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo2.Text = "";
            int muctieu;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT2.Text) && Int32.TryParse(lbTarget2.Text, out muctieu))
            {
                soluong = Int32.Parse(lbDT2.Text) - muctieu;
                if (soluong > 0)
                {
                    lblHieuSo2.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo2.ForeColor = Color.Red;
                }

                lblHieuSo2.Text = soluong + "";
            }
        }

        private void lbDT3_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo3.Text = "";
            int target;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT3.Text) && Int32.TryParse(lbTarget3.Text, out target))
            {
                soluong = Int32.Parse(lbDT3.Text) - target;
                if (soluong > 0)
                {
                    lblHieuSo3.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo3.ForeColor = Color.Red;
                }

                lblHieuSo3.Text = soluong + "";
            }
        }

        private void lbDT4_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo4.Text = "";
            int target;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT4.Text) && Int32.TryParse(lbTarget4.Text, out target))
            {
                soluong = Int32.Parse(lbDT4.Text) - target;
                if (soluong > 0)
                {
                    lblHieuSo4.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo4.ForeColor = Color.Red;
                }

                lblHieuSo4.Text = soluong + "";
            }
        }

        private void lbDT5_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo5.Text = "";
            int target;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT5.Text) && Int32.TryParse(lbTarget5.Text, out target))
            {
                soluong = Int32.Parse(lbDT5.Text) - target;
                if (soluong > 0)
                {
                    lblHieuSo5.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo5.ForeColor = Color.Red;
                }

                lblHieuSo5.Text = soluong + "";
            }
        }

        private void lbDT6_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo6.Text = "";
            int target;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT6.Text) && Int32.TryParse(lbTarget6.Text, out target))
            {
                soluong = Int32.Parse(lbDT6.Text) - target;
                if (soluong > 0)
                {
                    lblHieuSo6.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo6.ForeColor = Color.Red;
                }

                lblHieuSo6.Text = soluong + "";
            }

        }

        private void lbDT7_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo7.Text = "";
            int target;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT7.Text) && Int32.TryParse(lbTarget7.Text, out target))
            {
                soluong = Int32.Parse(lbDT7.Text) - target;
                if (soluong > 0)
                {
                    lblHieuSo7.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo7.ForeColor = Color.Red;
                }

                lblHieuSo7.Text = soluong + "";
            }
        }

        private void lbDT8_TextChanged(object sender, EventArgs e)
        {
            lblHieuSo8.Text = "";
            int target;
            int soluong;
            if (!String.IsNullOrEmpty(lbDT8.Text) && Int32.TryParse(lbTarget8.Text, out target))
            {
                soluong = Int32.Parse(lbDT8.Text) - target;
                if (soluong > 0)
                {
                    lblHieuSo8.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblHieuSo8.ForeColor = Color.Red;
                }

                lblHieuSo8.Text = soluong + "";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                // UpdateDoanhThuTungGio();
                // UpdateDoanhThuNgay();
                HienThiThongTin();
            }
            catch //(Exception ex)
            {
               // MessageBox.Show("Lỗi load dữ liệu " + ex.ToString());
            }
        }
    }
}
