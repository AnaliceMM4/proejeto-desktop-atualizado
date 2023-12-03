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
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelVoltar_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelo'. Você pode movê-la ou removê-la conforme necessário.
            this.modeloTableAdapter.Fill(this.corretoraDataSet.Modelo);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            //   this.clientesTableAdapter.Fill(this.corretoraDataSet.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            // this.clientesTableAdapter.Fill(this.corretoraDataSet.Clientes);

        }
        private void labelAvancar_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCliente f = new MenuCliente();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCliente f = new MenuCliente();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void modeloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

        /*private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }*/

        /* private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
         {
             this.Validate();
             this.clientesBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

         }*/
    }
}
