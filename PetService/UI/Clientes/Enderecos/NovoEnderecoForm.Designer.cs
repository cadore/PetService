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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoEnderecoForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfEstado = new DevExpress.XtraEditors.TextEdit();
            this.bdgEnderecos = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfCidade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfComplemento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfEndereco = new DevExpress.XtraEditors.TextEdit();
            this.tfNumero = new DevExpress.XtraEditors.TextEdit();
            this.cbBairro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgBairros = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltaxa_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvar = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancelar = new WCButtons.Black.ButtonCancelBlack();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(623, 188);
            this.panelControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.86992F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.13008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tfEstado, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tfCidade, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tfComplemento, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tfEndereco, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tfNumero, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBairro, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 138);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Endereço:";
            // 
            // tfEstado
            // 
            this.tfEstado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "estado", true));
            this.tfEstado.EditValue = "";
            this.tfEstado.Location = new System.Drawing.Point(478, 113);
            this.tfEstado.Name = "tfEstado";
            this.tfEstado.Properties.ReadOnly = true;
            this.tfEstado.Size = new System.Drawing.Size(137, 20);
            this.tfEstado.TabIndex = 7;
            this.tfEstado.TabStop = false;
            // 
            // bdgEnderecos
            // 
            this.bdgEnderecos.DataSource = typeof(PetService.clientes_endereco);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Numero:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(434, 113);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Estado:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Bairro:";
            // 
            // tfCidade
            // 
            this.tfCidade.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "cidade", true));
            this.tfCidade.Location = new System.Drawing.Point(75, 113);
            this.tfCidade.Name = "tfCidade";
            this.tfCidade.Properties.ReadOnly = true;
            this.tfCidade.Size = new System.Drawing.Size(353, 20);
            this.tfCidade.TabIndex = 6;
            this.tfCidade.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Complemento:";
            // 
            // tfComplemento
            // 
            this.tfComplemento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "complemento", true));
            this.tfComplemento.Location = new System.Drawing.Point(75, 83);
            this.tfComplemento.Name = "tfComplemento";
            this.tfComplemento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfComplemento.Size = new System.Drawing.Size(353, 20);
            this.tfComplemento.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Cidade:";
            // 
            // tfEndereco
            // 
            this.tfEndereco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "endereco", true));
            this.tfEndereco.Location = new System.Drawing.Point(75, 3);
            this.tfEndereco.Name = "tfEndereco";
            this.tfEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfEndereco.Size = new System.Drawing.Size(353, 20);
            this.tfEndereco.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o endereço";
            this.validator.SetValidationRule(this.tfEndereco, conditionValidationRule1);
            // 
            // tfNumero
            // 
            this.tfNumero.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "endereco_numero", true));
            this.tfNumero.Location = new System.Drawing.Point(75, 29);
            this.tfNumero.Name = "tfNumero";
            this.tfNumero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfNumero.Size = new System.Drawing.Size(110, 20);
            this.tfNumero.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe o numero";
            this.validator.SetValidationRule(this.tfNumero, conditionValidationRule2);
            // 
            // cbBairro
            // 
            this.cbBairro.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEnderecos, "bairro", true));
            this.cbBairro.EditValue = "";
            this.cbBairro.Location = new System.Drawing.Point(75, 54);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBairro.Properties.DataSource = this.bdgBairros;
            this.cbBairro.Properties.DisplayMember = "nome";
            this.cbBairro.Properties.NullText = "Selecione o bairro";
            this.cbBairro.Properties.ValueMember = "id";
            this.cbBairro.Properties.View = this.searchLookUpEdit1View;
            this.cbBairro.Size = new System.Drawing.Size(353, 20);
            this.cbBairro.TabIndex = 8;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o bairro";
            conditionValidationRule3.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbBairro, conditionValidationRule3);
            // 
            // bdgBairros
            // 
            this.bdgBairros.DataSource = typeof(PetService.bairro);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome,
            this.coltaxa_entrega});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 109;
            // 
            // colnome
            // 
            this.colnome.Caption = "Nome Bairro";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.OptionsColumn.AllowEdit = false;
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            this.colnome.Width = 356;
            // 
            // coltaxa_entrega
            // 
            this.coltaxa_entrega.Caption = "Taxa de Entrega";
            this.coltaxa_entrega.DisplayFormat.FormatString = "c2";
            this.coltaxa_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltaxa_entrega.FieldName = "taxa_entrega";
            this.coltaxa_entrega.Name = "coltaxa_entrega";
            this.coltaxa_entrega.OptionsColumn.AllowEdit = false;
            this.coltaxa_entrega.Visible = true;
            this.coltaxa_entrega.VisibleIndex = 2;
            this.coltaxa_entrega.Width = 231;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSalvar);
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 143);
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
            this.ClientSize = new System.Drawing.Size(623, 188);
            this.Controls.Add(this.panelControl1);
            this.Name = "NovoEnderecoForm";
            this.Text = "Novo Endereco";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NovoEnderecoForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfNumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbBairro;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource bdgBairros;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn coltaxa_entrega;
    }
}