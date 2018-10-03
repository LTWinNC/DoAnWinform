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
    public partial class QLKetQua : DevExpress.XtraEditors.XtraForm
    {
        public QLKetQua()
        {
            InitializeComponent();
        }

        private void kETQUABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kETQUABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHVDataSet);

        }

        private void QLKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHVDataSet.KETQUA' table. You can move, or remove it, as needed.
            this.kETQUATableAdapter.Fill(this.qLHVDataSet.KETQUA);

        }

        private void QLKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đóng chức năng quản lý kết quả không?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                MessageBox.Show(edtSearch.EditValue.ToString());
        }
    }
}