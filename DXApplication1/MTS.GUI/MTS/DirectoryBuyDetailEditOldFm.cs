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
using MTS.BLL.DTO;
using MTS.BLL.DTO.ModelsDTO;
using Ninject;
using MTS.BLL.Infrastructure;
using MTS.BLL.Interfaces;
using MTS.BLL.Services;

namespace MTS.GUI.MTS
{
    public partial class DirectoryBuyDetailEditOldFm : DevExpress.XtraEditors.XtraForm
    {
       // private Utils.Operation operation;
        private IMtsSpecificationsService mtsService;
        private BindingSource nomenclatureGroupsBS = new BindingSource();
        private BindingSource nomenclatureBS = new BindingSource();

        private ObjectBase Item
        {
            get { return nomenclatureBS.Current as ObjectBase; }
            set
            {
                nomenclatureBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DirectoryBuyDetailEditOldFm(MTSNomenclaturesDTO model)
        {
            InitializeComponent();
           // this.operation = operation;

            nomenclatureBS.DataSource = Item = model;

            LoadNomenclatureGroups();
        }
        private void LoadNomenclatureGroups()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            nomenclatureGroupsBS.DataSource = mtsService.GetAllNomenclatureGroupsOld();
            nomenclatureGroupsGrid.DataSource = nomenclatureGroupsBS;
            if (nomenclatureGroupsBS.Count == 0)
                nomenclatureGrid.DataSource = null;
            else 
            {
                nomenclatureGrid.DataSource = nomenclatureBS;
                LoadNomenclature(((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID);
            }

        }
        private void LoadNomenclature(int nomenGroupId)
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            nomenclatureBS.DataSource = mtsService.GetAllNomenclatures(nomenGroupId);
            nomenclatureGrid.DataSource = nomenclatureBS;


        }
        public MTSNomenclaturesDTO Returnl()
        {
            return ((MTSNomenclaturesDTO)Item);
        }

        

        public MTSNomenclatureGroupsDTO Return()
        {
            return ((MTSNomenclatureGroupsDTO)Item);
        }

        //private void AddBuyMaterial(Utils.Operation operation, MTSNomenclaturesOldDTO buyDetails)
        //{
            
        //   // using (MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm = new MtsBuyDetailEditOldFm(operation, buyDetails))
        //    MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm = new MtsBuyDetailEditOldFm(operation, buyDetails);
           
        //        if (mtsBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            MTSNomenclaturesOldDTO getBuyMaterial = mtsBuyDetailEditOldFm.Return();
                    
        //        }
           
            
        //}
        private void nomenclatureGroupsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (nomenclatureGroupsBS.Count > 0)
                LoadNomenclature(((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID);
        }
        
        private void nomenclatureGridView_DoubleClick(object sender, EventArgs e)
        {
         //   this.Item.EndEdit();
            MTSNomenclaturesDTO item = (MTSNomenclaturesDTO)nomenclatureBS.Current;   
            MTSNomenclaturesDTO model = new MTSNomenclaturesDTO()
            {
                ID = item.ID,
                NAME = item.NAME,
                GUAGE = item.GUAGE
            };
            DialogResult = DialogResult.OK;
            this.Close();
            
         //   AddBuyMaterial(Utils.Operation.Update, model);//(MTSNomenclaturesOldDTO)nomenclatureBS.Current);

        }

        private void DirectoryBuyDetailEditOldFm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}