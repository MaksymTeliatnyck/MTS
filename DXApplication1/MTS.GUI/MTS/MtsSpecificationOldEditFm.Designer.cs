namespace MTS.GUI.MTS
{
    partial class MtsSpecificationOldEditFm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawingEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.weightEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nameSpecificationEdit = new DevExpress.XtraEditors.MemoEdit();
            this.saveDBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelDBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameSpecificationEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(520, 219);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cancelDBtn);
            this.groupControl1.Controls.Add(this.saveDBtn);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.drawingEdit);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.quantityEdit);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.weightEdit);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.dateEdit);
            this.groupControl1.Controls.Add(this.nameSpecificationEdit);
            this.groupControl1.Location = new System.Drawing.Point(0, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(516, 209);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Спецификация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(314, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(134, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вес";
            // 
            // drawingEdit
            // 
            this.drawingEdit.Location = new System.Drawing.Point(12, 108);
            this.drawingEdit.Name = "drawingEdit";
            this.drawingEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawingEdit.Properties.Appearance.Options.UseFont = true;
            this.drawingEdit.Size = new System.Drawing.Size(496, 22);
            this.drawingEdit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // quantityEdit
            // 
            this.quantityEdit.Location = new System.Drawing.Point(12, 152);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityEdit.Properties.Appearance.Options.UseFont = true;
            this.quantityEdit.Size = new System.Drawing.Size(117, 22);
            this.quantityEdit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Чертёж";
            // 
            // weightEdit
            // 
            this.weightEdit.Location = new System.Drawing.Point(134, 152);
            this.weightEdit.Name = "weightEdit";
            this.weightEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightEdit.Properties.Appearance.Options.UseFont = true;
            this.weightEdit.Size = new System.Drawing.Size(173, 22);
            this.weightEdit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изделие";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(314, 152);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEdit.Properties.Appearance.Options.UseFont = true;
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(194, 22);
            this.dateEdit.TabIndex = 4;
            // 
            // nameSpecificationEdit
            // 
            this.nameSpecificationEdit.Location = new System.Drawing.Point(14, 46);
            this.nameSpecificationEdit.Name = "nameSpecificationEdit";
            this.nameSpecificationEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameSpecificationEdit.Properties.Appearance.Options.UseFont = true;
            this.nameSpecificationEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameSpecificationEdit.Size = new System.Drawing.Size(494, 40);
            this.nameSpecificationEdit.TabIndex = 0;
            // 
            // saveDBtn
            // 
            this.saveDBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDBtn.Appearance.Options.UseFont = true;
            this.saveDBtn.Location = new System.Drawing.Point(314, 179);
            this.saveDBtn.Name = "saveDBtn";
            this.saveDBtn.Size = new System.Drawing.Size(87, 23);
            this.saveDBtn.TabIndex = 12;
            this.saveDBtn.Text = "Сохранить";
            this.saveDBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelDBtn
            // 
            this.cancelDBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelDBtn.Appearance.Options.UseFont = true;
            this.cancelDBtn.Location = new System.Drawing.Point(415, 179);
            this.cancelDBtn.Name = "cancelDBtn";
            this.cancelDBtn.Size = new System.Drawing.Size(93, 23);
            this.cancelDBtn.TabIndex = 13;
            this.cancelDBtn.Text = "Отмена";
            this.cancelDBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MtsSpecificationOldEditFm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 219);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtsSpecificationOldEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование спецификации";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameSpecificationEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.TextEdit weightEdit;
        private DevExpress.XtraEditors.TextEdit quantityEdit;
        private DevExpress.XtraEditors.TextEdit drawingEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit nameSpecificationEdit;
        private DevExpress.XtraEditors.SimpleButton cancelDBtn;
        private DevExpress.XtraEditors.SimpleButton saveDBtn;
    }
}