using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.shared.Sales_Invoice
{
    public class SalesInvoice
    {
        private int id;
        private string docNum;
        private string salesOrderNo;
        private string cardCode;
        private string cardName;
        private DateTime docDate;
        private DateTime docDueDate;
        private string purchaseOrderNo;
        private int billingTypeId;
        private int salesmanId;
        private int bUnitId;

        [DisplayName("Sales Invoice ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Sales Invoice No")]
        [Required(ErrorMessage = "Sales Invoice is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Sales Invoice must be between 3 and 50 characters")]
        public string DocNum
        {
            get { return docNum; }
            set { docNum = value; }
        }

        [DisplayName("Customer Id")]
        [Required(ErrorMessage = "Customer Id is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer Id must be between 3 and 50 characters")]
        public string CardCode
        {
            get { return cardCode; }
            set { cardCode = value; }
        }


        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "Customer Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer Name must be between 3 and 50 characters")]
        public string CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }


        [DisplayName("Sales Order Number")]
        [Required(ErrorMessage = "Customer Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer Name must be between 3 and 50 characters")]
        public string SalesOrderNo
        {
            get { return salesOrderNo; }
            set { salesOrderNo = value; }
        }


        [DisplayName("Salesman Id")]
        [Required(ErrorMessage = "Salesman Id is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Salesman Id must be between 3 and 50 characters")]
        public int SalesmanId
        {
            get { return salesmanId; }
            set { salesmanId = value; }
        }

        [DisplayName("Document Date")]
        [Required(ErrorMessage = "Document Date is required")]
        [DataType(DataType.DateTime)]
        public DateTime DocDate
        {
            get { return docDate; }
            set { docDate = value; }
        }

        [DisplayName("Due Date")]
        [Required(ErrorMessage = "Document Date is required")]
        [DataType(DataType.DateTime)]
        public DateTime DocDueDate
        {
            get { return docDueDate; }
            set { docDueDate = value; }
        }

        [DisplayName("Business Unit")]
        [Required(ErrorMessage = "Business Unit is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Salesman Id must be between 3 and 50 characters")]
        public int BUnitId
        {
            get { return bUnitId; }
            set { bUnitId = value; }
        }


        [DisplayName("Purchase Order No")]
        [Required(ErrorMessage = "Purchase Order No is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Salesman Id must be between 3 and 50 characters")]
        public string PurchaseOrderNo
        {
            get { return purchaseOrderNo; }
            set { purchaseOrderNo = value; }
        }


        [DisplayName("Billing Type Id")]
        public int BillingTypeId
        {
            get { return (int)billingTypeId; }
            set { billingTypeId = value; }
        }

        public BillingType BillingType { get; set; }


    }
}

