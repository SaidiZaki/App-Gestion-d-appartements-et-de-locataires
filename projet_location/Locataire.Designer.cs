
namespace projet_location
{
    partial class Locataire
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
            this.bindingSourceLocataire = new System.Windows.Forms.BindingSource(this.components);
            this.locationDataSet = new projet_location.LocationDataSet();
            this.locatairesTableAdapter = new projet_location.LocationDataSetTableAdapters.LocatairesTableAdapter();
            this.dataGridViewLocataire = new System.Windows.Forms.DataGridView();
            this.locataireIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locataireCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutmariageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new projet_location.LocationDataSetTableAdapters.TableAdapterManager();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbxStatut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNumeroContact = new System.Windows.Forms.TextBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocataire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocataire)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceLocataire
            // 
            this.bindingSourceLocataire.DataMember = "Locataires";
            this.bindingSourceLocataire.DataSource = this.locationDataSet;
            // 
            // locationDataSet
            // 
            this.locationDataSet.DataSetName = "LocationDataSet";
            this.locationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatairesTableAdapter
            // 
            this.locatairesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewLocataire
            // 
            this.dataGridViewLocataire.AutoGenerateColumns = false;
            this.dataGridViewLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocataire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locataireIDDataGridViewTextBoxColumn,
            this.locataireCodeDataGridViewTextBoxColumn,
            this.nomprenomDataGridViewTextBoxColumn,
            this.statutmariageDataGridViewTextBoxColumn,
            this.numerocontactDataGridViewTextBoxColumn});
            this.dataGridViewLocataire.DataSource = this.bindingSourceLocataire;
            this.dataGridViewLocataire.Location = new System.Drawing.Point(53, 24);
            this.dataGridViewLocataire.MinimumSize = new System.Drawing.Size(700, 150);
            this.dataGridViewLocataire.Name = "dataGridViewLocataire";
            this.dataGridViewLocataire.RowHeadersWidth = 51;
            this.dataGridViewLocataire.RowTemplate.Height = 24;
            this.dataGridViewLocataire.Size = new System.Drawing.Size(944, 150);
            this.dataGridViewLocataire.TabIndex = 0;
            // 
            // locataireIDDataGridViewTextBoxColumn
            // 
            this.locataireIDDataGridViewTextBoxColumn.DataPropertyName = "locataireID";
            this.locataireIDDataGridViewTextBoxColumn.HeaderText = "locataireID";
            this.locataireIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locataireIDDataGridViewTextBoxColumn.Name = "locataireIDDataGridViewTextBoxColumn";
            this.locataireIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.locataireIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // locataireCodeDataGridViewTextBoxColumn
            // 
            this.locataireCodeDataGridViewTextBoxColumn.DataPropertyName = "locataireCode";
            this.locataireCodeDataGridViewTextBoxColumn.HeaderText = "locataireCode";
            this.locataireCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locataireCodeDataGridViewTextBoxColumn.Name = "locataireCodeDataGridViewTextBoxColumn";
            this.locataireCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomprenomDataGridViewTextBoxColumn
            // 
            this.nomprenomDataGridViewTextBoxColumn.DataPropertyName = "Nomprenom";
            this.nomprenomDataGridViewTextBoxColumn.HeaderText = "Nomprenom";
            this.nomprenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomprenomDataGridViewTextBoxColumn.Name = "nomprenomDataGridViewTextBoxColumn";
            this.nomprenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // statutmariageDataGridViewTextBoxColumn
            // 
            this.statutmariageDataGridViewTextBoxColumn.DataPropertyName = "Statutmariage";
            this.statutmariageDataGridViewTextBoxColumn.HeaderText = "Statutmariage";
            this.statutmariageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statutmariageDataGridViewTextBoxColumn.Name = "statutmariageDataGridViewTextBoxColumn";
            this.statutmariageDataGridViewTextBoxColumn.Width = 125;
            // 
            // numerocontactDataGridViewTextBoxColumn
            // 
            this.numerocontactDataGridViewTextBoxColumn.DataPropertyName = "numerocontact";
            this.numerocontactDataGridViewTextBoxColumn.HeaderText = "numerocontact";
            this.numerocontactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numerocontactDataGridViewTextBoxColumn.Name = "numerocontactDataGridViewTextBoxColumn";
            this.numerocontactDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appartementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bailTableAdapter = null;
            this.tableAdapterManager.LocatairesTableAdapter = this.locatairesTableAdapter;
            this.tableAdapterManager.paiementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projet_location.LocationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(892, 353);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 41);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(755, 353);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(95, 41);
            this.btnEffacer.TabIndex = 2;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(619, 353);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(113, 41);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cbxStatut
            // 
            this.cbxStatut.FormattingEnabled = true;
            this.cbxStatut.Items.AddRange(new object[] {
            "",
            "Celibataire",
            "Marié(e)",
            "Divorcé(e)",
            "Autre"});
            this.cbxStatut.Location = new System.Drawing.Point(160, 362);
            this.cbxStatut.Name = "cbxStatut";
            this.cbxStatut.Size = new System.Drawing.Size(121, 24);
            this.cbxStatut.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero contact";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(160, 236);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(88, 22);
            this.txtCode.TabIndex = 9;
            // 
            // txtNumeroContact
            // 
            this.txtNumeroContact.Location = new System.Drawing.Point(433, 236);
            this.txtNumeroContact.Name = "txtNumeroContact";
            this.txtNumeroContact.Size = new System.Drawing.Size(183, 22);
            this.txtNumeroContact.TabIndex = 10;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(160, 291);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(456, 22);
            this.txtNomPrenom.TabIndex = 11;
            // 
            // Locataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.txtNumeroContact);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStatut);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.dataGridViewLocataire);
            this.Name = "Locataire";
            this.Text = "Locataire";
            this.Load += new System.EventHandler(this.Locataire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocataire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocataire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceLocataire;
        private LocationDataSet locationDataSet;
        private LocationDataSetTableAdapters.LocatairesTableAdapter locatairesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewLocataire;
        private System.Windows.Forms.DataGridViewTextBoxColumn locataireIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locataireCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutmariageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocontactDataGridViewTextBoxColumn;
        private LocationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cbxStatut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNumeroContact;
        private System.Windows.Forms.TextBox txtNomPrenom;
    }
}