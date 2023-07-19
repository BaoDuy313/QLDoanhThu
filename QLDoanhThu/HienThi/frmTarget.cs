using System;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.HienThi
{
    public partial class frmTarget : Form
    {
        private int idChiphi;
        private decimal chiphingay;
        private string idStyle;
        public delegate void SendData(int idchiphi,decimal chiphingay,string idStyle);
        public SendData sendDataFormProfit;
        public delegate void SendInfoUpdate(int soLuong);
        public event SendInfoUpdate sendInfo;
        TargetBUS target = new TargetBUS();
        public frmTarget()
        {
            InitializeComponent();
            sendDataFormProfit = new SendData(GetDataFormProfit);
        }
        public void GetDataFormProfit(int idChiPhi,decimal chiPhiNgay,string idStyle)
        {
            this.idChiphi = idChiPhi;
            this.chiphingay = chiPhiNgay;
            this.idStyle = idStyle;
        }

        private void frmTarget_Load(object sender, EventArgs e)
        {
          HienThiThongTin();
        }

        private void HienThiThongTin() 
        { 
            Target t = target.HienThiTarget(idChiphi,chiphingay,idStyle);
            lbNgay.Text = String.Format("{0:dd/MM/yyyy}",t.Ngay);
            lbLine.Text = t.NameLine;
            lbStyle.Text = t.Style;

            lbDayTarget.Text = String.Format("{0:N0}",Math.Ceiling(t.DayTarget)) + " PCS";
            lbDayFinish.Text = String.Format("{0:N0}",Math.Ceiling(t.DayFinish)) +" PCS";

            lbTotalTarget.Text = String.Format("{0:N0}",Math.Ceiling(t.TotalTarget)) + " PCS";
            lbTotalFinish.Text = String.Format("{0:N0}",Math.Ceiling(t.TotalFinish)) + " PCS";

            lblPersent.Text = t.Percent + " %";
           
        }

        private void frmTarget_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frmTarget_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sendInfo != null)
            {
                sendInfo(Int16.Parse(lbDayFinish.Text.Replace(" PCS", "")));
            }
        }

        private void frmTarget_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add)
            {
                
                int soLuongTang = Int16.Parse(lbDayFinish.Text.Replace(" PCS",""));
                int chiPhiNgay = Int16.Parse(lbDayTarget.Text.Replace(" PCS",""));
                soLuongTang += 1;
                lbDayFinish.Text = String.Format("{0:N0}", Math.Ceiling((decimal)soLuongTang) + " PCS");
                lblPersent.Text = (soLuongTang * 100)/chiPhiNgay + " %";
            }

            if (e.KeyCode == Keys.Subtract)
            {
                int soLuongGiam = Int16.Parse(lbDayFinish.Text.Replace(" PCS", ""));
                int chiPhiNgay = Int16.Parse(lbDayTarget.Text.Replace(" PCS", ""));
                soLuongGiam -= 1;
                lbDayFinish.Text = String.Format("{0:N0}", Math.Ceiling((decimal)soLuongGiam) + " PCS");
                lblPersent.Text = (soLuongGiam * 100) / chiPhiNgay + " %";
            }
        }

        private void frmTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
