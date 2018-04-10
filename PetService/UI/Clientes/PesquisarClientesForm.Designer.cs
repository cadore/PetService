namespace PetService.UI.Clientes
{
    partial class PesquisarClientesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarClientesForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPesquisar = new WCButtons.Black.ButtonSearchBlack();
            this.tfPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new WCButtons.Black.ButtonCancelBlack();
            this.btnSelecionar = new WCButtons.Black.ButtonConfirmBlack();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bdgClientes = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome_completo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorgao_expedidor_rg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_emissao_rg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpre_cadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontatos = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPesquisar);
            this.panelControl1.Controls.Add(this.tfPesquisa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1041, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(459, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 33);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tfPesquisa
            // 
            this.tfPesquisa.CausesValidation = false;
            this.tfPesquisa.Location = new System.Drawing.Point(19, 15);
            this.tfPesquisa.Name = "tfPesquisa";
            this.tfPesquisa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfPesquisa.Properties.Mask.EditMask = "[0-9]{3}\\.[0-9]{3}\\.[0-9]{3}-[0-9]{2}|[A-ZÀ-Ú ]{40}";
            this.tfPesquisa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfPesquisa.Properties.Mask.ShowPlaceHolders = false;
            this.tfPesquisa.Properties.NullValuePromptShowForEmptyValue = true;
            this.tfPesquisa.Properties.ShowNullValuePromptWhenFocused = true;
            this.tfPesquisa.Size = new System.Drawing.Size(434, 20);
            this.tfPesquisa.TabIndex = 1;
            this.tfPesquisa.EditValueChanged += new System.EventHandler(this.tfPesquisa_EditValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Controls.Add(this.btnSelecionar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 440);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1041, 53);
            this.panelControl2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(926, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(806, 9);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(114, 33);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 50);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1041, 390);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bdgClientes;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1037, 386);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // bdgClientes
            // 
            this.bdgClientes.DataSource = typeof(PetService.cliente);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome_completo,
            this.coldata_nascimento,
            this.colcpf,
            this.colrg,
            this.colorgao_expedidor_rg,
            this.coldata_emissao_rg,
            this.colemail,
            this.colpre_cadastro,
            this.colcontatos});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 63;
            // 
            // colnome_completo
            // 
            this.colnome_completo.Caption = "Nome";
            this.colnome_completo.FieldName = "nome_completo";
            this.colnome_completo.Name = "colnome_completo";
            this.colnome_completo.OptionsColumn.AllowEdit = false;
            this.colnome_completo.Visible = true;
            this.colnome_completo.VisibleIndex = 1;
            this.colnome_completo.Width = 212;
            // 
            // coldata_nascimento
            // 
            this.coldata_nascimento.Caption = "Data Nascimento";
            this.coldata_nascimento.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldata_nascimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldata_nascimento.FieldName = "data_nascimento";
            this.coldata_nascimento.Name = "coldata_nascimento";
            this.coldata_nascimento.OptionsColumn.AllowEdit = false;
            this.coldata_nascimento.Visible = true;
            this.coldata_nascimento.VisibleIndex = 2;
            this.coldata_nascimento.Width = 91;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.OptionsColumn.AllowEdit = false;
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 3;
            this.colcpf.Width = 94;
            // 
            // colrg
            // 
            this.colrg.FieldName = "rg";
            this.colrg.Name = "colrg";
            this.colrg.OptionsColumn.AllowEdit = false;
            this.colrg.Width = 89;
            // 
            // colorgao_expedidor_rg
            // 
            this.colorgao_expedidor_rg.FieldName = "orgao_expedidor_rg";
            this.colorgao_expedidor_rg.Name = "colorgao_expedidor_rg";
            this.colorgao_expedidor_rg.OptionsColumn.AllowEdit = false;
            this.colorgao_expedidor_rg.Width = 124;
            // 
            // coldata_emissao_rg
            // 
            this.coldata_emissao_rg.FieldName = "data_emissao_rg";
            this.coldata_emissao_rg.Name = "coldata_emissao_rg";
            this.coldata_emissao_rg.OptionsColumn.AllowEdit = false;
            this.coldata_emissao_rg.Width = 85;
            // 
            // colemail
            // 
            this.colemail.Caption = "E-mail";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            this.colemail.Width = 212;
            // 
            // colpre_cadastro
            // 
            this.colpre_cadastro.Caption = "Pré Cadastro";
            this.colpre_cadastro.FieldName = "pre_cadastro";
            this.colpre_cadastro.Name = "colpre_cadastro";
            this.colpre_cadastro.OptionsColumn.AllowEdit = false;
            this.colpre_cadastro.Visible = true;
            this.colpre_cadastro.VisibleIndex = 6;
            this.colpre_cadastro.Width = 89;
            // 
            // colcontatos
            // 
            this.colcontatos.Caption = "Contatos";
            this.colcontatos.FieldName = "contatos_tabela";
            this.colcontatos.Name = "colcontatos";
            this.colcontatos.OptionsColumn.AllowEdit = false;
            this.colcontatos.Visible = true;
            this.colcontatos.VisibleIndex = 5;
            this.colcontatos.Width = 258;
            // 
            // PesquisarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "PesquisarClientesForm";
            this.Size = new System.Drawing.Size(1041, 493);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tfPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WCButtons.Black.ButtonSearchBlack btnPesquisar;
        private DevExpress.XtraEditors.TextEdit tfPesquisa;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_completo;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.Columns.GridColumn colrg;
        private DevExpress.XtraGrid.Columns.GridColumn colorgao_expedidor_rg;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_emissao_rg;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colpre_cadastro;
        private DevExpress.XtraGrid.Columns.GridColumn colcontatos;
        private WCButtons.Black.ButtonCancelBlack btnCancelar;
        private WCButtons.Black.ButtonConfirmBlack btnSelecionar;
    }
}
