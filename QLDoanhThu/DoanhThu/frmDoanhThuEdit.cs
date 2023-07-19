using System;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.DoanhThu
{
    public partial class frmDoanhThuEdit : Form
    {
        public delegate void SendData(int id, string line, string style, int soluong,int mucTieu);

        public SendData Send;

        public delegate void Reload();

        public event Reload reloading;

        private DoanhThuBUS doanhThuBus;
        public frmDoanhThuEdit()
        {
            InitializeComponent();
            Send = new SendData(GetDataFromDoanhThu);
            doanhThuBus = new DoanhThuBUS();
        }

        public void GetDataFromDoanhThu(int id, string line, string style, int soluong,int mucTieu)
        {
            txtID.Text = id.ToString();
            txtLine.Text = line;
            txtStyle.Text = style;
            txtSoLuong.Text = soluong.ToString();
            txtMucTieu.Text = mucTieu.ToString();
        }

        private void FrmDoanhThuEdit_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Text.Trim()==null||txtID.Text.Trim()==""||txtSoLuong.Text.Trim()==null||txtSoLuong.Text.Trim()==""||String.IsNullOrEmpty(txtMucTieu.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!", "thông báo", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text);
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                int muctieu = Convert.ToInt32(txtMucTieu.Text);
                try
                {
                    doanhThuBus.UpdateDoanhThuAndMucTieu(id,soluong,muctieu);
                    if (reloading!=null)
                    {
                        reloading();
                        MessageBox.Show("Cập nhật số lượng thành công!", "thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}
