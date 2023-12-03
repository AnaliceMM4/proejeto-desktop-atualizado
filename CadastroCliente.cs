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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
           // this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.corretoraDataSet.Clientes);

        }

        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cEPLabel_Click(object sender, EventArgs e)
        {

        }

        private void cEPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uFLabel_Click(object sender, EventArgs e)
        {

        }

        private void uFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void orgaoEmissorLabel_Click(object sender, EventArgs e)
        {

        }

        private void cartMotoristaLabel_Click(object sender, EventArgs e)
        {

        }

        private void emissaoCartMotLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaMotLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void celularLabel_Click(object sender, EventArgs e)
        {

        }

        private void cPFLabel_Click(object sender, EventArgs e)
        {

        }

        private void rGLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataNascimentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaMotTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        //Botão Confirmar Contratação
        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void clienteIdLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            new MenuCliente().ShowDialog();


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
