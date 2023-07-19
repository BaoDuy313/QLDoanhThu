using System;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.DoanhThu
{
    public partial class frmDoanhThuGioEdit : Form
    {
        public delegate void GetData(int id);

        public GetData CallFuncGetData;
        private int id;
        private DoanhThuBUS d;
        private DoanhThuGioEdit getData;
        private HienThiDoanhThuTungGioBUS h;
        public frmDoanhThuGioEdit()
        {
            InitializeComponent();
            CallFuncGetData = new GetData(GetDataID);
            d = new DoanhThuBUS();
            h = new HienThiDoanhThuTungGioBUS();
        }

        private void GetDataID(int id)
        {
            this.id = id;
        }

        private void frmDoanhThuGioEdit_Load(object sender, EventArgs e)
        {
            getData = d.GetDataDoanhThuTungGio(id);
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            txtID.Text = getData.ID.ToString();
            txtLine.Text = getData.Line;
            txtStyle.Text = getData.Style;
            txtLan1.Text = getData.DTL1.ToString();
            txtLan2.Text = getData.DTL2.ToString();
            txtLan3.Text = getData.DTL3.ToString();
            txtLan4.Text = getData.DTL4.ToString();
            txtLan5.Text = getData.DTL5.ToString();
            txtLan6.Text = getData.DTL6.ToString();
            txtLan7.Text = getData.DTL7.ToString();
            txtLan8.Text = getData.DTL8.ToString();
            txtTangCa.Text = getData.DTOverTime.ToString();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int lan1 = String.IsNullOrEmpty(txtLan1.Text) ? -1 : Int32.Parse(txtLan1.Text);
            int lan2 = String.IsNullOrEmpty(txtLan2.Text) ? -1 : Int32.Parse(txtLan2.Text);
            int lan3 = String.IsNullOrEmpty(txtLan3.Text) ? -1 : Int32.Parse(txtLan3.Text);
            int lan4 = String.IsNullOrEmpty(txtLan4.Text) ? -1 : Int32.Parse(txtLan4.Text);
            int lan5 = String.IsNullOrEmpty(txtLan5.Text) ? -1 : Int32.Parse(txtLan5.Text);
            int lan6 = String.IsNullOrEmpty(txtLan6.Text) ? -1 : Int32.Parse(txtLan6.Text);
            int lan7 = String.IsNullOrEmpty(txtLan7.Text) ? -1 : Int32.Parse(txtLan7.Text);
            int lan8 = String.IsNullOrEmpty(txtLan8.Text) ? -1 : Int32.Parse(txtLan8.Text);
            int tangca = String.IsNullOrEmpty(txtTangCa.Text) ? -1 : Int32.Parse(txtTangCa.Text);

            try
            {
                h.UpdateMultiDoanhThuAndSoLuong(id,lan1,lan2,lan3,lan4,lan5,lan6,lan7,lan8,tangca);
               DialogResult result = MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result== DialogResult.OK)
                {
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
