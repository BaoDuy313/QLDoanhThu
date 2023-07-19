using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;

namespace QLDoanhThu.Report
{
    public partial class frmChiPhiReport : Form
    {
        private ChiPhiReportBUS cp;
        public frmChiPhiReport()
        {
            InitializeComponent();
            cp = new ChiPhiReportBUS();
        }

        private void frmChiPhiReport_Load(object sender, EventArgs e)
        {
            try
            {
                dtThoiGian.CustomFormat = "yyyy";
                dtThoiGian.MaxDate = DateTime.Now;

                var time = dtThoiGian.Value;
                HienThiChartChiPhiNam();
                HienThiChartChiPhiThang(time);
                gcData.DataSource = cp.GetDataChiPhi(time).OrderByDescending(cp => cp.Ngay);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void dtThoiGian_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var time = dtThoiGian.Value;
                HienThiChartChiPhiThang(time);
                gcData.DataSource = cp.GetDataChiPhi(time).OrderByDescending(cp => cp.Ngay);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        public void HienThiChartChiPhiNam()
        {
            try
            {
                chartChiPhiNam.Titles.Clear();
                Title title = new Title();
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                title.Text = "Chi Phí Các Năm";
                chartChiPhiNam.Titles.Add(title);
                chartChiPhiNam.Series["Chi Phí"].XValueMember = "ThoiGian";
                chartChiPhiNam.Series["Chi Phí"].YValueMembers = "Tong";
                chartChiPhiNam.Series["Chi Phí"].Label = "#VALY{C0}";
                chartChiPhiNam.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C0";
                chartChiPhiNam.DataSource = cp.GetDataChiPhiNam();
                chartChiPhiNam.DataBind();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        public void HienThiChartChiPhiThang(DateTime time)
        {
            try
            {
                decimal tong = 0;
                foreach(var item in cp.GetDataChiPhiThang(time))
                {
                    tong += (decimal)item.Tong;
                }
                chartChiPhiThang.Titles.Clear();
                Title title = new Title();
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                title.Text = "Chi Phí Tháng Của Năm " + dtThoiGian.Value.Year + " : " + tong.ToString("C2");
                chartChiPhiThang.Titles.Add(title);
                chartChiPhiThang.Series["Chi Phí"].XValueMember = "ThoiGian";
                chartChiPhiThang.Series["Chi Phí"].YValueMembers = "Tong";
                chartChiPhiThang.Series["Chi Phí"].Label = "#VALY{C0}";
                chartChiPhiThang.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C0";
                chartChiPhiThang.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
                chartChiPhiThang.DataSource = cp.GetDataChiPhiThang(time);
                chartChiPhiThang.DataBind();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
