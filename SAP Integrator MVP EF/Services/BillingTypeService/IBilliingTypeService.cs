using SAP_Integrator_MVP_EF.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Services.BillingTypeService
{
    public interface IBillingTypeService
    {
        void Delete(BillingType billingType);
        List<BillingType> GetAll();
        void Add(BillingType billingType);
        void Edit(BillingType billingType);
        List<BillingType> GetByValue(string value); //Searchs
    }
}
