using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produits_High_Techs.Client
{
    public partial class FormIdentification : Form
    {
        int nb = 1;
        public FormIdentification()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPassword.Text == "123")
            {
                MessageBox.Show("Le mot de passe est valide");
                //ouverture form de Gestion
                FormGestion fg = new FormGestion();
                this.Hide();
                fg.Show();
            }
            else
            {
                if (nb < 3)
                {
                    nb = nb + 1;
                    MessageBox.Show("Identifiants incorrects, veuillez reessayer.");
                    textBoxUser.Text = "";
                    textBoxPassword.Text = "";
                    textBoxUser.Focus();
                }
                else
                {
                    MessageBox.Show("Vous avez depasse le nombre de tentatives autorise.");
                    Application.Exit();
                }
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
