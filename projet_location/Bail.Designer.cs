
namespace projet_location
{
    partial class Bail
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
            System.Windows.Forms.Label bailIDLabel;
            System.Windows.Forms.Label bailCodeLabel;
            System.Windows.Forms.Label baildateLabel;
            System.Windows.Forms.Label apartementodeLabel;
            System.Windows.Forms.Label locatairecodeLabel;
            System.Windows.Forms.Label baildureeLabel;
            System.Windows.Forms.Label baildebutLabel;
            System.Windows.Forms.Label montantloyerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bail));
            this.btnRechercher = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.locationDataSet = new projet_location.LocationDataSet();
            this.bailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bailTableAdapter = new projet_location.LocationDataSetTableAdapters.bailTableAdapter();
            this.tableAdapterManager = new projet_location.LocationDataSetTableAdapters.TableAdapterManager();
            this.bailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBailID = new System.Windows.Forms.TextBox();
            this.txtBailCode = new System.Windows.Forms.TextBox();
            this.txtBailDate = new System.Windows.Forms.DateTimePicker();
            this.txtAppartementCode = new System.Windows.Forms.TextBox();
            this.txtLocataireCode = new System.Windows.Forms.TextBox();
            this.txtBailDuree = new System.Windows.Forms.TextBox();
            this.txtBailDebut = new System.Windows.Forms.DateTimePicker();
            this.txtMontantLoyer = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.dataGridViewResultat = new System.Windows.Forms.DataGridView();
            bailIDLabel = new System.Windows.Forms.Label();
            bailCodeLabel = new System.Windows.Forms.Label();
            baildateLabel = new System.Windows.Forms.Label();
            apartementodeLabel = new System.Windows.Forms.Label();
            locatairecodeLabel = new System.Windows.Forms.Label();
            baildureeLabel = new System.Windows.Forms.Label();
            baildebutLabel = new System.Windows.Forms.Label();
            montantloyerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingNavigator)).BeginInit();
            this.bailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // bailIDLabel
            // 
            bailIDLabel.AutoSize = true;
            bailIDLabel.Location = new System.Drawing.Point(40, 330);
            bailIDLabel.Name = "bailIDLabel";
            bailIDLabel.Size = new System.Drawing.Size(51, 17);
            bailIDLabel.TabIndex = 5;
            bailIDLabel.Text = "bail ID:";
            // 
            // bailCodeLabel
            // 
            bailCodeLabel.AutoSize = true;
            bailCodeLabel.Location = new System.Drawing.Point(40, 358);
            bailCodeLabel.Name = "bailCodeLabel";
            bailCodeLabel.Size = new System.Drawing.Size(71, 17);
            bailCodeLabel.TabIndex = 7;
            bailCodeLabel.Text = "bail Code:";
            // 
            // baildateLabel
            // 
            baildateLabel.AutoSize = true;
            baildateLabel.Location = new System.Drawing.Point(40, 386);
            baildateLabel.Name = "baildateLabel";
            baildateLabel.Size = new System.Drawing.Size(62, 17);
            baildateLabel.TabIndex = 9;
            baildateLabel.Text = "baildate:";
            // 
            // apartementodeLabel
            // 
            apartementodeLabel.AutoSize = true;
            apartementodeLabel.Location = new System.Drawing.Point(390, 328);
            apartementodeLabel.Name = "apartementodeLabel";
            apartementodeLabel.Size = new System.Drawing.Size(108, 17);
            apartementodeLabel.TabIndex = 11;
            apartementodeLabel.Text = "apartementode:";
            // 
            // locatairecodeLabel
            // 
            locatairecodeLabel.AutoSize = true;
            locatairecodeLabel.Location = new System.Drawing.Point(390, 356);
            locatairecodeLabel.Name = "locatairecodeLabel";
            locatairecodeLabel.Size = new System.Drawing.Size(97, 17);
            locatairecodeLabel.TabIndex = 13;
            locatairecodeLabel.Text = "locatairecode:";
            // 
            // baildureeLabel
            // 
            baildureeLabel.AutoSize = true;
            baildureeLabel.Location = new System.Drawing.Point(390, 384);
            baildureeLabel.Name = "baildureeLabel";
            baildureeLabel.Size = new System.Drawing.Size(71, 17);
            baildureeLabel.TabIndex = 15;
            baildureeLabel.Text = "bailduree:";
            // 
            // baildebutLabel
            // 
            baildebutLabel.AutoSize = true;
            baildebutLabel.Location = new System.Drawing.Point(744, 327);
            baildebutLabel.Name = "baildebutLabel";
            baildebutLabel.Size = new System.Drawing.Size(70, 17);
            baildebutLabel.TabIndex = 17;
            baildebutLabel.Text = "baildebut:";
            // 
            // montantloyerLabel
            // 
            montantloyerLabel.AutoSize = true;
            montantloyerLabel.Location = new System.Drawing.Point(744, 354);
            montantloyerLabel.Name = "montantloyerLabel";
            montantloyerLabel.Size = new System.Drawing.Size(94, 17);
            montantloyerLabel.TabIndex = 19;
            montantloyerLabel.Text = "montantloyer:";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(454, 458);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(111, 37);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Recherche";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1100, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quitter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // locationDataSet
            // 
            this.locationDataSet.DataSetName = "LocationDataSet";
            this.locationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bailBindingSource
            // 
            this.bailBindingSource.DataMember = "bail";
            this.bailBindingSource.DataSource = this.locationDataSet;
            // 
            // bailTableAdapter
            // 
            this.bailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appartementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bailTableAdapter = this.bailTableAdapter;
            this.tableAdapterManager.LocatairesTableAdapter = null;
            this.tableAdapterManager.paiementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projet_location.LocationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bailBindingNavigator
            // 
            this.bailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bailBindingNavigator.BindingSource = this.bailBindingSource;
            this.bailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bailBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bailBindingNavigatorSaveItem});
            this.bailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bailBindingNavigator.Name = "bailBindingNavigator";
            this.bailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bailBindingNavigator.Size = new System.Drawing.Size(1445, 27);
            this.bailBindingNavigator.TabIndex = 3;
            this.bailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bailBindingNavigatorSaveItem
            // 
            this.bailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bailBindingNavigatorSaveItem.Image")));
            this.bailBindingNavigatorSaveItem.Name = "bailBindingNavigatorSaveItem";
            this.bailBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bailBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.bailBindingNavigatorSaveItem.Click += new System.EventHandler(this.bailBindingNavigatorSaveItem_Click);
            // 
            // bailDataGridView
            // 
            this.bailDataGridView.AutoGenerateColumns = false;
            this.bailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bailDataGridView.DataSource = this.bailBindingSource;
            this.bailDataGridView.Location = new System.Drawing.Point(20, 48);
            this.bailDataGridView.Name = "bailDataGridView";
            this.bailDataGridView.RowHeadersWidth = 51;
            this.bailDataGridView.RowTemplate.Height = 24;
            this.bailDataGridView.Size = new System.Drawing.Size(1413, 220);
            this.bailDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bailID";
            this.dataGridViewTextBoxColumn1.HeaderText = "bailID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bailCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "bailCode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "baildate";
            this.dataGridViewTextBoxColumn3.HeaderText = "baildate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "apartementode";
            this.dataGridViewTextBoxColumn4.HeaderText = "apartementode";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "locatairecode";
            this.dataGridViewTextBoxColumn5.HeaderText = "locatairecode";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bailduree";
            this.dataGridViewTextBoxColumn6.HeaderText = "bailduree";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "baildebut";
            this.dataGridViewTextBoxColumn7.HeaderText = "baildebut";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "montantloyer";
            this.dataGridViewTextBoxColumn8.HeaderText = "montantloyer";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // txtBailID
            // 
            this.txtBailID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "bailID", true));
            this.txtBailID.Enabled = false;
            this.txtBailID.Location = new System.Drawing.Point(154, 327);
            this.txtBailID.Name = "txtBailID";
            this.txtBailID.Size = new System.Drawing.Size(200, 22);
            this.txtBailID.TabIndex = 6;
            // 
            // txtBailCode
            // 
            this.txtBailCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "bailCode", true));
            this.txtBailCode.Location = new System.Drawing.Point(154, 355);
            this.txtBailCode.Name = "txtBailCode";
            this.txtBailCode.Size = new System.Drawing.Size(200, 22);
            this.txtBailCode.TabIndex = 8;
            // 
            // txtBailDate
            // 
            this.txtBailDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bailBindingSource, "baildate", true));
            this.txtBailDate.Location = new System.Drawing.Point(154, 382);
            this.txtBailDate.Name = "txtBailDate";
            this.txtBailDate.Size = new System.Drawing.Size(200, 22);
            this.txtBailDate.TabIndex = 10;
            // 
            // txtAppartementCode
            // 
            this.txtAppartementCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "apartementode", true));
            this.txtAppartementCode.Location = new System.Drawing.Point(504, 325);
            this.txtAppartementCode.Name = "txtAppartementCode";
            this.txtAppartementCode.Size = new System.Drawing.Size(200, 22);
            this.txtAppartementCode.TabIndex = 12;
            // 
            // txtLocataireCode
            // 
            this.txtLocataireCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "locatairecode", true));
            this.txtLocataireCode.Location = new System.Drawing.Point(504, 353);
            this.txtLocataireCode.Name = "txtLocataireCode";
            this.txtLocataireCode.Size = new System.Drawing.Size(200, 22);
            this.txtLocataireCode.TabIndex = 14;
            // 
            // txtBailDuree
            // 
            this.txtBailDuree.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "bailduree", true));
            this.txtBailDuree.Location = new System.Drawing.Point(504, 381);
            this.txtBailDuree.Name = "txtBailDuree";
            this.txtBailDuree.Size = new System.Drawing.Size(200, 22);
            this.txtBailDuree.TabIndex = 16;
            // 
            // txtBailDebut
            // 
            this.txtBailDebut.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bailBindingSource, "baildebut", true));
            this.txtBailDebut.Location = new System.Drawing.Point(858, 323);
            this.txtBailDebut.Name = "txtBailDebut";
            this.txtBailDebut.Size = new System.Drawing.Size(200, 22);
            this.txtBailDebut.TabIndex = 18;
            // 
            // txtMontantLoyer
            // 
            this.txtMontantLoyer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "montantloyer", true));
            this.txtMontantLoyer.Location = new System.Drawing.Point(858, 351);
            this.txtMontantLoyer.Name = "txtMontantLoyer";
            this.txtMontantLoyer.Size = new System.Drawing.Size(200, 22);
            this.txtMontantLoyer.TabIndex = 20;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(1100, 348);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(115, 37);
            this.btnEnregistrer.TabIndex = 21;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Rechercher par nom client:";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(1100, 403);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(115, 37);
            this.btnEffacer.TabIndex = 25;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(249, 465);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(157, 22);
            this.txtRecherche.TabIndex = 26;
            // 
            // dataGridViewResultat
            // 
            this.dataGridViewResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultat.Location = new System.Drawing.Point(20, 524);
            this.dataGridViewResultat.Name = "dataGridViewResultat";
            this.dataGridViewResultat.RowHeadersWidth = 51;
            this.dataGridViewResultat.RowTemplate.Height = 24;
            this.dataGridViewResultat.Size = new System.Drawing.Size(1323, 150);
            this.dataGridViewResultat.TabIndex = 27;
            // 
            // Bail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 878);
            this.Controls.Add(this.dataGridViewResultat);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(bailIDLabel);
            this.Controls.Add(this.txtBailID);
            this.Controls.Add(bailCodeLabel);
            this.Controls.Add(this.txtBailCode);
            this.Controls.Add(baildateLabel);
            this.Controls.Add(this.txtBailDate);
            this.Controls.Add(apartementodeLabel);
            this.Controls.Add(this.txtAppartementCode);
            this.Controls.Add(locatairecodeLabel);
            this.Controls.Add(this.txtLocataireCode);
            this.Controls.Add(baildureeLabel);
            this.Controls.Add(this.txtBailDuree);
            this.Controls.Add(baildebutLabel);
            this.Controls.Add(this.txtBailDebut);
            this.Controls.Add(montantloyerLabel);
            this.Controls.Add(this.txtMontantLoyer);
            this.Controls.Add(this.bailDataGridView);
            this.Controls.Add(this.bailBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRechercher);
            this.Name = "Bail";
            this.Text = "Bail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingNavigator)).EndInit();
            this.bailBindingNavigator.ResumeLayout(false);
            this.bailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button button3;
        private LocationDataSet locationDataSet;
        private System.Windows.Forms.BindingSource bailBindingSource;
        private LocationDataSetTableAdapters.bailTableAdapter bailTableAdapter;
        private LocationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bailBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtBailID;
        private System.Windows.Forms.TextBox txtBailCode;
        private System.Windows.Forms.DateTimePicker txtBailDate;
        private System.Windows.Forms.TextBox txtAppartementCode;
        private System.Windows.Forms.TextBox txtLocataireCode;
        private System.Windows.Forms.TextBox txtBailDuree;
        private System.Windows.Forms.DateTimePicker txtBailDebut;
        private System.Windows.Forms.TextBox txtMontantLoyer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridView dataGridViewResultat;
    }
}