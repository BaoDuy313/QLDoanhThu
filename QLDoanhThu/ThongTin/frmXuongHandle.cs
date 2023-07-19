using System;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.ThongTin
{
    public partial class frmXuongHandle : Form
    {
        private XuongBUS xuongBus;

        public delegate void LoadData();
          public event LoadData loading;

        public delegate void Editdata(string id, string name, bool status);

        public Editdata editXuong;

      
        public frmXuongHandle()
        {
            InitializeComponent();
            xuongBus = new XuongBUS();
            
            editXuong = new Editdata(GetDataXuong);
        }

        public void GetDataXuong(string id, string name, bool status)
        {
            txtID.Text = id;
            txtName.Text = name;
            txtID.Enabled = false;
            ckStatus.Checked = status;
        }

        private void FrmXuongHandle_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Enabled == false)
            {
                if (txtName.Text.Trim() == "" || txtName.Text.Trim() == null)
                {
                     MessageBox.Show("Cần nhập tên xưởng","thông báo",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                }
                else
                {
                    string id = txtID.Text.ToString();
                    string name = txtName.Text.ToString();
                    bool status = Convert.ToBoolean(ckStatus.Checked.ToString());
                    xuongBus.UpdateDataXuong(id, name, status);
                    if (loading!=null)
                    {
                        loading();
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
              
            }
            else
            {
                if (txtID.Text.Trim() == null || txtID.Text.Trim() == "" || txtName.Text.Trim() == null || txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Cần nhập đủ thông tin ở trên", "Thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string id = txtID.Text.ToString();
                    string name = txtName.Text.ToString();
                    bool status = Convert.ToBoolean(ckStatus.Checked.ToString());
                    xuongBus.InsertDataXuong(id, name, status);

                    if (loading != null)
                    {
                        loading();
                    }

                    MessageBox.Show("Thêm dữ liệu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }
    }
}
