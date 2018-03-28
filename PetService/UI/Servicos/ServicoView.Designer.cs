namespace PetService.UI.Servicos
{
    partial class ServicoView
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
            System.Windows.Forms.Label servico_idLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicoView));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvar = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancelar = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonMinusBlack1 = new WCButtons.Black.ButtonMinusBlack();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgServicosGrid = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colservico_descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_realizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colservico_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacao_servico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpet_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_unitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_ficha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrecebido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonAddBlack1 = new WCButtons.Black.ButtonAddBlack();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit3 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            servico_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgServicosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // servico_idLabel
            // 
            servico_idLabel.AutoSize = true;
            servico_idLabel.Location = new System.Drawing.Point(5, 28);
            servico_idLabel.Name = "servico_idLabel";
            servico_idLabel.Size = new System.Drawing.Size(46, 13);
            servico_idLabel.TabIndex = 6;
            servico_idLabel.Text = "Serviço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 13);
            label1.TabIndex = 6;
            label1.Text = "Observações:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSalvar);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 387);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(790, 43);
            this.panelControl1.TabIndex = 0;
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
            this.btnSalvar.Location = new System.Drawing.Point(559, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 33);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(675, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 33);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dateEdit1);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.searchLookUpEdit2);
            this.panelControl2.Controls.Add(this.searchLookUpEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(790, 387);
            this.panelControl2.TabIndex = 1;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(77, 31);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(123, 20);
            this.dateEdit1.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Data Serviço:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.buttonMinusBlack1);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.buttonAddBlack1);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.searchLookUpEdit3);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(servico_idLabel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(786, 328);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Detalhamento Serviço";
            // 
            // buttonMinusBlack1
            // 
            this.buttonMinusBlack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.buttonMinusBlack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinusBlack1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.buttonMinusBlack1.ForeColor = System.Drawing.Color.White;
            this.buttonMinusBlack1.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinusBlack1.Image")));
            this.buttonMinusBlack1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinusBlack1.Location = new System.Drawing.Point(740, 102);
            this.buttonMinusBlack1.Name = "buttonMinusBlack1";
            this.buttonMinusBlack1.Size = new System.Drawing.Size(41, 33);
            this.buttonMinusBlack1.TabIndex = 14;
            this.buttonMinusBlack1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMinusBlack1.UseVisualStyleBackColor = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgServicosGrid;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(2, 152);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(782, 174);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdgServicosGrid
            // 
            this.bdgServicosGrid.DataSource = typeof(PetService.servicos_diario);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colservico_descricao,
            this.coldata_realizado,
            this.colservico_id,
            this.colobservacao_servico,
            this.colcliente_id,
            this.colpet_id,
            this.colquantidade,
            this.colvalor_unitario,
            this.colvalor_total,
            this.colem_ficha,
            this.colrecebido});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colobservacao_servico, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 49;
            // 
            // colservico_descricao
            // 
            this.colservico_descricao.Caption = "Descrição";
            this.colservico_descricao.FieldName = "descricao_servico";
            this.colservico_descricao.Name = "colservico_descricao";
            this.colservico_descricao.OptionsColumn.AllowEdit = false;
            this.colservico_descricao.Visible = true;
            this.colservico_descricao.VisibleIndex = 1;
            this.colservico_descricao.Width = 214;
            // 
            // coldata_realizado
            // 
            this.coldata_realizado.Caption = "Data Realizado";
            this.coldata_realizado.FieldName = "data_realizado";
            this.coldata_realizado.Name = "coldata_realizado";
            this.coldata_realizado.OptionsColumn.AllowEdit = false;
            this.coldata_realizado.Width = 89;
            // 
            // colservico_id
            // 
            this.colservico_id.FieldName = "servico_id";
            this.colservico_id.Name = "colservico_id";
            this.colservico_id.OptionsColumn.AllowEdit = false;
            // 
            // colobservacao_servico
            // 
            this.colobservacao_servico.Caption = "Observações";
            this.colobservacao_servico.FieldName = "observacao_servico";
            this.colobservacao_servico.Name = "colobservacao_servico";
            this.colobservacao_servico.OptionsColumn.AllowEdit = false;
            this.colobservacao_servico.Visible = true;
            this.colobservacao_servico.VisibleIndex = 5;
            this.colobservacao_servico.Width = 104;
            // 
            // colcliente_id
            // 
            this.colcliente_id.FieldName = "cliente_id";
            this.colcliente_id.Name = "colcliente_id";
            this.colcliente_id.OptionsColumn.AllowEdit = false;
            // 
            // colpet_id
            // 
            this.colpet_id.FieldName = "pet_id";
            this.colpet_id.Name = "colpet_id";
            this.colpet_id.OptionsColumn.AllowEdit = false;
            // 
            // colquantidade
            // 
            this.colquantidade.Caption = "Quantidade";
            this.colquantidade.FieldName = "quantidade";
            this.colquantidade.Name = "colquantidade";
            this.colquantidade.OptionsColumn.AllowEdit = false;
            this.colquantidade.Visible = true;
            this.colquantidade.VisibleIndex = 2;
            this.colquantidade.Width = 69;
            // 
            // colvalor_unitario
            // 
            this.colvalor_unitario.Caption = "R$ Unitário";
            this.colvalor_unitario.FieldName = "valor_unitario";
            this.colvalor_unitario.Name = "colvalor_unitario";
            this.colvalor_unitario.OptionsColumn.AllowEdit = false;
            this.colvalor_unitario.Visible = true;
            this.colvalor_unitario.VisibleIndex = 3;
            this.colvalor_unitario.Width = 83;
            // 
            // colvalor_total
            // 
            this.colvalor_total.Caption = "R$ Total";
            this.colvalor_total.FieldName = "valor_total";
            this.colvalor_total.Name = "colvalor_total";
            this.colvalor_total.OptionsColumn.AllowEdit = false;
            this.colvalor_total.Visible = true;
            this.colvalor_total.VisibleIndex = 4;
            this.colvalor_total.Width = 77;
            // 
            // colem_ficha
            // 
            this.colem_ficha.FieldName = "em_ficha";
            this.colem_ficha.Name = "colem_ficha";
            this.colem_ficha.OptionsColumn.AllowEdit = false;
            // 
            // colrecebido
            // 
            this.colrecebido.Caption = "Recebido";
            this.colrecebido.FieldName = "recebido";
            this.colrecebido.Name = "colrecebido";
            this.colrecebido.OptionsColumn.AllowEdit = false;
            this.colrecebido.Visible = true;
            this.colrecebido.VisibleIndex = 6;
            this.colrecebido.Width = 81;
            // 
            // buttonAddBlack1
            // 
            this.buttonAddBlack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.buttonAddBlack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBlack1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.buttonAddBlack1.ForeColor = System.Drawing.Color.White;
            this.buttonAddBlack1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBlack1.Image")));
            this.buttonAddBlack1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBlack1.Location = new System.Drawing.Point(740, 53);
            this.buttonAddBlack1.Name = "buttonAddBlack1";
            this.buttonAddBlack1.Size = new System.Drawing.Size(41, 33);
            this.buttonAddBlack1.TabIndex = 12;
            this.buttonAddBlack1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddBlack1.UseVisualStyleBackColor = false;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(85, 51);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(643, 84);
            this.memoEdit1.TabIndex = 11;
            this.memoEdit1.UseOptimizedRendering = true;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(631, 25);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Mask.EditMask = "c2";
            this.textEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(97, 20);
            this.textEdit3.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(581, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "R$ Total:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(496, 25);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "c2";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(77, 20);
            this.textEdit2.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(433, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "R$ Unitário:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(380, 25);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(47, 20);
            this.textEdit1.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(348, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Qnt.:";
            // 
            // searchLookUpEdit3
            // 
            this.searchLookUpEdit3.Location = new System.Drawing.Point(85, 25);
            this.searchLookUpEdit3.Name = "searchLookUpEdit3";
            this.searchLookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit3.Properties.NullText = "";
            this.searchLookUpEdit3.Properties.View = this.searchLookUpEdit3View;
            this.searchLookUpEdit3.Size = new System.Drawing.Size(256, 20);
            this.searchLookUpEdit3.TabIndex = 7;
            // 
            // searchLookUpEdit3View
            // 
            this.searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(356, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Pet:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cliente:";
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.Location = new System.Drawing.Point(382, 7);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.NullText = "";
            this.searchLookUpEdit2.Properties.View = this.gridView1;
            this.searchLookUpEdit2.Size = new System.Drawing.Size(294, 20);
            this.searchLookUpEdit2.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(77, 7);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.NullText = "";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;            
            this.searchLookUpEdit1.Size = new System.Drawing.Size(266, 20);
            this.searchLookUpEdit1.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ServicoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ServicoView";
            this.Size = new System.Drawing.Size(790, 430);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgServicosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSaveBlack btnSalvar;
        private WCButtons.Black.ButtonCancelBlack btnCancelar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private WCButtons.Black.ButtonAddBlack buttonAddBlack1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource bdgServicosGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_realizado;
        private DevExpress.XtraGrid.Columns.GridColumn colservico_id;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacao_servico;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpet_id;
        private DevExpress.XtraGrid.Columns.GridColumn colquantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_unitario;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_total;
        private DevExpress.XtraGrid.Columns.GridColumn colem_ficha;
        private DevExpress.XtraGrid.Columns.GridColumn colrecebido;
        private DevExpress.XtraGrid.Columns.GridColumn colservico_descricao;
        private WCButtons.Black.ButtonMinusBlack buttonMinusBlack1;
    }
}
