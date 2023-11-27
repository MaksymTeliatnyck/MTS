using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Infrastructure;
using MTS.BLL.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MTS.GUI.MTS
{
    public partial class DirectoryBuyDetailEditOldFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclaturesService;
        private IMtsSpecificationsService mtsService;
        private BindingSource nomenclatureGroupsBS = new BindingSource();
        private BindingSource nomenclatureBS = new BindingSource();
        private List<MTSNomenclatureGroupsDTO> nomenclatureGroupsList = new List<MTSNomenclatureGroupsDTO>();
        private Boolean directoryParam;
        private ObjectBase Item
        {
            get { return nomenclatureGroupsBS.Current as ObjectBase; }
            set
            {
                nomenclatureGroupsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private ObjectBase ItemNomenclature
        {
            get { return nomenclatureBS.Current as ObjectBase; }
            set
            {
                nomenclatureBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DirectoryBuyDetailEditOldFm(MTSNomenclaturesDTO model, bool directory)
        {
            InitializeComponent();
            // this.operation = operation;
            directoryParam = directory;
            nomenclatureBS.DataSource = ItemNomenclature = model;

            LoadNomenclatureGroups();
        }
        private void LoadNomenclatureGroups()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            nomenclatureGroupsList = mtsService.GetAllNomenclatureGroupsOld().ToList();
            nomenclatureGroupsList.Add(new MTSNomenclatureGroupsDTO()
            {
                ID = 0,
                ADDIT_CALCULATION_ACTIVE = false,
                ADDIT_CALCULATION_ID = null,
                PARENT_ID = null,
                NAME = "Общая",
                CODPROD = 0,
                RATIO_OF_WASTE = 0,
                SORTPOSITION = 0
            });
            nomenclatureGroupsBS.DataSource = nomenclatureGroupsList;



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
            if (nomenGroupId > 0)
                nomenclatureBS.DataSource = mtsService.GetAllNomenclatures(nomenGroupId);
            else
                nomenclatureBS.DataSource = mtsService.GetAllNomenclaturesAll();

            nomenclatureGrid.DataSource = nomenclatureBS;


        }
        public MTSNomenclaturesDTO Returnl()
        {
            return ((MTSNomenclaturesDTO)ItemNomenclature);
        }

        private void SetGridSetting()
        {
            nomenGostCol.Width = Properties.Settings.Default.nomenGostCol;
            nomenGuageCol.Width = Properties.Settings.Default.nomenGuageCol;
            nomenMeasureCol.Width = Properties.Settings.Default.nomenMeasureCol;
            //gridcolumn1.width = properties.settings.default.gridcol1;
            //gridcolumn2.width = properties.settings.default.gridcol2;
            //gridcolumn3.width = properties.settings.default.gridcol3;
            //gridcolumn4.width = properties.settings.default.gridcol4;
            //gridcolumn5.width = properties.settings.default.gridcol5;
            //gridcolumn6.width = properties.settings.default.gridcol6;
            //gridcolumn7.width = properties.settings.default.gridcol7;
            //gridcolumn8.width = properties.settings.default.gridcol8;
            //gridcolumn9.width = properties.settings.default.gridcol9;
            //gridcolumn10.width = properties.settings.default.gridcol10;
            //gridcolumn11.width = properties.settings.default.gridcol11;
            //gridcolumn12.width = properties.settings.default.gridcol12;
            //gridcolumn13.width = properties.settings.default.gridcol13;
            //gridcolumn14.width = properties.settings.default.gridcol14;
            //gridcolumn15.width = properties.settings.default.gridcol15;
            //gridcolumn16.width = properties.settings.default.gridcol16;
            //gridcolumn17.width = properties.settings.default.gridcol17;
            //gridcolumn18.width = properties.settings.default.gridcol18;
            //gridcolumn19.width = properties.settings.default.gridcol19;
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
            //MTSNomenclaturesOldDTO item = (MTSNomenclaturesOldDTO)nomenclatureBS.Current;
            //MTSNomenclaturesOldDTO model = new MTSNomenclaturesOldDTO()
            //{
            //    ID = item.ID,
            //    NAME = item.NAME,
            //    GUAGE = item.GUAGE
            //};
            //DialogResult = DialogResult.OK;
            //this.Close();

            //this.Item.EndEdit();
            if (directoryParam == false)
            {
                MTSNomenclaturesDTO item = (MTSNomenclaturesDTO)nomenclatureBS.Current;
                MTSNomenclaturesDTO model = new MTSNomenclaturesDTO()
                {
                    ID = item.ID,
                    NAME = item.NAME,
                    GUAGE = item.GUAGE
                };
                DialogResult = DialogResult.OK;
                this.Close();
            }

            //   AddBuyMaterial(Utils.Operation.Update, model);//(MTSNomenclaturesOldDTO)nomenclatureBS.Current);

        }

        private void DirectoryBuyDetailEditOldFm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void addGroupItem_Click(object sender, EventArgs e)
        {
            EditNomenclatureGroup(Utils.Operation.Add, new MTSNomenclatureGroupsDTO());
        }

        private void EditNomenclatureGroup(Utils.Operation operation, MTSNomenclatureGroupsDTO model)
        {
            using (MTSNomenclatureGroupEditFm mtsNomenclatureGroupEditFm = new MTSNomenclatureGroupEditFm(operation, model))
            {
                if (mtsNomenclatureGroupEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSNomenclatureGroupsDTO returnItem = mtsNomenclatureGroupEditFm.Return();
                    nomenclatureGroupsGridView.BeginDataUpdate();

                    LoadNomenclatureGroups();

                    nomenclatureGroupsGridView.EndDataUpdate();

                    int rowHandle = nomenclatureGroupsGridView.LocateByValue("ID", returnItem.ID);

                    nomenclatureGroupsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void editGroupItem_Click(object sender, EventArgs e)
        {
            EditNomenclatureGroup(Utils.Operation.Update, (MTSNomenclatureGroupsDTO)Item);
        }

        private void deleteGroupItem_Click(object sender, EventArgs e)
        {
            mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();
            if (mtsNomenclaturesService.CheckNomenclaturesGroup(((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID))
            {
                MessageBox.Show("Група містить номенклатури. Перемістіть номенклатури до іншої групи.", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DeleteGroup();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteGroup()
        {
            if (nomenclatureGroupsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити групу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();
                    nomenclatureGroupsGridView.BeginDataUpdate();
                    mtsNomenclaturesService.NomenclarureGroupDelete(((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID);
                    LoadNomenclatureGroups();
                    nomenclatureGroupsGridView.EndDataUpdate();
                    int rowHandle = nomenclatureGroupsGridView.FocusedRowHandle - 1;
                    nomenclatureGroupsGridView.FocusedRowHandle = (nomenclatureGroupsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1; ;
                }
            }
        }

        private void addNomenclatureItem_Click(object sender, EventArgs e)
        {
            MTSNomenclaturesDTO newNomenclature = new MTSNomenclaturesDTO()
            {
                NOMENCLATUREGROUPS_ID = ((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID
            };

            editNomenclature(Utils.Operation.Add, newNomenclature);

        }

        private void editNomenclatureItem_Click(object sender, EventArgs e)
        {
            editNomenclature(Utils.Operation.Update, (MTSNomenclaturesDTO)nomenclatureBS.Current);
        }


        private void editNomenclature(Utils.Operation operation, MTSNomenclaturesDTO model)
        {
            using (MtsNomenclatureEditOldFm mtsNomenclatureEditOldFm = new MtsNomenclatureEditOldFm(operation, model))
            {
                if (mtsNomenclatureEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSNomenclaturesDTO return_Id = mtsNomenclatureEditOldFm.Return();
                    nomenclatureGridView.BeginDataUpdate();
                    //    LoadNomenclatureGroups();
                    LoadNomenclature(((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID);
                    nomenclatureGridView.EndDataUpdate();

                    int rowHandle = nomenclatureGridView.LocateByValue("ID", return_Id.ID);
                    nomenclatureGridView.FocusedRowHandle = rowHandle;
                }
            }

        }


        private void deleteNomenclatureItem_Click(object sender, EventArgs e)
        {
            if (nomenclatureBS.Count != 0)
            {
                if (MessageBox.Show("Видалити номенклатуру?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();
                    nomenclatureGridView.BeginDataUpdate();
                    mtsNomenclaturesService.NomenclarureDelete(((MTSNomenclaturesDTO)nomenclatureBS.Current).ID);

                    LoadNomenclature(((MTSNomenclatureGroupsDTO)nomenclatureGroupsBS.Current).ID);
                    nomenclatureGridView.EndDataUpdate();
                    int rowHandle = nomenclatureGridView.FocusedRowHandle - 1;
                    nomenclatureGridView.FocusedRowHandle = (nomenclatureGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1; ;

                }
            }
        }
    }
}