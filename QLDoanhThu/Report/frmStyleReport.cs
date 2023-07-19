using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLDoanhThu.Report
{
    public partial class frmStyleReport : Form
    {
        private StyleReportBUS s;
        private StyleReportBUS t;
        public frmStyleReport()
        {
            InitializeComponent();
            s = new StyleReportBUS();
            t = new StyleReportBUS();
        }

        private void frmStyleReport_Load(object sender, EventArgs e)
        {
            try
            {
                gcData.DataSource = s.GetDataStyle().OrderByDescending(cp => cp.Ngay);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiDoanhThuStyle();
        }
        public void HienThiDoanhThuStyle()
        {
            int row = gvData.FocusedRowHandle;
            if (row >= 0)
            {
                string idStyle = gvData.GetRowCellValue(row, col_IDStyle).ToString();
                lbTongStyle.Text = "Mã: " + idStyle + " / Tổng " + String.Format("{0:c2}", Convert.ToDecimal(t.GetDataDoanhThuStyle(idStyle).Sum(cp => cp.Tong)));
                gcDataTong.DataSource = t.GetDataDoanhThuStyle(idStyle);
            }
        }
    }
}
