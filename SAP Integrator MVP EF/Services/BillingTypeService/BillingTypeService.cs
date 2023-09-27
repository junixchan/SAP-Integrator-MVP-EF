using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SAP_Integrator_MVP_EF.Data;
using SAP_Integrator_MVP_EF.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Services.BillingTypeService
{
    public class BillingTypeService : IBillingTypeService
    {
        private readonly DataContext _context;
        public BillingTypeService(DataContext context)
        {
            _context = context;
        }

        //public IEnumerable<BillingType> GetAll()
        //{
        //    var billingTypes = _context.BillingTypes.ToList();
        //    return billingTypes;
        //}
        public List<BillingType> GetAll()
        {
            return _context.BillingTypes.ToList();
        }

        public void Add(BillingType billingType)
        {
            _context.BillingTypes.Add(billingType);
            _context.SaveChanges();
        }

        public void Edit(BillingType billingType)
        {
            var update = _context.BillingTypes.Find(billingType.Id);
            if (update != null)
            {
                _context.Entry(update).CurrentValues.SetValues(billingType);
                _context.SaveChanges();
            }
        }

        public void Delete(BillingType billingType)
        {
            var update = _context.BillingTypes.Find(billingType.Id);
            if (update != null)
            {
                _context.BillingTypes.Remove(billingType);
                _context.SaveChanges();
            }
        }

        public List<BillingType> GetByValue(string searchQuery)
        {

            return _context.BillingTypes
                .Where(c => c.Id.ToString().Contains(searchQuery) || c.Name.Contains(searchQuery) || c.Description.Contains(searchQuery))
                .ToList();
        }

    }
}
