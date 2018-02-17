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

namespace PetService.UI.Clientes.Contatos
{
    public partial class NovoContatoForm : UtilForm
    {
        public clientes_contato Contato;
        public NovoContatoForm()
        {
            InitializeComponent();
            bdgContato.DataSource = new clientes_contato();
            tfContato.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            Contato = (clientes_contato)bdgContato.Current;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}