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
using PetService.UI.Pets.Racas;
using PetService.UI.Enderecos.Bairros;

namespace PetService.UI.Clientes
{
    public partial class CadastroRapidoCliente : PetService.UI.UtilForm
    {
        public CadastroRapidoCliente()
        {
            InitializeComponent();

            //carrega bairros
            bdgBairros.DataSource = bairro.Fetch("ORDER BY nome");
            bdgCliente.DataSource = new cliente() { pre_cadastro = true };
            bdgPet.DataSource = new pet() { pre_cadastro = true, especie = -1, porte = -1 };
            bdgEndereco.DataSource = new clientes_endereco() { cidade = "LUCAS DO RIO VERDE", estado = "MT - MATO GROSSO", principal = true };
            bdgContato.DataSource = new clientes_contato() { principal = true };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!validador.Validate())
                return;
            try
            {
                using (var scope = cliente.repo.GetTransaction())
                {
                    cliente c = (cliente)bdgCliente.Current;
                    clientes_endereco ce = (clientes_endereco)bdgEndereco.Current;
                    clientes_contato cc = (clientes_contato)bdgContato.Current;
                    pet p = (pet)bdgPet.Current;
                    c.Save();
                    ce.cliente_id = c.id;
                    cc.cliente_id = c.id;
                    p.cliente_id = c.id;
                    ce.Save();
                    cc.Save();
                    p.Save();
                    scope.Complete();
                    XtraMessageBox.Show("Cliente e Pet adicionados com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cliente.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void especieRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (especieRadioGroup.EditValue != null)
            {
                //carrega racas
                List<raca> listR = raca.Fetch("WHERE tipo_raca = @0 ORDER BY tipo_raca, raca_descricao", especieRadioGroup.EditValue);
                for (int i = 0; i < listR.Count; i++)
                {
                    listR[i].tipo_raca_desc = listR[i].tipo_raca == 0 ? "Canina" : "Felina";
                }
                bdgRacas.DataSource = listR;
            }
        }

        private void btnAddRaca_Click(object sender, EventArgs e)
        {
            NovaRacaForm nrf = new NovaRacaForm(null);
            DialogResult rs = nrf.ShowDialog();
            if (rs == DialogResult.OK)
                especieRadioGroup_SelectedIndexChanged(null, null);
        }

        private void btnAddBairro_Click(object sender, EventArgs e)
        {
            NovoBairro nb = new NovoBairro(null);
            if (nb.ShowDialog() == DialogResult.OK)
            {
                bdgBairros.DataSource = bairro.Fetch("ORDER BY nome");
                cbBairro.EditValue = bairro.SingleOrDefault("ORDER BY id DESC LIMIT 1").id;
            }
        }
    }
}
