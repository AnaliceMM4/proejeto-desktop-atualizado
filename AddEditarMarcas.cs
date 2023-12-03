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
    public partial class AddEditarMarcas : Form
    {
        public AddEditarMarcas()
        {
            InitializeComponent();
           // this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);

        }

        public void Editar(int id)
        {
            marcaBindingSource.Position = marcaBindingSource.Find("Id", id);
        }

        private void marcaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
        }


        private void EditarMarcas_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inícioAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuADM().ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
