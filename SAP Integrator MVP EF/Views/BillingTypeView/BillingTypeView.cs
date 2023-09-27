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

namespace SAP_Integrator_MVP_EF.Views.BillingTypeView
{
    public partial class BillingTypeView : Form, IBillingTypeView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public BillingTypeView()
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private static BillingTypeView instance;

        public static BillingTypeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BillingTypeView();
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

        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public string SAP_ObjectCode
        {
            get { return txtSAP_ObjectCode.Text; }
            set { txtSAP_ObjectCode.Text = value; }
        }

    }
}
