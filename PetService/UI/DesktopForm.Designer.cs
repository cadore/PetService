﻿namespace PetService.UI
{
    partial class DesktopForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo_cliente = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pesquisar_cliente = new DevExpress.XtraBars.BarButtonItem();
            this.btn_novo_pet = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pesquisar_pet = new DevExpress.XtraBars.BarButtonItem();
            this.btn_racas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cadastro_rapido = new DevExpress.XtraBars.BarButtonItem();
            this.btn_bairros = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_novo_cliente,
            this.btn_pesquisar_cliente,
            this.btn_novo_pet,
            this.btn_pesquisar_pet,
            this.btn_racas,
            this.btn_cadastro_rapido,
            this.btn_bairros});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage4,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(909, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_novo_cliente
            // 
            this.btn_novo_cliente.Caption = "Novo";
            this.btn_novo_cliente.Id = 1;
            this.btn_novo_cliente.Name = "btn_novo_cliente";
            this.btn_novo_cliente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_novo_cliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_novo_cliente_ItemClick);
            // 
            // btn_pesquisar_cliente
            // 
            this.btn_pesquisar_cliente.Caption = "Pesquisar";
            this.btn_pesquisar_cliente.Id = 2;
            this.btn_pesquisar_cliente.Name = "btn_pesquisar_cliente";
            this.btn_pesquisar_cliente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_pesquisar_cliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_pesquisar_cliente_ItemClick);
            // 
            // btn_novo_pet
            // 
            this.btn_novo_pet.Caption = "Novo";
            this.btn_novo_pet.Id = 3;
            this.btn_novo_pet.Name = "btn_novo_pet";
            this.btn_novo_pet.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_pesquisar_pet
            // 
            this.btn_pesquisar_pet.Caption = "Pesquisar";
            this.btn_pesquisar_pet.Id = 4;
            this.btn_pesquisar_pet.Name = "btn_pesquisar_pet";
            this.btn_pesquisar_pet.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_racas
            // 
            this.btn_racas.Caption = "Gerenciar Raças";
            this.btn_racas.Id = 5;
            this.btn_racas.Name = "btn_racas";
            this.btn_racas.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_racas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_racas_ItemClick);
            // 
            // btn_cadastro_rapido
            // 
            this.btn_cadastro_rapido.Caption = "Cadastro Rápido";
            this.btn_cadastro_rapido.Id = 6;
            this.btn_cadastro_rapido.Name = "btn_cadastro_rapido";
            this.btn_cadastro_rapido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_cadastro_rapido_ItemClick);
            // 
            // btn_bairros
            // 
            this.btn_bairros.Caption = "Gerenciar Bairros";
            this.btn_bairros.Id = 7;
            this.btn_bairros.Name = "btn_bairros";
            this.btn_bairros.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_bairros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_bairros_ItemClick);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Serviços/Vendas";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cadastros";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo_cliente);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_pesquisar_cliente);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_cadastro_rapido);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Clientes";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_novo_pet);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_pesquisar_pet);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Pets";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_racas);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Raças";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_bairros);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Endereços";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Financeiro";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Estoque";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(909, 31);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 144);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(909, 281);
            this.tabControl.TabIndex = 2;
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.Resize += new System.EventHandler(this.tabControl_Resize);
            // 
            // DesktopForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 456);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DesktopForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DesktopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_novo_cliente;
        private DevExpress.XtraBars.BarButtonItem btn_pesquisar_cliente;
        private DevExpress.XtraBars.BarButtonItem btn_novo_pet;
        private DevExpress.XtraBars.BarButtonItem btn_pesquisar_pet;
        private DevExpress.XtraBars.BarButtonItem btn_racas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        public DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem btn_cadastro_rapido;
        private DevExpress.XtraBars.BarButtonItem btn_bairros;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}