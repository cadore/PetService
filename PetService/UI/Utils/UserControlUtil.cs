using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using PetService.UI.SplashScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetService.UI.Utils
{
    public class UserControlUtil : DevExpress.XtraEditors.XtraUserControl
    {
        public static DesktopForm desk = null;

        protected bool IsNew;
        public UserControlUtil()
        {
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        protected bool MessageToSave(string s)
        {
            if (IsNew)
            {
                DialogResult rs = XtraMessageBox.Show(String.Format("{0} salvo com sucesso, deseja cadastrar um novo?", s), "Cadore Tecnologia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                    return true;
            }
            else
            {
                XtraMessageBox.Show(String.Format("{0} atualizado com sucesso", s), "Cadore Tecnologia");
            }
            desk.CloseCurrentTab();
            return false;
        }

        protected decimal ToDecimal(object b)
        {
            decimal d;
            try
            {
                d = Convert.ToDecimal(b);
            }
            catch (Exception)
            {
                d = 0;
            }
            return d;
        }
    }
}
