using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.ChiPhi
{
    public partial class frmChiPhi : Form, IChiPhi
    {
        private XuongBUS x;
        private ChiPhiBUS c;

        public frmChiPhi()
        {
            InitializeComponent();
            x = new XuongBUS();
            c = new ChiPhiBUS();
        }

        private void FrmChiPhi_Load(object sender, EventArgs e)
        {
            listboxXuong.DataSource = x.GetDataXuongCheck();
            listboxXuong.DisplayMember = "Name";
            listboxXuong.ValueMember = "IDFac";

            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = c.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";
        }

        private void ListboxXuong_Click(object sender, EventArgs e)
        {

            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = c.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";



        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmChiPhiHandle f = new frmChiPhiHandle();
            f.Loading += ReloadData;
            f.sending(listboxChuyen.SelectedValue.ToString());
            f.ShowDialog();
            /*frmChiPhiHandle f = new frmChiPhiHandle(this);
            f.ShowDialog();*/
        }

        private void ReloadData()
        {
            gcData.DataSource = c.GetDataChiPhiTheoMa(listboxChuyen.SelectedValue.ToString());
        }

        private void ListboxChuyen_Click(object sender, EventArgs e)
        {

            gcData.DataSource = c.GetDataChiPhiTheoMa(listboxChuyen.SelectedValue.ToString());
        }



        private void PopupCompleteChiPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            string col_id = "IDChiPhi";
            try
            {
                c.UpdateTinhTrang(Convert.ToInt32(gvData.GetRowCellValue(row, col_id).ToString()));
                MessageBox.Show("Hoàn tất chi phí", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvData.SetFocusedRowCellValue(col_TinhTrang.FieldName, "Completed");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void PopupDeleteChiPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int row = gvData.FocusedRowHandle;
                int id = Convert.ToInt32(gvData.GetRowCellValue(row, col_ID.FieldName).ToString());
                try
                {
                    c.DeleteChiPhi(id);
                    gvData.DeleteRow(row);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void PopupEditChiPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            string idline = listboxChuyen.SelectedValue.ToString();
            int id = Convert.ToInt32(gvData.GetRowCellValue(row, col_ID.FieldName).ToString());
            string name = gvData.GetRowCellValue(row, col_Name.FieldName).ToString();
            DateTime ngay = Convert.ToDateTime(gvData.GetRowCellValue(row, col_Ngay.FieldName).ToString());
            int chiphi = Convert.ToInt32(gvData.GetRowCellValue(row, col_ChiPhi.FieldName).ToString());
            string dvt = gvData.GetRowCellValue(row, col_DVT.FieldName).ToString();
            int ngaycong = Convert.ToInt32(gvData.GetRowCellValue(row, colNgayCong.FieldName).ToString());
            //Update 2023 
            decimal mo = Convert.ToDecimal(gvData.GetRowCellValue(row, col_MO.FieldName).ToString());

            frmChiPhiHandle f = new frmChiPhiHandle();
            f.SendEditData(idline, id, name, ngay, chiphi, dvt, ngaycong, mo);
            f.Loading += ReloadData;
            f.ShowDialog();
        }

        private void GvData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int row = gvData.FocusedRowHandle;
                if (row >= 0)
                {
                    popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
        }

        private void ListboxXuong_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {

        }

        public void LoadData()
        {
            MessageBox.Show("gọi interface");
        }
    }
}
