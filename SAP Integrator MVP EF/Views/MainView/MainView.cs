using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Integrator_MVP_EF.Views.MainView
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnBillingType.Click += delegate { ShowBillingTypeView?.Invoke(this, EventArgs.Empty); };
            btnSalesInvoice.Click += delegate { ShowSalesInvoiceView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowBillingTypeView;
        public event EventHandler ShowSalesInvoiceView;

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
