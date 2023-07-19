using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.ThongTin
{
    public partial class frmXuong : Form
    {
        private XuongBUS xuong;
        public frmXuong()
        {
            InitializeComponent();
            xuong = new XuongBUS();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmXuongHandle frmXuong = new frmXuongHandle();
            frmXuong.loading += FrmXuong_loading;
            frmXuong.ShowDialog();
        }

        private void FrmXuong_loading()
        {
            gcData.DataSource = xuong.GetDataXuong();
        }

        private void FrmXuong_Load(object sender, EventArgs e)
        {
            gcData.DataSource = xuong.GetDataXuong();
        }

        private void GvData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowPosition = this.gvData.FocusedRowHandle;
                string col_ID = "IDFac";
                string col_Name = "Name";
                Object value_ID = this.gvData.GetRowCellValue(rowPosition, col_ID);
                Object value_Name = this.gvData.GetRowCellValue(rowPosition, col_Name);
                if (rowPosition >= 0)
                {
                    popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PopupEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowPosition = gvData.FocusedRowHandle;
            string col_id = "IDFac";
            Object value_ID = gvData.GetRowCellValue(rowPosition, col_id);
            Object value_Name = gvData.GetRowCellValue(rowPosition, col_Name);
            Object value_Status = gvData.GetRowCellValue(rowPosition, col_Status);
            frmXuongHandle f = new frmXuongHandle();
            f.editXuong(value_ID.ToString(), value_Name.ToString(), Convert.ToBoolean(value_Status));
            f.loading += FrmXuong_loading;
            f.ShowDialog();
        }



        private void PopupDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowPosition = gvData.FocusedRowHandle;
            string col_id = "IDFac";
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var value_ID = gvData.GetRowCellValue(rowPosition, col_id);
                try
                {
                    xuong.DeleteDataXuong(value_ID.ToString());
                    gvData.DeleteRow(rowPosition);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}
