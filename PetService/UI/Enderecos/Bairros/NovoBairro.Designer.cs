namespace PetService.UI.Enderecos.Bairros
{
    partial class NovoBairro
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label taxa_entregaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoBairro));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvar = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancelar = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tfTaxaEntrega = new DevExpress.XtraEditors.CalcEdit();
            this.bdgBairro = new System.Windows.Forms.BindingSource(this.components);
            this.tfNome = new DevExpress.XtraEditors.TextEdit();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            nomeLabel = new System.Windows.Forms.Label();
            taxa_entregaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfTaxaEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 15);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(69, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome Bairro:";
            // 
            // taxa_entregaLabel
            // 
            taxa_entregaLabel.AutoSize = true;
            taxa_entregaLabel.Location = new System.Drawing.Point(9, 41);
            taxa_entregaLabel.Name = "taxa_entregaLabel";
            taxa_entregaLabel.Size = new System.Drawing.Size(91, 13);
            taxa_entregaLabel.TabIndex = 2;
            taxa_entregaLabel.Text = "Taxa de Entrega:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSalvar);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 85);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(527, 45);
            this.panelControl1.TabIndex = 1;
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
            this.btnSalvar.Location = new System.Drawing.Point(296, 6);
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
            this.btnCancelar.Location = new System.Drawing.Point(412, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(taxa_entregaLabel);
            this.panelControl2.Controls.Add(this.tfTaxaEntrega);
            this.panelControl2.Controls.Add(nomeLabel);
            this.panelControl2.Controls.Add(this.tfNome);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(527, 85);
            this.panelControl2.TabIndex = 0;
            // 
            // tfTaxaEntrega
            // 
            this.tfTaxaEntrega.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBairro, "taxa_entrega", true));
            this.tfTaxaEntrega.Location = new System.Drawing.Point(109, 38);
            this.tfTaxaEntrega.Name = "tfTaxaEntrega";
            this.tfTaxaEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTaxaEntrega.Size = new System.Drawing.Size(157, 20);
            this.tfTaxaEntrega.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a taxa de entrega";
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfTaxaEntrega, conditionValidationRule1);
            // 
            // bdgBairro
            // 
            this.bdgBairro.DataSource = typeof(PetService.bairro);
            // 
            // tfNome
            // 
            this.tfNome.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBairro, "nome", true));
            this.tfNome.Location = new System.Drawing.Point(109, 12);
            this.tfNome.Name = "tfNome";
            this.tfNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfNome.Size = new System.Drawing.Size(390, 20);
            this.tfNome.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe o nome do bairro";
            this.validator.SetValidationRule(this.tfNome, conditionValidationRule2);
            // 
            // NovoBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 130);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "NovoBairro";
            this.Text = "NovoBairro";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfTaxaEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonCancelBlack btnCancelar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonSaveBlack btnSalvar;
        private DevExpress.XtraEditors.CalcEdit tfTaxaEntrega;
        private System.Windows.Forms.BindingSource bdgBairro;
        private DevExpress.XtraEditors.TextEdit tfNome;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}