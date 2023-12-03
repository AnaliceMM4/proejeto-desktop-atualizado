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
    public partial class FormularioTeste : Form
    {
        public FormularioTeste()
        {
            InitializeComponent();
        }

        private void marcaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void FormularioTeste_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);

        }

        private void marcaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
