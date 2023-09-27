namespace SAP_Integrator_MVP_EF.Views.MainView
{
    partial class MainView
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
            btnSalesInvoice = new Button();
            btnBillingType = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalesInvoice);
            panel1.Controls.Add(btnBillingType);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 721);
            panel1.TabIndex = 0;
            // 
            // btnSalesInvoice
            // 
            btnSalesInvoice.Location = new Point(0, 337);
            btnSalesInvoice.Name = "btnSalesInvoice";
            btnSalesInvoice.Size = new Size(172, 47);
            btnSalesInvoice.TabIndex = 1;
            btnSalesInvoice.Text = "Sales Invoice";
            btnSalesInvoice.UseVisualStyleBackColor = true;
            btnSalesInvoice.Click += btnSalesInvoice_Click;
            // 
            // btnBillingType
            // 
            btnBillingType.Location = new Point(0, 120);
            btnBillingType.Name = "btnBillingType";
            btnBillingType.Size = new Size(172, 47);
            btnBillingType.TabIndex = 0;
            btnBillingType.Text = "Billing Type";
            btnBillingType.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 721);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainView";
            Text = "MainView";
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBillingType;
        private Button btnSalesInvoice;
    }
}