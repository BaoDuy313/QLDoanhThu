using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.Style
{
    public partial class frmStyle : Form
    {
        private StyleBUS s;

        public frmStyle()
        {
            InitializeComponent();
            s = new StyleBUS();
        }

        private void FrmStyle_Load(object sender, EventArgs e)
        {
            listboxXuong.DataSource = s.GetDataXuong();
            listboxXuong.DisplayMember = "Name";
            listboxXuong.ValueMember = "IDFac";

            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = s.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";
        }

        private void ListboxXuong_Click(object sender, EventArgs e)
        {
            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = s.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";
        }

        private void ListboxChuyen_Click(object sender, EventArgs e)
        {
            gcData.DataSource = s.GetDataStyle(listboxChuyen.SelectedValue.ToString());
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmStyleHandle f = new frmStyleHandle();
            f.sending(listboxChuyen.SelectedValue.ToString());
            f.loading += F_loading;
            f.ShowDialog();
        }

        private void F_loading()
        {
            gcData.DataSource = s.GetDataStyle(listboxChuyen.SelectedValue.ToString());
        }

        private void GvData_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) != 0)
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

        private void PopupDeleteStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if (row >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var idStyle = gvData.GetRowCellValue(row, col_IDStyle).ToString();
                    try
                    {
                        s.DeleteDataStyle(idStyle);
                        gvData.DeleteRow(row);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
        }

        private void PopupCompleteStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int row = gvData.FocusedRowHandle;
            if (row >= 0)
            {
                string idStyle = gvData.GetRowCellValue(row, col_IDStyle).ToString();

                int count = s.CheckCompleteCTDT(idStyle);
                if (count > 0)
                {
                    MessageBox.Show("Bạn phải completed Doanh thu trước", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        s.UpDateStatus(idStyle);
                        MessageBox.Show("Hoàn tất mã hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gvData.SetFocusedRowCellValue(colTinhTrang.FieldName, "Completed");

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
        }

        private void PopupEditStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if (row >= 0)
            {
                string idstyle = gvData.GetRowCellValue(row, col_IDStyle).ToString();
                int soluong = Convert.ToInt32(gvData.GetRowCellValue(row, colSoLuong).ToString());
                decimal dongia = Convert.ToDecimal(gvData.GetRowCellValue(row, colDonGia).ToString());
                DateTime ngay = Convert.ToDateTime(gvData.GetRowCellValue(row, colNgay).ToString());
                string idline = gvData.GetRowCellValue(row, colIDLine).ToString();

                frmStyleHandle frm = new frmStyleHandle();
                frm.editing(idstyle, soluong, dongia, ngay, idline);
                frm.loading += Frm_loading;
                frm.ShowDialog();
            }
        }

        private void Frm_loading()
        {
            gcData.DataSource = s.GetDataStyle(listboxChuyen.SelectedValue.ToString());
        }
    }
}
