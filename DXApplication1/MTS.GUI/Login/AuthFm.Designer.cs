namespace MTS.GUI.Login
{
    partial class AuthFm
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
            this.loginEdit = new DevExpress.XtraEditors.TextEdit();
            this.pwdEdit = new DevExpress.XtraEditors.TextEdit();
            this.setUserCheck = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setUserCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loginEdit
            // 
            this.loginEdit.Location = new System.Drawing.Point(12, 43);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Size = new System.Drawing.Size(249, 20);
            this.loginEdit.TabIndex = 0;
            // 
            // pwdEdit
            // 
            this.pwdEdit.Location = new System.Drawing.Point(12, 98);
            this.pwdEdit.Name = "pwdEdit";
            this.pwdEdit.Properties.PasswordChar = '*';
            this.pwdEdit.Size = new System.Drawing.Size(249, 20);
            this.pwdEdit.TabIndex = 1;
            // 
            // setUserCheck
            // 
            this.setUserCheck.Location = new System.Drawing.Point(12, 124);
            this.setUserCheck.Name = "setUserCheck";
            this.setUserCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setUserCheck.Properties.Appearance.Options.UseFont = true;
            this.setUserCheck.Properties.Caption = "Запомнить пароль";
            this.setUserCheck.Size = new System.Drawing.Size(86, 20);
            this.setUserCheck.TabIndex = 2;
            this.setUserCheck.CheckedChanged += new System.EventHandler(this.setUserCheck_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Логин ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Location = new System.Drawing.Point(12, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Пароль";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(13, 167);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Вход";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(170, 167);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(91, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отмена";
            // 
            // AuthFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 202);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.setUserCheck);
            this.Controls.Add(this.pwdEdit);
            this.Controls.Add(this.loginEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setUserCheck.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit loginEdit;
        private DevExpress.XtraEditors.TextEdit pwdEdit;
        private DevExpress.XtraEditors.CheckEdit setUserCheck;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
    }
}