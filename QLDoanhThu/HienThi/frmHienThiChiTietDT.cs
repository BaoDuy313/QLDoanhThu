using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.HienThi
{
    public partial class frmHienThiChiTietDT : Form
    {
        public delegate void GetIdChiphi(int id);

        public readonly GetIdChiphi GetIdChiPhi;
        private int _idChiPhi;
        private HienThiDoanhThuTungGio _dataHienThi;
        private HienThiDoanhThuTungGioBUS h;
        private decimal _mucTieuNgay;
        private int _mucTieuGio;
        //private int mucTieuPhanDu;
        private int _tongDoanhThu;
        private int _idCtdt;

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

        private readonly TimeSpan _dl9 = TimeSpan.Parse("16:31:00");
        private readonly TimeSpan _cl9 = TimeSpan.Parse("17:30:00");
        public frmHienThiChiTietDT()
        {
            InitializeComponent();
            GetIdChiPhi = new GetIdChiphi(GetIDChiPhi);
            h = new HienThiDoanhThuTungGioBUS();
        }

        private void GetIDChiPhi(int idChiPhi)
        {
            this._idChiPhi = idChiPhi;
        }

        private void HienThiThongTin()
        {
            _dataHienThi = h.LayThongTinHienThi(_idChiPhi,_idCtdt);
            lbLine.Text = _dataHienThi.NameLine;
            lbStyle.Text = _dataHienThi.Style;

            _idCtdt = _dataHienThi.ID;

            _mucTieuNgay = _dataHienThi.DayTarget;
            if (Math.Ceiling(_mucTieuNgay)%9==0)
            {
                _mucTieuGio = (int) (Math.Ceiling(_mucTieuNgay) / 9);
                lbTarget1.Text = _mucTieuGio.ToString();
                lbTarget2.Text = _mucTieuGio.ToString();
                lbTarget3.Text = _mucTieuGio.ToString();
                lbTarget4.Text = _mucTieuGio.ToString();
                lbTarget5.Text = _mucTieuGio.ToString();
                lbTarget6.Text = _mucTieuGio.ToString();
                lbTarget7.Text = _mucTieuGio.ToString();
                lbTarget8.Text = _mucTieuGio.ToString();
                lbTarget9.Text = _mucTieuGio.ToString();
            }
            else
            {
                _mucTieuGio = (int) (Math.Ceiling(_mucTieuNgay) / 9) + 1;
                lbTarget1.Text = _mucTieuGio.ToString();
                lbTarget2.Text = _mucTieuGio.ToString();
                lbTarget3.Text = _mucTieuGio.ToString();
                lbTarget4.Text = _mucTieuGio.ToString();
                lbTarget5.Text = _mucTieuGio.ToString();
                lbTarget6.Text = _mucTieuGio.ToString();
                lbTarget7.Text = _mucTieuGio.ToString();
                lbTarget8.Text = _mucTieuGio.ToString();
                lbTarget9.Text = _mucTieuGio.ToString();
            }


            lbDT1.Text = _dataHienThi.DTL1 == null ? "" : _dataHienThi.DTL1.ToString();
            lbDT2.Text = _dataHienThi.DTL2 == null ? "" : _dataHienThi.DTL2.ToString(); 
            lbDT3.Text = _dataHienThi.DTL3 == null ? "" : _dataHienThi.DTL3.ToString(); 
            lbDT4.Text = _dataHienThi.DTL4 == null ? "" : _dataHienThi.DTL4.ToString(); 
            lbDT5.Text = _dataHienThi.DTL5 == null ? "" : _dataHienThi.DTL5.ToString(); 
            lbDT6.Text = _dataHienThi.DTL6 == null ? "" : _dataHienThi.DTL6.ToString(); 
            lbDT7.Text = _dataHienThi.DTL7 == null ? "" : _dataHienThi.DTL7.ToString(); 
            lbDT8.Text = _dataHienThi.DTL8 == null ? "" : _dataHienThi.DTL8.ToString(); 
            lbDT9.Text = _dataHienThi.DTOverTime == null ? "" : _dataHienThi.DTOverTime.ToString();

            lbChiPhiThang.Text = $"{Math.Ceiling(_dataHienThi.TotalTarget):N0}" + " PCS";
            lbDoanhThuThang.Text = $"{Math.Ceiling(_dataHienThi.TotalFinish):N0}" + " PCS";

             lbSoNgay.Text = _dataHienThi.SoNgayConLai.ToString() + " ngày";

            HienThiPhanTram();

        }


        private void HienThiPhanTram()
        {
            _tongDoanhThu = int.Parse(lbDT1.Text!=""?lbDT1.Text:"0") + int.Parse(lbDT2.Text!=""?lbDT2.Text:"0") + int.Parse(lbDT3.Text!=""?lbDT3.Text:"0") +
                           int.Parse(lbDT4.Text!=""?lbDT4.Text:"0") + int.Parse(lbDT5.Text!=""?lbDT5.Text:"0") + int.Parse(lbDT6.Text!=""?lbDT6.Text:"0") +
                           int.Parse(lbDT7.Text!=""?lbDT7.Text:"0") + int.Parse(lbDT8.Text!=""?lbDT8.Text:"0") + int.Parse(lbDT9.Text!=""?lbDT9.Text:"0");

            lbPhanTram.Text = (_tongDoanhThu * 100) / (_mucTieuGio * 9) + "%";
        }

        private void HienThiSoLuong(int target,params string[] values)
        {
            int sum = 0;
            foreach (var value in values)
            {
              
                sum += int.Parse(value==""?"0":value);
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
        

        private void frmHienThiChiTietDT_Load(object sender, EventArgs e)
        {
            HienThiThongTin();

            timer1.Start();
            timer2.Start();
            lbGio.Text = DateTime.Now.ToLongTimeString();
            lbNgay.Text = $"{DateTime.Now:dd/MM/yyyy}";



            /*TimeSpan gioHientai = DateTime.Now.TimeOfDay;
            TimeSpan gioKiemTra = TimeSpan.Parse("11:30:00");
            TimeSpan gioKiemTra2 = TimeSpan.Parse("14:30:00");
            if (gioKiemTra < gioHientai && gioHientai < gioKiemTra2)
            {
                MessageBox.Show(idChiPhi.ToString());
            }
            else
            {
                MessageBox.Show("no ok");
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void UpdateDoanhThuTungGio()
        {
            h.UpdateMultiDoanhThu(_idCtdt,
                                  int.Parse(lbDT1.Text==""?"-1":lbDT1.Text),
                                  int.Parse(lbDT2.Text==""?"-1":lbDT2.Text),
                                  int.Parse(lbDT3.Text==""?"-1":lbDT3.Text),
                                  int.Parse(lbDT4.Text==""?"-1":lbDT4.Text),
                                  int.Parse(lbDT5.Text==""?"-1":lbDT5.Text),
                                  int.Parse(lbDT6.Text==""?"-1":lbDT6.Text),
                                  int.Parse(lbDT7.Text==""?"-1":lbDT7.Text),
                                  int.Parse(lbDT8.Text==""?"-1":lbDT8.Text),
                                  int.Parse(lbDT9.Text==""?"-1":lbDT9.Text));
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
            int dt9 = int.Parse(lbDT9.Text == "" ? "0" : lbDT9.Text);

            int soluongtong = dt1 + dt2 + dt3 + dt4 + dt5 + dt6 + dt7 + dt8 + dt9;

            h.UpdateDoanhThu(_idCtdt,soluongtong);
        }
        private void frmHienThiChiTietDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add)
            {
                TimeSpan gioHienTai = DateTime.Now.TimeOfDay;
                if (_dl1 <= gioHienTai && gioHienTai <= _cl1)
                {
                   
                    int soluong = lbDT1.Text == "" ? 0 : int.Parse(lbDT1.Text);
                    soluong += 1;
                    lbDT1.Text = soluong + "";

                    if (int.Parse(lbDT1.Text==""?"0":lbDT1.Text) < int.Parse(lbTarget1.Text))
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

                    
           

                }else if (_dl2 <= gioHienTai && gioHienTai <= _cl2)
                {
                   
                   
                    int soluong = lbDT2.Text == "" ? 0 : int.Parse(lbDT2.Text);
                    soluong += 1;
                    lbDT2.Text = soluong + "";

                    if (int.Parse(lbDT2.Text==""?"0":lbDT2.Text) < int.Parse(lbTarget2.Text))
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
                    HienThiSoLuong(_mucTieuGio*2, lbDT1.Text, lbDT2.Text);


                    SetGiaTriLableRong(lbDT1, lbDT2);
                   
                }
                else if (_dl3 <= gioHienTai && gioHienTai <= _cl3)
                {
                      

                    int soluong = lbDT3.Text == "" ? 0 : int.Parse(lbDT3.Text);
                    soluong += 1;
                    lbDT3.Text = soluong + "";

                    if (int.Parse(lbDT3.Text==""?"0":lbDT3.Text) < int.Parse(lbTarget3.Text))
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
                    HienThiSoLuong(_mucTieuGio*3, lbDT1.Text,lbDT2.Text,lbDT3.Text);

                    SetGiaTriLableRong(lbDT1, lbDT2, lbDT3);

                  
                }
                else if (_dl4 <= gioHienTai && gioHienTai <= _cl4)
                {
                 
                    int soluong = lbDT4.Text == "" ? 0 : int.Parse(lbDT4.Text);
                    soluong += 1;
                    lbDT4.Text = soluong + "";

                    if (int.Parse(lbDT4.Text==""?"0":lbDT4.Text) < int.Parse(lbTarget4.Text))
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
                    HienThiSoLuong(_mucTieuGio*4, lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text);

                    SetGiaTriLableRong(lbDT1, lbDT2,lbDT3,lbDT4);
                }
                else if (_dl5 <= gioHienTai && gioHienTai <= _cl5)
                {
                    
                    int soluong = lbDT5.Text == "" ? 0 : int.Parse(lbDT5.Text);
                    soluong += 1;
                    lbDT5.Text = soluong + "";

                    if (int.Parse(lbDT5.Text==""?"0":lbDT5.Text) < int.Parse(lbTarget5.Text))
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
                    HienThiSoLuong(_mucTieuGio*5, lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2,lbDT3,lbDT4,lbDT5);


                }
                else if (_dl6 <= gioHienTai && gioHienTai <= _cl6)
                {
                    
                    int soluong = lbDT6.Text == "" ? 0 : int.Parse(lbDT6.Text);
                    soluong += 1;
                    lbDT6.Text = soluong + "";

                    if (int.Parse(lbDT6.Text==""?"0":lbDT6.Text) < int.Parse(lbTarget6.Text))
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
                    HienThiSoLuong(_mucTieuGio*6, lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2,lbDT3,lbDT4,lbDT5,lbDT6);

      

                    
                }
                else if (_dl7 <= gioHienTai && gioHienTai <= _cl7)
                {
                     
                    int soluong = lbDT7.Text == "" ? 0 : int.Parse(lbDT7.Text);
                    soluong += 1;
                    lbDT7.Text = soluong + "";

                    if (int.Parse(lbDT7.Text==""?"0":lbDT7.Text) < int.Parse(lbTarget7.Text))
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
                    HienThiSoLuong(_mucTieuGio*7, lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text,lbDT7.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2,lbDT3,lbDT4,lbDT5,lbDT6,lbDT7);

     
                   
                }
                else if (_dl8 <= gioHienTai && gioHienTai <= _cl8)
                {
                    
                    int soluong = lbDT8.Text == "" ? 0 : int.Parse(lbDT8.Text);
                    soluong += 1;
                    lbDT8.Text = soluong + "";

                    if (int.Parse(lbDT8.Text==""?"0":lbDT8.Text) < int.Parse(lbTarget8.Text))
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
                    HienThiSoLuong(_mucTieuGio*8, lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text,lbDT7.Text,lbDT8.Text);
                    SetGiaTriLableRong(lbDT1, lbDT2,lbDT3,lbDT4,lbDT5,lbDT6,lbDT7,lbDT8);

  
                    
                }
                else if (_dl9 <= gioHienTai && gioHienTai <=_cl9)
                {
                    
                    int soluong = lbDT9.Text == "" ? 0 : int.Parse(lbDT9.Text);
                    soluong += 1;
                    lbDT9.Text = soluong + "";

                    if (int.Parse(lbDT9.Text==""?"0":lbDT9.Text) < int.Parse(lbTarget9.Text))
                    {
                        lbDT9.BackColor = Color.Brown;
                        lbDT9.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lbDT9.BackColor = Color.White;
                        lbDT9.ForeColor = Color.Black;
                    }

                    HienThiPhanTram();
                    HienThiSoLuong(_mucTieuGio*9,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text,lbDT7.Text,lbDT8.Text,lbDT9.Text);

                    SetGiaTriLableRong(lbDT1, lbDT2,lbDT3,lbDT4,lbDT5,lbDT6,lbDT7,lbDT8,lbDT9);

  
                }

            }

            if (e.KeyCode == Keys.Subtract)
            {
                TimeSpan gioHienTai = DateTime.Now.TimeOfDay;
                if (_dl1 <= gioHienTai && gioHienTai <= _cl1 && lbDT1.Text!="")
                {
                    int soluong = int.Parse(lbDT1.Text);
                    if (soluong>0)
                    {
                        soluong -= 1;
                        lbDT1.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio,lbDT1.Text);

              

                    }
                }
                else if (_dl2 <= gioHienTai && gioHienTai <= _cl2 && lbDT2.Text!="")
                {
                    int soluong = int.Parse(lbDT2.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT2.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*2,lbDT1.Text,lbDT2.Text);

                    

                    }
                }
                else if (_dl3 <= gioHienTai && gioHienTai <= _cl3 && lbDT3.Text!="")
                {
                    int soluong = int.Parse(lbDT3.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT3.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*3,lbDT1.Text,lbDT2.Text,lbDT3.Text);

                    

                    }
                }
                else if (_dl4 <= gioHienTai && gioHienTai <= _cl4 && lbDT4.Text!="")
                {
                    int soluong = int.Parse(lbDT4.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT4.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*4,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text);

                 

                    }
                }
                else if (_dl5 <= gioHienTai && gioHienTai <= _cl5 && lbDT5.Text!="")
                {
                    int soluong = int.Parse(lbDT5.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT5.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*5,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text);

                   

                    }
                }
                else if (_dl6 <= gioHienTai && gioHienTai <= _cl6 && lbDT6.Text!="")
                {
                    int soluong = int.Parse(lbDT6.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT6.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*6,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text);

                    }
                }
                else if (_dl7 <= gioHienTai && gioHienTai <= _cl7 && lbDT7.Text!="")
                {
                    int soluong = int.Parse(lbDT7.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT7.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*7,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text,lbDT7.Text);


                    }
                }
                else if (_dl8 <= gioHienTai && gioHienTai <= _cl8 && lbDT8.Text!="")
                {
                    int soluong = int.Parse(lbDT8.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT8.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*8,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text,lbDT7.Text,lbDT8.Text);

                     

                    }
                }
                else if (_dl9 <= gioHienTai && gioHienTai <= _cl9 && lbDT9.Text!="")
                {
                    int soluong = int.Parse(lbDT9.Text);
                    if (soluong > 0)
                    {
                        soluong -= 1;
                        lbDT9.Text = soluong + "";

                        HienThiPhanTram();
                        HienThiSoLuong(_mucTieuGio*9,lbDT1.Text,lbDT2.Text,lbDT3.Text,lbDT4.Text,lbDT5.Text,lbDT6.Text,lbDT7.Text,lbDT8.Text,lbDT9.Text);


                    }
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                UpdateDoanhThuTungGio();
                UpdateDoanhThuNgay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
