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
                            XtraMessageBox.Show(String.Format("O Endereço {0} ja esta na lista do cliente atual", ce.endereco),
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
                clientes_endereco p = (clientes_endereco)bdgEnderecos.Current;
                if (p.id > 0)
                    clientes_endereco.Delete(p.id);
                bdgEnderecos.RemoveCurrent();
            }
        }
    }
}
