namespace PetService.UI.Servicos
{
    partial class ServicosDiariosView
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bdgServicosDiarios = new System.Windows.Forms.BindingSource(this.components);
            this.colturno_servico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_execucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltaxi_dog = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgServicosDiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 359);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(901, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(901, 359);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgServicosDiarios;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(897, 355);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colturno_servico,
            this.colem_execucao,
            this.colcliente,
            this.colpet,
            this.colporte,
            this.colendereco,
            this.colbairro,
            this.coltaxi_dog});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // bdgServicosDiarios
            // 
            this.bdgServicosDiarios.DataSource = typeof(PetService.ServicosDiariosModal);
            // 
            // colturno_servico
            // 
            this.colturno_servico.Caption = "Turno";
            this.colturno_servico.FieldName = "turno_servico";
            this.colturno_servico.Name = "colturno_servico";
            this.colturno_servico.OptionsColumn.AllowEdit = false;
            this.colturno_servico.Visible = true;
            this.colturno_servico.VisibleIndex = 0;
            this.colturno_servico.Width = 89;
            // 
            // colem_execucao
            // 
            this.colem_execucao.Caption = "Em Execução";
            this.colem_execucao.FieldName = "em_execucao";
            this.colem_execucao.Name = "colem_execucao";
            this.colem_execucao.OptionsColumn.AllowEdit = false;
            this.colem_execucao.Visible = true;
            this.colem_execucao.VisibleIndex = 1;
            this.colem_execucao.Width = 77;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 2;
            this.colcliente.Width = 141;
            // 
            // colpet
            // 
            this.colpet.Caption = "Pet";
            this.colpet.FieldName = "pet";
            this.colpet.Name = "colpet";
            this.colpet.OptionsColumn.AllowEdit = false;
            this.colpet.Visible = true;
            this.colpet.VisibleIndex = 3;
            this.colpet.Width = 131;
            // 
            // colporte
            // 
            this.colporte.Caption = "Porte";
            this.colporte.FieldName = "porte";
            this.colporte.Name = "colporte";
            this.colporte.OptionsColumn.AllowEdit = false;
            this.colporte.Visible = true;
            this.colporte.VisibleIndex = 4;
            this.colporte.Width = 106;
            // 
            // colendereco
            // 
            this.colendereco.Caption = "Endereço";
            this.colendereco.FieldName = "endereco";
            this.colendereco.Name = "colendereco";
            this.colendereco.OptionsColumn.AllowEdit = false;
            this.colendereco.Visible = true;
            this.colendereco.VisibleIndex = 5;
            this.colendereco.Width = 159;
            // 
            // colbairro
            // 
            this.colbairro.Caption = "Bairro";
            this.colbairro.FieldName = "bairro";
            this.colbairro.Name = "colbairro";
            this.colbairro.OptionsColumn.AllowEdit = false;
            this.colbairro.Visible = true;
            this.colbairro.VisibleIndex = 6;
            this.colbairro.Width = 99;
            // 
            // coltaxi_dog
            // 
            this.coltaxi_dog.Caption = "Taxi Dog";
            this.coltaxi_dog.FieldName = "taxi_dog";
            this.coltaxi_dog.Name = "coltaxi_dog";
            this.coltaxi_dog.OptionsColumn.AllowEdit = false;
            this.coltaxi_dog.Visible = true;
            this.coltaxi_dog.VisibleIndex = 7;
            this.coltaxi_dog.Width = 77;
            // 
            // ServicosDiariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ServicosDiariosView";
            this.Size = new System.Drawing.Size(901, 413);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgServicosDiarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgServicosDiarios;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_servico;
        private DevExpress.XtraGrid.Columns.GridColumn colem_execucao;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colpet;
        private DevExpress.XtraGrid.Columns.GridColumn colporte;
        private DevExpress.XtraGrid.Columns.GridColumn colendereco;
        private DevExpress.XtraGrid.Columns.GridColumn colbairro;
        private DevExpress.XtraGrid.Columns.GridColumn coltaxi_dog;
    }
}
