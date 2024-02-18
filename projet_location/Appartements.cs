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
    public partial class Appartements : Form
    {
        public Appartements()
        {
            InitializeComponent();
        }

        private void Appartements_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'locationDataSet.appartement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.appartementTableAdapter.Fill(this.locationDataSet.appartement);

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtAppartementCode.Text = "";
            txtAppartementType.Text = "";
            txtAdresse.Text = "";
            txtVille.Text = "";
            txtProvince.Text = "";
            txtStatut.Text = "";
            txtLoyer.Text = "";
            txtnbchambre.Text = "";
            txtnbsalleb.Text = "";
            txtcodep.Text = "";
            cbxAnnimauxAutorises.Checked = false;
            cbxDispoBoisFranc.Checked = false;
            cbxGarage.Checked = false;
            cbxDispoLaveuse.Checked = false;
            cbxDispoTapis.Checked = false;

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection =
           new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\banco\\source\\repos\\projet_location\\projet_location\\Location.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command =
                new SqlCommand("INSERT INTO appartement(apartementcode,apartementtype, Adresse, ville,province ,codepostal, nbrechambre, nbresdb,disposetapis , disposeboisfranc," +
                "disposegarage,disposelaveuse,animauxautorises , statut , loyer)" +
                " values('"+txtAppartementCode.Text+"','"+txtAppartementType.Text+"','"+txtAdresse.Text+ "','" + txtVille.Text + "','" + txtProvince.Text + "','" + txtcodep.Text +
                "'," + txtnbchambre.Text + "," + txtnbsalleb.Text + ",'" + cbxDispoTapis.Checked + "','" + cbxDispoBoisFranc.Checked + "','" +
                cbxGarage.Checked + "','" + cbxDispoLaveuse.Checked + "','" + cbxAnnimauxAutorises.Checked + "','" + txtStatut.Text + "','" + txtLoyer.Text + "');", connection);
                connection.Open();
                command.ExecuteNonQuery();
                dataGridViewAppartement.Refresh();

                MessageBox.Show("Un nouveau Appartement a été ajouté.",
                               "Gestion de locataires",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }

        }

        private void adresseTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
