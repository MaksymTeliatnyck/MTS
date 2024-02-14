using DevExpress.XtraSplashScreen;
using MTS.BLL.Interfaces;
using Ninject;
using System;

namespace MTS.GUI
{
    public partial class StartScreenFm : SplashScreen
    {
        private string processText;
        private IUserService userService = Program.kernel.Get<IUserService>();

        public StartScreenFm()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);

            SplashScreenCommand command = (SplashScreenCommand)cmd;

            if (command == SplashScreenCommand.SetLabel)
            {
                processText = (string)arg;
                statusLbl.Text = processText;
            }
        }

        #endregion

        public enum SplashScreenCommand
        {
            SetLabel
        }
    }
}