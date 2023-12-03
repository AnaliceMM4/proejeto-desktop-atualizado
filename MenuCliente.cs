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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void iniciarSimulaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            /*this.Hide();
            //SimulacaoApolice f = new SimulacaoApolice();
            f.Closed += (s, args) => this.Close();
            f.Show();*/
            new Simulacao().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewModeloMarca'. Você pode movê-la ou removê-la conforme necessário.
            //    this.viewModeloMarcaTableAdapter.Fill(this.corretoraDataSet.ViewModeloMarca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewModeloMarca'. Você pode movê-la ou removê-la conforme necessário.
            //  this.viewModeloMarcaTableAdapter.Fill(this.corretoraDataSet.ViewModeloMarca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
        }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioCliente f = new FormularioCliente();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void apolicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog();
        }

        private void testeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
