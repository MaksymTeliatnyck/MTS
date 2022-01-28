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

namespace MTS.GUI.MTS
{
    public partial class MTSNomenclatureGroupEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;
        private IMtsNomenclaturesService mtsNomenclaturesService;

        private BindingSource mtsNomenclatureGroupBS = new BindingSource();
        private BindingSource additCalcWasteBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return mtsNomenclatureGroupBS.Current as ObjectBase; }
            set
            {
                mtsNomenclatureGroupBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }
        public MTSNomenclatureGroupEditFm(Utils.Operation oparation, MTSNomenclatureGroupsDTO model)
        {
            InitializeComponent();

            this.operation = operation;

            mtsNomenclatureGroupBS.DataSource = Item = model;

            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();

            nomenclatureGroupNameEdit.DataBindings.Add("EditValue", mtsNomenclatureGroupBS, "NAME", true, DataSourceUpdateMode.OnPropertyChanged);
            ratOfWasteEdit.DataBindings.Add("EditValue", mtsNomenclatureGroupBS, "RATIO_OF_WASTE", true, DataSourceUpdateMode.OnPropertyChanged);
            activeCheck.DataBindings.Add("Checked", mtsNomenclatureGroupBS, "ADDIT_CALCULATION_ACTIVE", true, DataSourceUpdateMode.OnPropertyChanged);

            additCalcEdit.DataBindings.Add("EditValue", mtsNomenclatureGroupBS, "ADDIT_CALCULATION_ID", true, DataSourceUpdateMode.OnPropertyChanged);
            additCalcEdit.Properties.DataSource = mtsSpecificationsService.GetAdditCalculationUnits();
            additCalcEdit.Properties.ValueMember = "ID";
            additCalcEdit.Properties.DisplayMember = "Name";
            additCalcEdit.Properties.NullText = "Немає данних";

        }

        public MTSNomenclatureGroupsDTO Return()
        {
            return (MTSNomenclatureGroupsDTO)Item;
        }

        private void activeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (activeCheck.Checked)
                additCalcEdit.Enabled = true;
            else
                additCalcEdit.Enabled = false;
        }

        private void activeCheck_PropertiesChanged(object sender, EventArgs e)
        {
            if (activeCheck.Checked)
                additCalcEdit.Enabled = true;
            else
                additCalcEdit.Enabled = false;
        }

        private void activeCheck_EditValueChanged(object sender, EventArgs e)
        {
            if (activeCheck.Checked)
                additCalcEdit.Enabled = true;
            else
                additCalcEdit.Enabled = false;
        }
    }
}