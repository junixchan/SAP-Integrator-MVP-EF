using SAP_Integrator_MVP_EF.Services.BillingTypeService;
using SAP_Integrator_MVP_EF.Services.SalesInvoiceService;
using SAP_Integrator_MVP_EF.Views.SalesInvoiceView;
using SAP_Integrator_MVP_EF.shared;
using SAP_Integrator_MVP_EF.shared.Sales_Invoice;
using Microsoft.EntityFrameworkCore;

namespace SAP_Integrator_MVP_EF.Presenters
{
    public class SalesInvoicePresenter : ISalesInvoicePresenter
    {
        private readonly ISalesInvoiceView _view;
        private readonly ISalesInvoiceService _salesInvoiceService;
        private BindingSource bsSalesInvoice;
        private BindingSource bsBillingTypes;
        private IEnumerable<SalesInvoice> salesInvoiceList;
        private IEnumerable<BillingType> billingTypeList;

        public SalesInvoicePresenter(ISalesInvoiceView view, ISalesInvoiceService service)
        {
            bsSalesInvoice = new BindingSource();
            bsBillingTypes = new BindingSource();
            _view = view;
            _salesInvoiceService = service;

            //Events
            _view.AddNewEvent += AddNew;
            _view.SearchEvent += Search;
            _view.EditEvent += LoadSelectedToEdit;
            _view.DeleteEvent += DeleteSelected;
            _view.SaveEvent += Save;
            _view.CancelEvent += CancelAction;


            //Methods
            Initialized();
            _view.SetBindingSourceList(bsSalesInvoice);
            _view.SetBindingSourceBillingTypeList(bsBillingTypes);
            _view.Show();

            CleanviewFields();
        }

        public void Initialized()
        {
            LoadBillingTypes();
            LoadSalesInvoice();
        }

        public void LoadSalesInvoice()
        {
            salesInvoiceList = _salesInvoiceService.GetAllSalesInvoice();
            bsSalesInvoice.DataSource = salesInvoiceList;
        }

        public void LoadBillingTypes()
        {
             billingTypeList =  _salesInvoiceService.GetAllBillingType();
             bsBillingTypes.DataSource = billingTypeList;
        }


        private void AddNew(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void LoadSelectedToEdit(object? sender, EventArgs e)
        {
            var salesInvoice = (SalesInvoice)bsSalesInvoice.Current;
            _view.Id = salesInvoice.Id.ToString();
            _view.DocNum = salesInvoice.DocNum;
            _view.SalesOrderNo = salesInvoice.SalesOrderNo;
            _view.PurchaseOrderNo = salesInvoice.PurchaseOrderNo;
            _view.CardCode = salesInvoice.CardCode;
            _view.CardName = salesInvoice.CardName;
            _view.DocDate = salesInvoice.DocDate;
            _view.DocDueDate = salesInvoice.DocDueDate;
            _view.SalesmanId = salesInvoice.SalesmanId.ToString();
            _view.BUnitId = salesInvoice.BUnitId.ToString();
            _view.SetSelectedBillingTypeId(salesInvoice.BillingTypeId);
            _view.IsEdit = true;
        }

        private void CleanviewFields()
        {
            _view.Id = "0";
            _view.DocNum = "";
            _view.SalesOrderNo = "";
            _view.PurchaseOrderNo = "";
            _view.CardCode = "";
            _view.CardName = "";
            _view.DocDate = DateTime.Today;
            _view.DocDueDate = DateTime.Today;
            _view.SalesmanId = "0";
            _view.BUnitId = "0";
            //_view.BillingTypeId = 1;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }


        private void Save(object sender, EventArgs e)
        {
            var model = new SalesInvoice();
            model.Id = Convert.ToInt32(_view.Id);
            model.DocNum = _view.DocNum;
            model.SalesOrderNo = _view.SalesOrderNo;
            model.PurchaseOrderNo = _view.PurchaseOrderNo;
            model.CardCode = _view.CardCode;
            model.CardName = _view.CardName;
            model.DocDate = DateTime.Today;
            model.DocDueDate= DateTime.Today;
            model.BUnitId = Convert.ToInt32(_view.BUnitId);
            model.SalesmanId = Convert.ToInt32(_view.SalesmanId);
            //model.BillingTypeId = Convert.ToInt32(_view.selectedBillingType.Id);

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (_view.IsEdit)
                {
                    _salesInvoiceService.Edit(model);
                    _view.Message = "Edited successfuly";
                }
                else
                {
                    _salesInvoiceService.Add(model);
                    _view.Message = "Added successfuly";
                }
                _view.IsSuccessful = true;
                LoadSalesInvoice();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }

        }
        private void DeleteSelected(object? sender, EventArgs e)
        {
            try
            {
                var model = (SalesInvoice)bsSalesInvoice.Current; 
                 _salesInvoiceService.Delete(model);
                _view.IsSuccessful = true;
                _view.Message = "Deleted successfully";
                LoadSalesInvoice();

            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not delete pet";

            }
        }

        private void Search(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
                salesInvoiceList = _salesInvoiceService.GetByValue(this._view.SearchValue);
            else
                salesInvoiceList = _salesInvoiceService.GetAllSalesInvoice();
                bsSalesInvoice.DataSource = salesInvoiceList;
        }
    }
}
