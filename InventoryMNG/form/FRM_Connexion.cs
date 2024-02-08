using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMNG.FM
{
    public partial class FRMConnexion : Form
    {
       private Model.DbStockContext db;

        //classe connexion
       BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRMConnexion()
        {
            InitializeComponent();
            //initialiser base de données
            db = new Model.DbStockContext();
        }

        // Pour vérifier les champs obligatoire
        string TestObligatoire()
        {
            if (TxtUsername.Text == "" || TxtUsername.Text == "Username") //si le nom d'utilisateur est vide ou le text de textbox est "Username"
            {
                return "Entrer votre Nom";
            }
            if (TxtPassword.Text == "" || TxtPassword.Text == "Password")
            {
                return "Entrer votre Mot De Passe";
            }
            //si l'utilisateur est entrer son nom et son mot de passe
            return null;
        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            // pour vider le textBox
            if (TxtUsername.Text == "Username")
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = Color.Blue;//changer couleur de text
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                TxtUsername.Text = "Username";
                TxtUsername.ForeColor = Color.Silver;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            // pour vider le textBox
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.PasswordChar = '*';
                TxtPassword.ForeColor = Color.Blue;//changer couleur de text
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";
                TxtPassword.ForeColor = Color.Silver;
            }
        }
        

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRMConnexion_Load(object sender, EventArgs e)
        {

        }

        private void TxtLogin_Click(object sender, EventArgs e)
        {
            if (TestObligatoire() == null)
            {
                if (C.ConnexionValide(db, TxtUsername.Text, TxtPassword.Text) == true)//utilisateur existe
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else // false n'existe pas
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(TestObligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

