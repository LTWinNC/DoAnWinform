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
    public partial class QLLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public QLLopHoc()
        {
            InitializeComponent();
        }

        private void lOPHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHVDataSet);

        }

        private void QLLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHVDataSet.LOPHOC' table. You can move, or remove it, as needed.
            this.lOPHOCTableAdapter.Fill(this.qLHVDataSet.LOPHOC);

        }

        private void QLLopHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đóng chức năng quản lý lớp học không?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}