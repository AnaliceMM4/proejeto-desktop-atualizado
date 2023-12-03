namespace ProjetoFinalDesktop2
{
    partial class SimulacaoApolice
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
            System.Windows.Forms.Label anoModeloLabel;
            System.Windows.Forms.Label anoFabricacaoLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label apoliceIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulacaoApolice));
            System.Windows.Forms.Label clienteIdLabel;
            this.corretoraDataSet = new ProjetoFinalDesktop2.CorretoraDataSet();
            this.apolicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apolicesTableAdapter = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.ApolicesTableAdapter();
            this.tableAdapterManager = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.apolicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.anoModeloTextBox = new System.Windows.Forms.TextBox();
            this.anoFabricacaoTextBox = new System.Windows.Forms.TextBox();
            this.apoliceIdTextBox = new System.Windows.Forms.TextBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSimulaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.apolicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            anoModeloLabel = new System.Windows.Forms.Label();
            anoFabricacaoLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            apoliceIdLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingNavigator)).BeginInit();
            this.apolicesBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anoModeloLabel
            // 
            anoModeloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            anoModeloLabel.AutoSize = true;
            anoModeloLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoModeloLabel.Location = new System.Drawing.Point(50, 192);
            anoModeloLabel.Name = "anoModeloLabel";
            anoModeloLabel.Size = new System.Drawing.Size(97, 19);
            anoModeloLabel.TabIndex = 9;
            anoModeloLabel.Text = "Ano Modelo:";
            // 
            // anoFabricacaoLabel
            // 
            anoFabricacaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            anoFabricacaoLabel.AutoSize = true;
            anoFabricacaoLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoFabricacaoLabel.Location = new System.Drawing.Point(50, 163);
            anoFabricacaoLabel.Name = "anoFabricacaoLabel";
            anoFabricacaoLabel.Size = new System.Drawing.Size(120, 19);
            anoFabricacaoLabel.TabIndex = 7;
            anoFabricacaoLabel.Text = "Ano Fabricacao:";
            anoFabricacaoLabel.Click += new System.EventHandler(this.anoFabricacaoLabel_Click);
            // 
            // modeloLabel
            // 
            modeloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(50, 130);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(65, 19);
            modeloLabel.TabIndex = 5;
            modeloLabel.Text = "Modelo:";
            // 
            // marcaLabel
            // 
            marcaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(50, 101);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(56, 19);
            marcaLabel.TabIndex = 3;
            marcaLabel.Text = "Marca:";
            // 
            // apoliceIdLabel
            // 
            apoliceIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            apoliceIdLabel.AutoSize = true;
            apoliceIdLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apoliceIdLabel.Location = new System.Drawing.Point(50, 69);
            apoliceIdLabel.Name = "apoliceIdLabel";
            apoliceIdLabel.Size = new System.Drawing.Size(82, 19);
            apoliceIdLabel.TabIndex = 1;
            apoliceIdLabel.Text = "Apolice Id:";
            apoliceIdLabel.Click += new System.EventHandler(this.apoliceIdLabel_Click);
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apolicesBindingSource
            // 
            this.apolicesBindingSource.DataMember = "Apolices";
            this.apolicesBindingSource.DataSource = this.corretoraDataSet;
            // 
            // apolicesTableAdapter
            // 
            this.apolicesTableAdapter.ClearBeforeFill = true;
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
            // apolicesBindingNavigator
            // 
            this.apolicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.apolicesBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apolicesBindingNavigator.BindingSource = this.apolicesBindingSource;
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
            this.apolicesBindingNavigator.Location = new System.Drawing.Point(0, 41);
            this.apolicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.apolicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.apolicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.apolicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.apolicesBindingNavigator.Name = "apolicesBindingNavigator";
            this.apolicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.apolicesBindingNavigator.Size = new System.Drawing.Size(792, 51);
            this.apolicesBindingNavigator.TabIndex = 0;
            this.apolicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 48);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 51);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // anoModeloTextBox
            // 
            this.anoModeloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.anoModeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "AnoModelo", true));
            this.anoModeloTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoModeloTextBox.Location = new System.Drawing.Point(183, 192);
            this.anoModeloTextBox.Multiline = true;
            this.anoModeloTextBox.Name = "anoModeloTextBox";
            this.anoModeloTextBox.Size = new System.Drawing.Size(149, 23);
            this.anoModeloTextBox.TabIndex = 10;
            this.anoModeloTextBox.TextChanged += new System.EventHandler(this.anoModeloTextBox_TextChanged);
            // 
            // anoFabricacaoTextBox
            // 
            this.anoFabricacaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.anoFabricacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "AnoFabricacao", true));
            this.anoFabricacaoTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoFabricacaoTextBox.Location = new System.Drawing.Point(183, 161);
            this.anoFabricacaoTextBox.Multiline = true;
            this.anoFabricacaoTextBox.Name = "anoFabricacaoTextBox";
            this.anoFabricacaoTextBox.Size = new System.Drawing.Size(149, 23);
            this.anoFabricacaoTextBox.TabIndex = 8;
            this.anoFabricacaoTextBox.TextChanged += new System.EventHandler(this.anoFabricacaoTextBox_TextChanged);
            // 
            // apoliceIdTextBox
            // 
            this.apoliceIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.apoliceIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ApoliceId", true));
            this.apoliceIdTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apoliceIdTextBox.Location = new System.Drawing.Point(183, 71);
            this.apoliceIdTextBox.Multiline = true;
            this.apoliceIdTextBox.Name = "apoliceIdTextBox";
            this.apoliceIdTextBox.Size = new System.Drawing.Size(149, 23);
            this.apoliceIdTextBox.TabIndex = 2;
            this.apoliceIdTextBox.TextChanged += new System.EventHandler(this.apoliceIdTextBox_TextChanged);
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.marcaComboBox.Location = new System.Drawing.Point(182, 104);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(149, 21);
            this.marcaComboBox.TabIndex = 27;
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(183, 133);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(149, 21);
            this.modeloComboBox.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(clienteIdLabel);
            this.panel1.Controls.Add(this.clienteIdTextBox);
            this.panel1.Controls.Add(this.modeloComboBox);
            this.panel1.Controls.Add(this.marcaComboBox);
            this.panel1.Controls.Add(apoliceIdLabel);
            this.panel1.Controls.Add(this.apoliceIdTextBox);
            this.panel1.Controls.Add(marcaLabel);
            this.panel1.Controls.Add(modeloLabel);
            this.panel1.Controls.Add(anoFabricacaoLabel);
            this.panel1.Controls.Add(this.anoFabricacaoTextBox);
            this.panel1.Controls.Add(this.anoModeloTextBox);
            this.panel1.Controls.Add(anoModeloLabel);
            this.panel1.Location = new System.Drawing.Point(3, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 353);
            this.panel1.TabIndex = 28;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 513);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btSair);
            this.panel3.Controls.Add(this.btCancelar);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 56);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(792, 41);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSimulaçãoToolStripMenuItem
            // 
            this.iniciarSimulaçãoToolStripMenuItem.Name = "iniciarSimulaçãoToolStripMenuItem";
            this.iniciarSimulaçãoToolStripMenuItem.Size = new System.Drawing.Size(109, 37);
            this.iniciarSimulaçãoToolStripMenuItem.Text = "Iniciar Simulação";
            // 
            // contratarToolStripMenuItem
            // 
            this.contratarToolStripMenuItem.Name = "contratarToolStripMenuItem";
            this.contratarToolStripMenuItem.Size = new System.Drawing.Size(69, 37);
            this.contratarToolStripMenuItem.Text = "Contratar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 37);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 48);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 48);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 48);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 48);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 48);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 48);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // apolicesBindingNavigatorSaveItem
            // 
            this.apolicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apolicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("apolicesBindingNavigatorSaveItem.Image")));
            this.apolicesBindingNavigatorSaveItem.Name = "apolicesBindingNavigatorSaveItem";
            this.apolicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 48);
            this.apolicesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.apolicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.apolicesBindingNavigatorSaveItem_Click_3);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(41, 48);
            this.toolStripButton1.Text = "Editar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteIdLabel.Location = new System.Drawing.Point(440, 164);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(78, 19);
            clienteIdLabel.TabIndex = 32;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ClienteId", true));
            this.clienteIdTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdTextBox.Location = new System.Drawing.Point(534, 161);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(104, 26);
            this.clienteIdTextBox.TabIndex = 33;
            // 
            // SimulacaoApolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulacaoApolice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulação do Carro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSimulacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingNavigator)).EndInit();
            this.apolicesBindingNavigator.ResumeLayout(false);
            this.apolicesBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource apolicesBindingSource;
        private CorretoraDataSetTableAdapters.ApolicesTableAdapter apolicesTableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox anoModeloTextBox;
        private System.Windows.Forms.TextBox anoFabricacaoTextBox;
        private System.Windows.Forms.TextBox apoliceIdTextBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSimulaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clienteIdTextBox;
    }
}