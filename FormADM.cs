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
    public partial class FormADM : Form
    {
        public FormADM()
        {
            InitializeComponent();
        }

        private void FormADM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaFIPETableAdapter.Fill(this.corretoraDataSet.TabelaFIPE);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            //this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewModeloMarca'. Você pode movê-la ou removê-la conforme necessário.
            this.viewModeloMarcaTableAdapter.Fill(this.corretoraDataSet.ViewModeloMarca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewMarcaModelo'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void viewMarcaModeloDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewMarcaModeloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaBindingSource.EndEdit();
            this.viewModeloMarcaBindingSource.EndEdit();
            this.tabelaFIPEBindingSource.EndEdit();
          //  this.viewMarcaModeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void viewModeloMarcaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marcaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaFIPEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
