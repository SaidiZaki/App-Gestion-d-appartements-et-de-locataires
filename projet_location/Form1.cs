using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocataires_Click(object sender, EventArgs e)
        {
            var myForm = new Locataire();
            myForm.Show();

        }

        private void btnAppartements_Click(object sender, EventArgs e)
        {
            var myForm = new Appartements();
            myForm.Show();
        }

        private void btnBails_Click(object sender, EventArgs e)
        {
            var myForm = new Bail();
            myForm.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
