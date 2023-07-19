using BUS;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace QLDoanhThu
{
    public partial class frmShowDetail : Form
    {
        public delegate void GetIdChiPhi(int id, int muctieu, int idCTDT);
        public GetIdChiPhi getData;
        private int _idChiPhi;

        private HienThiDoanhThuTungGio _dataHienThi;
        private HienThiDoanhThuTungGioBUS h;
        private decimal _mucTieuNgay;
        private int _mucTieuGio;

        private int _tongDoanhThu;
        private int _idCtdt;

        //Mục tiêu theo lũy tuyến
        //private int _mucTieuLuyTuyen;
        //Mục tiêu theo trung bình
        //private int _mucTieuTrungBinh;

        //update 30/03/2020
        private int mucTieu;
        private int idCTDT;

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
        private TimeSpan GioBD;
        private int soGioLamViec;

        private int X = 2000;
        private int Y = 255;
        public frmShowDetail()
        {
            InitializeComponent();
            getData = new GetIdChiPhi(GetIDChiPhi);
            h = new HienThiDoanhThuTungGioBUS();

            //định dạng tiền tệ có số âm
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            CultureInfo newCulter = new CultureInfo(cultureInfo.Name);
            newCulter.NumberFormat.CurrencyNegativePattern = 1;
            Thread.CurrentThread.CurrentCulture = newCulter;
        }
        private void GetIDChiPhi(int id, int mucTieu, int idCTDT)
        {
            this._idChiPhi = id;
            this.mucTieu = mucTieu;
            this.idCTDT = idCTDT;
        }
        private void HienThiThongTin()
        {
            _dataHienThi = h.LayThongTinHienThi(_idChiPhi, idCTDT);
            lbLine.Text = _dataHienThi.NameLine;
            lbStyle.Text = _dataHienThi.Style;

            _idCtdt = _dataHienThi.ID;

            _mucTieuNgay = _dataHienThi.MucTieuTrungBinhNgay;

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

        }
        private void HienThiPhanTram()
        {
            _tongDoanhThu = int.Parse(lbDT1.Text != "" ? lbDT1.Text : "0") + int.Parse(lbDT2.Text != "" ? lbDT2.Text : "0") + int.Parse(lbDT3.Text != "" ? lbDT3.Text : "0") +
                           int.Parse(lbDT4.Text != "" ? lbDT4.Text : "0") + int.Parse(lbDT5.Text != "" ? lbDT5.Text : "0") + int.Parse(lbDT6.Text != "" ? lbDT6.Text : "0") +
                           int.Parse(lbDT7.Text != "" ? lbDT7.Text : "0") + int.Parse(lbDT8.Text != "" ? lbDT8.Text : "0") + int.Parse(lbDTOverTime.Text != "" ? lbDTOverTime.Text : "0");
            lbSoLuongTong.Text = _tongDoanhThu.ToString();
            lbPhanTram.Text = (_tongDoanhThu * 100) / (_mucTieuGio * 8) + "%";
        }

        private void HienThiSoLuong(int target, params string[] values)
        {
            int sum = 0;
            foreach (var value in values)
            {

                sum += int.Parse(value == "" ? "0" : value);
            }

            lbSoLuongTong.Text = (sum - target) + "";

        }
        private void SetGiaTriLableRong(params Label[] values)
        {
            foreach (var lbDt in values)
            {
                if (lbDt.Text == "")
                {
                    lbDt.Text = "0";
                    lbDt.BackColor = Color.Brown;
                    lbDt.ForeColor = Color.Yellow;

                }
                else if (int.Parse(lbDt.Text) < _mucTieuGio)
                {
                    lbDt.BackColor = Color.Brown;
                    lbDt.ForeColor = Color.Yellow;
                }
            }
        }

        private void frmShowDetail_Load(object sender, EventArgs e)
        {
            HienThiThongTin();

            timer1.Start();
            timer2.Start();
            lbGio.Text = DateTime.Now.ToLongTimeString();
            lbNgay.Text = $@"{DateTime.Now:dd/MM/yyyy}";

            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            if (timeSpan >= _dl1 && timeSpan <= _cl8)
            {
                timer4.Start();
            }
            else
            {
                timer4.Stop();
            }
            timer3.Stop();
            label16.SetBounds(X, Y, 1, 1);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void UpdateDoanhThuTungGio()
        {

            h.UpdateMultiDoanhThu(_idCtdt,
                                  int.Parse(lbDT1.Text == "" ? "-1" : lbDT1.Text),
                                  int.Parse(lbDT2.Text == "" ? "-1" : lbDT2.Text),
                                  int.Parse(lbDT3.Text == "" ? "-1" : lbDT3.Text),
                                  int.Parse(lbDT4.Text == "" ? "-1" : lbDT4.Text),
                                  int.Parse(lbDT5.Text == "" ? "-1" : lbDT5.Text),
                                  int.Parse(lbDT6.Text == "" ? "-1" : lbDT6.Text),
                                  int.Parse(lbDT7.Text == "" ? "-1" : lbDT7.Text),
                                  int.Parse(lbDT8.Text == "" ? "-1" : lbDT8.Text),
                                  int.Parse(lbDTOverTime.Text == "" ? "-1" : lbDTOverTime.Text));
        }

        private void UpdateDoanhThuNgay()
        {
            int dt1 = int.Parse(lbDT1.Text == "" ? "0" : lbDT1.Text);
            int dt2 = int.Parse(lbDT2.Text == "" ? "0" : lbDT2.Text);
            int dt3 = int.Parse(lbDT3.Text == "" ? "0" : lbDT3.Text);
            int dt4 = int.Parse(lbDT4.Text == "" ? "0" : lbDT4.Text);
            int dt5 = int.Parse(lbDT5.Text == "" ? "0" : lbDT5.Text);
            int dt6 = int.Parse(lbDT6.Text == "" ? "0" : lbDT6.Text);
            int dt7 = int.Parse(lbDT7.Text == "" ? "0" : lbDT7.Text);
            int dt8 = int.Parse(lbDT8.Text == "" ? "0" : lbDT8.Text);
            int dtOverTime = int.Parse(lbDTOverTime.Text == "" ? "0" : lbDTOverTime.Text);

            int soluongtong = dt1 + dt2 + dt3 + dt4 + dt5 + dt6 + dt7 + dt8 + dtOverTime;

            h.UpdateDoanhThu(_idCtdt, soluongtong);
        }

        private void frmShowDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add)
            {
                TimeSpan gioHienTai = DateTime.Now.TimeOfDay;

                if (_dl1 <= gioHienTai && gioHienTai <= _cl1 && gioHienTai >= GioBD)
                {

                    int soluong = lbDT1.Text == "" ? 0 : int.Parse(lbDT1.Text);
                    soluong += 1;
                    lbDT1.Text = soluong + "";

                    if (int.Parse(lbDT1.Text == "" ? "0" : lbDT1.Text) < int.Parse(lbTarget1.Text))
                    {
                        lbDT1.BackColor = Color.Brown;
                        lbDT1.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT1.BackColor = Color.White;
                        lbDT1.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio, lbDT1.Text);

                }
                else if (_dl2 <= gioHienTai && gioHienTai <= _cl2 && gioHienTai >= GioBD)
                {


                    int soluong = lbDT2.Text == "" ? 0 : int.Parse(lbDT2.Text);
                    soluong += 1;
                    lbDT2.Text = soluong + "";

                    if (int.Parse(lbDT2.Text == "" ? "0" : lbDT2.Text) < int.Parse(lbTarget2.Text))
                    {
                        lbDT2.BackColor = Color.Brown;
                        lbDT2.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT2.BackColor = Color.White;
                        lbDT2.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 2, lbDT1.Text, lbDT2.Text);


                    SetGiaTriLableRong(lbDT1, lbDT2);

                }
                else if (_dl3 <= gioHienTai && gioHienTai <= _cl3 && gioHienTai >= GioBD)
                {


                    int soluong = lbDT3.Text == "" ? 0 : int.Parse(lbDT3.Text);
                    soluong += 1;
                    lbDT3.Text = soluong + "";

                    if (int.Parse(lbDT3.Text == "" ? "0" : lbDT3.Text) < int.Parse(lbTarget3.Text))
                    {
                        lbDT3.BackColor = Color.Brown;
                        lbDT3.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT3.BackColor = Color.White;
                        lbDT3.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 3, lbDT1.Text, lbDT2.Text, lbDT3.Text);

                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3);


                }
                else if (_dl4 <= gioHienTai && gioHienTai <= _cl4 && gioHienTai >= GioBD)
                {

                    int soluong = lbDT4.Text == "" ? 0 : int.Parse(lbDT4.Text);
                    soluong += 1;
                    lbDT4.Text = soluong + "";

                    if (int.Parse(lbDT4.Text == "" ? "0" : lbDT4.Text) < int.Parse(lbTarget4.Text))
                    {
                        lbDT4.BackColor = Color.Brown;
                        lbDT4.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT4.BackColor = Color.White;
                        lbDT4.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 4, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text);

                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3, lbDT4);
                }
                else if (_dl5 <= gioHienTai && gioHienTai <= _cl5 && gioHienTai >= GioBD)
                {

                    int soluong = lbDT5.Text == "" ? 0 : int.Parse(lbDT5.Text);
                    soluong += 1;
                    lbDT5.Text = soluong + "";

                    if (int.Parse(lbDT5.Text == "" ? "0" : lbDT5.Text) < int.Parse(lbTarget5.Text))
                    {
                        lbDT5.BackColor = Color.Brown;
                        lbDT5.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT5.BackColor = Color.White;
                        lbDT5.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 5, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3, lbDT4, lbDT5);


                }
                else if (_dl6 <= gioHienTai && gioHienTai <= _cl6 && gioHienTai >= GioBD)
                {

                    int soluong = lbDT6.Text == "" ? 0 : int.Parse(lbDT6.Text);
                    soluong += 1;
                    lbDT6.Text = soluong + "";

                    if (int.Parse(lbDT6.Text == "" ? "0" : lbDT6.Text) < int.Parse(lbTarget6.Text))
                    {
                        lbDT6.BackColor = Color.Brown;
                        lbDT6.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT6.BackColor = Color.White;
                        lbDT6.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 6, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3, lbDT4, lbDT5, lbDT6);




                }
                else if (_dl7 <= gioHienTai && gioHienTai <= _cl7 && gioHienTai >= GioBD)
                {

                    int soluong = lbDT7.Text == "" ? 0 : int.Parse(lbDT7.Text);
                    soluong += 1;
                    lbDT7.Text = soluong + "";

                    if (int.Parse(lbDT7.Text == "" ? "0" : lbDT7.Text) < int.Parse(lbTarget7.Text))
                    {
                        lbDT7.BackColor = Color.Brown;
                        lbDT7.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT7.BackColor = Color.White;
                        lbDT7.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 7, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text, lbDT7.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3, lbDT4, lbDT5, lbDT6, lbDT7);



                }
                else if (_dl8 <= gioHienTai && gioHienTai <= _cl8 && gioHienTai >= GioBD)
                {

                    int soluong = lbDT8.Text == "" ? 0 : int.Parse(lbDT8.Text);
                    soluong += 1;
                    lbDT8.Text = soluong + "";

                    if (int.Parse(lbDT8.Text == "" ? "0" : lbDT8.Text) < int.Parse(lbTarget8.Text))
                    {
                        lbDT8.BackColor = Color.Brown;
                        lbDT8.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT8.BackColor = Color.White;
                        lbDT8.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 8, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text, lbDT7.Text, lbDT8.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3, lbDT4, lbDT5, lbDT6, lbDT7, lbDT8);



                }
                else if (_dlOvertime <= gioHienTai && gioHienTai >= GioBD)
                {

                    int soluong = lbDTOverTime.Text == "" ? 0 : int.Parse(lbDTOverTime.Text);
                    soluong += 1;
                    lbDTOverTime.Text = soluong + "";


                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio * 8, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text, lbDT7.Text, lbDT8.Text, lbDTOverTime.Text);

                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3, lbDT4, lbDT5, lbDT6, lbDT7, lbDT8);


                }

                //Hiển thị Actual và Profit
                lbActual.Text = String.Format("{0:c1}", _tongDoanhThu * _dataHienThi.Dongia);
                lbProfit.Text = String.Format("{0:c1}", decimal.Parse(lbActual.Text.Replace("$", "")) - decimal.Parse(lbTarget.Text.Replace("$", "")));


                //Update Database
                UpdateDoanhThuTungGio();
                UpdateDoanhThuNgay();

            }

            if (e.KeyCode == Keys.Subtract)
            {
                TimeSpan gioHienTai = DateTime.Now.TimeOfDay;
                if (_dl1 <= gioHienTai && gioHienTai <= _cl1 && lbDT1.Text != "")
                {
                    int soluong = int.Parse(lbDT1.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT1.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio, lbDT1.Text);



                    }
                }
                else if (_dl2 <= gioHienTai && gioHienTai <= _cl2 && lbDT2.Text != "")
                {
                    int soluong = int.Parse(lbDT2.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT2.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 2, lbDT1.Text, lbDT2.Text);



                    }
                }
                else if (_dl3 <= gioHienTai && gioHienTai <= _cl3 && lbDT3.Text != "")
                {
                    int soluong = int.Parse(lbDT3.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT3.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 3, lbDT1.Text, lbDT2.Text, lbDT3.Text);



                    }
                }
                else if (_dl4 <= gioHienTai && gioHienTai <= _cl4 && lbDT4.Text != "")
                {
                    int soluong = int.Parse(lbDT4.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT4.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 4, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text);



                    }
                }
                else if (_dl5 <= gioHienTai && gioHienTai <= _cl5 && lbDT5.Text != "")
                {
                    int soluong = int.Parse(lbDT5.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT5.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 5, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text);



                    }
                }
                else if (_dl6 <= gioHienTai && gioHienTai <= _cl6 && lbDT6.Text != "")
                {
                    int soluong = int.Parse(lbDT6.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT6.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 6, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text);

                    }
                }
                else if (_dl7 <= gioHienTai && gioHienTai <= _cl7 && lbDT7.Text != "")
                {
                    int soluong = int.Parse(lbDT7.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT7.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 7, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text, lbDT7.Text);


                    }
                }
                else if (_dl8 <= gioHienTai && gioHienTai <= _cl8 && lbDT8.Text != "")
                {
                    int soluong = int.Parse(lbDT8.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT8.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 8, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text, lbDT7.Text, lbDT8.Text);



                    }
                }
                else if (_dlOvertime <= gioHienTai && lbDTOverTime.Text != "")
                {
                    int soluong = int.Parse(lbDTOverTime.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDTOverTime.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio * 8, lbDT1.Text, lbDT2.Text, lbDT3.Text, lbDT4.Text, lbDT5.Text, lbDT6.Text, lbDT7.Text, lbDT8.Text, lbDTOverTime.Text);

                    }
                }

                //Hiển thị Actual và Profit
                lbActual.Text = String.Format("{0:c1}", _tongDoanhThu * _dataHienThi.Dongia);
                lbProfit.Text = String.Format("{0:c1}", decimal.Parse(lbActual.Text.Replace("$", "")) - decimal.Parse(lbTarget.Text.Replace("$", "")));

                //Update Database
                UpdateDoanhThuTungGio();
                UpdateDoanhThuNgay();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                // UpdateDoanhThuTungGio();
                // UpdateDoanhThuNgay();
                HienThiThongTin();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu " + ex.ToString());
            }
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeSpan timeSpan = DateTime.Now.TimeOfDay;
                if (timeSpan >= _dl1 && timeSpan <= _cl8)
                {
                    label16.SetBounds(X, Y, 1, 1);

                    tableLayoutPanel4.Visible = false;
                    X -= 3;
                    if (X <= -3000)
                    {
                        X = 2000;
                        tableLayoutPanel4.Visible = true;
                        timer4.Start();
                        timer3.Stop();
                    }
                }
                else
                {
                    X = 2000;
                    label16.SetBounds(X, Y, 1, 1);
                    label16.Text = "";
                    tableLayoutPanel4.Visible = true;
                    timer4.Start();
                    timer3.Stop();
                }

            }
            catch
            {

            }
        }
        public void HienThiChu()
        {
            TimeSpan gioHienTai = DateTime.Now.TimeOfDay;
            int _t = 0;
            int slThieu;
            slThieu = int.Parse(lblHieuSo1.Text != "" ? lblHieuSo1.Text : "0") + int.Parse(lblHieuSo2.Text != "" ? lblHieuSo2.Text : "0") + int.Parse(lblHieuSo3.Text != "" ? lblHieuSo3.Text : "0") +
                           int.Parse(lblHieuSo4.Text != "" ? lblHieuSo4.Text : "0") + int.Parse(lblHieuSo5.Text != "" ? lblHieuSo5.Text : "0") + int.Parse(lblHieuSo6.Text != "" ? lblHieuSo6.Text : "0") +
                           int.Parse(lblHieuSo7.Text != "" ? lblHieuSo7.Text : "0") + int.Parse(lblHieuSo8.Text != "" ? lblHieuSo8.Text : "0");
            if (gioHienTai >= _dl1 && gioHienTai <= _cl8)
            {
                if (_dataHienThi.MucTieu > _tongDoanhThu)
                {
                    if (gioHienTai < _dl5)
                    {
                        _t = (_cl8 - gioHienTai).Hours - 1;
                    }
                    else
                    {
                        _t = (_cl8 - gioHienTai).Hours;
                    }

                    _t += 1;
                    if (slThieu < 0)
                    {
                        if ((slThieu % _t) == 0)
                        {
                            label16.Text = "Bạn cần " + (_mucTieuGio - (slThieu / _t)) + " sản phẩm mỗi giờ để đạt mục tiêu";
                        }
                        else
                        {
                            label16.Text = "Bạn cần " + ((_mucTieuGio - (slThieu / _t)) + 1) + " sản phẩm mỗi giờ để đạt mục tiêu";
                        }
                    }
                    else
                    {
                        label16.Text = "Bạn cần " + _mucTieuGio + " sản phẩm mỗi giờ để đạt mục tiêu";
                    }
                }
                else if (_dataHienThi.MucTieu <= _tongDoanhThu)
                {
                    label16.Text = " Bạn hãy cố gắng giữ vững hiệu xuất để đạt mục tiêu trong ngày";
                }
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeSpan timeSpan = DateTime.Now.TimeOfDay;
                if (timeSpan >= _dl1 && timeSpan <= _cl8)
                {
                    HienThiChu();
                    timer3.Start();
                    timer4.Stop();
                }

            }
            catch
            {

            }
        }
    }
}
