using System;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.ThongTin
{
    public partial class frmChuyenHandle : Form
    {
        private ChuyenBUS c;
        private XuongBUS x;

        public delegate void LoadData();

        public event LoadData loading;

        public delegate void SendData(string idfac, string idline, string name, bool status);

        public SendData Sending;
        public frmChuyenHandle()
        {
            InitializeComponent();
            c = new ChuyenBUS();
            x = new XuongBUS();
            Sending = new SendData(GetDataTuDelegate);
        }

        public void GetDataTuDelegate(string idfac, string idline, string name,bool status)
        {
            txtID.Text = idline;
            txtName.Text = name;
          
            lookUpEditFac.EditValue = idfac;
            txtID.Enabled = false;

            ckStatusFac.Checked = status;


        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Enabled == false)
            {
                if ( txtName.Text.Trim() == "" || txtName.Text.Trim() == null || lookUpEditFac.EditValue == null)
                {
                    MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string idline = txtID.Text.Trim().ToString();
                    string name = txtName.Text.ToString();
                    string idfac = lookUpEditFac.EditValue.ToString();
                    bool status = Convert.ToBoolean(ckStatusFac.Checked.ToString());
                    try
                    {
                        c.UpdateDataChuyen(idline, idfac, name, status);
                        if (loading!=null)
                        {
                            loading();
                        }
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK,
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
                if (txtID.Text.Trim() == "" || txtID.Text.Trim() == null || txtName.Text.Trim() == "" || txtName.Text.Trim() == null || lookUpEditFac.EditValue == null)
                {
                    MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string idline = txtID.Text.Trim().ToString();
                    string name = txtName.Text.ToString();
                    string idfac = lookUpEditFac.EditValue.ToString();
                    bool status = Convert.ToBoolean(ckStatusFac.Checked.ToString());
                    try
                    {
                        c.InsertDataChuyen(idfac, idline, name, status);
                        if (loading != null)
                        {
                            loading();
                        }
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Trùng mã, ID này đã nhập rồi");
                    }


                }
            }
           
        }

        private void FrmChuyenHandle_Load(object sender, EventArgs e)
        {
            lookUpEditFac.Properties.DataSource = x.GetDataXuongCheck();
            lookUpEditFac.Properties.DisplayMember = "Name";
            lookUpEditFac.Properties.ValueMember = "IDFac";
        }
    }
}
