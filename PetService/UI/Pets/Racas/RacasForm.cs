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

namespace PetService.UI.Pets.Racas
{
    public partial class RacasForm : UtilForm
    {
        public RacasForm()
        {
            InitializeComponent();
            rgTipo.EditValue = 2;
            tfDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rgTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tfDescricao.SelectAll();
            tfDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = String.Format("WHERE raca_descricao ILIKE '{0}'", raca.Concat(tfDescricao.EditValue));
                int tipo = Convert.ToInt32(rgTipo.EditValue);
                if (tipo == 0 || tipo == 1)
                {
                    sql += String.Format("AND tipo_raca={0}", tipo);
                }
                sql += " ORDER BY raca_descricao;";
                List<raca> list = raca.Fetch(sql);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].tipo_raca_desc = list[i].tipo_raca == 0 ? "Canina" : "Felina";
                }
                bdgRaca.DataSource = list;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Erro/Atenção");
            }
        }

        private void tfDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            NovaRacaForm nrf = new NovaRacaForm(null);
            if (nrf.ShowDialog() == DialogResult.OK)
                btnPesquisar_Click(sender, e);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            raca r = (raca)bdgRaca.Current;
            if (r != null)
            {
                NovaRacaForm nrf = new NovaRacaForm(r);
                if (nrf.ShowDialog() == DialogResult.OK)
                    btnPesquisar_Click(sender, e);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionar_Click(sender, e);
        }
    }
}