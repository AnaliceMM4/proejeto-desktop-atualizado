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
    public partial class AddEditarModelos : Form
    {
        public AddEditarModelos()
        {
            InitializeComponent();
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
         //   this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);

        }


        public void EditarModelo(int id)
        {
            modeloBindingSource.Position = modeloBindingSource.Find("ModeloId", id);
        }
       

        private void AddEdModelos_Load(object sender, EventArgs e)
        {
         //   this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);

        }

        private void modeloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void modeloBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void inícioAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog();
        }

        /* private void modeloBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
         {
             this.Validate();
             this.modeloBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

         }*/
    }
}
