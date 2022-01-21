namespace MTS.GUI.MTS
{
    partial class DirectoryDetailOldFm
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.nameEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.drawingEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.okBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.detailGrid = new DevExpress.XtraGrid.GridControl();
            this.detailGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRAWING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detalContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).BeginInit();
            this.detalContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.nameEdit,
            this.drawingEdit,
            this.okBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(716, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // nameEdit
            // 
            this.nameEdit.Caption = "Наименование";
            this.nameEdit.Edit = this.repositoryItemTextEdit1;
            this.nameEdit.EditWidth = 120;
            this.nameEdit.Id = 3;
            this.nameEdit.Name = "nameEdit";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // drawingEdit
            // 
            this.drawingEdit.Caption = "Чертеж           ";
            this.drawingEdit.Edit = this.repositoryItemTextEdit2;
            this.drawingEdit.EditWidth = 120;
            this.drawingEdit.Id = 4;
            this.drawingEdit.Name = "drawingEdit";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // okBtn
            // 
            this.okBtn.Caption = "Поиск";
            this.okBtn.Glyph = global::MTS.GUI.PrintRibbonControllerResources.RibbonPrintPreview_ZoomLarge;
            this.okBtn.Id = 5;
            this.okBtn.Name = "okBtn";
            this.okBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.okBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.okBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.nameEdit);
            this.ribbonPageGroup.ItemLinks.Add(this.drawingEdit);
            this.ribbonPageGroup.ItemLinks.Add(this.okBtn);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // detailGrid
            // 
            this.detailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGrid.Location = new System.Drawing.Point(0, 95);
            this.detailGrid.MainView = this.detailGridView;
            this.detailGrid.Name = "detailGrid";
            this.detailGrid.Size = new System.Drawing.Size(716, 352);
            this.detailGrid.TabIndex = 1;
            this.detailGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailGridView});
            // 
            // detailGridView
            // 
            this.detailGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NAME,
            this.DRAWING});
            this.detailGridView.GridControl = this.detailGrid;
            this.detailGridView.Name = "detailGridView";
            this.detailGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.detailGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // NAME
            // 
            this.NAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NAME.AppearanceCell.Options.UseFont = true;
            this.NAME.AppearanceCell.Options.UseTextOptions = true;
            this.NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NAME.AppearanceHeader.Options.UseFont = true;
            this.NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAME.Caption = "Найменование";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 0;
            // 
            // DRAWING
            // 
            this.DRAWING.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DRAWING.AppearanceCell.Options.UseFont = true;
            this.DRAWING.AppearanceCell.Options.UseTextOptions = true;
            this.DRAWING.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DRAWING.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DRAWING.AppearanceHeader.Options.UseFont = true;
            this.DRAWING.AppearanceHeader.Options.UseTextOptions = true;
            this.DRAWING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DRAWING.Caption = "Чертеж";
            this.DRAWING.FieldName = "DRAWING";
            this.DRAWING.Name = "DRAWING";
            this.DRAWING.OptionsColumn.AllowEdit = false;
            this.DRAWING.OptionsColumn.AllowFocus = false;
            this.DRAWING.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DRAWING.Visible = true;
            this.DRAWING.VisibleIndex = 1;
            // 
            // detalContextMenuStrip
            // 
            this.detalContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripMenuItem});
            this.detalContextMenuStrip.Name = "detalContextMenuStrip";
            this.detalContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.delToolStripMenuItem.Text = "Удалить";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // DirectoryDetailOldFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 447);
            this.ContextMenuStrip = this.detalContextMenuStrip;
            this.Controls.Add(this.detailGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DirectoryDetailOldFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник деталей";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).EndInit();
            this.detalContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraGrid.GridControl detailGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView detailGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraBars.BarEditItem nameEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem drawingEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn DRAWING;
        private DevExpress.XtraBars.BarButtonItem okBtn;
        private System.Windows.Forms.ContextMenuStrip detalContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
    }
}