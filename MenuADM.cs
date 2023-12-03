using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalDesktop2
{
    public partial class MenuADM : Form
    {
        public MenuADM()
        {
            InitializeComponent();
        }

        private void Atualiza() {
//this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
           // this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            this.viewModelosMarcasTableAdapter.Fill(this.corretoraDataSet.ViewModelosMarcas);
            this.viewTabelaFIPETableAdapter.Fill(this.corretoraDataSet.ViewTabelaFIPE);
            this.tabelaFIPETableAdapter.Fill(this.corretoraDataSet.TabelaFIPE);

        }

        private void marcaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void MenuADM_Load(object sender, EventArgs e)
        {
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            var marca = corretoraDataSet.Marca.NewMarcaRow();
            marca.Id = 0;
            marca.Marca = "(Todas)";
            corretoraDataSet.Marca.AddMarcaRow(marca);


            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            var modelo = corretoraDataSet.Modelo.NewModeloRow();
            modelo.ModeloId = 0;
            modelo.Modelo = "(Todos)";
            corretoraDataSet.Modelo.AddModeloRow(modelo);

            Atualiza();
            marcaBindingSource.Sort = "Marca";
            modeloBindingSource.Sort = "Modelo";

        }

        //ADICIONAR E EDITAR - MARCA
        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            var editar = new AddEditarMarcas();
            var marca = corretoraDataSet.Marca
                [marcaBindingSource.Position];
            editar.Editar(marca.Id);
            editar.ShowDialog();
            Atualiza();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var adicionar = new AddEditarMarcas();
            adicionar.ShowDialog();
            Atualiza();
        }

        //ADICIONAR E EDITAR - MODELO
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            var editar = new AddEditarModelos();
            var modelo = corretoraDataSet.Modelo
                [viewModelosMarcasBindingSource.Position];
            editar.EditarModelo(modelo.ModeloId);
            editar.ShowDialog();
            Atualiza();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var adicionarModelo = new AddEditarModelos();
            adicionarModelo.ShowDialog();
            Atualiza();
        }

        private void marcaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (marcaBindingSource.Position == 0)
            {
                viewModelosMarcasBindingSource.RemoveFilter();
                viewTabelaFIPEBindingSource.RemoveFilter();

            }
            else
            {
                var desccat = comboBox1.Text;
                viewModelosMarcasBindingSource.Filter = "Marca = '" + desccat + "'";

                desccat = comboBox3.Text;
                viewTabelaFIPEBindingSource.Filter = "Marca = '" + desccat + "'";
            }
        }

        //ADICIONAR E EDITAR - TABELA FIPE
        private void toolStripButton16_Click_1(object sender, EventArgs e)
        {
            var editarTabelaFipe = new AddEditarTabelaFipe();
            var tabelaFIpe = corretoraDataSet.TabelaFIPE
                [viewTabelaFIPEBindingSource.Position];
            editarTabelaFipe.EditarTabelaFipe(tabelaFIpe.TabelaFipeId);
            editarTabelaFipe.ShowDialog();
            Atualiza();
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            var adicionarTabelaFipe = new AddEditarTabelaFipe();
            adicionarTabelaFipe.ShowDialog();
            Atualiza();
        }

        private void modeloBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (modeloBindingSource.Position == 0)
            {
                viewTabelaFIPEBindingSource.RemoveFilter();
            }
            else
            {
                var desccat = comboBox2.Text;
                viewTabelaFIPEBindingSource.Filter = "Modelo = '" + desccat + "'";
            }
        }

      

        private void viewTabelaFIPEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inícioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuCliente().ShowDialog();
        }

        private void inícioADMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listasClientesEApólicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();            
            ListaClientesEApolices l = new ListaClientesEApolices();
            l.Closed += (s, args) => this.Close();
            l.Show();
        }
    }
}
