using System;
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
    public partial class CadastroTabelaFIPE : Form
    {
        public CadastroTabelaFIPE()
        {
            InitializeComponent();
        }

        private void tabelaFIPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaFIPEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
        }

        private void CadastroTabelaFIPE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaFIPETableAdapter.Fill(this.corretoraDataSet.TabelaFIPE);
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarMarcas().ShowDialog();

        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarModelos().ShowDialog();
        }

        private void telaADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog();
        }
    }
}
