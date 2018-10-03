namespace ApplicationWinform
{
    partial class QLHocVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHocVien));
            this.qLHVDataSet = new ApplicationWinform.QLHVDataSet();
            this.hOCVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCVIENTableAdapter = new ApplicationWinform.QLHVDataSetTableAdapters.HOCVIENTableAdapter();
            this.tableAdapterManager = new ApplicationWinform.QLHVDataSetTableAdapters.TableAdapterManager();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateNgsinh = new DevExpress.XtraEditors.DateEdit();
            this.cboMalop = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboGT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.edtSdt = new DevExpress.XtraEditors.TextEdit();
            this.edtHoten = new DevExpress.XtraEditors.TextEdit();
            this.edtDchi = new DevExpress.XtraEditors.TextEdit();
            this.edtMahv = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grvHocVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLHVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgsinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgsinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDchi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMahv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // qLHVDataSet
            // 
            this.qLHVDataSet.DataSetName = "QLHVDataSet";
            this.qLHVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCVIENBindingSource
            // 
            this.hOCVIENBindingSource.DataMember = "HOCVIEN";
            this.hOCVIENBindingSource.DataSource = this.qLHVDataSet;
            // 
            // hOCVIENTableAdapter
            // 
            this.hOCVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BIENLAITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_LOPHOCTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCVIEN_LOPHOCTableAdapter = null;
            this.tableAdapterManager.HOCVIENTableAdapter = this.hOCVIENTableAdapter;
            this.tableAdapterManager.KETQUATableAdapter = null;
            this.tableAdapterManager.KHOAHOCTableAdapter = null;
            this.tableAdapterManager.LICHHOCTableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApplicationWinform.QLHVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAdd,
            this.btnDel,
            this.btnUpdate,
            this.bnSave,
            this.btnCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1020, 177);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa dữ liệu";
            this.btnDel.Id = 2;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa dữ liệu";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // bnSave
            // 
            this.bnSave.Caption = "Lưu thay đổi";
            this.bnSave.Id = 4;
            this.bnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bnSave.ImageOptions.SvgImage")));
            this.bnSave.Name = "bnSave";
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy thay đổi";
            this.btnCancel.Id = 5;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Name = "btnCancel";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý học viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.bnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateNgsinh);
            this.layoutControl1.Controls.Add(this.cboMalop);
            this.layoutControl1.Controls.Add(this.cboGT);
            this.layoutControl1.Controls.Add(this.edtSdt);
            this.layoutControl1.Controls.Add(this.edtHoten);
            this.layoutControl1.Controls.Add(this.edtDchi);
            this.layoutControl1.Controls.Add(this.edtMahv);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 177);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1020, 136);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateNgsinh
            // 
            this.dateNgsinh.EditValue = null;
            this.dateNgsinh.Location = new System.Drawing.Point(585, 44);
            this.dateNgsinh.MenuManager = this.ribbonControl1;
            this.dateNgsinh.Name = "dateNgsinh";
            this.dateNgsinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgsinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgsinh.Size = new System.Drawing.Size(398, 22);
            this.dateNgsinh.StyleController = this.layoutControl1;
            this.dateNgsinh.TabIndex = 12;
            // 
            // cboMalop
            // 
            this.cboMalop.Location = new System.Drawing.Point(585, 72);
            this.cboMalop.MenuManager = this.ribbonControl1;
            this.cboMalop.Name = "cboMalop";
            this.cboMalop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMalop.Size = new System.Drawing.Size(398, 22);
            this.cboMalop.StyleController = this.layoutControl1;
            this.cboMalop.TabIndex = 11;
            // 
            // cboGT
            // 
            this.cboGT.Location = new System.Drawing.Point(99, 72);
            this.cboGT.MenuManager = this.ribbonControl1;
            this.cboGT.Name = "cboGT";
            this.cboGT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGT.Size = new System.Drawing.Size(397, 22);
            this.cboGT.StyleController = this.layoutControl1;
            this.cboGT.TabIndex = 10;
            // 
            // edtSdt
            // 
            this.edtSdt.Location = new System.Drawing.Point(99, 44);
            this.edtSdt.MenuManager = this.ribbonControl1;
            this.edtSdt.Name = "edtSdt";
            this.edtSdt.Size = new System.Drawing.Size(397, 22);
            this.edtSdt.StyleController = this.layoutControl1;
            this.edtSdt.TabIndex = 9;
            // 
            // edtHoten
            // 
            this.edtHoten.Location = new System.Drawing.Point(585, 16);
            this.edtHoten.MenuManager = this.ribbonControl1;
            this.edtHoten.Name = "edtHoten";
            this.edtHoten.Size = new System.Drawing.Size(398, 22);
            this.edtHoten.StyleController = this.layoutControl1;
            this.edtHoten.TabIndex = 8;
            // 
            // edtDchi
            // 
            this.edtDchi.Location = new System.Drawing.Point(99, 100);
            this.edtDchi.MenuManager = this.ribbonControl1;
            this.edtDchi.Name = "edtDchi";
            this.edtDchi.Size = new System.Drawing.Size(884, 22);
            this.edtDchi.StyleController = this.layoutControl1;
            this.edtDchi.TabIndex = 7;
            // 
            // edtMahv
            // 
            this.edtMahv.Location = new System.Drawing.Point(99, 16);
            this.edtMahv.MenuManager = this.ribbonControl1;
            this.edtMahv.Name = "edtMahv";
            this.edtMahv.Size = new System.Drawing.Size(397, 22);
            this.edtMahv.StyleController = this.layoutControl1;
            this.edtMahv.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(999, 148);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.edtMahv;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(486, 28);
            this.layoutControlItem1.Text = "Mã học viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(973, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtDchi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(973, 28);
            this.layoutControlItem4.Text = "Địa chỉ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edtHoten;
            this.layoutControlItem5.Location = new System.Drawing.Point(486, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem5.Text = "Họ và tên";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.edtSdt;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(486, 28);
            this.layoutControlItem6.Text = "Số điện thoại";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cboGT;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(486, 28);
            this.layoutControlItem7.Text = "Giới tính";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboMalop;
            this.layoutControlItem3.Location = new System.Drawing.Point(486, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem3.Text = "Mã lớp học";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateNgsinh;
            this.layoutControlItem2.Location = new System.Drawing.Point(486, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem2.Text = "Ngày sinh";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 16);
            // 
            // grvHocVien
            // 
            this.grvHocVien.AutoGenerateColumns = false;
            this.grvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grvHocVien.DataSource = this.hOCVIENBindingSource;
            this.grvHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvHocVien.Location = new System.Drawing.Point(0, 313);
            this.grvHocVien.Name = "grvHocVien";
            this.grvHocVien.RowTemplate.Height = 24;
            this.grvHocVien.Size = new System.Drawing.Size(1020, 301);
            this.grvHocVien.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASOHV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTENHV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYSINHHV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHIHV";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SDTHV";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MASOLH";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã lớp học";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // QLHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.Controls.Add(this.grvHocVien);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "QLHocVien";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLHocVien_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNgsinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgsinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDchi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMahv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLHVDataSet qLHVDataSet;
        private System.Windows.Forms.BindingSource hOCVIENBindingSource;
        private QLHVDataSetTableAdapters.HOCVIENTableAdapter hOCVIENTableAdapter;
        private QLHVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.DataGridView grvHocVien;
        private DevExpress.XtraEditors.TextEdit edtDchi;
        private DevExpress.XtraEditors.TextEdit edtMahv;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit edtSdt;
        private DevExpress.XtraEditors.TextEdit edtHoten;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem bnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit cboMalop;
        private DevExpress.XtraEditors.ComboBoxEdit cboGT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DevExpress.XtraEditors.DateEdit dateNgsinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;


    }
}