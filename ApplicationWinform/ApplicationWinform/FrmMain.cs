using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ApplicationWinform
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuQLKH_Click(object sender, EventArgs e)
        {
            QLKhoaHoc frm = new QLKhoaHoc();
            frm.Show();
        }

        private void menuQLLH_Click(object sender, EventArgs e)
        {
            QLLopHoc frm = new QLLopHoc();
            frm.Show();
        }

        private void menuQLHV_Click(object sender, EventArgs e)
        {
            QLHocVien frm = new QLHocVien();
            frm.Show();
        }

        private void menuQLKQ_Click(object sender, EventArgs e)
        {
            QLKetQua frm = new QLKetQua();
            frm.Show();
        }

        private void menuQLGV_Click(object sender, EventArgs e)
        {
            QLGiaoVien frm = new QLGiaoVien();
            frm.Show();
        }

        private void menuQLLich_Click(object sender, EventArgs e)
        {
            QLLichHoc frm = new QLLichHoc();
            frm.Show();
        }
    }
}