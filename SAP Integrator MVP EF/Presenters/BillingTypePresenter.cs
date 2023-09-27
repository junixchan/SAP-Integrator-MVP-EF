using Microsoft.EntityFrameworkCore;
using SAP_Integrator_MVP_EF.Data;
using SAP_Integrator_MVP_EF.Services.BillingTypeService;
using SAP_Integrator_MVP_EF.Views.BillingTypeView;
using SAP_Integrator_MVP_EF.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Integrator_MVP_EF.Presenters
{
    public class BillingTypePresenter
    {
        private readonly IBillingTypeView _view;
        private readonly IBillingTypeService _service;
        private BindingSource bindingSource;
        private IEnumerable<BillingType> dataList;

        //private IBillingTypeService repository;



        public BillingTypePresenter(IBillingTypeView view, IBillingTypeService service)
        {
            this.bindingSource = new BindingSource();
            this._view = view;
            this._service = service;
            this._view.Show();



            //Events
            this._view.AddNewEvent += AddNew;
            this._view.SearchEvent += Search;
            this._view.EditEvent += LoadSelectedToEdit;
            this._view.DeleteEvent += DeleteSelected;
            this._view.SaveEvent += Save;
            this._view.CancelEvent += CancelAction;


            //Methods
            this._view.SetBindingSourceList(bindingSource);
            this.LoadData();
            CleanviewFields();
        }

        public void LoadData()
        {
            dataList = _service.GetAll();
            bindingSource.DataSource = dataList;
        }


        private void AddNew(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void LoadSelectedToEdit(object? sender, EventArgs e)
        {
            var billingType = (BillingType)bindingSource.Current;
            _view.Id = billingType.Id.ToString();
            _view.Name = billingType.Name;
            _view.Description = billingType.Description;
            _view.SAP_ObjectCode = billingType.SAP_ObjectCode.ToString(); ;
            _view.IsEdit = true;
        }

        private void CleanviewFields()
        {
            _view.Id = "0";
            _view.Name = "";
            _view.Description = "";
            _view.SAP_ObjectCode = "13";
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }


        private void Save(object sender, EventArgs e)
        {
            var model = new BillingType();
            model.Id = Convert.ToInt32(_view.Id);
            model.Name = _view.Name;
            model.Description = _view.Description;
            model.SAP_ObjectCode = Convert.ToInt32(_view.SAP_ObjectCode);

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (_view.IsEdit)
                {
                    _service.Edit(model);
                    _view.Message = "Edited successfuly";
                }
                else
                {
                    _service.Add(model);
                    _view.Message = "Added successfuly";
                }
                _view.IsSuccessful = true;
                LoadData();
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
                var model = (BillingType)bindingSource.Current; 
                 _service.Delete(model);
                _view.IsSuccessful = true;
                _view.Message = "Deleted successfully";
                LoadData();

            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An eror ocurred, could not delete pet";

            }
        }

        private void Search(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
                dataList = _service.GetByValue(this._view.SearchValue);
            else
                dataList = _service.GetAll();
            bindingSource.DataSource = dataList;
        }
    }
}
