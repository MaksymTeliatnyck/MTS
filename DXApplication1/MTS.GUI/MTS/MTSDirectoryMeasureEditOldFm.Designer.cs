namespace MTS.GUI.MTS
{
    partial class MTSDirectoryMeasureEditOldFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.measureEdit = new DevExpress.XtraEditors.TextEdit();
            this.okBtn1 = new DevExpress.XtraEditors.SimpleButton();
            this.measureValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // measureEdit
            // 
            this.measureEdit.Location = new System.Drawing.Point(132, 13);
            this.measureEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.measureEdit.Name = "measureEdit";
            this.measureEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measureEdit.Properties.Appearance.Options.UseFont = true;
            this.measureEdit.Properties.Mask.SaveLiteral = false;
            this.measureEdit.Properties.Mask.ShowPlaceHolders = false;
            this.measureEdit.Size = new System.Drawing.Size(285, 24);
            this.measureEdit.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule2.Value1 = "<Null>";
            conditionValidationRule2.Value2 = "<Null>";
            conditionValidationRule2.Values.Add(",/3");
            this.measureValidationProvider.SetValidationRule(this.measureEdit, conditionValidationRule2);
            this.measureEdit.EditValueChanged += new System.EventHandler(this.measureEdit_EditValueChanged);
            this.measureEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.measureEdit_KeyPress);
            // 
            // okBtn1
            // 
            this.okBtn1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn1.Appearance.Options.UseFont = true;
            this.okBtn1.Location = new System.Drawing.Point(248, 45);
            this.okBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okBtn1.Name = "okBtn1";
            this.okBtn1.Size = new System.Drawing.Size(81, 24);
            this.okBtn1.TabIndex = 2;
            this.okBtn1.Text = "Додати";
            this.okBtn1.Click += new System.EventHandler(this.okBtn1_Click);
            // 
            // measureValidationProvider
            // 
            this.measureValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.measureValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.measureValidationProvider_ValidationFailed);
            this.measureValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.measureValidationProvider_ValidationSucceeded);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(16, 51);
            this.validateLbl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(200, 14);
            this.validateLbl.TabIndex = 49;
            this.validateLbl.Text = "*Для збереження, заповніть  поле";
            this.validateLbl.Click += new System.EventHandler(this.validateLbl_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.Location = new System.Drawing.Point(337, 45);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 24);
            this.cancelBtn.TabIndex = 50;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Один. вим.";
            // 
            // MTSDirectoryMeasureEditOldFm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 82);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.okBtn1);
            this.Controls.Add(this.measureEdit);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MTSDirectoryMeasureEditOldFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одиниці вимірювання";
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit measureEdit;
        private DevExpress.XtraEditors.SimpleButton okBtn1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider measureValidationProvider;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private System.Windows.Forms.Label label1;
    }
}