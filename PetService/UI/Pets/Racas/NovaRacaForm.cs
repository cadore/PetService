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
    public partial class NovaRacaForm : UtilForm
    {
        public NovaRacaForm(raca r)
        {
            InitializeComponent();
            if (r == null)
            {
                r = new raca() { tipo_raca = 2 };
            }
            else
                this.Text = "Editar raça";

            bdgRaca.DataSource = r;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;

            try
            {
                raca r = (raca)bdgRaca.Current;
                r.Save();
                XtraMessageBox.Show("Raça salva com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Erro/Atenção");
            }
        }
    }
}