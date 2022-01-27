using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MTS.BLL.Infrastructure;
using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Interfaces;
using Ninject;
using MTS.BLL.Services;

namespace MTS.GUI.MTS
{
    public partial class MTSNomenclatureGroupEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclaturesService;
        private IMtsSpecificationsService mtsSpecificationService;

        private BindingSource mtsNomenclatureGroupsBS = new BindingSource();
        private BindingSource additCalcBS = new BindingSource();


        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return mtsNomenclatureGroupsBS.Current as ObjectBase; }
            set
            {
                mtsNomenclatureGroupsBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public MTSNomenclatureGroupEditFm(Utils.Operation operation, MTSNomenclatureGroupsDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;

            mtsNomenclatureGroupsBS.DataSource = Item = model;

            mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();
            mtsSpecificationService = Program.kernel.Get<IMtsSpecificationsService>();

            //currencyRatesBS.DataSource = ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId == null ?
            //    new Currency_RatesDTO() { Currency_Id = 1, Multiplicity = 1, CurrencyPayment = 0.00m, Rate = 0.000000m } :
            //    currencyService.GetCurrencyRates().Where(s => s.Id == ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId).SingleOrDefault();

            if (operation == Utils.Operation.Add)
            {
                //((Bank_PaymentsDTO)Item).Payment_Date = DateTime.Now;
                //((Bank_PaymentsDTO)Item).Payment_Price = 0.00m;
                //((Bank_PaymentsDTO)Item).Payment_PriceCurrency = 0.00m;
                //((Bank_PaymentsDTO)Item).VatPrice = 0.00m;
                //((Bank_PaymentsDTO)Item).Rate = 0.000000m;
                //((Bank_PaymentsDTO)Item).CurrencyId = 1;
                //((Bank_PaymentsDTO)Item).AccountingOperationId = 1;

                //contractorsEdit.Enabled = false;
                //employeesEdit.Enabled = false;

                //currencyConvertEdit.Enabled = false;
                //currencyPriceConvertTBox.Enabled = false;
                //rateConvertTBox.Enabled = false;
            }
            else
            {
                //contractorCheckEdit.Checked = (((Bank_PaymentsDTO)Item).Contractor_Id > 0) ? true : false;
                //employeeCheckEdit.Checked = (((Bank_PaymentsDTO)Item).EmployeesId > 0) ? true : false;

                //if (((Bank_PaymentsDTO)Item).CurrencyRatesConvertId != null)
                //{
                //    convertCheckEdit.CheckState = CheckState.Checked;

                //    currencyConvertEdit.Enabled = true;
                //    currencyPriceConvertTBox.Enabled = true;
                //    rateConvertTBox.Enabled = true;
                //}
                //else
                //{
                //    currencyConvertEdit.Enabled = false;
                //    currencyPriceConvertTBox.Enabled = false;
                //    rateConvertTBox.Enabled = false;
                //}
            }

            //if (_operation == Utils.Operation.Custom)
            //{
            //    employeesEdit.Enabled = false;
            //    currencyConvertEdit.Enabled = false;
            //    currencyPriceConvertTBox.Enabled = false;
            //    rateConvertTBox.Enabled = false;

            //    contractorCheckEdit.Checked = true;
            //}
            //if (_operation == Utils.Operation.Template)
            //{
            //    paymentDateEdit.Enabled = false;
            //    paymentDocumentTBox.Enabled = false;
            //    paymentPriceTBox.Enabled = false;
            //    paymentPriceCurrencyTBox.Enabled = false;
            //    currencyEdit.Enabled = false;
            //    groupControl3.Enabled = false;
            //    purposeEdit.Enabled = false;
            //    rateTBox.Enabled = false;
            //    vatPriceTBox.Enabled = false;

            //    vatAccountEdit.Enabled = false;
            //    convertCheckEdit.Enabled = false;
            //    groupControl4.Enabled = false;





            //    employeesEdit.Enabled = false;
            //    currencyConvertEdit.Enabled = false;
            //    currencyPriceConvertTBox.Enabled = false;
            //    rateConvertTBox.Enabled = false;

            //    contractorCheckEdit.Checked = true;
            //}



            //accountsBS.DataSource = accountsService.GetAccounts();

            #region DataBinding's

            nomeclatureNameEdit.DataBindings.Add("EditValue", mtsNomenclatureGroupsBS, "NAME", true, DataSourceUpdateMode.OnPropertyChanged);
            ratioOfWasteEdit.DataBindings.Add("EditValue", mtsNomenclatureGroupsBS, "RATIO_OF_WASTE", true, DataSourceUpdateMode.OnPropertyChanged);
            additCalcEdit.DataBindings.Add("EditValue", mtsNomenclatureGroupsBS, "ADDIT_CALCULATION_ID", true, DataSourceUpdateMode.OnPropertyChanged);


            additCalcEdit.DataBindings.Add("EditValue", additCalcBS, "CurrencyId", true, DataSourceUpdateMode.OnPropertyChanged);
            additCalcEdit.Properties.DataSource = mtsSpecificationService.GetAdditCalculationUnits();
            additCalcEdit.Properties.ValueMember = "Id";
            additCalcEdit.Properties.DisplayMember = "Name";
            additCalcEdit.Properties.NullText = "Немає данних";

            

            #endregion

            //ControlValidation();

            splashScreenManager.CloseWaitForm();
        }

        //private void EditBankPayment(Utils.Operation operation, MTSNomenclatureGroupsDTO model)
        //{
        //    using (BankPaymentEditFm bankPaymentEditFm = new BankPaymentEditFm(operation, model))
        //    {
        //        if (bankPaymentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            Bank_PaymentsDTO returnItem = bankPaymentEditFm.Return();
        //            bankPaymentsGridView.BeginDataUpdate();

        //            LoadDataByPeriod(_beginDate, _endDate);

        //            bankPaymentsGridView.EndDataUpdate();

        //            int rowHandle = bankPaymentsGridView.LocateByValue("Id", returnItem.Id);

        //            bankPaymentsGridView.FocusedRowHandle = rowHandle;
        //        }
        //    }
        //}
        public NomenclatureGroupsDTO Return()
        {
            return (NomenclatureGroupsDTO)Item;
        }
   
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}