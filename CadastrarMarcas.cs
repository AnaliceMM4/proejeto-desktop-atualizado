﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDesktop2
{
    public partial class CadastrarMarcas : Form
    {
        public CadastrarMarcas()
        {
            InitializeComponent();
        }

        private void marcaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
        }

        private void CadastrarMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarModelos().ShowDialog();
        }

        private void tabelaFIPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroTabelaFIPE().ShowDialog();
        }

        private void telaADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog();
        }

      //  private void marcaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
      //  {

        //}
    }
}
