using SAP_Integrator_MVP_EF.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Views.BillingTypeView
{
    public interface IBillingTypeView
    {
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }


        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string SAP_ObjectCode { get; set; }

        //events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetBindingSourceList(BindingSource billingTypeList);
        void Show(); //optional
    }

}
