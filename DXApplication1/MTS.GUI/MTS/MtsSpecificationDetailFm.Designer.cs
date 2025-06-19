namespace MTS.GUI.MTS
{
    partial class MtsSpecificationDetailFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MtsSpecificationDetailFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.customerOrderGrid = new DevExpress.XtraGrid.GridControl();
            this.customerOrderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.orderNumberEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addCustomerOrderBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::MTS.GUI.WaitForm1), true, true);
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.specificationNameEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificationNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customerOrderGrid
            // 
            this.customerOrderGrid.Location = new System.Drawing.Point(14, 103);
            this.customerOrderGrid.MainView = this.customerOrderGridView;
            this.customerOrderGrid.Name = "customerOrderGrid";
            this.customerOrderGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.customerOrderGrid.Size = new System.Drawing.Size(578, 261);
            this.customerOrderGrid.TabIndex = 0;
            this.customerOrderGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customerOrderGridView});
            // 
            // customerOrderGridView
            // 
            this.customerOrderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberCol,
            this.contractorNameCol,
            this.checkCol});
            this.customerOrderGridView.GridControl = this.customerOrderGrid;
            this.customerOrderGridView.Name = "customerOrderGridView";
            this.customerOrderGridView.OptionsView.ShowGroupPanel = false;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.Caption = "Номер заказа";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 0;
            this.orderNumberCol.Width = 186;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.Caption = "Контрагент";
            this.contractorNameCol.FieldName = "ContractorName";
            this.contractorNameCol.Name = "contractorNameCol";
            this.contractorNameCol.OptionsColumn.AllowEdit = false;
            this.contractorNameCol.OptionsColumn.AllowFocus = false;
            this.contractorNameCol.Visible = true;
            this.contractorNameCol.VisibleIndex = 1;
            this.contractorNameCol.Width = 332;
            // 
            // checkCol
            // 
            this.checkCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.AppearanceHeader.Image")));
            this.checkCol.AppearanceHeader.Options.UseImage = true;
            this.checkCol.AppearanceHeader.Options.UseTextOptions = true;
            this.checkCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkCol.Caption = " ";
            this.checkCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkCol.FieldName = "Check";
            this.checkCol.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.Image")));
            this.checkCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkCol.Name = "checkCol";
            this.checkCol.Visible = true;
            this.checkCol.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // orderNumberEdit
            // 
            this.orderNumberEdit.Location = new System.Drawing.Point(12, 75);
            this.orderNumberEdit.Name = "orderNumberEdit";
            this.orderNumberEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.orderNumberEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("orderNumberEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.orderNumberEdit.Properties.ImmediatePopup = true;
            this.orderNumberEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.orderNumberEdit.Properties.PopupFormSize = new System.Drawing.Size(1000, 0);
            this.orderNumberEdit.Properties.View = this.gridView2;
            this.orderNumberEdit.Size = new System.Drawing.Size(416, 22);
            this.orderNumberEdit.TabIndex = 169;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.SearchInPreview = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "№ заказу";
            this.gridColumn1.FieldName = "OrderNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 84;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Дата";
            this.gridColumn2.FieldName = "OrderDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Контрагент";
            this.gridColumn3.FieldName = "ContractorName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 169;
            // 
            // addCustomerOrderBtn
            // 
            this.addCustomerOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerOrderBtn.Image")));
            this.addCustomerOrderBtn.Location = new System.Drawing.Point(434, 74);
            this.addCustomerOrderBtn.Name = "addCustomerOrderBtn";
            this.addCustomerOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.addCustomerOrderBtn.TabIndex = 170;
            this.addCustomerOrderBtn.Text = "Додати";
            this.addCustomerOrderBtn.ToolTip = "Додати обраний заказ";
            this.addCustomerOrderBtn.Click += new System.EventHandler(this.addCustomerOrderBtn_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 56);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(29, 13);
            this.labelControl8.TabIndex = 171;
            this.labelControl8.Text = "Заказ";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(517, 370);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 172;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.ToolTip = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(515, 74);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 173;
            this.deleteBtn.Text = "Видалити";
            this.deleteBtn.ToolTip = "Видалити обраний заказ";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 13);
            this.labelControl1.TabIndex = 174;
            this.labelControl1.Text = "Матеріальна специфікація";
            // 
            // specificationNameEdit
            // 
            this.specificationNameEdit.Location = new System.Drawing.Point(14, 22);
            this.specificationNameEdit.Name = "specificationNameEdit";
            this.specificationNameEdit.Properties.AllowFocused = false;
            this.specificationNameEdit.Properties.ReadOnly = true;
            this.specificationNameEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.specificationNameEdit.Size = new System.Drawing.Size(578, 28);
            this.specificationNameEdit.TabIndex = 175;
            // 
            // MtsSpecificationDetailFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 400);
            this.Controls.Add(this.specificationNameEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.addCustomerOrderBtn);
            this.Controls.Add(this.orderNumberEdit);
            this.Controls.Add(this.customerOrderGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtsSpecificationDetailFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування заказу";
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificationNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl customerOrderGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView customerOrderGridView;
        private DevExpress.XtraEditors.GridLookUpEdit orderNumberEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton addCustomerOrderBtn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorNameCol;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraGrid.Columns.GridColumn checkCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit specificationNameEdit;
    }
}