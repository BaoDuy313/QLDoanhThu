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
    public partial class frmDoanhThuReport : Form
    {
        private DoanhThuReportBUS dt;
        
        public frmDoanhThuReport()
        {
            InitializeComponent();
            dt = new DoanhThuReportBUS();
        }

        private void frmDoanhThuReport_Load(object sender, EventArgs e)
        {
            try
            {
                dtThoiGian.CustomFormat = "yyyy";
                dtThoiGian.MaxDate = DateTime.Now;
                var time = dtThoiGian.Value;
                
                HienThiChartDoanhThuNam();
                HienThiChartDoanhThuThang(time);
                gcData.DataSource = dt.GetDataDoanhThu(time).OrderByDescending(dt => dt.Ngay);
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
                HienThiChartDoanhThuThang(time);
                gcData.DataSource = dt.GetDataDoanhThu(time).OrderByDescending(dt => dt.Ngay);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        public void HienThiCharDoanhThuNgay(DateTime time)
        {
            try
            {
                decimal tong = 0;
                foreach(var item in dt.GetDataDoanhThuNgay(time))
                {
                    tong += (decimal)item.Tong;
                }
                chartDoanhThuNgay.Titles.Clear();
                Title title = new Title();
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                title.Text = "Doanh Thu Ngày " + time.ToString("dd/MM/yyyy") + " : " + tong.ToString("C2");
                chartDoanhThuNgay.Titles.Add(title);
                chartDoanhThuNgay.Series["Doanh Thu"].XValueMember = "ThoiGian";
                chartDoanhThuNgay.Series["Doanh Thu"].YValueMembers = "Tong";
                chartDoanhThuNgay.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C0";
                //chartDoanhThuNgay.ChartAreas["ChartArea1"].AxisY.LabelStyle.Interval = 1;
                chartDoanhThuNgay.Series["Doanh Thu"].Label = "#VALY{C0}";
                chartDoanhThuNgay.DataSource = dt.GetDataDoanhThuNgay(time).OrderBy(dt => dt.ThoiGian);
                chartDoanhThuNgay.DataBind();
            }
            catch
            {

            }
        }
        public void HienThiChartDoanhThuNam()
        {
            try
            {
                chartDoanhThuNam.Titles.Clear();
                Title title = new Title();
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                title.Text = "Doanh Thu Các Năm ";
                chartDoanhThuNam.Titles.Add(title);
                chartDoanhThuNam.Series["Doanh Thu"].XValueMember = "ThoiGian";
                chartDoanhThuNam.Series["Doanh Thu"].YValueMembers = "Tong";
                chartDoanhThuNam.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C0";
                chartDoanhThuNam.Series["Doanh Thu"].Label = "#VALY{C0}";
                chartDoanhThuNam.DataSource = dt.GetDataDoanhThuNam().OrderBy(x => x.ThoiGian);
                chartDoanhThuNam.DataBind();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        public void HienThiChartDoanhThuThang(DateTime time)
        {
            try
            {
                decimal tong = 0;
                foreach(var item in dt.GetDataDoanhThuThang(time))
                {
                    tong += (decimal)item.Tong;
                }
                chartDoanhThuThang.Titles.Clear();
                Title title = new Title();
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                title.Text = "Doanh Thu Các Tháng Của Năm " + time.Year + " : " + tong.ToString("C0");
                chartDoanhThuThang.Titles.Add(title);
                chartDoanhThuThang.Series["Doanh Thu"].XValueMember = "ThoiGian";
                chartDoanhThuThang.Series["Doanh Thu"].YValueMembers = "Tong";
                chartDoanhThuThang.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C0";
                chartDoanhThuThang.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
                chartDoanhThuThang.Series["Doanh Thu"].Label = "#VALY{C0}";
                chartDoanhThuThang.DataSource = dt.GetDataDoanhThuThang(time);
                chartDoanhThuThang.DataBind();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void gcData_MouseClick(object sender, MouseEventArgs e)
        {
            int row = gvData.FocusedRowHandle;
            if(row>= 0)
            {
                DateTime time = (DateTime)gvData.GetRowCellValue(row, colNgay);
                HienThiCharDoanhThuNgay(time);
            }
        }
    }
}
