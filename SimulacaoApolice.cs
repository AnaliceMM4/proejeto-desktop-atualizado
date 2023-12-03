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
    public partial class SimulacaoApolice : Form
    {
        public SimulacaoApolice()
        {
            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void FormSimulacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void apolicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

       /* private void apolicesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void apolicesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }*/

        private void apolicesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        private void apoliceIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void franquiaRedLabel_Click(object sender, EventArgs e)
        {

        }

        private void anoFabricacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void marcaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modeloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void anoModeloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void anoFabricacaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apoliceIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           // var form = new Form();
        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {



/*            string marcaSelecionada = marcaComboBox.SelectedItem.ToString();

            // Utilize a marcaSelecionada para filtrar os produtos do banco de dados
            using (var db = new CadastrarMarcas())
            {
                // Por exemplo, se você tem uma tabela Produtos com uma coluna Marca
               var marca = db.Apolices.Where(p => p.Marca == marcaSelecionada).ToList();
                marcaComboBox.DataSource = null;
                // Atualiza o ComboBox com os produtos da marca selecionada
                marcaComboBox.DataSource = marca;
                marcaComboBox.DisplayMember = "Nome";
                marcaComboBox.ValueMember = "Id";
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
