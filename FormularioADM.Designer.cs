namespace ProjetoFinalDesktop2
{
    partial class FormularioADM
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloIdLabel;
            System.Windows.Forms.Label marcaIdLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label tabelaFipeIdLabel;
            System.Windows.Forms.Label marcaId1Label;
            System.Windows.Forms.Label modeloId1Label;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label valorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioADM));
            this.corretoraDataSet = new ProjetoFinalDesktop2.CorretoraDataSet();
            this.viewMarcaModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.viewMarcaModeloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.viewMarcaModeloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloIdTextBox = new System.Windows.Forms.TextBox();
            this.marcaIdTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.tabelaFipeIdTextBox = new System.Windows.Forms.TextBox();
            this.marcaId1TextBox = new System.Windows.Forms.TextBox();
            this.modeloId1TextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloIdLabel = new System.Windows.Forms.Label();
            marcaIdLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            tabelaFipeIdLabel = new System.Windows.Forms.Label();
            marcaId1Label = new System.Windows.Forms.Label();
            modeloId1Label = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMarcaModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMarcaModeloBindingNavigator)).BeginInit();
            this.viewMarcaModeloBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(244, 65);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(244, 91);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(54, 18);
            marcaLabel.TabIndex = 3;
            marcaLabel.Text = "Marca:";
            // 
            // modeloIdLabel
            // 
            modeloIdLabel.AutoSize = true;
            modeloIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloIdLabel.Location = new System.Drawing.Point(244, 117);
            modeloIdLabel.Name = "modeloIdLabel";
            modeloIdLabel.Size = new System.Drawing.Size(77, 18);
            modeloIdLabel.TabIndex = 5;
            modeloIdLabel.Text = "Modelo Id:";
            // 
            // marcaIdLabel
            // 
            marcaIdLabel.AutoSize = true;
            marcaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaIdLabel.Location = new System.Drawing.Point(244, 143);
            marcaIdLabel.Name = "marcaIdLabel";
            marcaIdLabel.Size = new System.Drawing.Size(69, 18);
            marcaIdLabel.TabIndex = 7;
            marcaIdLabel.Text = "Marca Id:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(244, 169);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(62, 18);
            modeloLabel.TabIndex = 9;
            modeloLabel.Text = "Modelo:";
            // 
            // tabelaFipeIdLabel
            // 
            tabelaFipeIdLabel.AutoSize = true;
            tabelaFipeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabelaFipeIdLabel.Location = new System.Drawing.Point(244, 195);
            tabelaFipeIdLabel.Name = "tabelaFipeIdLabel";
            tabelaFipeIdLabel.Size = new System.Drawing.Size(103, 18);
            tabelaFipeIdLabel.TabIndex = 11;
            tabelaFipeIdLabel.Text = "Tabela Fipe Id:";
            // 
            // marcaId1Label
            // 
            marcaId1Label.AutoSize = true;
            marcaId1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaId1Label.Location = new System.Drawing.Point(244, 221);
            marcaId1Label.Name = "marcaId1Label";
            marcaId1Label.Size = new System.Drawing.Size(77, 18);
            marcaId1Label.TabIndex = 13;
            marcaId1Label.Text = "Marca Id1:";
            // 
            // modeloId1Label
            // 
            modeloId1Label.AutoSize = true;
            modeloId1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloId1Label.Location = new System.Drawing.Point(244, 247);
            modeloId1Label.Name = "modeloId1Label";
            modeloId1Label.Size = new System.Drawing.Size(85, 18);
            modeloId1Label.TabIndex = 15;
            modeloId1Label.Text = "Modelo Id1:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLabel.Location = new System.Drawing.Point(244, 273);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(38, 18);
            anoLabel.TabIndex = 17;
            anoLabel.Text = "Ano:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(244, 299);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(46, 18);
            valorLabel.TabIndex = 19;
            valorLabel.Text = "Valor:";
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewMarcaModeloBindingSource
            // 
            this.viewMarcaModeloBindingSource.DataMember = "ViewMarcaModelo";
            this.viewMarcaModeloBindingSource.DataSource = this.corretoraDataSet;
            // 
            // viewMarcaModeloTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.ModeloTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoFinalDesktop2.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewMarcaModeloBindingNavigator
            // 
            this.viewMarcaModeloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.viewMarcaModeloBindingNavigator.BindingSource = this.viewMarcaModeloBindingSource;
            this.viewMarcaModeloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewMarcaModeloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.viewMarcaModeloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.viewMarcaModeloBindingNavigatorSaveItem});
            this.viewMarcaModeloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.viewMarcaModeloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewMarcaModeloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewMarcaModeloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewMarcaModeloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewMarcaModeloBindingNavigator.Name = "viewMarcaModeloBindingNavigator";
            this.viewMarcaModeloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viewMarcaModeloBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.viewMarcaModeloBindingNavigator.TabIndex = 0;
            this.viewMarcaModeloBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // viewMarcaModeloBindingNavigatorSaveItem
            // 
            this.viewMarcaModeloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewMarcaModeloBindingNavigatorSaveItem.Enabled = false;
            this.viewMarcaModeloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("viewMarcaModeloBindingNavigatorSaveItem.Image")));
            this.viewMarcaModeloBindingNavigatorSaveItem.Name = "viewMarcaModeloBindingNavigatorSaveItem";
            this.viewMarcaModeloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.viewMarcaModeloBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(355, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(207, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(355, 88);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(207, 22);
            this.marcaTextBox.TabIndex = 4;
            // 
            // modeloIdTextBox
            // 
            this.modeloIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "ModeloId", true));
            this.modeloIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloIdTextBox.Location = new System.Drawing.Point(355, 114);
            this.modeloIdTextBox.Name = "modeloIdTextBox";
            this.modeloIdTextBox.Size = new System.Drawing.Size(207, 22);
            this.modeloIdTextBox.TabIndex = 6;
            // 
            // marcaIdTextBox
            // 
            this.marcaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "MarcaId", true));
            this.marcaIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaIdTextBox.Location = new System.Drawing.Point(355, 140);
            this.marcaIdTextBox.Name = "marcaIdTextBox";
            this.marcaIdTextBox.Size = new System.Drawing.Size(207, 22);
            this.marcaIdTextBox.TabIndex = 8;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(355, 166);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(207, 22);
            this.modeloTextBox.TabIndex = 10;
            // 
            // tabelaFipeIdTextBox
            // 
            this.tabelaFipeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "TabelaFipeId", true));
            this.tabelaFipeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaFipeIdTextBox.Location = new System.Drawing.Point(355, 192);
            this.tabelaFipeIdTextBox.Name = "tabelaFipeIdTextBox";
            this.tabelaFipeIdTextBox.Size = new System.Drawing.Size(207, 22);
            this.tabelaFipeIdTextBox.TabIndex = 12;
            // 
            // marcaId1TextBox
            // 
            this.marcaId1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "MarcaId1", true));
            this.marcaId1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaId1TextBox.Location = new System.Drawing.Point(355, 218);
            this.marcaId1TextBox.Name = "marcaId1TextBox";
            this.marcaId1TextBox.Size = new System.Drawing.Size(207, 22);
            this.marcaId1TextBox.TabIndex = 14;
            // 
            // modeloId1TextBox
            // 
            this.modeloId1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "ModeloId1", true));
            this.modeloId1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloId1TextBox.Location = new System.Drawing.Point(355, 244);
            this.modeloId1TextBox.Name = "modeloId1TextBox";
            this.modeloId1TextBox.Size = new System.Drawing.Size(207, 22);
            this.modeloId1TextBox.TabIndex = 16;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "Ano", true));
            this.anoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoTextBox.Location = new System.Drawing.Point(355, 270);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(207, 22);
            this.anoTextBox.TabIndex = 18;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewMarcaModeloBindingSource, "Valor", true));
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(355, 296);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(207, 22);
            this.valorTextBox.TabIndex = 20;
            // 
            // FormularioADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloIdLabel);
            this.Controls.Add(this.modeloIdTextBox);
            this.Controls.Add(marcaIdLabel);
            this.Controls.Add(this.marcaIdTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(tabelaFipeIdLabel);
            this.Controls.Add(this.tabelaFipeIdTextBox);
            this.Controls.Add(marcaId1Label);
            this.Controls.Add(this.marcaId1TextBox);
            this.Controls.Add(modeloId1Label);
            this.Controls.Add(this.modeloId1TextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.viewMarcaModeloBindingNavigator);
            this.Name = "FormularioADM";
            this.Text = "FormularioADM";
            this.Load += new System.EventHandler(this.FormularioADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMarcaModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMarcaModeloBindingNavigator)).EndInit();
            this.viewMarcaModeloBindingNavigator.ResumeLayout(false);
            this.viewMarcaModeloBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource viewMarcaModeloBindingSource;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator viewMarcaModeloBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton viewMarcaModeloBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloIdTextBox;
        private System.Windows.Forms.TextBox marcaIdTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox tabelaFipeIdTextBox;
        private System.Windows.Forms.TextBox marcaId1TextBox;
        private System.Windows.Forms.TextBox modeloId1TextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
    }
}