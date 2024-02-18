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
    public partial class Bail : Form
    {
        public Bail()
        {
            InitializeComponent();
        }

        private void bailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.locationDataSet);

        }

        private void Bail_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'locationDataSet.appartement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bailTableAdapter.Fill(this.locationDataSet.bail);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtBailCode.Text = "";
            txtBailDate.Text = "";
            txtAppartementCode.Text = "";
            txtLocataireCode.Text = "";
            txtBailDuree.Text = "";
            txtBailDebut.Text = "";
            txtMontantLoyer.Text = "";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection =
           new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\banco\\source\\repos\\projet_location\\projet_location\\Location.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command =
                 new SqlCommand("INSERT INTO bail(bailCode, baildate, apartementode, locatairecode, bailduree, baildebut, montantloyer)" +
                 "values('"+txtBailCode.Text+"','"+txtBailDate.Text+ "','" + txtAppartementCode.Text + "','" + txtLocataireCode.Text + "','" +
                 txtBailDuree.Text + "','" + txtBailDebut.Text + "'," + txtMontantLoyer.Text + ");", connection);

                connection.Open();
                command.ExecuteNonQuery();
                bailDataGridView.Refresh();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            /*
                        if (txtRecherche.Text == "")
                        {
                            MessageBox.Show("Entrer  le nom du locataire ", "Gestion des locataire",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        string cs = "C:\\Users\\banco\\source\\repos\\projet_location\\projet_location\\Location.mdf";

                        string query = "select A.apartementcode ,A.apartementtype ,A.Adresse ,A.ville ,A.province , A.codepostal ,A.loyer , L.Nomprenom " +
                       "from appartement A , bail B, Locataires L " +
                       "where A.apartementcode = B.apartementode and B.locatairecode = L.locataireCode and L.Nomprenom like '" + txtRecherche.Text + "%';";

                        using (SqlConnection connection = 
                      new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+cs+";Integrated Security=True;Connect Timeout=30"))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            connection.Open();
                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "AppartementDS");
                            dataGridViewResultat.DataSource = ds.Tables["AppartementDS"];



                        }
                      */

            if (txtRecherche.Text == "")
            {
                MessageBox.Show("Entrer  le nom du locataire ", "Gestion des locataire",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            string cs = "C:\\Users\\banco\\source\\repos\\projet_location\\projet_location\\Location.mdf;";
            string connex = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + cs + "Integrated Security=True;Connect Timeout=30";

            string query = "select A.apartementcode ,A.apartementtype ,A.Adresse ,A.ville ,A.province , A.codepostal ,A.loyer " +
            "from appartement A , bail B, Locataires L " +
            "where A.apartementcode = B.apartementode and B.locatairecode = L.locataireCode and L.Nomprenom like '%" + txtRecherche.Text + "%';";

            using (SqlConnection connection = new SqlConnection(connex))
            {
                
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                ad.Fill(ds, "AppartementDS");
                dataGridViewResultat.DataSource = ds.Tables["AppartementDS"];

            }

        }
   
    }
}
