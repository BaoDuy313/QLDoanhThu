using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.ThongTin
{
    public partial class frmChuyen : Form
    {
        private ChuyenBUS c;
        public frmChuyen()
        {
            InitializeComponent();
            c = new ChuyenBUS();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmChuyenHandle f = new frmChuyenHandle();
            f.loading += F_loading;
            f.ShowDialog();
        }

        private void F_loading()
        {
            gcData.DataSource = c.GetDataChuyen();
        }

        private void FrmChuyen_Load(object sender, EventArgs e)
        {
            gcData.DataSource = c.GetDataChuyen();
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

        private void PopupEditChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            string col_IDFac = "IDFac";
            string col_IDLine = "IDLine";
            string col_Name = "NameLine";

            Object valueIDFac = gvData.GetRowCellValue(row, col_IDFac);
            Object valueIDLine = gvData.GetRowCellValue(row, col_IDLine);
            Object valueName = gvData.GetRowCellValue(row, col_Name);
            Object valueStatus = gvData.GetRowCellValue(row,col_Status);

            frmChuyenHandle f = new frmChuyenHandle();
            f.Sending(valueIDFac.ToString(), valueIDLine.ToString(), valueName.ToString(), Convert.ToBoolean(valueStatus));
            f.loading += F_loading;
            f.ShowDialog();
        }

        private void PopupDeleteChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            string col_IDLine = "IDLine";
            Object valueIDLine = gvData.GetRowCellValue(row, col_IDLine);
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    c.DeleteDataChuyen(valueIDLine.ToString());
                    gvData.DeleteRow(row);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}
