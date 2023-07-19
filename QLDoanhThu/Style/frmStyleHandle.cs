using System;
using System.Windows.Forms;
using  BUS;

namespace QLDoanhThu.Style
{
    public partial class frmStyleHandle : Form
    {
        private StyleBUS s;
        public delegate void SendData(string str1);

        public SendData sending;

        public delegate void EditData(string s1, int s2, decimal s3, DateTime s4,string s5);

        public EditData editing;

        public delegate void LoadData();

        public event LoadData loading;
        private bool flagEdit;
        public frmStyleHandle()
        {
            InitializeComponent();
            sending = new SendData(GetIDLineFromDelegate);
            editing = new EditData(GetDataEdit);
            s = new StyleBUS();
        }

        public void GetDataEdit(string idstyle, int soluong, decimal dongia, DateTime ngay,string idline)
        {
            txtIDStyle.Text = idstyle;
            txtSoLuong.Text = soluong.ToString("##,###");
            txtDonGia.Text = dongia.ToString("C2");
            dateNgayNhap.EditValue = ngay;
            txtIDLine.Text = idline;
            flagEdit = true;
            txtIDStyle.Enabled = false;
        }

        private void GetIDLineFromDelegate(string idline)
        {
            txtIDLine.Text = idline;
            flagEdit = false;
        }

        private void FrmStyleHandle_Load(object sender, EventArgs e)
        {
            if (flagEdit==false)
            {
                dateNgayNhap.EditValue = DateTime.Now.Date;
            }
            
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagEdit==true)
            {
                if (txtIDStyle.Text.Trim() == "" || txtIDLine.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtDonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Cần nhập đủ thông tin", "thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string idline = txtIDLine.Text.ToString();
                    string idstyle = txtIDStyle.Text.Trim();
                    int solong = Convert.ToInt32((txtSoLuong.Text.ToString()).Replace(",", "")); 
                    decimal dongia = Convert.ToDecimal(txtDonGia.Text.ToString().Replace("$",""));
                    DateTime ngay = Convert.ToDateTime(dateNgayNhap.EditValue.ToString());

                    try
                    {
                        s.UpdateDataStyle(idstyle, solong, dongia, ngay);
                        if (loading != null)
                        {
                            loading();
                        }
                        MessageBox.Show("Cập nhật dữ liệu thành công", "thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
            else
            {
                if (txtIDStyle.Text.Trim() == "" || txtIDLine.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtDonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Cần nhập đủ thông tin", "thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string idline = txtIDLine.Text.ToString();
                    string idstyle = txtIDStyle.Text.Trim();
                    int solong = Convert.ToInt32((txtSoLuong.Text.ToString()).Replace(",", ""));
                    decimal dongia = Convert.ToDecimal(txtDonGia.Text.ToString());
                    DateTime ngay = Convert.ToDateTime(dateNgayNhap.EditValue.ToString());

                    try
                    {
                        s.InsertDataStyle(idstyle, solong, dongia, ngay, idline);
                        if (loading != null)
                        {
                            loading();
                        }
                        MessageBox.Show("Thêm dữ liệu thành công", "thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
            
        }
    }
}
