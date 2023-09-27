using SAP_Integrator_MVP_EF.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Views.SalesInvoiceView
{
    public interface ISalesInvoiceView
    {
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        string Id { get; set; }
        string DocNum{ get; set; }
        string SalesOrderNo { get; set; }
        string PurchaseOrderNo { get; set; }
        string CardCode { get; set; }
        string CardName { get; set; }
        DateTime DocDate { get; set; }
        DateTime DocDueDate { get; set; }
        string SalesmanId { get; set; }
        string BUnitId { get; set; }
        int BillingTypeId { get; set; }


        //BillingType selectedBillingType { get; set; }

        //events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetBindingSourceList(BindingSource List);
        void SetBindingSourceBillingTypeList(BindingSource List);

        void SetSelectedBillingTypeId(int billingTypeId);

        int GetSelectedBillingTypeId();

        //void BindBillingTypes(List<BillingType> billingTypes);
        void Show(); //optional
    }

}
