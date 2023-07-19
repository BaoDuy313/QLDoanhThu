using System;
using System.Windows.Forms;

namespace QLDoanhThu.DoanhThu
{
    public partial class frmXacNhanXoa : Form
    {
        public delegate void Delete(string matkhau);

        public event Delete deleting;
        public frmXacNhanXoa()
        {
            InitializeComponent();
        }

        private void FrmXacNhanXoa_Load(object sender, EventArgs e)
        {

        }

        private void TxtMaKhauXoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string matkhau = txtMaKhauXoa.Text.ToString();
                if (deleting!=null)
                {
                    deleting(matkhau);
                }
                this.Close();
            }
        }
    }
}
