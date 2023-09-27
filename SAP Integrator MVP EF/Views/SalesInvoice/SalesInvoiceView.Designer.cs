namespace SAP_Integrator_MVP_EF.Views.SalesInvoiceView
{
    partial class SalesInvoiceView
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
            panel1 = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            tcBillingType = new TabControl();
            tpList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvList = new DataGridView();
            tpDetail = new TabPage();
            cbBillingTypes = new ComboBox();
            dtpDocDueDate = new DateTimePicker();
            dtpDocDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            txtPONum = new TextBox();
            label6 = new Label();
            txtSONum = new TextBox();
            label5 = new Label();
            txtDocNum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBUnit = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtSalesman = new TextBox();
            lblSalesman = new Label();
            txtCardName = new TextBox();
            lblCardName = new Label();
            txtCardCode = new TextBox();
            lblCardCode = new Label();
            txtId = new TextBox();
            lblId = new Label();
            panel1.SuspendLayout();
            tcBillingType.SuspendLayout();
            tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            tpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 67);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(813, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 55);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(202, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Sales Invoice";
            // 
            // tcBillingType
            // 
            tcBillingType.Controls.Add(tpList);
            tcBillingType.Controls.Add(tpDetail);
            tcBillingType.Dock = DockStyle.Fill;
            tcBillingType.Location = new Point(0, 67);
            tcBillingType.Multiline = true;
            tcBillingType.Name = "tcBillingType";
            tcBillingType.SelectedIndex = 0;
            tcBillingType.Size = new Size(883, 769);
            tcBillingType.TabIndex = 1;
            // 
            // tpList
            // 
            tpList.Controls.Add(btnDelete);
            tpList.Controls.Add(btnEdit);
            tpList.Controls.Add(btnAdd);
            tpList.Controls.Add(btnSearch);
            tpList.Controls.Add(txtSearch);
            tpList.Controls.Add(label1);
            tpList.Controls.Add(dgvList);
            tpList.Location = new Point(4, 24);
            tpList.Name = "tpList";
            tpList.Padding = new Padding(3);
            tpList.Size = new Size(875, 741);
            tpList.TabIndex = 0;
            tpList.Text = "List";
            tpList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(757, 692);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 47);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Location = new Point(639, 692);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 47);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(518, 692);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 47);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(760, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(8, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(746, 23);
            txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // dgvList
            // 
            dgvList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(8, 56);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(864, 630);
            dgvList.TabIndex = 0;
            // 
            // tpDetail
            // 
            tpDetail.Controls.Add(cbBillingTypes);
            tpDetail.Controls.Add(dtpDocDueDate);
            tpDetail.Controls.Add(dtpDocDate);
            tpDetail.Controls.Add(dataGridView1);
            tpDetail.Controls.Add(label8);
            tpDetail.Controls.Add(label7);
            tpDetail.Controls.Add(txtPONum);
            tpDetail.Controls.Add(label6);
            tpDetail.Controls.Add(txtSONum);
            tpDetail.Controls.Add(label5);
            tpDetail.Controls.Add(txtDocNum);
            tpDetail.Controls.Add(label2);
            tpDetail.Controls.Add(label3);
            tpDetail.Controls.Add(txtBUnit);
            tpDetail.Controls.Add(label4);
            tpDetail.Controls.Add(btnCancel);
            tpDetail.Controls.Add(btnSave);
            tpDetail.Controls.Add(txtSalesman);
            tpDetail.Controls.Add(lblSalesman);
            tpDetail.Controls.Add(txtCardName);
            tpDetail.Controls.Add(lblCardName);
            tpDetail.Controls.Add(txtCardCode);
            tpDetail.Controls.Add(lblCardCode);
            tpDetail.Controls.Add(txtId);
            tpDetail.Controls.Add(lblId);
            tpDetail.Location = new Point(4, 24);
            tpDetail.Name = "tpDetail";
            tpDetail.Padding = new Padding(3);
            tpDetail.Size = new Size(875, 741);
            tpDetail.TabIndex = 1;
            tpDetail.Text = "Detail";
            tpDetail.UseVisualStyleBackColor = true;
            // 
            // cbBillingTypes
            // 
            cbBillingTypes.FormattingEnabled = true;
            cbBillingTypes.Location = new Point(170, 165);
            cbBillingTypes.Name = "cbBillingTypes";
            cbBillingTypes.Size = new Size(231, 23);
            cbBillingTypes.TabIndex = 30;
            // 
            // dtpDocDueDate
            // 
            dtpDocDueDate.Location = new Point(597, 136);
            dtpDocDueDate.Name = "dtpDocDueDate";
            dtpDocDueDate.Size = new Size(231, 23);
            dtpDocDueDate.TabIndex = 29;
            // 
            // dtpDocDate
            // 
            dtpDocDate.Location = new Point(597, 107);
            dtpDocDate.Name = "dtpDocDate";
            dtpDocDate.Size = new Size(231, 23);
            dtpDocDate.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(883, 492);
            dataGridView1.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(426, 134);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 25;
            label8.Text = "Document Due Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(426, 105);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 23;
            label7.Text = "Document Date";
            // 
            // txtPONum
            // 
            txtPONum.Location = new Point(597, 78);
            txtPONum.Name = "txtPONum";
            txtPONum.Size = new Size(231, 23);
            txtPONum.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(426, 76);
            label6.Name = "label6";
            label6.Size = new Size(146, 21);
            label6.TabIndex = 21;
            label6.Text = "Purchase Order No.";
            // 
            // txtSONum
            // 
            txtSONum.Location = new Point(597, 49);
            txtSONum.Name = "txtSONum";
            txtSONum.Size = new Size(231, 23);
            txtSONum.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(426, 47);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 19;
            label5.Text = "Sales Order No.";
            // 
            // txtDocNum
            // 
            txtDocNum.Location = new Point(597, 20);
            txtDocNum.Name = "txtDocNum";
            txtDocNum.Size = new Size(231, 23);
            txtDocNum.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(426, 18);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 17;
            label2.Text = "Document No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 163);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 15;
            label3.Text = "Billing Type";
            // 
            // txtBUnit
            // 
            txtBUnit.Location = new Point(170, 136);
            txtBUnit.Name = "txtBUnit";
            txtBUnit.Size = new Size(231, 23);
            txtBUnit.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 134);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 13;
            label4.Text = "Business Unit";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(757, 692);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 47);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(639, 692);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 47);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtSalesman
            // 
            txtSalesman.Location = new Point(170, 107);
            txtSalesman.Name = "txtSalesman";
            txtSalesman.Size = new Size(231, 23);
            txtSalesman.TabIndex = 10;
            // 
            // lblSalesman
            // 
            lblSalesman.AutoSize = true;
            lblSalesman.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalesman.Location = new Point(8, 105);
            lblSalesman.Name = "lblSalesman";
            lblSalesman.Size = new Size(77, 21);
            lblSalesman.TabIndex = 9;
            lblSalesman.Text = "Salesman";
            // 
            // txtCardName
            // 
            txtCardName.Location = new Point(170, 78);
            txtCardName.Name = "txtCardName";
            txtCardName.Size = new Size(231, 23);
            txtCardName.TabIndex = 8;
            // 
            // lblCardName
            // 
            lblCardName.AutoSize = true;
            lblCardName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCardName.Location = new Point(8, 76);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new Size(85, 21);
            lblCardName.TabIndex = 7;
            lblCardName.Text = "CardName";
            // 
            // txtCardCode
            // 
            txtCardCode.Location = new Point(170, 49);
            txtCardCode.Name = "txtCardCode";
            txtCardCode.Size = new Size(231, 23);
            txtCardCode.TabIndex = 6;
            // 
            // lblCardCode
            // 
            lblCardCode.AutoSize = true;
            lblCardCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCardCode.Location = new Point(8, 47);
            lblCardCode.Name = "lblCardCode";
            lblCardCode.Size = new Size(79, 21);
            lblCardCode.TabIndex = 5;
            lblCardCode.Text = "CardCode";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(170, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(231, 23);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(8, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 21);
            lblId.TabIndex = 3;
            lblId.Text = "Id";
            // 
            // SalesInvoiceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 836);
            Controls.Add(tcBillingType);
            Controls.Add(panel1);
            Name = "SalesInvoiceView";
            Text = "SalesInvoiceView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcBillingType.ResumeLayout(false);
            tpList.ResumeLayout(false);
            tpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            tpDetail.ResumeLayout(false);
            tpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tcBillingType;
        private TabPage tpList;
        private DataGridView dgvList;
        private TabPage tpDetail;
        private Label lblTitle;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Button btnClose;
        private TextBox txtSalesman;
        private Label lblSalesman;
        private TextBox txtCardName;
        private Label lblCardName;
        private TextBox txtCardCode;
        private Label lblCardCode;
        private TextBox txtId;
        private Label lblId;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
        private Label label8;
        private Label label7;
        private TextBox txtPONum;
        private Label label6;
        private TextBox txtSONum;
        private Label label5;
        private TextBox txtDocNum;
        private Label label2;
        private Label label3;
        private TextBox txtBUnit;
        private Label label4;
        private DataGridView dataGridView1;
        private DateTimePicker dtpDocDueDate;
        private DateTimePicker dtpDocDate;
        private ComboBox cbBillingTypes;
    }
}