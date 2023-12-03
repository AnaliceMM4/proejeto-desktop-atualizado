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
    public partial class AddEditarTabelaFipe : Form
    {
        public AddEditarTabelaFipe()
        {
            InitializeComponent();
            this.tabelaFIPETableAdapter.Fill(this.corretoraDataSet.TabelaFIPE);

        }

        public void EditarTabelaFipe(int id)
        {
            tabelaFIPEBindingSource.Position = tabelaFIPEBindingSource.Find("TabelaFipeId", id);
        }

        private void tabelaFIPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaFIPEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void AddEditarTabelaFIpe_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            //  this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewTabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.viewTabelaFIPETableAdapter.Fill(this.corretoraDataSet.ViewTabelaFIPE);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modeloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
