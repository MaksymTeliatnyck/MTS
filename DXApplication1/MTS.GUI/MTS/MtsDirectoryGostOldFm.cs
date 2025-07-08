using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Infrastructure;
using MTS.BLL.Interfaces;
using Ninject;
using System;
using System.Windows.Forms;

namespace MTS.GUI.MTS
{
    public partial class MtsDirectoryGostOldFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsService;
        private BindingSource gostBS = new BindingSource();


        public MtsDirectoryGostOldFm()
        {
            InitializeComponent();
            LoadGost();
        }

        private void LoadGost()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            gostBS.DataSource = mtsService.GetAllGostOld();
            gostGrid.DataSource = gostBS;

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditGost(Utils.Operation.Update, ((MTSGostDTO)gostBS.Current));
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGost(((MTSGostDTO)gostBS.Current).ID);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditGost(Utils.Operation.Add, new MTSGostDTO());
        }

        private void EditGost(Utils.Operation operation, MTSGostDTO model)
        {
            using (MtsDirectoryGostEditOldFm mtsDirectoryGostEditOldFm = new MtsDirectoryGostEditOldFm(operation, model))
            {
                if (mtsDirectoryGostEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSGostDTO return_Id = mtsDirectoryGostEditOldFm.Return();
                    //((MTSGostDTO)gostBS.Current).ID = return_Id.ID;


                    //gostGridView.PostEditor();
                    gostGridView.BeginDataUpdate();
                    LoadGost();
                    gostGridView.EndDataUpdate();

                    int rowHandle = gostGridView.LocateByValue("ID", return_Id.ID);
                    gostGridView.FocusedRowHandle = rowHandle;
                }
            }
        }
        private void DeleteGost(int Id)
        {
            if (MessageBox.Show("Видалити Гост?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mtsService = Program.kernel.Get<IMtsSpecificationsService>();

                mtsService.MTSDeleteGost(Id);

                gostGridView.PostEditor();
                gostGridView.BeginDataUpdate();
                LoadGost();
                gostGridView.EndDataUpdate();
            }
        }

        private void MtsDirectoryGostOldFm_Load(object sender, EventArgs e)
        {

        }
    }
}