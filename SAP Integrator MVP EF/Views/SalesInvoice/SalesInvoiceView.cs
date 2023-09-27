using SAP_Integrator_MVP_EF.Presenters;
using SAP_Integrator_MVP_EF.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAP_Integrator_MVP_EF.Views.SalesInvoiceView
{
    public partial class SalesInvoiceView : Form, ISalesInvoiceView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public SalesInvoiceView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcBillingType.TabPages.Remove(tpDetail);

            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //AddNew
            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tcBillingType.TabPages.Remove(tpList);
                tcBillingType.TabPages.Add(tpDetail);
                tpDetail.Text = "Add New";

            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tcBillingType.TabPages.Remove(tpList);
                tcBillingType.TabPages.Add(tpDetail);
                tpDetail.Text = "Editing";
            };
            //Save
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tcBillingType.TabPages.Remove(tpDetail);
                    tcBillingType.TabPages.Add(tpList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tcBillingType.TabPages.Remove(tpDetail);
                    tcBillingType.TabPages.Add(tpList);
                }
                MessageBox.Show(Message);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }



        public void SetBindingSourceList(BindingSource list)
        {
            dgvList.DataSource = list;
        }

        public void SetBindingSourceBillingTypeList(BindingSource list)
        {
            cbBillingTypes.DataSource = list;
            cbBillingTypes.DisplayMember = "Name";
            cbBillingTypes.ValueMember = "Id";
        }


        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private static SalesInvoiceView instance;

        public static SalesInvoiceView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SalesInvoiceView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }


        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Id
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public string CardCode
        {
            get { return txtCardCode.Text; }
            set { txtCardCode.Text = value; }
        }

        public string CardName
        {
            get { return txtCardName.Text; }
            set { txtCardName.Text = value; }
        }

        public string SalesmanId
        {
            get { return txtSalesman.Text; }
            set { txtSalesman.Text = value; }
        }
        public string DocNum
        {
            get { return txtDocNum.Text; }
            set { txtDocNum.Text = value; }
        }

        public string SalesOrderNo
        {
            get { return txtSONum.Text; }
            set { txtSONum.Text = value; }
        }
        public string PurchaseOrderNo
        {
            get { return txtPONum.Text; }
            set { txtPONum.Text = value; }
        }

        public string BUnitId
        {
            get { return txtBUnit.Text; }
            set { txtBUnit.Text = value; }
        }


        public int BillingTypeId { get; set; }


        public DateTime DocDueDate
        {
            get
            {
                if (DateTime.TryParse(dtpDocDueDate.Text, out DateTime result))
                {
                    return result;
                }
                return DateTime.MinValue;
            }
            set { dtpDocDueDate.Text = value.ToString("yyyy-MM-dd"); }
        }
        public DateTime DocDate
        {
            get
            {
                if (DateTime.TryParse(dtpDocDate.Text, out DateTime result))
                {
                    return result;
                }
                return DateTime.MinValue;
            }
            set { dtpDocDate.Text = value.ToString("yyyy-MM-dd"); }
        }


        public int GetSelectedBillingTypeId()
        {
            return (int)cbBillingTypes.SelectedValue;
        }

        public void SetSelectedBillingTypeId(int billingTypeId)
        {
            cbBillingTypes.SelectedValue = billingTypeId;
        }



    }
}