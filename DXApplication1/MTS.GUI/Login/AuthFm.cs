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
using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Interfaces;
using Ninject;
using MTS.BLL.Services;
using DevExpress.XtraSplashScreen;
using System.Threading;
using MTS.GUI.MTS;
using DevExpress.XtraBars;

namespace MTS.GUI.Login
{
    public partial class AuthFm : DevExpress.XtraEditors.XtraForm
    {
        private IUserService userService;
        private MTS_AUTHORIZATION_USERS_DTO userInfo;
        private IEnumerable<UserTasksDTO> userAccess;
        public AuthFm()
        {

            InitializeComponent();
            setUserCheck.Checked = Properties.Settings.Default.MtsCheckUser;
            loginEdit.Text = Properties.Settings.Default.MtsLoginUser;
            if(setUserCheck.Checked)
                pwdEdit.Text = Properties.Settings.Default.MtsPassUser;

            userService = Program.kernel.Get<IUserService>();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(setUserCheck.Checked)
            {
                Properties.Settings.Default.MtsLoginUser = loginEdit.Text;
                Properties.Settings.Default.MtsPassUser = pwdEdit.Text;
                Properties.Settings.Default.Save();
            }

            if (!CheckAccess())
            {
                this.Show();
                return;
            }

            userInfo = UserService.AuthorizatedUser;

            using (MtsSpecificationOldFm mtsSpecificationOldFm = new MtsSpecificationOldFm(userInfo))
            {
                if (mtsSpecificationOldFm.ShowDialog() == System.Windows.Forms.DialogResult.Abort)
                    this.Close();
            }

        }

        private bool CheckAccess()
        {
            userService = Program.kernel.Get<IUserService>();

            SplashScreenManager.ShowForm(typeof(StartScreenFm));
            SplashScreenManager.Default.SendCommand(StartScreenFm.SplashScreenCommand.SetLabel, "Авторизация пользователя...");
            Thread.Sleep(200);

            if (userService.TryAuthorize(loginEdit.Text, pwdEdit.Text))
            {
                //добавить трай-кач
                //SplashScreenManager.Default.SendCommand(StartScreenFm.SplashScreenCommand.SetLabel, "Користувач успішно авторизований \n(" + UserService.AuthorizatedUser.Fio + ")");
                //Thread.Sleep(200);
                SplashScreenManager.Default.SendCommand(StartScreenFm.SplashScreenCommand.SetLabel, "Настройки прав доступа...");
                Thread.Sleep(200);
                SplashScreenManager.CloseForm();
                return true;
            }
            else
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("Вам не разрешено работать в системе \nОбратитесь в отдел АСУП. \n", "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load += (s, e) => Close();
                return false;
            }

        }



        private void setUserCheck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MtsCheckUser = setUserCheck.Checked;
            Properties.Settings.Default.Save();
        }
    }
}