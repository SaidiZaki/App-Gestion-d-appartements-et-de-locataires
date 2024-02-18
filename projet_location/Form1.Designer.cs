
namespace projet_location
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLocataires = new System.Windows.Forms.Button();
            this.btnAppartements = new System.Windows.Forms.Button();
            this.btnBails = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocataires
            // 
            this.btnLocataires.Location = new System.Drawing.Point(217, 58);
            this.btnLocataires.Name = "btnLocataires";
            this.btnLocataires.Size = new System.Drawing.Size(170, 41);
            this.btnLocataires.TabIndex = 0;
            this.btnLocataires.Text = "Locataires";
            this.btnLocataires.UseVisualStyleBackColor = true;
            this.btnLocataires.Click += new System.EventHandler(this.btnLocataires_Click);
            // 
            // btnAppartements
            // 
            this.btnAppartements.Location = new System.Drawing.Point(217, 128);
            this.btnAppartements.Name = "btnAppartements";
            this.btnAppartements.Size = new System.Drawing.Size(170, 37);
            this.btnAppartements.TabIndex = 1;
            this.btnAppartements.Text = "Appartements";
            this.btnAppartements.UseVisualStyleBackColor = true;
            this.btnAppartements.Click += new System.EventHandler(this.btnAppartements_Click);
            // 
            // btnBails
            // 
            this.btnBails.Location = new System.Drawing.Point(217, 197);
            this.btnBails.Name = "btnBails";
            this.btnBails.Size = new System.Drawing.Size(170, 34);
            this.btnBails.TabIndex = 2;
            this.btnBails.Text = "Bails";
            this.btnBails.UseVisualStyleBackColor = true;
            this.btnBails.Click += new System.EventHandler(this.btnBails_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(217, 320);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(170, 35);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 384);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnBails);
            this.Controls.Add(this.btnAppartements);
            this.Controls.Add(this.btnLocataires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocataires;
        private System.Windows.Forms.Button btnAppartements;
        private System.Windows.Forms.Button btnBails;
        private System.Windows.Forms.Button btnQuitter;
    }
}

