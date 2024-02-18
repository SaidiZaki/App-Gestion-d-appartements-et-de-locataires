using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_location
{
    public partial class Locataire : Form
    {
        public Locataire()
        {
            InitializeComponent();
        }

        private void Locataire_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'locationDataSet.Locataires'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.locatairesTableAdapter.Fill(this.locationDataSet.Locataires);

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtNumeroContact.Text = "";
            txtNomPrenom.Text = "";
            cbxStatut.SelectedIndex =0;

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Vous devez saisir un code de locataire.",
                                "Gestion de locataires",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            if (txtNomPrenom.Text == "")
            {
                MessageBox.Show("Vous devez spécifier le nom et prénom du locataire.",
                                "Gestion de locataires",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection connection =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\banco\\source\\repos\\projet_location\\projet_location\\Location.mdf;Integrated Security=True;Connect Timeout=30")) 
            {
                SqlCommand command =
                 new SqlCommand("INSERT INTO Locataires(locataireCode, nomprenom, statutmariage, numerocontact) " +
                               "VALUES('" + txtCode.Text + "', '" +
                               txtNomPrenom.Text + "', '" + cbxStatut.Text + "', '" + txtNumeroContact.Text + "');", connection);
                connection.Open();
                command.ExecuteNonQuery();
                dataGridViewLocataire.Refresh();


                MessageBox.Show("Un nouveau locataire a été ajouté.",
                                "Gestion de locataires",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            btnEffacer_Click(sender, e);
            Locataire_Load(sender, e);
        }
    }
}
