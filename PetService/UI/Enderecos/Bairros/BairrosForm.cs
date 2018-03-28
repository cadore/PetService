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
    public partial class BairrosForm : UtilForm
    {
        public BairrosForm()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<bairro> listB = bairro.Fetch(String.Format("WHERE nome ILIKE '{0}' ORDER BY nome", bairro.Concat(tfDescricao.EditValue)));
            bdgBairros.DataSource = listB;
        }

        private void tfDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            bairro b = (bairro)bdgBairros.Current;
            if(b != null)
            {
                NovoBairro nb = new NovoBairro(b);
                if (nb.ShowDialog() == DialogResult.OK)
                    btnPesquisar_Click(sender, e);
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoBairro nb = new NovoBairro(null);
            if(nb.ShowDialog() == DialogResult.OK)
                btnPesquisar_Click(sender, e);
        }
    }
}