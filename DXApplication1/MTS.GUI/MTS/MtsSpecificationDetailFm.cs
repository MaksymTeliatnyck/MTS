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
using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Interfaces;
using Ninject;

namespace MTS.GUI.MTS
{
    public partial class MtsSpecificationDetailFm : DevExpress.XtraEditors.XtraForm
    {

        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource mtsCustomerOrdersBS = new BindingSource();

        private IMtsSpecificationsService mtsService;

        List<MTSCustomerOrdersDTO> mtsCustomerOrdersList = new List<MTSCustomerOrdersDTO>();

        public MtsSpecificationDetailFm(MTSSpecificationsDTO model)
        {
            InitializeComponent();

            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            customerOrdersBS.DataSource = mtsService.GetCustomerOrders().ToList();
            customerOrdersBS.DataSource = mtsService.GetContractors().ToList();

            customerOrdersBS.DataSource = mtsService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "";

            LoadData(model.ID);
        }

        private void LoadData(int specId)
        {
            splashScreenManager.ShowWaitForm();

            mtsService = Program.kernel.Get<IMtsSpecificationsService>();

            mtsCustomerOrdersList = mtsService.GetMTSCustomerOrdersFullBySpecificationId(specId).ToList();
            mtsCustomerOrdersBS.DataSource = mtsCustomerOrdersList;
            customerOrderGrid.DataSource = mtsCustomerOrdersBS;

            splashScreenManager.CloseWaitForm();
        }

        private void addCustomerOrderBtn_Click(object sender, EventArgs e)
        {
            if(orderNumberEdit.EditValue!=null)
            {
                //mtsService = Program.kernel.Get<IMtsSpecificationsService>();
                //mtsService.C((CashBookPageDTO)Item);
            }
            else
            {

            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (orderNumberEdit.EditValue != null)
            {
                //mtsService = Program.kernel.Get<IMtsSpecificationsService>();
                //mtsService.C((CashBookPageDTO)Item);
            }
            else
            {

            }
        }
    }
}