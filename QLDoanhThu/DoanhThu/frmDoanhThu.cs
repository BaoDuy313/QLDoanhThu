using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.DoanhThu
{
    public partial class frmDoanhThu : Form
    {
        private DoanhThuBUS d;
        private string matkhau;
        public frmDoanhThu()
        {
            InitializeComponent();
            d= new DoanhThuBUS();
        }

        private void FrmDoanhThu_Load(object sender, EventArgs e)
        {
            listboxXuong.DataSource = d.GetDataXuong();
            listboxXuong.DisplayMember = "Name";
            listboxXuong.ValueMember = "IDFac";

            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = d.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";

            string Namefac = listboxXuong.GetItemText(listboxXuong.SelectedIndex);
            lbl_fac.Text = Namefac;

            string NameLine = listboxChuyen.GetItemText(listboxChuyen.SelectedIndex);
            lblLine.Text = NameLine;

        }

        private void ListboxXuong_Click(object sender, EventArgs e)
        {
            string idfac = listboxXuong.SelectedValue.ToString();
            listboxChuyen.DataSource = d.GetDataChuyenTheoMa(idfac);
            listboxChuyen.DisplayMember = "Name";
            listboxChuyen.ValueMember = "IDLine";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmDoanhThuHandle frm = new frmDoanhThuHandle();
            string idline = listboxChuyen.SelectedValue.ToString();
            frm.sending(idline);
            frm.loading += Frm_loading;
            frm.ShowDialog();
        }

        private void Frm_loading()
        {
            gcData.DataSource = d.GetDataDoanhThu(listboxChuyen.SelectedValue.ToString());
        }

        private void ListboxXuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Namefac = listboxXuong.GetItemText(listboxXuong.SelectedIndex);
            lbl_fac.Text = Namefac;
        }

        private void ListboxChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NameLine = listboxChuyen.GetItemText(listboxChuyen.SelectedIndex);
            lblLine.Text = NameLine;
          
            
        }

        private void ListboxChuyen_Click(object sender, EventArgs e)
        {
             gcData.DataSource = d.GetDataDoanhThu(listboxChuyen.SelectedValue.ToString());
        }

        private void PopupComleteDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if (row>=0)
            {
                string tinhtrang = gvData.GetRowCellValue(row, colTinhTrang).ToString();
                int id = Convert.ToInt32(gvData.GetRowCellValue(row, col_ID).ToString());
                if (tinhtrang.Equals("Processing"))
                {
                    try
                    {
                        d.UpdateTinhTrangDoanhThu(id);
                        gvData.SetFocusedRowCellValue(colTinhTrang.FieldName,"Completed");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
               
            }
        }

        private void GvData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int row = gvData.FocusedRowHandle;
                if (row>=0)
                {
                    popupMenu1.ShowPopup(barManager1,new Point(MousePosition.X,MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
        }

        private void PopupDeleteDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if (row>=0)
            {
                int id = Convert.ToInt32(gvData.GetRowCellValue(row, col_ID).ToString());
                try
                {
                    frmXacNhanXoa frm = new frmXacNhanXoa();
                    frm.deleting += Frm_deleting;
                    frm.ShowDialog();
                    if (matkhau=="2019")
                    {
                        d.DeleteDoanhThu(id);
                        gvData.DeleteRow(row);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void Frm_deleting(string matkhau)
        {
            this.matkhau = matkhau;
        }

        private void PopupEditDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if (row>=0)
            {
                int id = Convert.ToInt32(gvData.GetRowCellValue(row, col_ID).ToString());
                string line = gvData.GetRowCellValue(row, colLine).ToString();
                string style = gvData.GetRowCellValue(row, colStyle).ToString();
                int soluong = Convert.ToInt32(gvData.GetRowCellValue(row, colSoLuong).ToString());
                int muctieu = gvData.GetRowCellValue(row, colMucTieu) == null
                    ? 0
                    : Convert.ToInt32(gvData.GetRowCellValue(row, colMucTieu));

                frmDoanhThuEdit frm = new frmDoanhThuEdit();
                frm.Send(id, line, style, soluong,muctieu);
                frm.reloading += Frm_reloading;
                frm.ShowDialog();
            }
        }

        private void Frm_reloading()
        {
             gcData.DataSource = d.GetDataDoanhThu(listboxChuyen.SelectedValue.ToString());
        }

        private void popupEditHours_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if (row >= 0)
            {
                int id = Convert.ToInt32(gvData.GetRowCellValue(row, col_ID).ToString());
                
                frmDoanhThuGioEdit frm = new frmDoanhThuGioEdit();
                frm.CallFuncGetData(id);
                frm.ShowDialog();
            }
        }
    }
}
