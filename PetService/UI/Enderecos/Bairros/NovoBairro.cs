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

namespace PetService.UI.Enderecos.Bairros
{
    public partial class NovoBairro : UtilForm
    {
        public NovoBairro(bairro b)
        {
            InitializeComponent();
            if (b == null)
                b = new bairro() { taxa_entrega = 0 };
            bdgBairro.DataSource = b;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                bairro b = (bairro)bdgBairro.Current;
                b.Save();
                XtraMessageBox.Show("Bairro salvo com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Erro/Atenção");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}