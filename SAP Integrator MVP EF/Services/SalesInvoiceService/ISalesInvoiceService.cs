using SAP_Integrator_MVP_EF.shared;
using SAP_Integrator_MVP_EF.shared.Sales_Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Services.SalesInvoiceService
{
    public interface ISalesInvoiceService
    {
        void Delete(SalesInvoice salesInvoice);
        List<SalesInvoice> GetAllSalesInvoice();
        List<BillingType> GetAllBillingType();
        void Add(SalesInvoice salesInvoice);
        void Edit(SalesInvoice salesInvoice);
        List<SalesInvoice> GetByValue(string value); //Searchs
    }
}
