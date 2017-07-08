using DevExpress.XtraBars.Ribbon;
using QuanBunDauTienHai.DAO;
using QuanBunDauTienHai.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmDSHoaDon : RibbonForm
    {
        DataTable dt = null;
        DataRow dr = null;
        DSHoaDonDAO hd = null;
        long tongTien = 0;
        int banTT = 0, banHuy = 0;
        long tienHuy = 0;
        string tatca = "Tất cả";
        public FrmDSHoaDon()
        {
            InitializeComponent();
            hd = new DSHoaDonDAO();
        }
        private void LoadData(DateTime date, string nguoiDung)
        {
            dt = null;
            if(tatca.Equals(nguoiDung))
            {
                nguoiDung = null;
            }
            try
            {
                tongTien = 0;
                banTT = 0;
                tienHuy = 0;
                banHuy = 0;
                string ngay = date.ToString("yyyy-MM-dd");
                if (nguoiDung == null)
                {
                    dt = hd.DSHoaDonNgay(ngay);
                }
                else
                {
                    dt = hd.DSHoaDonNhanVien(ngay, nguoiDung);
                }
                dt.Columns.Add("TinhTrangHinh", typeof(Image));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ("1".Equals(dt.Rows[i][6].ToString()))
                    {
                        dt.Rows[i][10] = Resources.apply_icon;
                        tongTien = +tongTien + long.Parse(dt.Rows[i][5].ToString());
                        banTT++;
                    }
                    else
                    {
                        dt.Rows[i][10] = Resources.delete_icon;
                        tienHuy = +tienHuy + long.Parse(dt.Rows[i][5].ToString());
                        banHuy++;
                    }
                    
                }
            }
            catch { }
            gridControlHoaDon.DataSource = dt;
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            lblTienThu.Text = tongTien.ToString("0,0", elGR);
            lblTienHuy.Text = tienHuy.ToString("0,0", elGR);
            lblBanTT.Text =  banTT.ToString()+" Bàn";
            lblBanHuy.Text = banHuy.ToString() + " Bàn";
            

        }
        private void FrmDSHoaDon_Load(object sender, EventArgs e)
        {
            LoadData(DateTime.Now,null);
            dt = hd.DSNhanVien();
            dr = dt.NewRow();
            dr[0] = tatca;
            dt.Rows.Add(dr);
            lookUpNguoiNV.Properties.DataSource = dt;
            lookUpNguoiNV.Properties.ValueMember = "TenDN";
            lookUpNguoiNV.Properties.DisplayMember = "TenDN";
            lookUpNguoiNV.ItemIndex = dt.Rows.Count - 1;
            dateTinhTien.EditValue = DateTime.Now.ToShortDateString();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData(DateTime.Parse(dateTinhTien.Text), lookUpNguoiNV.EditValue.ToString());
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            LoadData(DateTime.Now, null);
            dateTinhTien.EditValue = DateTime.Now.ToShortDateString();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dateTinhTien.Text);
            dateTinhTien.Text = date.AddDays(-1).ToShortDateString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dateTinhTien.Text);
            dateTinhTien.Text = date.AddDays(1).ToShortDateString();
        }

        private void gridViewHoaDon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dr = null;
                dr = gridViewHoaDon.GetFocusedDataRow();
                FrmHoaDonChiTiet frm = new FrmHoaDonChiTiet();
                FrmHoaDonChiTiet.MaHoaDon = int.Parse(dr[0].ToString());
                frm.ShowDialog();
            }
            catch { }
        }
    }
}
