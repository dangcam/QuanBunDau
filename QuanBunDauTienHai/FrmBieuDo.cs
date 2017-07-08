using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts;
using QuanBunDauTienHai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmBieuDo : RibbonForm
    {
        DataTable dt = null;
        BieuDoDAO bd = null;
        public FrmBieuDo()
        {
            InitializeComponent();
            bd = new BieuDoDAO();
        }
        private void LoadData(string Thang, string Nam)
        {
            if(Thang==null)
            {
                dt = bd.BieuDoNam(Nam);
                DataTable dataview = new DataTable();
                dataview.Columns.Add("THANG");
                dataview.Columns.Add("TONG", typeof(long));
                for (int i = 1; i < 13; i++)
                {
                    dataview.Rows.Add("Tháng " + i.ToString(), 0);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int j = int.Parse(dt.Rows[i][0].ToString()) - 1;
                    long tien = long.Parse(dt.Rows[i][1].ToString());
                    dataview.Rows[j][1] = tien;
                }
                chartControlThu.Series.Clear();
                Series s = new Series
                {
                    DataSource = dataview,
                    ArgumentScaleType = ScaleType.Qualitative,
                    ArgumentDataMember = "THANG",
                    ValueScaleType = ScaleType.Numerical
                };
                s.ValueDataMembers.AddRange(new string[] { "TONG" });
                s.Name = "Tổng Thu";
                chartControlThu.Series.Add(s);
                lblTieuDe.Text = "Năm " + txtNam.Text;
            }
            else
            {
                dt = bd.BieuDoThang(Thang, Nam);
                DataTable dataview = new DataTable();
                dataview.Columns.Add("NGAY");
                dataview.Columns.Add("TONG", typeof(long));
                for(int i = 1; i<32; i++)
                {
                    dataview.Rows.Add("Ngày " + i.ToString(), 0);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int j = int.Parse(dt.Rows[i][0].ToString()) - 1;
                    long tien = long.Parse(dt.Rows[i][1].ToString());
                    dataview.Rows[j][1] = tien;
                }
                chartControlThu.Series.Clear();
                Series s = new Series
                {
                    DataSource = dataview,
                    ArgumentScaleType = ScaleType.Qualitative,
                    ArgumentDataMember = "NGAY",
                    ValueScaleType = ScaleType.Numerical
                };
                s.ValueDataMembers.AddRange(new string[] { "TONG" });
                s.Name = "Tổng Thu";
                chartControlThu.Series.Add(s);
                lblTieuDe.Text = "Tháng " + txtThang.Text + " Năm " + txtNam.Text;
            }
        }
        private void FrmBieuDo_Load(object sender, EventArgs e)
        {
            
            txtThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            lblTieuDe.Text = "Tháng " + txtThang.Text + " Năm " + txtNam.Text;
            LoadData(txtThang.Text, txtNam.Text);
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            LoadData(txtThang.Text, txtNam.Text);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            LoadData(null, txtNam.Text);
        }

        private void radioButtonCot_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCot.Checked)
            {
                chartControlThu.Series[0].ChangeView(ViewType.Bar);
            }
        }

        private void radioButtonDuong_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDuong.Checked)
            {
                chartControlThu.Series[0].ChangeView(ViewType.Line);
            }
        }
    }
}
