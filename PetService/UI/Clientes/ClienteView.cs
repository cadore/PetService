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
using PetaPoco;
using PetService.Utils.Validations;

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
                Validations();
            }
            else
            {
                bdgContatos.DataSource = clientes_contato.Fetch("WHERE cliente_id=@0 ORDER BY id", c.id);
                bdgEnderecos.DataSource = clientes_endereco.Fetch("WHERE cliente_id=@0 ORDER BY id", c.id);
                tfCPF.Properties.ReadOnly = true;
                if (!String.IsNullOrEmpty(c.rg))
                    tfRG.Properties.ReadOnly = true;
            }
            bdgCliente.DataSource = c;
        }

        private void Validations()
        {
            ValidationsUtil.ValidatorCPFCNPJ validatorCPFCNPJ = new ValidationsUtil.ValidatorCPFCNPJ() 
            { ErrorText = "O CPF informado esta incorreto." };
            this.ValidadorPrincipal.SetValidationRule(this.tfCPF, validatorCPFCNPJ);

            ValidationsUtil.UniqueCPF uniqueCPF = new ValidationsUtil.UniqueCPF("clientes", "cpf") 
            { ErrorText = "O CPF informado ja esta cadastrado no sistema." };
            this.ValidadorUnique.SetValidationRule(this.tfCPF, uniqueCPF);

            ValidationsUtil.UniqueCPF uniqueRG = new ValidationsUtil.UniqueCPF("clientes", "rg") 
            { ErrorText = "O RG informado ja esta cadastrado no sistema." };
            this.ValidadorUnique.SetValidationRule(this.tfRG, uniqueRG);
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
                    if (bdgContatos.List.Count == 0)
                        ccf.Contato.principal = true;

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
                if (p.principal)
                {
                    XtraMessageBox.Show("Contato principal nao pode ser removido!", "Atenção");
                    return;
                }

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
                    if (bdgEnderecos.List.Count == 0)
                        nef.Endereco.principal = true;

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

                clientes_endereco p = (clientes_endereco)bdgEnderecos.Current;
                if (p.principal)
                {
                    XtraMessageBox.Show("Endereço principal nao pode ser removido!", "Atenção");
                    return;
                }
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
            List<clientes_endereco> ListCE = (List<clientes_endereco>)bdgEnderecos.List;
            List<clientes_contato> ListCC = (List<clientes_contato>)bdgContatos.List;
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
            if (!ValidadorUnique.Validate())
                return;

            if (ListCC.Count < 1)
            {
                XtraMessageBox.Show("É necessário informar no minimo um contato para o cliente!", "Atenção");
                return;
            }
            if (ListCE.Count < 1)
            {
                XtraMessageBox.Show("É necessário informar no minimo um endereço para o cliente!", "Atenção");
                return;
            }

            try
            {
                using (var scope = cliente.repo.GetTransaction())
                {
                    c.Save();
                    foreach (clientes_endereco ce in ListCE)
                    {
                        ce.cliente_id = c.id;
                        ce.Save();
                    }
                    foreach (clientes_contato cc in ListCC)
                    {
                        cc.cliente_id = c.id;
                        cc.Save();
                    }
                    scope.Complete();
                    if (MessageToSave("Cliente"))
                        desk.AddTabAndCloseCurrent(new ClienteView(null), "Novo Cliente", true);
                }
            }
            catch (Exception ex)
            {
                cliente.repo.AbortTransaction();
                XtraMessageBox.Show(ex.Message, "Erro/Atenção");
            }
        }

        private void btnContatoPrincipal_Click(object sender, EventArgs e)
        {
            List<clientes_contato> listCC = new List<clientes_contato>();
            listCC.Clear();
            foreach (clientes_contato cc in (List<clientes_contato>)bdgContatos.List)
            {
                cc.principal = false;
                listCC.Add(cc);
            }
            
            listCC[bdgContatos.Position].principal = true;
            bdgContatos.Clear();
            bdgContatos.DataSource = listCC;
        }

        private void bdgContatos_CurrentChanged(object sender, EventArgs e)
        {
            btnRemoverContato.Enabled = false;
            btnContatoPrincipal.Enabled = false;

            if (bdgContatos.Current != null)
            {
                btnRemoverContato.Enabled = true;
                if (((clientes_contato)bdgContatos.Current).principal == false)
                    btnContatoPrincipal.Enabled = true;
            }
        }

        private void btnEnderecoPrincipal_Click(object sender, EventArgs e)
        {
            List<clientes_endereco> listCE = new List<clientes_endereco>();
            listCE.Clear();
            foreach (clientes_endereco cc in (List<clientes_endereco>)bdgEnderecos.List)
            {
                cc.principal = false;
                listCE.Add(cc);
            }

            listCE[bdgEnderecos.Position].principal = true;
            bdgEnderecos.Clear();
            bdgEnderecos.DataSource = listCE;
        }

        private void bdgEnderecos_CurrentChanged(object sender, EventArgs e)
        {
            btnRemoverEndereco.Enabled = false;
            btnEnderecoPrincipal.Enabled = false;

            if (bdgEnderecos.Current != null)
            {
                btnRemoverEndereco.Enabled = true;
                if (((clientes_endereco)bdgEnderecos.Current).principal == false)
                    btnEnderecoPrincipal.Enabled = true;
            }
        }
    }
}
