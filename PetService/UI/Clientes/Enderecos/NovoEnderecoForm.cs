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

namespace PetService.UI.Clientes.Enderecos
{
    public partial class NovoEnderecoForm : UtilForm
    {
        public clientes_endereco Endereco;
        public NovoEnderecoForm()
        {
            InitializeComponent();
            bdgBairros.DataSource = bairro.Fetch("ORDER BY nome");
            bdgEnderecos.DataSource = new clientes_endereco() { cidade = "LUCAS DO RIO VERDE", estado = "MT - MATO GROSSO" };
            tfEndereco.Focus();
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
            Endereco = (clientes_endereco)bdgEnderecos.Current;
            Endereco.bairro_descricao = cbBairro.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NovoEnderecoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                btnCancelar_Click(sender, e);
        }
    }
}