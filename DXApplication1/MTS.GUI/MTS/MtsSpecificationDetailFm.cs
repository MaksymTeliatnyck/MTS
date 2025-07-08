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
        MTSSpecificationsDTO model = new MTSSpecificationsDTO();

        public MtsSpecificationDetailFm(MTSSpecificationsDTO model)
        {
            InitializeComponent();
            this.model = model;
            this.Text = "Редагування заказу у матеріальній специфікації: " + model.NAME;
            specificationNameEdit.Text = model.NAME;

            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            customerOrdersBS.DataSource = mtsService.GetCustomerOrders().ToList();
            customerOrdersBS.DataSource = mtsService.GetContractors().ToList();

            customerOrdersBS.DataSource = mtsService.GetCustomerOrdersWithDrawing().OrderByDescending(sort => sort.OrderDate).ToList();
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
                if(mtsCustomerOrdersList.Any(srch => srch.CustomerOrderId == (int)orderNumberEdit.EditValue))
                {
                    MessageBox.Show("До цієї матеріальної специфікації вже додано цей заказ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mtsService = Program.kernel.Get<IMtsSpecificationsService>();
                    mtsService.MTSCreateCustumerOrders(new MTSCustomerOrdersDTO()
                    {
                        CustomerOrderId = (int)orderNumberEdit.EditValue,
                        SpecificationId = model.ID,
                        DateCreate = DateTime.Now,
                        DateUpdate = DateTime.Now
                    });

                    LoadData(model.ID);
                    orderNumberEdit.EditValue = null;
                }    
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (mtsCustomerOrdersList.Count > 0)
            {
                List<MTSCustomerOrdersDTO> deleteList = new List<MTSCustomerOrdersDTO>();
                deleteList = mtsCustomerOrdersList.Where(chk => chk.Check == true).ToList();
                if(deleteList.Count > 0)
                {
                    if(MessageBox.Show("Ви точно бажаєте видалити закази?", "Видалення заказу", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        mtsService = Program.kernel.Get<IMtsSpecificationsService>();
                        foreach (var item in deleteList)
                        {
                            mtsService.MTSDeleteCustumerOrders(item.Id);
                        }

                        LoadData(model.ID);
                    }
                }
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}