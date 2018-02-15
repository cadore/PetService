﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PetService.UI.Pets.Racas;
using DevExpress.XtraEditors;
using PetService.Utils;
using PetService.UI.Clientes;

namespace PetService.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TabControlUtil tabUtil;
        public DesktopForm()
        {
            InitializeComponent();
            UtilForm.desk = this;
            tabUtil = new TabControlUtil(this);
        }

        public void AddTab(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.AddTab(userControl, titleTab, newTab);
        }

        public void AddTabAndCloseCurrent(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.CloseSelectedPage();
            tabUtil.AddTab(userControl, titleTab, newTab);
        }

        public void CloseCurrentTab()
        {
            tabUtil.CloseSelectedPage();
        }

        private void tabControl_Resize(object sender, EventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void btn_racas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RacasForm rf = new RacasForm();
            DialogResult dr = rf.ShowDialog();
        }

        private void btn_novo_cliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClienteView cv = new ClienteView(null);
            AddTab(cv, "Novo Cliente", false);
        }

        private void btn_pesquisar_cliente_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Deseja realmente sair?", "Confirmação de Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                e.Cancel = true;
        }
    }
}