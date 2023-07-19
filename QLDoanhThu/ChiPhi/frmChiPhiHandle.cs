using System;
using System.Windows.Forms;
using  BUS;

namespace QLDoanhThu.ChiPhi
{
    public partial class frmChiPhiHandle : Form
    {
        public delegate void SendData(string id);

        public SendData sending;

        public Action<string , int , string , DateTime , int , string , int, decimal > SendEditData;



        public delegate void LoadData();

        public event LoadData Loading;

        private ChiPhiBUS c;
        private int id;
        private bool flagUpadate;
        public IChiPhi _ChiPhi;

        public frmChiPhiHandle(IChiPhi chiphi)
        {
            InitializeComponent();
            _ChiPhi = chiphi;
        }
        public frmChiPhiHandle()
        {
            InitializeComponent();
            sending = GetData;
            SendEditData = getEditData;
            c = new ChiPhiBUS();
            flagUpadate = false;
        }

        public void GetData(string idLine)
        {
            txtID.Text = idLine;
            txtID.Enabled = false;
            flagUpadate = false;
        }

        public void getEditData(string idline, int id, string name, DateTime ngay, int chiphi, string dvt,int ngaycong, decimal mo)
        {
            flagUpadate = true;

            txtID.Text = idline;
            txtName.Text = name;
            dateNgayNhap.EditValue = ngay;
            txtChiPhi.Text = $"{chiphi:0,0}".ToString();
            txtNgayCong.Text = ngaycong.ToString();
            //Update 2023
            txtMO.Text = mo.ToString("c2");
            if (dvt.Equals("USD"))
            {
                rdoUSD.Checked = true;
            }
            else
            {
                rdoVND.Checked = true;
            }

            this.id = id;
            txtID.Enabled = false;
        }

        private void FrmChiPhiHandle_Load(object sender, EventArgs e)
        {
            if (id==0)
            {
                 dateNgayNhap.DateTime=DateTime.Now;
            }
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            if (flagUpadate)
            {
                if (txtName.Text.Trim() == "" || txtName.Text.Trim() == null || txtChiPhi.Text.Trim() == "" || txtChiPhi.Text.Trim() == null||txtNgayCong.Text.Trim()==null||txtNgayCong.Text.Trim()==""||txtMO.Text.Trim()==null|| txtMO.Text.Trim() == "")
                {
                    MessageBox.Show("Cần nhập đủ thông tin", "thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    var name = txtName.Text;
                    var date = dateNgayNhap.DateTime.Date;
                    var chiphi = Convert.ToInt32(txtChiPhi.Text.ToString().Replace(",", ""));

                    var ngaycong = Convert.ToInt32(txtNgayCong.Text.ToString());
                    var dvt = rdoUSD.Checked ? "USD" : "VNĐ";
                    var mo = Convert.ToDecimal(txtMO.Text.ToString() != "" ? txtMO.Text.ToString().Replace("$", "") : "0.00");
                    try
                    {
                        //Update 2023
                        c.UpdateChiPhi(id,name,date,chiphi,dvt,ngaycong,mo);

                        Loading?.Invoke();

                        MessageBox.Show("Cập nhật dữ liệu thành công", "thông báo", MessageBoxButtons.OK,
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
                if (txtName.Text.Trim() == "" || txtName.Text.Trim() == null || txtChiPhi.Text.Trim() == "" || txtChiPhi.Text.Trim() == null||txtNgayCong.Text.Trim()==""||txtNgayCong.Text.Trim()== null||txtMO.Text.Trim() == null || txtMO.Text.Trim() == "")
                {
                    MessageBox.Show("Cần nhập đủ thông tin", "thông báo", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    var name = txtName.Text.ToString();
                    var date = dateNgayNhap.DateTime.Date;
                    var chiphi = Convert.ToInt32(txtChiPhi.Text.ToString().Replace(",", ""));
                    var ngaycong = Convert.ToInt32(txtNgayCong.Text.ToString());
                    var dvt = rdoUSD.Checked ? "USD" : "VNĐ";
                    var idline = txtID.Text.ToString();
                    //Update 2023
                    var mo = Convert.ToDecimal(txtMO.Text.ToString()!= ""? txtMO.Text.ToString().Replace("$", ""):"0.00");
                    try
                    {
                        //Update 2023
                        c.InsertChiPhi(name, date, chiphi, dvt, idline, ngaycong, mo);

                        Loading?.Invoke();

                        MessageBox.Show("Thêm dữ liệu thành công", "thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();

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
