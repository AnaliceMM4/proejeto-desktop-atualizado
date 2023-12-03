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
    public partial class Simulacao : Form
    {
        private int currentPageIndex = 0; // Página atual

        public Simulacao()
        {
            InitializeComponent();
            OcultarTodasAsPaginasExcetoAtual();

        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewApolicesClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.viewApolicesClientesTableAdapter.Fill(this.corretoraDataSet.ViewApolicesClientes);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewApolicesClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.viewApolicesClientesTableAdapter.Fill(this.corretoraDataSet.ViewApolicesClientes);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewModelosMarcas'. Você pode movê-la ou removê-la conforme necessário.
            this.viewModelosMarcasTableAdapter.Fill(this.corretoraDataSet.ViewModelosMarcas);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.corretoraDataSet.Marca);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);

        }
        private void OcultarTodasAsPaginasExcetoAtual()
        {
           for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (i != currentPageIndex)
                {
                    tabControl1.TabPages[i].Padding = new Padding(0, -tabControl1.ItemSize.Height, 0, 0);
                }
            }

            // Mostra apenas a página atual
            tabControl1.TabPages[currentPageIndex].Padding = new Padding(0, 0, 0, 0);
         }

        private void apolicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.viewApolicesClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void marcaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void marcaLabel_Click(object sender, EventArgs e)
        {

        }

        private void modeloLabel_Click(object sender, EventArgs e)
        {

        }

        private void modeloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex = ++currentPageIndex;
            }
            else
            {
                // Você está na última página, faça algo aqui
                MessageBox.Show("Você chegou à última página!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex = ++currentPageIndex;
            }
            else
            {
                // Você está na última página, faça algo aqui
                MessageBox.Show("Você chegou à última página!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);*/

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex = ++currentPageIndex;
            }
            else
            {
                // Você está na última página, faça algo aqui
                MessageBox.Show("Você chegou à última página!");
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartMotoristaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emissaoCartMotLabel_Click(object sender, EventArgs e)
        {

        }

        private void emissaoCartMotDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataNascimentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataNascimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void cartMotoristaLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaMotLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaMotTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex = ++currentPageIndex;
            }
            else
            {
                // Você está na última página, faça algo aqui
                MessageBox.Show("Você chegou à última página!");
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                tabControl1.SelectedIndex = --currentPageIndex;
            }
            else
            {
                MessageBox.Show("Você está na primeira página!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                tabControl1.SelectedIndex = --currentPageIndex;
            }
            else
            {
                MessageBox.Show("Você está na terceira página!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                tabControl1.SelectedIndex = --currentPageIndex;
            }
            else
            {
                MessageBox.Show("Você está na quarta página!");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.viewApolicesClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.viewApolicesClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
        }

        private void apolicesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
