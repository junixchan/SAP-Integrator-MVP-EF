using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Views.MainView
{
    public interface IMainView
    {
        event EventHandler ShowBillingTypeView;
        event EventHandler ShowSalesInvoiceView;
    }
}
