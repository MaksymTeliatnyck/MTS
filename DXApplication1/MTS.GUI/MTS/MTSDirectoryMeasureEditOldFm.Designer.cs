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
            this.measureBtn = new System.Windows.Forms.Button();
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
            // measureBtn
            // 
            this.measureBtn.Location = new System.Drawing.Point(241, 38);
            this.measureBtn.Name = "measureBtn";
            this.measureBtn.Size = new System.Drawing.Size(75, 23);
            this.measureBtn.TabIndex = 1;
            this.measureBtn.Text = "OK";
            this.measureBtn.UseVisualStyleBackColor = true;
            this.measureBtn.Click += new System.EventHandler(this.measureBtn_Click);
            // 
            // MTSDirectoryMeasureEditOldFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 101);
            this.Controls.Add(this.measureBtn);
            this.Controls.Add(this.measureEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MTSDirectoryMeasureEditOldFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Единицы измерения";
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit measureEdit;
        private System.Windows.Forms.Button measureBtn;
    }
}