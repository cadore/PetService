namespace PetService.UI.Clientes.Enderecos
{
    partial class NovoEnderecoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoEnderecoForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tfEstado = new DevExpress.XtraEditors.TextEdit();
            this.bdgEnderecos = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tfCidade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfComplemento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfBairro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvar = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancelar = new WCButtons.Black.ButtonCancelBlack();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfEstado);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.tfCidade);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.tfComplemento);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.tfBairro);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.tfNumero);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tfEndereco);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(623, 193);
            this.panelControl1.TabIndex = 0;
            // 
            // tfEstado
            // 
            this.tfEstado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "estado", true));
            this.tfEstado.EditValue = "";
            this.tfEstado.Location = new System.Drawing.Point(443, 116);
            this.tfEstado.Name = "tfEstado";
            this.tfEstado.Properties.ReadOnly = true;
            this.tfEstado.Size = new System.Drawing.Size(168, 20);
            this.tfEstado.TabIndex = 7;
            this.tfEstado.TabStop = false;
            // 
            // bdgEnderecos
            // 
            this.bdgEnderecos.DataSource = typeof(PetService.clientes_endereco);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(400, 119);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Estado:";
            // 
            // tfCidade
            // 
            this.tfCidade.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "cidade", true));
            this.tfCidade.Location = new System.Drawing.Point(88, 116);
            this.tfCidade.Name = "tfCidade";
            this.tfCidade.Properties.ReadOnly = true;
            this.tfCidade.Size = new System.Drawing.Size(295, 20);
            this.tfCidade.TabIndex = 6;
            this.tfCidade.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Cidade:";
            // 
            // tfComplemento
            // 
            this.tfComplemento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "complemento", true));
            this.tfComplemento.Location = new System.Drawing.Point(88, 90);
            this.tfComplemento.Name = "tfComplemento";
            this.tfComplemento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfComplemento.Size = new System.Drawing.Size(523, 20);
            this.tfComplemento.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Complemento:";
            // 
            // tfBairro
            // 
            this.tfBairro.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "bairro", true));
            this.tfBairro.Location = new System.Drawing.Point(88, 64);
            this.tfBairro.Name = "tfBairro";
            this.tfBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfBairro.Size = new System.Drawing.Size(239, 20);
            this.tfBairro.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Bairro:";
            // 
            // tfNumero
            // 
            this.tfNumero.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "endereco_numero", true));
            this.tfNumero.Location = new System.Drawing.Point(88, 38);
            this.tfNumero.Name = "tfNumero";
            this.tfNumero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfNumero.Size = new System.Drawing.Size(110, 20);
            this.tfNumero.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Numero:";
            // 
            // tfEndereco
            // 
            this.tfEndereco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "endereco", true));
            this.tfEndereco.Location = new System.Drawing.Point(88, 12);
            this.tfEndereco.Name = "tfEndereco";
            this.tfEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfEndereco.Size = new System.Drawing.Size(523, 20);
            this.tfEndereco.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Endereço:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSalvar);
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 148);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(619, 43);
            this.panelControl2.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(388, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 33);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(504, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // NovoEnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 193);
            this.Controls.Add(this.panelControl1);
            this.Name = "NovoEnderecoForm";
            this.Text = "Novo Endereco";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonSaveBlack btnSalvar;
        private WCButtons.Black.ButtonCancelBlack btnCancelar;
        private System.Windows.Forms.BindingSource bdgEnderecos;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.TextEdit tfEstado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tfCidade;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tfComplemento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfBairro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfNumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}