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
    public partial class QLHocVien : DevExpress.XtraEditors.XtraForm
    {
        public QLHocVien()
        {
            InitializeComponent();
        }

        private void hOCVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHVDataSet);

        }

        private void hOCVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHVDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHVDataSet.HOCVIEN' table. You can move, or remove it, as needed.
            this.hOCVIENTableAdapter.Fill(this.qLHVDataSet.HOCVIEN);

        }

        private void QLHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đóng chức năng quản lý học viên không?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}