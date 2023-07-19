using System;
using System.Linq;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.HienThi
{
    public partial class frmThongTinShow : Form
    {
        private HienThiDoanhThuControlBUS h;

        //update 02/03/2020
        IQueryable<DoanhThuCustomBUS> getData;
    
        public frmThongTinShow()
        {
            InitializeComponent();
            h = new HienThiDoanhThuControlBUS();
        }

        private void FrmThongTinShow_Load(object sender, EventArgs e)
        {
            listboxXuong.DataSource = h.GetDataXuong();
            listboxXuong.DisplayMember = "Name";
            listboxXuong.ValueMember = "IDFac";

            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = h.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";

            string idline = listboxChuyen.SelectedValue.ToString();
            gcData.DataSource = h.GetDataDoanhThu(idline);
            //update 02/03/2020
            
        }

        private void ListboxXuong_Click(object sender, EventArgs e)
        {
            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = h.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";
        }

        private void ListboxChuyen_Click(object sender, EventArgs e)
        {
            var idline = listboxChuyen.SelectedValue.ToString();
            // gcData.DataSource = h.GetDataDoanhThu(idline);
            //update 02/03/2020
            
            // var test = h.GetDataDoanhThu(idline);
            getData = h.GetDataDoanhThu(idline);

            var test = (from s in getData
                        select s).Count();
            if (test > 1)
            {
                MessageBox.Show("Vui lòng Completed doanh thu ngày trước", "Bạn chưa Completed doanh thu",
                           MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                gcData.DataSource = getData;
            }
           
            /*if($"{DateTime.Now:d}" == $"{getData.OrderByDescending(x=>x.ID).Select(a => a.Ngay).FirstOrDefault():d}") 
            {
                gcData.DataSource = getData;
                  
            }*/

            //  MessageBox.Show("Bằng nhau nha");

        }

        private void LbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbHienThi_Click(object sender, EventArgs e)
        {
            int rowCount = gvData.RowCount;
            if (rowCount>0)
            {
                int rowHandle = gvData.FocusedRowHandle;
                if (rowHandle>=0)
                {
                    int idChiPhi = Convert.ToInt32(gvData.GetRowCellValue(rowHandle, colIDChiPhi).ToString());
                    int mucTieu = Int32.Parse(gvData.GetRowCellValue(rowHandle,colMucTieu).ToString());
                    int idCTDT = Int32.Parse(gvData.GetRowCellValue(rowHandle,col_ID).ToString());
                    /*frmShow frm = new frmShow();
                    frm.getIDChiPhi(idChiPhi);
                    frm.ShowDialog();*/

                    /*frmHienThiChiTietDT frm = new frmHienThiChiTietDT();
                    frm.GetIdChiPhi(idChiPhi);
                    frm.ShowDialog();*/
                  
                    frmShowDetail frm = new frmShowDetail();
                    frm.getData(idChiPhi,mucTieu,idCTDT);
                    frm.Show();


                }
            }
        }
    }
}
