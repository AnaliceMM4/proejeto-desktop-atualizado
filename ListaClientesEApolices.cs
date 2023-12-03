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
    public partial class ListaClientesEApolices : Form
    {
        public ListaClientesEApolices()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewApolicesClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.viewApolicesClientesTableAdapter.Fill(this.corretoraDataSet.ViewApolicesClientes);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewApolicesClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.viewApolicesClientesTableAdapter.Fill(this.corretoraDataSet.ViewApolicesClientes);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.corretoraDataSet.Clientes);

        }

        private void inícioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuCliente().ShowDialog();
        }

        private void inícioADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog(); 
            /*this.Hide();
            MenuADM m = new MenuADM();
            m.Closed += (s, args) => this.Close();
            m.Show();*/
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void clientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
