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

namespace PetService.UI
{
    public partial class UtilForm : DevExpress.XtraEditors.XtraForm
    {
        public static DesktopForm desk = null;
        public UtilForm()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
            KeyPreview = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        }
    }
}