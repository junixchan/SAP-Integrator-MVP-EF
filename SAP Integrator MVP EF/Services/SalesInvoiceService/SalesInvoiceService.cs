using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SAP_Integrator_MVP_EF.Data;
using SAP_Integrator_MVP_EF.shared;
using SAP_Integrator_MVP_EF.shared.Sales_Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Services.SalesInvoiceService
{
    public class SalesInvoiceService : ISalesInvoiceService
    {
        private readonly DataContext _context;
        public SalesInvoiceService(DataContext context)
        {
            _context = context;
        }

        //public IEnumerable<BillingType> GetAll()
        //{
        //    var billingTypes = _context.BillingTypes.ToList();
        //    return billingTypes;
        //}
        public List<SalesInvoice> GetAllSalesInvoice()
        {
            return _context.SalesInvoices.Include(p => p.BillingType).ToList();
        }
        public List<BillingType> GetAllBillingType()
        {
            return _context.BillingTypes.ToList();
        }

        public void Add(SalesInvoice salesInvoice)
        {
            _context.SalesInvoices.Add(salesInvoice);
            _context.SaveChanges();
        }

        public void Edit(SalesInvoice salesInvoice)
        {
            var update = _context.SalesInvoices.Find(salesInvoice.Id);
            if (update != null)
            {
                _context.Entry(update).CurrentValues.SetValues(salesInvoice);
                _context.SaveChanges();
            }
        }

        public void Delete(SalesInvoice salesInvoice)
        {
            var update = _context.SalesInvoices.Find(salesInvoice.Id);
            if (update != null)
            {
                _context.SalesInvoices.Remove(salesInvoice);
                _context.SaveChanges();
            }
        }

        public List<SalesInvoice> GetByValue(string searchQuery)
        {
            return _context.SalesInvoices
                .Where(c => c.Id.ToString().Contains(searchQuery) || c.SalesOrderNo.Contains(searchQuery) || c.DocNum.Contains(searchQuery) || c.PurchaseOrderNo.Contains(searchQuery))
                .ToList();
        }

    }
}
