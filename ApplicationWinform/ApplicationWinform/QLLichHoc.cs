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
    public partial class QLLichHoc : DevExpress.XtraEditors.XtraForm
    {
        public QLLichHoc()
        {
            InitializeComponent();
        }

        private void lICHHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lICHHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHVDataSet);

        }

        private void QLLichHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHVDataSet.LICHHOC' table. You can move, or remove it, as needed.
            this.lICHHOCTableAdapter.Fill(this.qLHVDataSet.LICHHOC);

        }

        private void QLLichHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đóng chức năng quản lý lịch không?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}