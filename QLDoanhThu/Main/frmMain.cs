using System;
using System.Windows.Forms;
using QLDoanhThu.ChiPhi;
using QLDoanhThu.DoanhThu;
using QLDoanhThu.Report;
using QLDoanhThu.Style;
using QLDoanhThu.ThongTin;

namespace QLDoanhThu.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ActiveChildForm(string name)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == name)
                {
                    child.Activate();
                    break;
                }
            }
        }

        protected bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name == name)
                {
                    check = true;
                    break;
                }
            }

            return check;
        }
        private void InactiveChildForm(string name)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name != name)
                {
                    child.Close();
                }

            }
        }
        private void XưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmXuong"))
            {
                frmXuong frmXuong = new frmXuong();
                frmXuong.MdiParent = this;
                frmXuong.Show();
                InactiveChildForm("frmXuong");
            }
            else
            {
                ActiveChildForm("frmXuong");
                InactiveChildForm("frmXuong");
            }
        }

        private void ChuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmChuyen"))
            {
                frmChuyen f = new frmChuyen();
                f.MdiParent = this;
                f.Show();
                InactiveChildForm("frmChuyen");
            }
            else
            {
                ActiveChildForm("frmChuyen");
                InactiveChildForm("frmChuyen");
            }

        }

        private void ChiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmChiPhi"))
            {
                frmChiPhi f = new frmChiPhi();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActiveChildForm("frmChiPhi");
            }
        }

        private void DoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDoanhThu"))
            {
                frmDoanhThu f = new frmDoanhThu();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActiveChildForm("frmDoanhThu");
            }
        }

        private void StyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmStyle"))
            {
                frmStyle frm = new frmStyle();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmStyle");
            }
        }

        private void chuyềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (!CheckExitsForm("frmShowDetailLine"))
            //{
            //    frmShowDetailLine f = new frmShowDetailLine();
            //    f.MdiParent = this;
            //    f.Show();
            //}
            //else
            //{
            //    ActiveChildForm("frmShowDetailLine");
            //}
            if (!CheckExitsForm("frmBaoCao"))
            {
                frmBaoCao f = new frmBaoCao();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActiveChildForm("frmBaoCao");
            }
        }

        private void reportStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmStyleReport"))
            {
                frmStyleReport f = new frmStyleReport();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActiveChildForm("frmStyleReport");
            }
        }

        private void reportChiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmChiPhiReport"))
            {
                frmChiPhiReport f = new frmChiPhiReport();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActiveChildForm("frmChiPhiReport");
            }
        }

        private void reportDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDoanhThuReport"))
            {
                frmDoanhThuReport f = new frmDoanhThuReport();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActiveChildForm("frmDoanhThuReport");
            }
        }
    }
}
