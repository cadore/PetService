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
using PetService.UI.Clientes.Contatos;
using PetService.UI.Clientes.Enderecos;

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
                bdgContatos.DataSource = new List<clientes_contato>();
                bdgEnderecos.DataSource = new List<clientes_endereco>();
            }
            else
            {
                bdgContatos.DataSource = clientes_contato.Fetch("WHERE cliente_id=@0 ORDER BY id", c.id);
                bdgEnderecos.DataSource = clientes_endereco.Fetch("WHERE cliente_id=@0 ORDER BY id", c.id);
            }
            bdgCliente.DataSource = c;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            NovoContatoForm ccf = new NovoContatoForm();
            if (ccf.ShowDialog() == DialogResult.OK)
            {
                if (ccf.Contato.telefone != null)
                {
                    foreach (clientes_contato co in bdgContatos.List)
                    {
                        if (co.telefone == ccf.Contato.telefone)
                        {
                            XtraMessageBox.Show(String.Format("O numero {0} ja esta na lista do cliente atual", co.telefone),
                                "Atenção");
                            return;
                        }
                    }
                    if (!bdgContatos.List.Contains(ccf.Contato))
                        bdgContatos.Add(ccf.Contato);
                }
                    
            }
        }

        private void btnRemoverContato_Click(object sender, EventArgs e)
        {
            if (bdgContatos.Current != null)
            {
                DialogResult rs = XtraMessageBox.Show("Deseja realmente excluir o contato selecionado?" +
                "\nNão sera possivel reverter esta ação.", "Confirmação de Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;

                clientes_contato p = (clientes_contato)bdgContatos.Current;
                if (p.id > 0)
                    clientes_contato.Delete(p.id);
                bdgContatos.RemoveCurrent();
            }
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            NovoEnderecoForm nef = new NovoEnderecoForm();
            if (nef.ShowDialog() == DialogResult.OK)
            {
                if (nef.Endereco.endereco!= null)
                {
                    foreach (clientes_endereco ce in bdgEnderecos.List)
                    {
                        if (ce.endereco == nef.Endereco.endereco)
                        {
                            XtraMessageBox.Show(String.Format("O endereço {0} ja esta na lista do cliente atual", ce.endereco),
                                "Atenção");
                            return;
                        }
                    }
                    if (!bdgEnderecos.List.Contains(nef.Endereco))
                        bdgEnderecos.Add(nef.Endereco);
                }
            }
        }

        private void btnRemoverEndereco_Click(object sender, EventArgs e)
        {
           if (bdgEnderecos.Current != null)
            {
                DialogResult rs = XtraMessageBox.Show("Deseja realmente excluir este endereço?" +
                 "\nNão sera possivel reverter esta ação.", "Confirmação de Exclusão",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;

                clientes_endereco p = (clientes_endereco)bdgEnderecos.Current ;
                if (p.id > 0)
                    clientes_endereco.Delete(p.id);
                bdgEnderecos.RemoveCurrent();
            }
        }

        DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRuleDataEmissaoRG = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
        DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRuleOrgaoExpedidor = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente c = (cliente)bdgCliente.Current;
            c.pre_cadastro = false;

            if (!String.IsNullOrEmpty(c.rg))
            {
                conditionValidationRuleDataEmissaoRG.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
                conditionValidationRuleDataEmissaoRG.ErrorText = "Informe a data de emissão do RG";
                this.ValidadorPrincipal.SetValidationRule(this.tfDataEmissaoRg, conditionValidationRuleDataEmissaoRG);

                conditionValidationRuleOrgaoExpedidor.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
                conditionValidationRuleOrgaoExpedidor.ErrorText = "Informe o orgão expedidor do RG";
                this.ValidadorPrincipal.SetValidationRule(this.tfOrgaoExpedidor, conditionValidationRuleOrgaoExpedidor);
            }
            else
            {
                this.ValidadorPrincipal.SetValidationRule(tfDataEmissaoRg, null);
                this.ValidadorPrincipal.SetValidationRule(tfOrgaoExpedidor, null);
            }
            if (!ValidadorPrincipal.Validate())
                return;

            if (bdgContatos.List.Count < 1)
            {
                XtraMessageBox.Show("É necessário informar no minimo um contato para o cliente!", "Atenção");
                return;
            }
            if (bdgEnderecos.List.Count < 1)
            {
                XtraMessageBox.Show("É necessário informar no minimo um endereço para o cliente!", "Atenção");
                return;
            }
        }
    }
}
