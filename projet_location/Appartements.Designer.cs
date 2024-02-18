
namespace projet_location
{
    partial class Appartements
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
            System.Windows.Forms.Label apartementIDLabel;
            System.Windows.Forms.Label apartementcodeLabel;
            System.Windows.Forms.Label apartementtypeLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label provinceLabel;
            System.Windows.Forms.Label txtCodePostal;
            System.Windows.Forms.Label txtNbreChambre;
            System.Windows.Forms.Label txtnbresdb;
            System.Windows.Forms.Label disposetapisLabel;
            System.Windows.Forms.Label disposeboisfrancLabel;
            System.Windows.Forms.Label labelDispoGarage;
            System.Windows.Forms.Label disposelaveuseLabel;
            System.Windows.Forms.Label animauxautorisesLabel;
            System.Windows.Forms.Label statutLabel;
            System.Windows.Forms.Label loyerLabel;
            this.bindingSourceAppartement = new System.Windows.Forms.BindingSource(this.components);
            this.locationDataSet = new projet_location.LocationDataSet();
            this.appartementTableAdapter = new projet_location.LocationDataSetTableAdapters.appartementTableAdapter();
            this.dataGridViewAppartement = new System.Windows.Forms.DataGridView();
            this.apartementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartementcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartementtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrechambreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbresdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disposetapisDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.disposeboisfrancDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.disposegarageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.disposelaveuseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.animauxautorisesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new projet_location.LocationDataSetTableAdapters.TableAdapterManager();
            this.txtAppartementID = new System.Windows.Forms.TextBox();
            this.txtAppartementCode = new System.Windows.Forms.TextBox();
            this.txtAppartementType = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtcodep = new System.Windows.Forms.TextBox();
            this.txtnbchambre = new System.Windows.Forms.TextBox();
            this.txtnbsalleb = new System.Windows.Forms.TextBox();
            this.cbxDispoTapis = new System.Windows.Forms.CheckBox();
            this.cbxDispoBoisFranc = new System.Windows.Forms.CheckBox();
            this.cbxGarage = new System.Windows.Forms.CheckBox();
            this.cbxDispoLaveuse = new System.Windows.Forms.CheckBox();
            this.cbxAnnimauxAutorises = new System.Windows.Forms.CheckBox();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.txtLoyer = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            apartementIDLabel = new System.Windows.Forms.Label();
            apartementcodeLabel = new System.Windows.Forms.Label();
            apartementtypeLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            txtCodePostal = new System.Windows.Forms.Label();
            txtNbreChambre = new System.Windows.Forms.Label();
            txtnbresdb = new System.Windows.Forms.Label();
            disposetapisLabel = new System.Windows.Forms.Label();
            disposeboisfrancLabel = new System.Windows.Forms.Label();
            labelDispoGarage = new System.Windows.Forms.Label();
            disposelaveuseLabel = new System.Windows.Forms.Label();
            animauxautorisesLabel = new System.Windows.Forms.Label();
            statutLabel = new System.Windows.Forms.Label();
            loyerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAppartement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppartement)).BeginInit();
            this.SuspendLayout();
            // 
            // apartementIDLabel
            // 
            apartementIDLabel.AutoSize = true;
            apartementIDLabel.Location = new System.Drawing.Point(113, 341);
            apartementIDLabel.Name = "apartementIDLabel";
            apartementIDLabel.Size = new System.Drawing.Size(101, 17);
            apartementIDLabel.TabIndex = 1;
            apartementIDLabel.Text = "apartement ID:";
            // 
            // apartementcodeLabel
            // 
            apartementcodeLabel.AutoSize = true;
            apartementcodeLabel.Location = new System.Drawing.Point(113, 369);
            apartementcodeLabel.Name = "apartementcodeLabel";
            apartementcodeLabel.Size = new System.Drawing.Size(115, 17);
            apartementcodeLabel.TabIndex = 3;
            apartementcodeLabel.Text = "apartementcode:";
            // 
            // apartementtypeLabel
            // 
            apartementtypeLabel.AutoSize = true;
            apartementtypeLabel.Location = new System.Drawing.Point(113, 397);
            apartementtypeLabel.Name = "apartementtypeLabel";
            apartementtypeLabel.Size = new System.Drawing.Size(111, 17);
            apartementtypeLabel.TabIndex = 5;
            apartementtypeLabel.Text = "apartementtype:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(113, 425);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(64, 17);
            adresseLabel.TabIndex = 7;
            adresseLabel.Text = "Adresse:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(113, 453);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(36, 17);
            villeLabel.TabIndex = 9;
            villeLabel.Text = "ville:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new System.Drawing.Point(113, 481);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(66, 17);
            provinceLabel.TabIndex = 11;
            provinceLabel.Text = "province:";
            // 
            // txtCodePostal
            // 
            txtCodePostal.AutoSize = true;
            txtCodePostal.Location = new System.Drawing.Point(113, 509);
            txtCodePostal.Name = "txtCodePostal";
            txtCodePostal.Size = new System.Drawing.Size(81, 17);
            txtCodePostal.TabIndex = 13;
            txtCodePostal.Text = "codepostal:";
            // 
            // txtNbreChambre
            // 
            txtNbreChambre.AutoSize = true;
            txtNbreChambre.Location = new System.Drawing.Point(113, 537);
            txtNbreChambre.Name = "txtNbreChambre";
            txtNbreChambre.Size = new System.Drawing.Size(96, 17);
            txtNbreChambre.TabIndex = 15;
            txtNbreChambre.Text = "nbrechambre:";
            // 
            // txtnbresdb
            // 
            txtnbresdb.AutoSize = true;
            txtnbresdb.Location = new System.Drawing.Point(113, 565);
            txtnbresdb.Name = "txtnbresdb";
            txtnbresdb.Size = new System.Drawing.Size(64, 17);
            txtnbresdb.TabIndex = 17;
            txtnbresdb.Text = "nbresdb:";
            // 
            // disposetapisLabel
            // 
            disposetapisLabel.AutoSize = true;
            disposetapisLabel.Location = new System.Drawing.Point(519, 341);
            disposetapisLabel.Name = "disposetapisLabel";
            disposetapisLabel.Size = new System.Drawing.Size(91, 17);
            disposetapisLabel.TabIndex = 19;
            disposetapisLabel.Text = "disposetapis:";
            // 
            // disposeboisfrancLabel
            // 
            disposeboisfrancLabel.AutoSize = true;
            disposeboisfrancLabel.Location = new System.Drawing.Point(519, 371);
            disposeboisfrancLabel.Name = "disposeboisfrancLabel";
            disposeboisfrancLabel.Size = new System.Drawing.Size(119, 17);
            disposeboisfrancLabel.TabIndex = 21;
            disposeboisfrancLabel.Text = "disposeboisfranc:";
            // 
            // labelDispoGarage
            // 
            labelDispoGarage.AutoSize = true;
            labelDispoGarage.Location = new System.Drawing.Point(519, 401);
            labelDispoGarage.Name = "labelDispoGarage";
            labelDispoGarage.Size = new System.Drawing.Size(106, 17);
            labelDispoGarage.TabIndex = 23;
            labelDispoGarage.Text = "disposegarage:";
            // 
            // disposelaveuseLabel
            // 
            disposelaveuseLabel.AutoSize = true;
            disposelaveuseLabel.Location = new System.Drawing.Point(519, 431);
            disposelaveuseLabel.Name = "disposelaveuseLabel";
            disposelaveuseLabel.Size = new System.Drawing.Size(110, 17);
            disposelaveuseLabel.TabIndex = 25;
            disposelaveuseLabel.Text = "disposelaveuse:";
            // 
            // animauxautorisesLabel
            // 
            animauxautorisesLabel.AutoSize = true;
            animauxautorisesLabel.Location = new System.Drawing.Point(519, 461);
            animauxautorisesLabel.Name = "animauxautorisesLabel";
            animauxautorisesLabel.Size = new System.Drawing.Size(122, 17);
            animauxautorisesLabel.TabIndex = 27;
            animauxautorisesLabel.Text = "animauxautorises:";
            // 
            // statutLabel
            // 
            statutLabel.AutoSize = true;
            statutLabel.Location = new System.Drawing.Point(436, 535);
            statutLabel.Name = "statutLabel";
            statutLabel.Size = new System.Drawing.Size(47, 17);
            statutLabel.TabIndex = 29;
            statutLabel.Text = "statut:";
            // 
            // loyerLabel
            // 
            loyerLabel.AutoSize = true;
            loyerLabel.Location = new System.Drawing.Point(436, 563);
            loyerLabel.Name = "loyerLabel";
            loyerLabel.Size = new System.Drawing.Size(43, 17);
            loyerLabel.TabIndex = 31;
            loyerLabel.Text = "loyer:";
            // 
            // bindingSourceAppartement
            // 
            this.bindingSourceAppartement.DataMember = "appartement";
            this.bindingSourceAppartement.DataSource = this.locationDataSet;
            // 
            // locationDataSet
            // 
            this.locationDataSet.DataSetName = "LocationDataSet";
            this.locationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appartementTableAdapter
            // 
            this.appartementTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewAppartement
            // 
            this.dataGridViewAppartement.AutoGenerateColumns = false;
            this.dataGridViewAppartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppartement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartementIDDataGridViewTextBoxColumn,
            this.apartementcodeDataGridViewTextBoxColumn,
            this.apartementtypeDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.codepostalDataGridViewTextBoxColumn,
            this.nbrechambreDataGridViewTextBoxColumn,
            this.nbresdbDataGridViewTextBoxColumn,
            this.disposetapisDataGridViewCheckBoxColumn,
            this.disposeboisfrancDataGridViewCheckBoxColumn,
            this.disposegarageDataGridViewCheckBoxColumn,
            this.disposelaveuseDataGridViewCheckBoxColumn,
            this.animauxautorisesDataGridViewCheckBoxColumn,
            this.statutDataGridViewTextBoxColumn,
            this.loyerDataGridViewTextBoxColumn});
            this.dataGridViewAppartement.DataSource = this.bindingSourceAppartement;
            this.dataGridViewAppartement.Location = new System.Drawing.Point(35, 26);
            this.dataGridViewAppartement.Name = "dataGridViewAppartement";
            this.dataGridViewAppartement.RowHeadersWidth = 51;
            this.dataGridViewAppartement.RowTemplate.Height = 24;
            this.dataGridViewAppartement.Size = new System.Drawing.Size(1801, 253);
            this.dataGridViewAppartement.TabIndex = 0;
            // 
            // apartementIDDataGridViewTextBoxColumn
            // 
            this.apartementIDDataGridViewTextBoxColumn.DataPropertyName = "apartementID";
            this.apartementIDDataGridViewTextBoxColumn.HeaderText = "apartementID";
            this.apartementIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apartementIDDataGridViewTextBoxColumn.Name = "apartementIDDataGridViewTextBoxColumn";
            this.apartementIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartementIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // apartementcodeDataGridViewTextBoxColumn
            // 
            this.apartementcodeDataGridViewTextBoxColumn.DataPropertyName = "apartementcode";
            this.apartementcodeDataGridViewTextBoxColumn.HeaderText = "apartementcode";
            this.apartementcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apartementcodeDataGridViewTextBoxColumn.Name = "apartementcodeDataGridViewTextBoxColumn";
            this.apartementcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // apartementtypeDataGridViewTextBoxColumn
            // 
            this.apartementtypeDataGridViewTextBoxColumn.DataPropertyName = "apartementtype";
            this.apartementtypeDataGridViewTextBoxColumn.HeaderText = "apartementtype";
            this.apartementtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apartementtypeDataGridViewTextBoxColumn.Name = "apartementtypeDataGridViewTextBoxColumn";
            this.apartementtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "province";
            this.provinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // codepostalDataGridViewTextBoxColumn
            // 
            this.codepostalDataGridViewTextBoxColumn.DataPropertyName = "codepostal";
            this.codepostalDataGridViewTextBoxColumn.HeaderText = "codepostal";
            this.codepostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepostalDataGridViewTextBoxColumn.Name = "codepostalDataGridViewTextBoxColumn";
            this.codepostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbrechambreDataGridViewTextBoxColumn
            // 
            this.nbrechambreDataGridViewTextBoxColumn.DataPropertyName = "nbrechambre";
            this.nbrechambreDataGridViewTextBoxColumn.HeaderText = "nbrechambre";
            this.nbrechambreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbrechambreDataGridViewTextBoxColumn.Name = "nbrechambreDataGridViewTextBoxColumn";
            this.nbrechambreDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbresdbDataGridViewTextBoxColumn
            // 
            this.nbresdbDataGridViewTextBoxColumn.DataPropertyName = "nbresdb";
            this.nbresdbDataGridViewTextBoxColumn.HeaderText = "nbresdb";
            this.nbresdbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbresdbDataGridViewTextBoxColumn.Name = "nbresdbDataGridViewTextBoxColumn";
            this.nbresdbDataGridViewTextBoxColumn.Width = 125;
            // 
            // disposetapisDataGridViewCheckBoxColumn
            // 
            this.disposetapisDataGridViewCheckBoxColumn.DataPropertyName = "disposetapis";
            this.disposetapisDataGridViewCheckBoxColumn.HeaderText = "disposetapis";
            this.disposetapisDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.disposetapisDataGridViewCheckBoxColumn.Name = "disposetapisDataGridViewCheckBoxColumn";
            this.disposetapisDataGridViewCheckBoxColumn.Width = 125;
            // 
            // disposeboisfrancDataGridViewCheckBoxColumn
            // 
            this.disposeboisfrancDataGridViewCheckBoxColumn.DataPropertyName = "disposeboisfranc";
            this.disposeboisfrancDataGridViewCheckBoxColumn.HeaderText = "disposeboisfranc";
            this.disposeboisfrancDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.disposeboisfrancDataGridViewCheckBoxColumn.Name = "disposeboisfrancDataGridViewCheckBoxColumn";
            this.disposeboisfrancDataGridViewCheckBoxColumn.Width = 125;
            // 
            // disposegarageDataGridViewCheckBoxColumn
            // 
            this.disposegarageDataGridViewCheckBoxColumn.DataPropertyName = "disposegarage";
            this.disposegarageDataGridViewCheckBoxColumn.HeaderText = "disposegarage";
            this.disposegarageDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.disposegarageDataGridViewCheckBoxColumn.Name = "disposegarageDataGridViewCheckBoxColumn";
            this.disposegarageDataGridViewCheckBoxColumn.Width = 125;
            // 
            // disposelaveuseDataGridViewCheckBoxColumn
            // 
            this.disposelaveuseDataGridViewCheckBoxColumn.DataPropertyName = "disposelaveuse";
            this.disposelaveuseDataGridViewCheckBoxColumn.HeaderText = "disposelaveuse";
            this.disposelaveuseDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.disposelaveuseDataGridViewCheckBoxColumn.Name = "disposelaveuseDataGridViewCheckBoxColumn";
            this.disposelaveuseDataGridViewCheckBoxColumn.Width = 125;
            // 
            // animauxautorisesDataGridViewCheckBoxColumn
            // 
            this.animauxautorisesDataGridViewCheckBoxColumn.DataPropertyName = "animauxautorises";
            this.animauxautorisesDataGridViewCheckBoxColumn.HeaderText = "animauxautorises";
            this.animauxautorisesDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.animauxautorisesDataGridViewCheckBoxColumn.Name = "animauxautorisesDataGridViewCheckBoxColumn";
            this.animauxautorisesDataGridViewCheckBoxColumn.Width = 125;
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "statut";
            this.statutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            this.statutDataGridViewTextBoxColumn.Width = 125;
            // 
            // loyerDataGridViewTextBoxColumn
            // 
            this.loyerDataGridViewTextBoxColumn.DataPropertyName = "loyer";
            this.loyerDataGridViewTextBoxColumn.HeaderText = "loyer";
            this.loyerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loyerDataGridViewTextBoxColumn.Name = "loyerDataGridViewTextBoxColumn";
            this.loyerDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appartementTableAdapter = this.appartementTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bailTableAdapter = null;
            this.tableAdapterManager.LocatairesTableAdapter = null;
            this.tableAdapterManager.paiementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projet_location.LocationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtAppartementID
            // 
            this.txtAppartementID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "apartementID", true));
            this.txtAppartementID.Enabled = false;
            this.txtAppartementID.Location = new System.Drawing.Point(241, 338);
            this.txtAppartementID.Name = "txtAppartementID";
            this.txtAppartementID.Size = new System.Drawing.Size(104, 22);
            this.txtAppartementID.TabIndex = 2;
            // 
            // txtAppartementCode
            // 
            this.txtAppartementCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "apartementcode", true));
            this.txtAppartementCode.Location = new System.Drawing.Point(241, 366);
            this.txtAppartementCode.Name = "txtAppartementCode";
            this.txtAppartementCode.Size = new System.Drawing.Size(104, 22);
            this.txtAppartementCode.TabIndex = 4;
            // 
            // txtAppartementType
            // 
            this.txtAppartementType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "apartementtype", true));
            this.txtAppartementType.Location = new System.Drawing.Point(241, 394);
            this.txtAppartementType.Name = "txtAppartementType";
            this.txtAppartementType.Size = new System.Drawing.Size(104, 22);
            this.txtAppartementType.TabIndex = 6;
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "Adresse", true));
            this.txtAdresse.Location = new System.Drawing.Point(241, 422);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(104, 22);
            this.txtAdresse.TabIndex = 8;
            this.txtAdresse.TextChanged += new System.EventHandler(this.adresseTextBox_TextChanged);
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "ville", true));
            this.txtVille.Location = new System.Drawing.Point(241, 450);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(104, 22);
            this.txtVille.TabIndex = 10;
            // 
            // txtProvince
            // 
            this.txtProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "province", true));
            this.txtProvince.Location = new System.Drawing.Point(241, 478);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(104, 22);
            this.txtProvince.TabIndex = 12;
            // 
            // txtcodep
            // 
            this.txtcodep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "codepostal", true));
            this.txtcodep.Location = new System.Drawing.Point(241, 506);
            this.txtcodep.Name = "txtcodep";
            this.txtcodep.Size = new System.Drawing.Size(104, 22);
            this.txtcodep.TabIndex = 14;
            // 
            // txtnbchambre
            // 
            this.txtnbchambre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "nbrechambre", true));
            this.txtnbchambre.Location = new System.Drawing.Point(241, 534);
            this.txtnbchambre.Name = "txtnbchambre";
            this.txtnbchambre.Size = new System.Drawing.Size(104, 22);
            this.txtnbchambre.TabIndex = 16;
            // 
            // txtnbsalleb
            // 
            this.txtnbsalleb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "nbresdb", true));
            this.txtnbsalleb.Location = new System.Drawing.Point(241, 562);
            this.txtnbsalleb.Name = "txtnbsalleb";
            this.txtnbsalleb.Size = new System.Drawing.Size(104, 22);
            this.txtnbsalleb.TabIndex = 18;
            // 
            // cbxDispoTapis
            // 
            this.cbxDispoTapis.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceAppartement, "disposetapis", true));
            this.cbxDispoTapis.Location = new System.Drawing.Point(647, 336);
            this.cbxDispoTapis.Name = "cbxDispoTapis";
            this.cbxDispoTapis.Size = new System.Drawing.Size(30, 24);
            this.cbxDispoTapis.TabIndex = 20;
            this.cbxDispoTapis.UseVisualStyleBackColor = true;
            // 
            // cbxDispoBoisFranc
            // 
            this.cbxDispoBoisFranc.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceAppartement, "disposeboisfranc", true));
            this.cbxDispoBoisFranc.Location = new System.Drawing.Point(647, 366);
            this.cbxDispoBoisFranc.Name = "cbxDispoBoisFranc";
            this.cbxDispoBoisFranc.Size = new System.Drawing.Size(30, 24);
            this.cbxDispoBoisFranc.TabIndex = 22;
            this.cbxDispoBoisFranc.UseVisualStyleBackColor = true;
            // 
            // cbxGarage
            // 
            this.cbxGarage.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceAppartement, "disposegarage", true));
            this.cbxGarage.Location = new System.Drawing.Point(647, 396);
            this.cbxGarage.Name = "cbxGarage";
            this.cbxGarage.Size = new System.Drawing.Size(104, 24);
            this.cbxGarage.TabIndex = 24;
            this.cbxGarage.UseVisualStyleBackColor = true;
            // 
            // cbxDispoLaveuse
            // 
            this.cbxDispoLaveuse.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceAppartement, "disposelaveuse", true));
            this.cbxDispoLaveuse.Location = new System.Drawing.Point(647, 426);
            this.cbxDispoLaveuse.Name = "cbxDispoLaveuse";
            this.cbxDispoLaveuse.Size = new System.Drawing.Size(104, 24);
            this.cbxDispoLaveuse.TabIndex = 26;
            this.cbxDispoLaveuse.UseVisualStyleBackColor = true;
            // 
            // cbxAnnimauxAutorises
            // 
            this.cbxAnnimauxAutorises.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceAppartement, "animauxautorises", true));
            this.cbxAnnimauxAutorises.Location = new System.Drawing.Point(647, 456);
            this.cbxAnnimauxAutorises.Name = "cbxAnnimauxAutorises";
            this.cbxAnnimauxAutorises.Size = new System.Drawing.Size(104, 24);
            this.cbxAnnimauxAutorises.TabIndex = 28;
            this.cbxAnnimauxAutorises.UseVisualStyleBackColor = true;
            // 
            // txtStatut
            // 
            this.txtStatut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "statut", true));
            this.txtStatut.Location = new System.Drawing.Point(522, 532);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(146, 22);
            this.txtStatut.TabIndex = 30;
            // 
            // txtLoyer
            // 
            this.txtLoyer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAppartement, "loyer", true));
            this.txtLoyer.Location = new System.Drawing.Point(522, 560);
            this.txtLoyer.Name = "txtLoyer";
            this.txtLoyer.Size = new System.Drawing.Size(146, 22);
            this.txtLoyer.TabIndex = 32;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(987, 311);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(124, 35);
            this.btnQuitter.TabIndex = 33;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(987, 379);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(124, 39);
            this.btnEffacer.TabIndex = 34;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(987, 450);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(124, 38);
            this.btnEnregistrer.TabIndex = 35;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // Appartements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 615);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(apartementIDLabel);
            this.Controls.Add(this.txtAppartementID);
            this.Controls.Add(apartementcodeLabel);
            this.Controls.Add(this.txtAppartementCode);
            this.Controls.Add(apartementtypeLabel);
            this.Controls.Add(this.txtAppartementType);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(provinceLabel);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(txtCodePostal);
            this.Controls.Add(this.txtcodep);
            this.Controls.Add(txtNbreChambre);
            this.Controls.Add(this.txtnbchambre);
            this.Controls.Add(txtnbresdb);
            this.Controls.Add(this.txtnbsalleb);
            this.Controls.Add(disposetapisLabel);
            this.Controls.Add(this.cbxDispoTapis);
            this.Controls.Add(disposeboisfrancLabel);
            this.Controls.Add(this.cbxDispoBoisFranc);
            this.Controls.Add(labelDispoGarage);
            this.Controls.Add(this.cbxGarage);
            this.Controls.Add(disposelaveuseLabel);
            this.Controls.Add(this.cbxDispoLaveuse);
            this.Controls.Add(animauxautorisesLabel);
            this.Controls.Add(this.cbxAnnimauxAutorises);
            this.Controls.Add(statutLabel);
            this.Controls.Add(this.txtStatut);
            this.Controls.Add(loyerLabel);
            this.Controls.Add(this.txtLoyer);
            this.Controls.Add(this.dataGridViewAppartement);
            this.Name = "Appartements";
            this.Text = "Appartements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Appartements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAppartement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceAppartement;
        private LocationDataSet locationDataSet;
        private LocationDataSetTableAdapters.appartementTableAdapter appartementTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewAppartement;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartementcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartementtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrechambreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbresdbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disposetapisDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disposeboisfrancDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disposegarageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disposelaveuseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn animauxautorisesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyerDataGridViewTextBoxColumn;
        private LocationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtAppartementID;
        private System.Windows.Forms.TextBox txtAppartementCode;
        private System.Windows.Forms.TextBox txtAppartementType;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtcodep;
        private System.Windows.Forms.TextBox txtnbchambre;
        private System.Windows.Forms.TextBox txtnbsalleb;
        private System.Windows.Forms.CheckBox cbxDispoTapis;
        private System.Windows.Forms.CheckBox cbxDispoBoisFranc;
        private System.Windows.Forms.CheckBox cbxGarage;
        private System.Windows.Forms.CheckBox cbxDispoLaveuse;
        private System.Windows.Forms.CheckBox cbxAnnimauxAutorises;
        private System.Windows.Forms.TextBox txtStatut;
        private System.Windows.Forms.TextBox txtLoyer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}