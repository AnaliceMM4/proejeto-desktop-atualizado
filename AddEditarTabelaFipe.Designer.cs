namespace ProjetoFinalDesktop2
{
    partial class AddEditarTabelaFipe
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
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label modeloIdLabel;
            System.Windows.Forms.Label tabelaFipeIdLabel;
            System.Windows.Forms.Label marcaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditarTabelaFipe));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaFIPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corretoraDataSet = new ProjetoFinalDesktop2.CorretoraDataSet();
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
            this.tabelaFIPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabelaFipeIdTextBox = new System.Windows.Forms.TextBox();
            this.marcaIdTextBox = new System.Windows.Forms.TextBox();
            this.modeloIdTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inícioAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaFIPETableAdapter = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TabelaFIPETableAdapter();
            this.tableAdapterManager = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.viewTabelaFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTabelaFIPETableAdapter = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.ViewTabelaFIPETableAdapter();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.ModeloTableAdapter();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.MarcaTableAdapter();
            valorLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            modeloIdLabel = new System.Windows.Forms.Label();
            tabelaFipeIdLabel = new System.Windows.Forms.Label();
            marcaIdLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).BeginInit();
            this.tabelaFIPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelaFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(78, 139);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(50, 19);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // anoLabel
            // 
            anoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            anoLabel.AutoSize = true;
            anoLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLabel.Location = new System.Drawing.Point(78, 113);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(41, 19);
            anoLabel.TabIndex = 6;
            anoLabel.Text = "Ano:";
            // 
            // modeloIdLabel
            // 
            modeloIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            modeloIdLabel.AutoSize = true;
            modeloIdLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloIdLabel.Location = new System.Drawing.Point(78, 87);
            modeloIdLabel.Name = "modeloIdLabel";
            modeloIdLabel.Size = new System.Drawing.Size(83, 19);
            modeloIdLabel.TabIndex = 4;
            modeloIdLabel.Text = "Modelo Id:";
            // 
            // tabelaFipeIdLabel
            // 
            tabelaFipeIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabelaFipeIdLabel.AutoSize = true;
            tabelaFipeIdLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabelaFipeIdLabel.Location = new System.Drawing.Point(78, 35);
            tabelaFipeIdLabel.Name = "tabelaFipeIdLabel";
            tabelaFipeIdLabel.Size = new System.Drawing.Size(110, 19);
            tabelaFipeIdLabel.TabIndex = 0;
            tabelaFipeIdLabel.Text = "Tabela Fipe Id:";
            // 
            // marcaIdLabel
            // 
            marcaIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            marcaIdLabel.AutoSize = true;
            marcaIdLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaIdLabel.Location = new System.Drawing.Point(78, 61);
            marcaIdLabel.Name = "marcaIdLabel";
            marcaIdLabel.Size = new System.Drawing.Size(74, 19);
            marcaIdLabel.TabIndex = 2;
            marcaIdLabel.Text = "Marca Id:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaFIPEBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 374);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tabelaFIPEBindingNavigator
            // 
            this.tabelaFIPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaFIPEBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaFIPEBindingNavigator.BindingSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaFIPEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaFIPEBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tabelaFIPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabelaFIPEBindingNavigatorSaveItem});
            this.tabelaFIPEBindingNavigator.Location = new System.Drawing.Point(0, 37);
            this.tabelaFIPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaFIPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaFIPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaFIPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaFIPEBindingNavigator.Name = "tabelaFIPEBindingNavigator";
            this.tabelaFIPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaFIPEBindingNavigator.Size = new System.Drawing.Size(691, 44);
            this.tabelaFIPEBindingNavigator.TabIndex = 7;
            this.tabelaFIPEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // tabelaFIPEBindingSource
            // 
            this.tabelaFIPEBindingSource.DataMember = "TabelaFIPE";
            this.tabelaFIPEBindingSource.DataSource = this.corretoraDataSet;
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 41);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // tabelaFIPEBindingNavigatorSaveItem
            // 
            this.tabelaFIPEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaFIPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaFIPEBindingNavigatorSaveItem.Image")));
            this.tabelaFIPEBindingNavigatorSaveItem.Name = "tabelaFIPEBindingNavigatorSaveItem";
            this.tabelaFIPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 41);
            this.tabelaFIPEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaFIPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaFIPEBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(tabelaFipeIdLabel);
            this.panel1.Controls.Add(this.tabelaFipeIdTextBox);
            this.panel1.Controls.Add(marcaIdLabel);
            this.panel1.Controls.Add(this.marcaIdTextBox);
            this.panel1.Controls.Add(modeloIdLabel);
            this.panel1.Controls.Add(this.modeloIdTextBox);
            this.panel1.Controls.Add(anoLabel);
            this.panel1.Controls.Add(this.anoTextBox);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.valorTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 287);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabelaFipeIdTextBox
            // 
            this.tabelaFipeIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabelaFipeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "TabelaFipeId", true));
            this.tabelaFipeIdTextBox.Location = new System.Drawing.Point(203, 36);
            this.tabelaFipeIdTextBox.Name = "tabelaFipeIdTextBox";
            this.tabelaFipeIdTextBox.Size = new System.Drawing.Size(213, 20);
            this.tabelaFipeIdTextBox.TabIndex = 1;
            // 
            // marcaIdTextBox
            // 
            this.marcaIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.marcaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "MarcaId", true));
            this.marcaIdTextBox.Location = new System.Drawing.Point(203, 62);
            this.marcaIdTextBox.Name = "marcaIdTextBox";
            this.marcaIdTextBox.Size = new System.Drawing.Size(213, 20);
            this.marcaIdTextBox.TabIndex = 3;
            // 
            // modeloIdTextBox
            // 
            this.modeloIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modeloIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "ModeloId", true));
            this.modeloIdTextBox.Location = new System.Drawing.Point(203, 88);
            this.modeloIdTextBox.Name = "modeloIdTextBox";
            this.modeloIdTextBox.Size = new System.Drawing.Size(213, 20);
            this.modeloIdTextBox.TabIndex = 5;
            // 
            // anoTextBox
            // 
            this.anoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "Ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(203, 114);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(213, 20);
            this.anoTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(203, 140);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(213, 20);
            this.valorTextBox.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioAdministradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inícioAdministradorToolStripMenuItem
            // 
            this.inícioAdministradorToolStripMenuItem.Name = "inícioAdministradorToolStripMenuItem";
            this.inícioAdministradorToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.inícioAdministradorToolStripMenuItem.Text = "Início Administrador";
            // 
            // tabelaFIPETableAdapter
            // 
            this.tabelaFIPETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.ModeloTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = this.tabelaFIPETableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewTabelaFIPEBindingSource
            // 
            this.viewTabelaFIPEBindingSource.DataMember = "ViewTabelaFIPE";
            this.viewTabelaFIPEBindingSource.DataSource = this.corretoraDataSet;
            // 
            // viewTabelaFIPETableAdapter
            // 
            this.viewTabelaFIPETableAdapter.ClearBeforeFill = true;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "Modelo";
            this.modeloBindingSource.DataSource = this.corretoraDataSet;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.corretoraDataSet;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditarTabelaFipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditarTabelaFipe";
            this.Text = "AddEditarTabelaFIpe";
            this.Load += new System.EventHandler(this.AddEditarTabelaFIpe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).EndInit();
            this.tabelaFIPEBindingNavigator.ResumeLayout(false);
            this.tabelaFIPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelaFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inícioAdministradorToolStripMenuItem;
        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource tabelaFIPEBindingSource;
        private CorretoraDataSetTableAdapters.TabelaFIPETableAdapter tabelaFIPETableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaFIPEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabelaFIPEBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource viewTabelaFIPEBindingSource;
        private CorretoraDataSetTableAdapters.ViewTabelaFIPETableAdapter viewTabelaFIPETableAdapter;
        private System.Windows.Forms.TextBox tabelaFipeIdTextBox;
        private System.Windows.Forms.TextBox marcaIdTextBox;
        private System.Windows.Forms.TextBox modeloIdTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private CorretoraDataSetTableAdapters.ModeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private CorretoraDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}