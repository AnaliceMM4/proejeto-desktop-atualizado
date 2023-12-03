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
    public partial class CadastrarModelos : Form
    {
        public CadastrarModelos()
        {
            InitializeComponent();
        }

        private void modeloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void modeloBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.modeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void CadastrarModelos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarMarcas().ShowDialog();

        }

        private void telaADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog();

        }

        private void tabelaFIPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroTabelaFIPE().ShowDialog();  
        }
    }
}
