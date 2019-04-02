using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Produits_High_Techs.Business;
using Produits_High_Techs.DataAccess;

namespace Produits_High_Techs.Client
{
    public partial class FormGestion : Form
    {
        private List<Produit> mesProduits;
        int index;
        int nbProd;

        public FormGestion()
        {
            InitializeComponent();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            mesProduits = new List<Produit>();
            nbProd = 0;
            textBoxNumero.Focus();
        }

        //KeyPress
            private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Seuls les chiffres sont autorises.");
                e.KeyChar = ' ';
            }
        }

        private void textBoxQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Seuls les chiffres sont autorises.");
                e.KeyChar = ' ';
            }
        }

        private void textBoxPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Seuls les chiffres sont autorises.");
                e.KeyChar = ' ';
            }
        }

        //Index Listbox

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                MessageBox.Show("Produit : " + mesProduits[index].Numero + " !");
                textBoxNumero.Text = mesProduits[index].Numero.ToString();
                textBoxQuantite.Text = mesProduits[index].Quantite.ToString();
                textBoxPrix.Text = mesProduits[index].Prix.ToString();
                dateTimePicker1.Text = mesProduits[index].DateFab.ToString();
                comboBoxType.Text = mesProduits[index].Type.ToString();
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }
            textBoxNumero.Focus();
            textBoxNumero.Enabled = false;
        }

        //Quitter
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Ajouter
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Produit unProduit = new Produit();
            unProduit.Numero = Convert.ToInt32(textBoxNumero.Text);
            unProduit.Quantite = Convert.ToInt32(textBoxQuantite.Text);
            unProduit.Prix = Convert.ToDouble(textBoxPrix.Text);

            unProduit.Type = (EnumTypeProduit)this.comboBoxType.SelectedIndex;
            this.dateTimePicker1.Value = DateTime.Now;

            unProduit.DateFab = this.dateTimePicker1.Value;

            mesProduits.Add(unProduit);
            buttonDisplay.Enabled = true;
            buttonSearch.Enabled = true;
            
            buttonEcrire.Enabled = true;
            nbProd += 1;
        }

        //Afficher
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Enabled = true;
            if (mesProduits.Count >= 0)
            {
                foreach (Produit element in mesProduits)
                {
                    listBox1.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxNumero.Focus();
            textBoxNumero.Enabled = true;
        }

       
        //Reset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                listBox1.Items.Clear();
                comboBoxType.Text = "";
                
            }
            textBoxNumero.Focus();
            textBoxNumero.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        //Update

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous modifier ce Produit ?", "Modifier", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                mesProduits[index].Numero = Convert.ToInt32(textBoxNumero.Text);
                mesProduits[index].Quantite = Convert.ToInt32(textBoxQuantite.Text);
                mesProduits[index].Prix = Convert.ToDouble(textBoxPrix.Text);
                // enun
                mesProduits[index].Type = (EnumTypeProduit)this.comboBoxType.SelectedIndex;
                // date
                listBox1.Items.Clear();
                foreach (Produit element in mesProduits)
                {
                    listBox1.Items.Add(element);
                }
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                MessageBox.Show("Produit modifie!");
            }
            textBoxNumero.Focus();
            textBoxNumero.Enabled = true;
        }

        //Supprimer
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Volez-vous supprimer ce Produit ? ", "Supprimer", MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            bool done = false;
            if (result == DialogResult.Yes)
            {
                mesProduits.RemoveAt(index);
                done = true;
                if (mesProduits.Count() == 0)
                {
                    listBox1.Enabled = false;
                }
            }

            if (done)
            {
                MessageBox.Show("Produit supprime!");
                listBox1.Items.Clear();
                foreach (Produit element in mesProduits)
                {
                    listBox1.Items.Add(element);
                }

                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                textBoxNumero.Enabled = true;
                textBoxNumero.Focus();
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                        control.Text = "";
                }
                comboBoxType.Text = "";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (Produit element in mesProduits)
            {
                if (element.Numero == Convert.ToInt32(textBoxRecherche.Text))
                {
                    listBox1.Items.Clear();
                    listBox1.Enabled = true;
                    listBox1.Items.Add(element);
                    ok = true;
                }
            }
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            listBox1.Enabled = false;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            comboBoxType.Text = "";
            if (!ok)
            {
                MessageBox.Show("Ce produit n'existe pas.");
            }
        }

        private void buttonEcrire_Click(object sender, EventArgs e)
        {
            FileHandler.WriteToFile(mesProduits);
        }

        //Afficher le contenu du fichier
        public void Afficher(List<Produit> mesProduits, ListBox listBox1)
        {
            listBox1.Enabled = true;
            listBox1.Items.Clear();

            if (mesProduits.Capacity != 0) // si la liste des Clients est pleine
            {
                foreach (Produit element in mesProduits)
                {
                    listBox1.Items.Add(element);//add to listBox
                }
            }
            else
            {
                MessageBox.Show("NO DATA");
            } // si la liste des Clients est vide
        }

        private void buttonLire_Click(object sender, EventArgs e)
        {
            mesProduits = FileHandler.ReadFromFile();
            Afficher(mesProduits, listBox1);
        }

      
        


    }
}
