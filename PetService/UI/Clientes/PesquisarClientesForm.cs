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
    public partial class PesquisarClientesForm : PetService.UI.Utils.UserControlUtil
    {
        public PesquisarClientesForm()
        {
            InitializeComponent();
        }

        private void tfPesquisa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (tfPesquisa.EditValue != null)
                {
                    string sql = String.Format("SELECT * FROM clientes WHERE nome_completo ILIKE '{0}'"
                           + " UNION SELECT * FROM clientes WHERE cpf ILIKE '{0}' ORDER BY nome_completo",
                           cliente.Concat(tfPesquisa.EditValue));
                    List<cliente> listC = cliente.Fetch(sql);

                    for (int i = 0; i < listC.Count; i++)
                    {
                        string contato = "";
                        List<clientes_contato> listCC = clientes_contato.Fetch("WHERE cliente_id=@0 ORDER BY principal DESC", listC[i].id);
                        for (int b = 0; b < listCC.Count; b++)
                        {
                            contato += listCC[b].telefone + " / ";
                        }
                        contato = contato.Substring(0, contato.Length - 2);
                        listC[i].contatos_tabela = contato;
                    }

                    bdgClientes.DataSource = listC;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Atenção");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            tfPesquisa_EditValueChanged(sender, e);
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            if ((cliente)bdgClientes.Current != null)
            {
                ClienteView cv = new ClienteView((cliente)bdgClientes.Current);
                desk.AddTab(cv, "Editar Cliente", true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            gridControl_DoubleClick(sender, e);
        }
    }
}
