namespace ProjetoFinalDesktop2
{
    partial class SimulacaoCoberturasDesejadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.combustivelLabel = new System.Windows.Forms.Label();
            this.chassiLabel = new System.Windows.Forms.Label();
            this.placaLabel = new System.Windows.Forms.Label();
            this.rouboLabel = new System.Windows.Forms.Label();
            this.vidrosLabel = new System.Windows.Forms.Label();
            this.acidentesLabel = new System.Windows.Forms.Label();
            this.danosTerceirosLabel = new System.Windows.Forms.Label();
            this.franquiaRedLabel = new System.Windows.Forms.Label();
            this.valorDoBemLabel = new System.Windows.Forms.Label();
            this.valorFranquiaLabel = new System.Windows.Forms.Label();
            this.valorApoliceLabel = new System.Windows.Forms.Label();
            this.valorPremioLabel = new System.Windows.Forms.Label();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.apolicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corretoraDataSet = new ProjetoFinalDesktop2.CorretoraDataSet();
            this.apolicesTableAdapter = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.ApolicesTableAdapter();
            this.apolicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.apolicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.chassiTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSimulaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.rouboCheckBox = new System.Windows.Forms.CheckBox();
            this.vidrosCheckBox = new System.Windows.Forms.CheckBox();
            this.acidentesCheckBox = new System.Windows.Forms.CheckBox();
            this.danosTerceirosCheckBox = new System.Windows.Forms.CheckBox();
            this.franquiaRedCheckBox = new System.Windows.Forms.CheckBox();
            this.valorDoBemTextBox = new System.Windows.Forms.TextBox();
            this.valorFranquiaTextBox = new System.Windows.Forms.TextBox();
            this.valorApoliceTextBox = new System.Windows.Forms.TextBox();
            this.valorPremioTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingNavigator)).BeginInit();
            this.apolicesBindingNavigator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combustivelLabel
            // 
            this.combustivelLabel.AutoSize = true;
            this.combustivelLabel.Location = new System.Drawing.Point(50, 60);
            this.combustivelLabel.Name = "combustivelLabel";
            this.combustivelLabel.Size = new System.Drawing.Size(67, 13);
            this.combustivelLabel.TabIndex = 6;
            this.combustivelLabel.Text = "Combustivel:";
            // 
            // chassiLabel
            // 
            this.chassiLabel.AutoSize = true;
            this.chassiLabel.Location = new System.Drawing.Point(50, 86);
            this.chassiLabel.Name = "chassiLabel";
            this.chassiLabel.Size = new System.Drawing.Size(41, 13);
            this.chassiLabel.TabIndex = 8;
            this.chassiLabel.Text = "Chassi:";
            // 
            // placaLabel
            // 
            this.placaLabel.AutoSize = true;
            this.placaLabel.Location = new System.Drawing.Point(50, 112);
            this.placaLabel.Name = "placaLabel";
            this.placaLabel.Size = new System.Drawing.Size(37, 13);
            this.placaLabel.TabIndex = 10;
            this.placaLabel.Text = "Placa:";
            // 
            // rouboLabel
            // 
            this.rouboLabel.AutoSize = true;
            this.rouboLabel.Location = new System.Drawing.Point(345, 30);
            this.rouboLabel.Name = "rouboLabel";
            this.rouboLabel.Size = new System.Drawing.Size(42, 13);
            this.rouboLabel.TabIndex = 12;
            this.rouboLabel.Text = "Roubo:";
            // 
            // vidrosLabel
            // 
            this.vidrosLabel.AutoSize = true;
            this.vidrosLabel.Location = new System.Drawing.Point(345, 60);
            this.vidrosLabel.Name = "vidrosLabel";
            this.vidrosLabel.Size = new System.Drawing.Size(39, 13);
            this.vidrosLabel.TabIndex = 14;
            this.vidrosLabel.Text = "Vidros:";
            // 
            // acidentesLabel
            // 
            this.acidentesLabel.AutoSize = true;
            this.acidentesLabel.Location = new System.Drawing.Point(345, 90);
            this.acidentesLabel.Name = "acidentesLabel";
            this.acidentesLabel.Size = new System.Drawing.Size(57, 13);
            this.acidentesLabel.TabIndex = 16;
            this.acidentesLabel.Text = "Acidentes:";
            // 
            // danosTerceirosLabel
            // 
            this.danosTerceirosLabel.AutoSize = true;
            this.danosTerceirosLabel.Location = new System.Drawing.Point(345, 120);
            this.danosTerceirosLabel.Name = "danosTerceirosLabel";
            this.danosTerceirosLabel.Size = new System.Drawing.Size(88, 13);
            this.danosTerceirosLabel.TabIndex = 18;
            this.danosTerceirosLabel.Text = "Danos Terceiros:";
            // 
            // franquiaRedLabel
            // 
            this.franquiaRedLabel.AutoSize = true;
            this.franquiaRedLabel.Location = new System.Drawing.Point(345, 150);
            this.franquiaRedLabel.Name = "franquiaRedLabel";
            this.franquiaRedLabel.Size = new System.Drawing.Size(74, 13);
            this.franquiaRedLabel.TabIndex = 20;
            this.franquiaRedLabel.Text = "Franquia Red:";
            // 
            // valorDoBemLabel
            // 
            this.valorDoBemLabel.AutoSize = true;
            this.valorDoBemLabel.Location = new System.Drawing.Point(345, 178);
            this.valorDoBemLabel.Name = "valorDoBemLabel";
            this.valorDoBemLabel.Size = new System.Drawing.Size(75, 13);
            this.valorDoBemLabel.TabIndex = 22;
            this.valorDoBemLabel.Text = "Valor Do Bem:";
            // 
            // valorFranquiaLabel
            // 
            this.valorFranquiaLabel.AutoSize = true;
            this.valorFranquiaLabel.Location = new System.Drawing.Point(345, 204);
            this.valorFranquiaLabel.Name = "valorFranquiaLabel";
            this.valorFranquiaLabel.Size = new System.Drawing.Size(78, 13);
            this.valorFranquiaLabel.TabIndex = 24;
            this.valorFranquiaLabel.Text = "Valor Franquia:";
            // 
            // valorApoliceLabel
            // 
            this.valorApoliceLabel.AutoSize = true;
            this.valorApoliceLabel.Location = new System.Drawing.Point(345, 235);
            this.valorApoliceLabel.Name = "valorApoliceLabel";
            this.valorApoliceLabel.Size = new System.Drawing.Size(72, 13);
            this.valorApoliceLabel.TabIndex = 26;
            this.valorApoliceLabel.Text = "Valor Apolice:";
            // 
            // valorPremioLabel
            // 
            this.valorPremioLabel.AutoSize = true;
            this.valorPremioLabel.Location = new System.Drawing.Point(345, 261);
            this.valorPremioLabel.Name = "valorPremioLabel";
            this.valorPremioLabel.Size = new System.Drawing.Size(69, 13);
            this.valorPremioLabel.TabIndex = 28;
            this.valorPremioLabel.Text = "Valor Premio:";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(144, 57);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(104, 20);
            this.combustivelTextBox.TabIndex = 7;
            // 
            // apolicesBindingSource
            // 
            this.apolicesBindingSource.DataMember = "Apolices";
            this.apolicesBindingSource.DataSource = this.corretoraDataSet;
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apolicesTableAdapter
            // 
            this.apolicesTableAdapter.ClearBeforeFill = true;
            // 
            // apolicesBindingNavigator
            // 
            this.apolicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.apolicesBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apolicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.apolicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.apolicesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.apolicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.apolicesBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.apolicesBindingNavigator.Location = new System.Drawing.Point(0, 59);
            this.apolicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.apolicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.apolicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.apolicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.apolicesBindingNavigator.Name = "apolicesBindingNavigator";
            this.apolicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.apolicesBindingNavigator.Size = new System.Drawing.Size(792, 74);
            this.apolicesBindingNavigator.TabIndex = 0;
            this.apolicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 71);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 71);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 71);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 71);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 71);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 74);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 71);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 71);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 74);
            // 
            // apolicesBindingNavigatorSaveItem
            // 
            this.apolicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apolicesBindingNavigatorSaveItem.Name = "apolicesBindingNavigatorSaveItem";
            this.apolicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 71);
            this.apolicesBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(41, 71);
            this.toolStripButton1.Text = "Editar";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = this.apolicesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.ModeloTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chassiTextBox
            // 
            this.chassiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "Chassi", true));
            this.chassiTextBox.Location = new System.Drawing.Point(144, 83);
            this.chassiTextBox.Name = "chassiTextBox";
            this.chassiTextBox.Size = new System.Drawing.Size(104, 20);
            this.chassiTextBox.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.apolicesBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, -148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 747);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btSair);
            this.panel3.Controls.Add(this.btCancelar);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 658);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 86);
            this.panel3.TabIndex = 30;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(73, 22);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(99, 27);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(472, 22);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 27);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Avançar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSimulaçãoToolStripMenuItem,
            this.contratarToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 59);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSimulaçãoToolStripMenuItem
            // 
            this.iniciarSimulaçãoToolStripMenuItem.Name = "iniciarSimulaçãoToolStripMenuItem";
            this.iniciarSimulaçãoToolStripMenuItem.Size = new System.Drawing.Size(109, 55);
            this.iniciarSimulaçãoToolStripMenuItem.Text = "Iniciar Simulação";
            // 
            // contratarToolStripMenuItem
            // 
            this.contratarToolStripMenuItem.Name = "contratarToolStripMenuItem";
            this.contratarToolStripMenuItem.Size = new System.Drawing.Size(69, 55);
            this.contratarToolStripMenuItem.Text = "Contratar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 55);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.combustivelLabel);
            this.panel1.Controls.Add(this.combustivelTextBox);
            this.panel1.Controls.Add(this.chassiLabel);
            this.panel1.Controls.Add(this.chassiTextBox);
            this.panel1.Controls.Add(this.placaLabel);
            this.panel1.Controls.Add(this.placaTextBox);
            this.panel1.Controls.Add(this.rouboLabel);
            this.panel1.Controls.Add(this.rouboCheckBox);
            this.panel1.Controls.Add(this.vidrosLabel);
            this.panel1.Controls.Add(this.vidrosCheckBox);
            this.panel1.Controls.Add(this.acidentesLabel);
            this.panel1.Controls.Add(this.acidentesCheckBox);
            this.panel1.Controls.Add(this.danosTerceirosLabel);
            this.panel1.Controls.Add(this.danosTerceirosCheckBox);
            this.panel1.Controls.Add(this.franquiaRedLabel);
            this.panel1.Controls.Add(this.franquiaRedCheckBox);
            this.panel1.Controls.Add(this.valorDoBemLabel);
            this.panel1.Controls.Add(this.valorDoBemTextBox);
            this.panel1.Controls.Add(this.valorFranquiaLabel);
            this.panel1.Controls.Add(this.valorFranquiaTextBox);
            this.panel1.Controls.Add(this.valorApoliceLabel);
            this.panel1.Controls.Add(this.valorApoliceTextBox);
            this.panel1.Controls.Add(this.valorPremioLabel);
            this.panel1.Controls.Add(this.valorPremioTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 516);
            this.panel1.TabIndex = 28;
            // 
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "Placa", true));
            this.placaTextBox.Location = new System.Drawing.Point(144, 109);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(104, 20);
            this.placaTextBox.TabIndex = 11;
            // 
            // rouboCheckBox
            // 
            this.rouboCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.apolicesBindingSource, "Roubo", true));
            this.rouboCheckBox.Location = new System.Drawing.Point(439, 25);
            this.rouboCheckBox.Name = "rouboCheckBox";
            this.rouboCheckBox.Size = new System.Drawing.Size(104, 24);
            this.rouboCheckBox.TabIndex = 13;
            this.rouboCheckBox.Text = "checkBox1";
            this.rouboCheckBox.UseVisualStyleBackColor = true;
            // 
            // vidrosCheckBox
            // 
            this.vidrosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.apolicesBindingSource, "Vidros", true));
            this.vidrosCheckBox.Location = new System.Drawing.Point(439, 55);
            this.vidrosCheckBox.Name = "vidrosCheckBox";
            this.vidrosCheckBox.Size = new System.Drawing.Size(104, 24);
            this.vidrosCheckBox.TabIndex = 15;
            this.vidrosCheckBox.Text = "checkBox1";
            this.vidrosCheckBox.UseVisualStyleBackColor = true;
            // 
            // acidentesCheckBox
            // 
            this.acidentesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.apolicesBindingSource, "Acidentes", true));
            this.acidentesCheckBox.Location = new System.Drawing.Point(439, 85);
            this.acidentesCheckBox.Name = "acidentesCheckBox";
            this.acidentesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.acidentesCheckBox.TabIndex = 17;
            this.acidentesCheckBox.Text = "checkBox1";
            this.acidentesCheckBox.UseVisualStyleBackColor = true;
            // 
            // danosTerceirosCheckBox
            // 
            this.danosTerceirosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.apolicesBindingSource, "DanosTerceiros", true));
            this.danosTerceirosCheckBox.Location = new System.Drawing.Point(439, 115);
            this.danosTerceirosCheckBox.Name = "danosTerceirosCheckBox";
            this.danosTerceirosCheckBox.Size = new System.Drawing.Size(104, 24);
            this.danosTerceirosCheckBox.TabIndex = 19;
            this.danosTerceirosCheckBox.Text = "checkBox1";
            this.danosTerceirosCheckBox.UseVisualStyleBackColor = true;
            // 
            // franquiaRedCheckBox
            // 
            this.franquiaRedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.apolicesBindingSource, "FranquiaRed", true));
            this.franquiaRedCheckBox.Location = new System.Drawing.Point(439, 145);
            this.franquiaRedCheckBox.Name = "franquiaRedCheckBox";
            this.franquiaRedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.franquiaRedCheckBox.TabIndex = 21;
            this.franquiaRedCheckBox.Text = "checkBox1";
            this.franquiaRedCheckBox.UseVisualStyleBackColor = true;
            // 
            // valorDoBemTextBox
            // 
            this.valorDoBemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ValorDoBem", true));
            this.valorDoBemTextBox.Location = new System.Drawing.Point(439, 175);
            this.valorDoBemTextBox.Name = "valorDoBemTextBox";
            this.valorDoBemTextBox.Size = new System.Drawing.Size(104, 20);
            this.valorDoBemTextBox.TabIndex = 23;
            // 
            // valorFranquiaTextBox
            // 
            this.valorFranquiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ValorFranquia", true));
            this.valorFranquiaTextBox.Location = new System.Drawing.Point(439, 201);
            this.valorFranquiaTextBox.Name = "valorFranquiaTextBox";
            this.valorFranquiaTextBox.Size = new System.Drawing.Size(104, 20);
            this.valorFranquiaTextBox.TabIndex = 25;
            // 
            // valorApoliceTextBox
            // 
            this.valorApoliceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ValorApolice", true));
            this.valorApoliceTextBox.Location = new System.Drawing.Point(439, 232);
            this.valorApoliceTextBox.Name = "valorApoliceTextBox";
            this.valorApoliceTextBox.Size = new System.Drawing.Size(104, 20);
            this.valorApoliceTextBox.TabIndex = 27;
            // 
            // valorPremioTextBox
            // 
            this.valorPremioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ValorPremio", true));
            this.valorPremioTextBox.Location = new System.Drawing.Point(439, 258);
            this.valorPremioTextBox.Name = "valorPremioTextBox";
            this.valorPremioTextBox.Size = new System.Drawing.Size(104, 20);
            this.valorPremioTextBox.TabIndex = 29;
            // 
            // SimulacaoCoberturasDesejadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimulacaoCoberturasDesejadas";
            this.Text = "SimulacaoCoberturasDesejadas";
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingNavigator)).EndInit();
            this.apolicesBindingNavigator.ResumeLayout(false);
            this.apolicesBindingNavigator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.BindingSource apolicesBindingSource;
        private CorretoraDataSet corretoraDataSet;
        private CorretoraDataSetTableAdapters.ApolicesTableAdapter apolicesTableAdapter;
        private System.Windows.Forms.BindingNavigator apolicesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton apolicesBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox chassiTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSimulaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.CheckBox rouboCheckBox;
        private System.Windows.Forms.CheckBox vidrosCheckBox;
        private System.Windows.Forms.CheckBox acidentesCheckBox;
        private System.Windows.Forms.CheckBox danosTerceirosCheckBox;
        private System.Windows.Forms.CheckBox franquiaRedCheckBox;
        private System.Windows.Forms.TextBox valorDoBemTextBox;
        private System.Windows.Forms.TextBox valorFranquiaTextBox;
        private System.Windows.Forms.TextBox valorApoliceTextBox;
        private System.Windows.Forms.TextBox valorPremioTextBox;
        private System.Windows.Forms.Label combustivelLabel;
        private System.Windows.Forms.Label chassiLabel;
        private System.Windows.Forms.Label placaLabel;
        private System.Windows.Forms.Label rouboLabel;
        private System.Windows.Forms.Label vidrosLabel;
        private System.Windows.Forms.Label acidentesLabel;
        private System.Windows.Forms.Label danosTerceirosLabel;
        private System.Windows.Forms.Label franquiaRedLabel;
        private System.Windows.Forms.Label valorDoBemLabel;
        private System.Windows.Forms.Label valorFranquiaLabel;
        private System.Windows.Forms.Label valorApoliceLabel;
        private System.Windows.Forms.Label valorPremioLabel;
    }
}