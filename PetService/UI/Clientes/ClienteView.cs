using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PetService.UI.Clientes
{
    public partial class ClienteView : PetService.UI.Utils.UserControlUtil
    {
        public ClienteView(cliente c)
        {
            InitializeComponent();
            if (c == null)
            {
                IsNew = true;
                c = new cliente();
            }
        }
    }
}
