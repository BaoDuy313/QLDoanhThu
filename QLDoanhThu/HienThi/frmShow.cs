using BUS;
using System;
using System.Windows.Forms;

namespace QLDoanhThu.HienThi
{
    public partial class frmShow : Form
    {
        public delegate void GetData(int i);

        public GetData getIDChiPhi;
        private int idChiPhi;
        private DoanhThuBUS d;
        private int soluong;
        private decimal dongia;
        private int id;

        private bool isShow;
         HienThiDoanhThuBUS hienthi;
        frmTarget frm;

        public frmShow()
        {
            InitializeComponent();
            d = new DoanhThuBUS();
            getIDChiPhi = new GetData(GetIDChiPhi);
            
            isShow = false;
        }

        public void GetIDChiPhi(int id)
        {
            this.idChiPhi = id;
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
             frm = new frmTarget();
            timeUpdate.Start();
        }

        public void HienThiThongTin()
        {
           hienthi = d.LayDanhSachHienThi(idChiPhi);
            lbNgay.Text = String.Format("{0:dd/MM/yyyy}", hienthi.Ngay);
            lbStyle.Text = hienthi.Style.ToString();

            lbChiPhiNgay.Text = String.Format("{0:C0}", hienthi.ChiPhiNgay);

            lbChiPhiThang.Text = String.Format("{0:C0}", hienthi.ChiPhiThang);
            lbSoNgay.Text = hienthi.SoNgayConLai.ToString() + " ngày";
            lbDoanhThuThang.Text = String.Format("{0:C0}", hienthi.DoanhThuThang);

            this.soluong = (int)hienthi.SoLuong;
            this.dongia = (decimal)hienthi.DonGia;
            this.id = hienthi.ID;

            lbSoLuongLamDuoc.Text = String.Format(soluong.ToString()) + " pcs";
            lbDoanhThuNgay.Text = String.Format("{0:C0}", soluong * dongia);
            lbLine.Text = hienthi.NameLine.ToString();
        }

        private void FrmShow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add)
            {
                int soluongTang = Convert.ToInt32(lbSoLuongLamDuoc.Text.Replace(" pcs", ""));
                soluongTang += 1;
                lbSoLuongLamDuoc.Text = String.Format("{0:n0}", soluongTang) + " pcs";
                lbDoanhThuNgay.Text = String.Format("{0:C0}", soluongTang * dongia);
            }

            if (e.KeyCode == Keys.Subtract)
            {
                int soluongTang = Convert.ToInt32(lbSoLuongLamDuoc.Text.Replace(" pcs", ""));
                if (soluongTang >= 1)
                {
                    soluongTang -= 1;
                    lbSoLuongLamDuoc.Text = String.Format("{0:n0}", soluongTang) + " pcs";
                    lbDoanhThuNgay.Text = String.Format("{0:C0}", soluongTang * dongia);
                }
            }
        }

        private void TimeUpdate_Tick(object sender, EventArgs e)
        {
            hienthi = d.LayDanhSachHienThi(idChiPhi);
            isShow = !isShow;

            try
            {
                int soluonghientai = Convert.ToInt32(lbSoLuongLamDuoc.Text.ToString().Replace(" pcs", ""));
                d.UpdateDoanhThu(id, soluonghientai);
                HienThiThongTin();

               

                if (isShow==true)
                {
                    frm.sendDataFormProfit(idChiPhi,hienthi.ChiPhiNgay,hienthi.Style);
                    frm.sendInfo-=Frm_sendInfo;
                    frm.ShowDialog();

                }
                else
                {
                    frm.sendInfo += Frm_sendInfo;
                    frm.Close();
                }
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void Frm_sendInfo(int soLuong)
        {
            d.UpdateDoanhThu(id,soLuong);
            HienThiThongTin();
        }

        private void frmShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}