using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MTS.GUI.MTS
{
    public partial class MtsSpecificationOldSelectFm : DevExpress.XtraEditors.XtraForm
    {

        private List<MTSSpecificationsDTO> mtsSpecificationsList = new List<MTSSpecificationsDTO>();
        private IMtsSpecificationsService mtsService;
        private BindingSource specificBS = new BindingSource();

        public MtsSpecificationOldSelectFm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            specificBS.DataSource = mtsService.GetAllSpecificationOld().OrderByDescending(ord => ord.ID).ToList();
            specificGrid.DataSource = specificBS;
        }

        public List<MTSSpecificationsDTO> Return()
        {
            return mtsSpecificationsList;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            specificGridView.PostEditor();

            mtsSpecificationsList = ((List<MTSSpecificationsDTO>)specificBS.DataSource).Where(s => s.Selected).ToList();
            if (mtsSpecificationsList.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

            else { MessageBox.Show("Выберите спецификацию!"); }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cancelBtn2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn2_Click(object sender, EventArgs e)
        {
            specificGridView.PostEditor();

            mtsSpecificationsList = ((List<MTSSpecificationsDTO>)specificBS.DataSource).Where(s => s.Selected).ToList();
            if (mtsSpecificationsList.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

            else { MessageBox.Show("Выберите спецификацию!"); }
        }
    }
}