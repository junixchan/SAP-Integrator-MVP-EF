namespace SAP_Integrator_MVP_EF.Views.BillingTypeView
{
    partial class BillingTypeView
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
            btnCancel = new Button();
            btnSave = new Button();
            txtSAP_ObjectCode = new TextBox();
            lblSAP_ObjectCode = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtId = new TextBox();
            lblId = new Label();
            panel1.SuspendLayout();
            tcBillingType.SuspendLayout();
            tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            tpDetail.SuspendLayout();
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
            lblTitle.Size = new Size(182, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Billing Type";
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
            tcBillingType.Size = new Size(883, 525);
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
            tpList.Size = new Size(875, 497);
            tpList.TabIndex = 0;
            tpList.Text = "List";
            tpList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(757, 444);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 47);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Location = new Point(639, 444);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 47);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(522, 444);
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
            dgvList.Location = new Point(-4, 56);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(883, 384);
            dgvList.TabIndex = 0;
            // 
            // tpDetail
            // 
            tpDetail.Controls.Add(btnCancel);
            tpDetail.Controls.Add(btnSave);
            tpDetail.Controls.Add(txtSAP_ObjectCode);
            tpDetail.Controls.Add(lblSAP_ObjectCode);
            tpDetail.Controls.Add(txtDescription);
            tpDetail.Controls.Add(lblDescription);
            tpDetail.Controls.Add(txtName);
            tpDetail.Controls.Add(lblName);
            tpDetail.Controls.Add(txtId);
            tpDetail.Controls.Add(lblId);
            tpDetail.Location = new Point(4, 24);
            tpDetail.Name = "tpDetail";
            tpDetail.Padding = new Padding(3);
            tpDetail.Size = new Size(875, 497);
            tpDetail.TabIndex = 1;
            tpDetail.Text = "Detail";
            tpDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(432, 199);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 47);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(311, 199);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 47);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtSAP_ObjectCode
            // 
            txtSAP_ObjectCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSAP_ObjectCode.Location = new Point(201, 138);
            txtSAP_ObjectCode.Name = "txtSAP_ObjectCode";
            txtSAP_ObjectCode.Size = new Size(346, 23);
            txtSAP_ObjectCode.TabIndex = 10;
            // 
            // lblSAP_ObjectCode
            // 
            lblSAP_ObjectCode.AutoSize = true;
            lblSAP_ObjectCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSAP_ObjectCode.Location = new Point(8, 136);
            lblSAP_ObjectCode.Name = "lblSAP_ObjectCode";
            lblSAP_ObjectCode.Size = new Size(127, 21);
            lblSAP_ObjectCode.TabIndex = 9;
            lblSAP_ObjectCode.Text = "SAP Object Code";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(201, 98);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(346, 23);
            txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(8, 96);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 21);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(201, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 23);
            txtName.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(8, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtId.Enabled = false;
            txtId.Location = new Point(201, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(346, 23);
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
            // BillingTypeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 592);
            Controls.Add(tcBillingType);
            Controls.Add(panel1);
            Name = "BillingTypeView";
            Text = "BillingTypeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcBillingType.ResumeLayout(false);
            tpList.ResumeLayout(false);
            tpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            tpDetail.ResumeLayout(false);
            tpDetail.PerformLayout();
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
        private TextBox txtSAP_ObjectCode;
        private Label lblSAP_ObjectCode;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtId;
        private Label lblId;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
    }
}