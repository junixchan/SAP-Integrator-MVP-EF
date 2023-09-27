using SAP_Integrator_MVP_EF.Data;
using SAP_Integrator_MVP_EF.Services;
using SAP_Integrator_MVP_EF.Services.BillingTypeService;
using SAP_Integrator_MVP_EF.Services.SalesInvoiceService;
using SAP_Integrator_MVP_EF.Views.BillingTypeView;
using SAP_Integrator_MVP_EF.Views.MainView;
using SAP_Integrator_MVP_EF.Views.SalesInvoiceView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.mainView.ShowBillingTypeView += ShowBillingTypeView;
            this.mainView.ShowSalesInvoiceView += ShowSalesInvoiceView;
            this.sqlConnectionString = sqlConnectionString;           
        }


        private void ShowBillingTypeView(object sender, EventArgs e)
        {
            var context = new DataContext();
            IBillingTypeView view = BillingTypeView.GetInstance((MainView)mainView);
            IBillingTypeService service = new BillingTypeService(context);
            //IBillingTypeService repository = new BillingTypeService();
            new BillingTypePresenter(view, service);
        }

        private void ShowSalesInvoiceView(object sender, EventArgs e)
        {
            var context = new DataContext();
            ISalesInvoiceView view = SalesInvoiceView.GetInstance((MainView)mainView);
            ISalesInvoiceService service = new SalesInvoiceService(context);
            //IBillingTypeService repository = new BillingTypeService();
            new SalesInvoicePresenter(view, service);
        }
    }
}
