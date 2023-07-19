using System;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.DoanhThu
{
    public partial class frmDoanhThuHandle : Form
    {
        public delegate void SendData(string str);

        public SendData sending;

        public delegate void LoadData();

        public event LoadData loading;
        private string idline;
        private DoanhThuBUS db;

        public frmDoanhThuHandle()
        {
            InitializeComponent();
            db = new DoanhThuBUS();
    
            sending = new SendData(GetDataSending);
        }

        public void GetDataSending(string idline)
        {
            this.idline = idline;
        }

        private void FrmDoanhThuHandle_Load(object sender, EventArgs e)
        {
            cmbStyle.Properties.DataSource = db.GetDataStyleTheoLine(idline);
            cmbStyle.Properties.DisplayMember = "ID";
            cmbStyle.Properties.ValueMember = "ID";

            cmbChiPhi.Properties.DataSource = db.GetDataChiPhiTheoLine(idline);
            cmbChiPhi.Properties.DisplayMember = "Name";
            cmbChiPhi.Properties.ValueMember = "ID";

            dateNgayNhap.EditValue = DateTime.Now;
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dateNgayNhap.EditValue==null || cmbStyle.EditValue == null || cmbChiPhi.EditValue ==null || txtMucTieu.EditValue == null)
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "thông báo", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DateTime ngaynhap = Convert.ToDateTime(dateNgayNhap.EditValue.ToString());
                int idChiPhi = Convert.ToInt32(cmbChiPhi.EditValue.ToString());
                string idStyle = cmbStyle.EditValue.ToString();
                int muctieu = Int32.Parse(txtMucTieu.Text);
                TimeSpan GioBD =  timeBD.Time.TimeOfDay;

                int count = db.CheckCoCTDTChua(ngaynhap, idChiPhi, idStyle);
                if (count > 0)
                {
                    MessageBox.Show("Doanh thu cho mã hàng này ngày hôm nay đã được tạo, vui lòng kiểm tra lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        db.InsertDataDoanhThu(ngaynhap, idChiPhi, idStyle, muctieu,GioBD);
                        if (loading != null)
                        {
                            loading();
                        }
                        MessageBox.Show("Nhập dữ liệu thành công", "thông báo", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);

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
