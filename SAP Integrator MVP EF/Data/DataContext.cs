using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SAP_Integrator_MVP_EF.shared;
using SAP_Integrator_MVP_EF.shared.Sales_Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BillingType> BillingTypes { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer(@"Data Source=junaki;Initial Catalog=SAPIntegrator;Encrypt=False;Persist Security Info=True;User ID=sa;Password=p@ssw0rd");
            //optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillingType>().HasData(
                new BillingType { Id = 1, Name = "SV", Description = "Cancel Cash Sale", SAP_ObjectCode = 13 },
                new BillingType { Id = 2, Name = "ZID1", Description = "Invoice", SAP_ObjectCode = 13 },
                new BillingType { Id = 3, Name = "ZID4", Description = "Credit for Returns", SAP_ObjectCode = 14 },
                new BillingType { Id = 4, Name = "ZRE1", Description = "Credit Ret W / O Ref", SAP_ObjectCode = 14 },
                new BillingType { Id = 5, Name = "ZRSS", Description = "RSS Invoice", SAP_ObjectCode = 13 },
                new BillingType { Id = 6, Name = "ZVAN", Description = "Van Sales Cash Inv.", SAP_ObjectCode = 13 },
                new BillingType { Id = 7, Name = "ZID7", Description = "ZID7", SAP_ObjectCode = 13 },
                new BillingType { Id = 8, Name = "ZID8", Description = "ZID8", SAP_ObjectCode = 13 },
                new BillingType { Id = 9, Name = "ZID9", Description = "ZID9", SAP_ObjectCode = 13 },
                new BillingType { Id = 10, Name = "ZRS1", Description = "ZRS1", SAP_ObjectCode = 13 }
                );

            modelBuilder.Entity<SalesInvoice>().HasData(
                new SalesInvoice
                {
                    Id = 1,
                    DocNum = "SI12345",
                    SalesOrderNo = "SO12345",
                    PurchaseOrderNo = "PO12345",
                    CardCode = "UIC12345",
                    CardName = "NCCC",
                    BillingTypeId = 3,
                    BUnitId = 1,
                    SalesmanId = 1,
                    DocDate = DateTime.Today,
                    DocDueDate = DateTime.Today
                },
                new SalesInvoice
                {
                    Id = 2,
                    DocNum = "SI12346",
                    SalesOrderNo = "SO12346",
                    PurchaseOrderNo = "PO12346",
                    CardCode = "UIC12346",
                    CardName = "NCCC",
                    BillingTypeId = 4,
                    BUnitId = 12,
                    SalesmanId = 11,
                    DocDate = DateTime.Now,
                    DocDueDate = DateTime.Now
                });
        }
    }
}