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
            this.measureEdit = new DevExpress.XtraEditors.TextEdit();
            this.okBtn1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // measureEdit
            // 
            this.measureEdit.Location = new System.Drawing.Point(35, 40);
            this.measureEdit.Name = "measureEdit";
            this.measureEdit.Size = new System.Drawing.Size(140, 20);
            this.measureEdit.TabIndex = 0;
            // 
            // okBtn1
            // 
            this.okBtn1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.okBtn1.Appearance.Options.UseFont = true;
            this.okBtn1.Location = new System.Drawing.Point(241, 38);
            this.okBtn1.Name = "okBtn1";
            this.okBtn1.Size = new System.Drawing.Size(75, 23);
            this.okBtn1.TabIndex = 2;
            this.okBtn1.Text = "Ок";
            this.okBtn1.Click += new System.EventHandler(this.okBtn1_Click);
            // 
            // MTSDirectoryMeasureEditOldFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 101);
            this.Controls.Add(this.okBtn1);
            this.Controls.Add(this.measureEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MTSDirectoryMeasureEditOldFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одиниці вимірювання";
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit measureEdit;
        private DevExpress.XtraEditors.SimpleButton okBtn1;
    }
}